using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindGenerator
{
    public partial class FormMain : UIForm
    {
        private DataTable compoentInfo = new DataTable(); // 部件信息表
        private DataTable shipInfo = new DataTable(); // 船舶信息表
        private DataTable climateInfo = new DataTable(); // 气象信息表
        private DataTable equipmentInfo = new DataTable(); // 设备运行表
        private DataTable equipmentRun = new DataTable(); // 设备运行表
        private DataTable fixLog = new DataTable(); // 维修记录表
        private DataTable fixSent = new DataTable(); // 维修派工表
        private DataTable resourceInfo = new DataTable(); // 物资信息表
        private DataTable employee = new DataTable(); // 职工表
        private DataTable employeeInfo = new DataTable(); // 职工信息表
        private DataTable pilePosition = new DataTable(); // 桩位表

        public FormMain()
        {
            InitializeComponent();

            //设备信息管理桩位数据显示
            showTable("select * from 桩位表", this.pilePosition, this.uiDataGridView1);

            // 气象信息管理数据显示
            showTable("select * from 气象信息表", this.climateInfo, this.uiDataGridView4);

            // 维修管理活动数据显示
            showTable("select * from 维修派工表", this.fixSent, this.uiDataGridView7);
            showTable("select * from 维修记录表", this.fixLog, this.uiDataGridView8);

            // 物资信息管理数据显示
            showTable("Select * from 部件信息表 ", this.compoentInfo, this.uiDataGridView9);//显示部件信息
            showTable("Select * from 船舶信息表 ", this.shipInfo, this.uiDataGridView11);//显示船舶信息
            showTable("Select * from 物资信息表 ", this.resourceInfo, this.uiDataGridView10);//显示物资信息
            populate();
        }



        public void showTable(string sqlQuery, DataTable sqlDataTable, UIDataGridView dataGrid)
        {
            // 维修活动管理-派遣维修按钮
            // 调用案例，显示部件信息表：showTable(sqlQuery, this.compoentInfo, this.uiDataGridView9)
            SqlConnection con = getConnected();
            string query = sqlQuery;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader(); // 运行sql语句并将结果存储在读取器中
            DataTable tmp = new DataTable();
            tmp.Load(reader);
            sqlDataTable = tmp;
            dataGrid.DataSource = tmp;
            con.Close();
        }
        public SqlConnection getConnected()
        {
            SqlConnection connection;
            string connectionString = "Data Source=LAPTOP-VEMPUMO4;Initial Catalog=海上风电场;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            bool flag = connection.State == System.Data.ConnectionState.Open;
            if (flag)
            {
                Console.WriteLine("数据库已连接");
            }
            else
            {
                Console.WriteLine("数据库未连接");
            }

            return connection;
        }

        public void populate()
        {
            SqlConnection connection = getConnected();
            string query = "select * from 船舶信息表";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            uiDataGridView12.DataSource = ds.Tables[0];
            connection.Close();
        }

        public void filter()
        {
            SqlConnection connection = getConnected();
            string query = "select * from 船舶信息表 where 船舶型号 = '" + uiComboBox2.SelectedItem.ToString() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            uiDataGridView12.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void uiRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void uiRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            // 维修活动管理-派遣维修按钮
            SqlConnection con = getConnected();
            string procedure = "Dispatch";
            SqlCommand cmd = new SqlCommand();

            SqlParameter maintainer_id = new SqlParameter("@maintainer_id", uiTextBox1.Text);
            maintainer_id.Direction = ParameterDirection.Input;
            SqlParameter ship_id = new SqlParameter("@ship_id", uiTextBox2.Text.ToString());
            ship_id.Direction = ParameterDirection.Input;
            SqlParameter start_time = new SqlParameter("@start_time", uiTimePicker2.Text.ToString());
            start_time.Direction = ParameterDirection.Input;
            SqlParameter maintenance_type = new SqlParameter("@maintenance_type", uiComboBox1.Text.ToString());
            maintenance_type.Direction = ParameterDirection.Input;
            SqlParameter facility_id = new SqlParameter("@facility_id", uiTextBox6.Text.ToString());
            facility_id.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(maintainer_id);
            cmd.Parameters.Add(ship_id);
            cmd.Parameters.Add(start_time);
            cmd.Parameters.Add(maintenance_type);
            cmd.Parameters.Add(facility_id);

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure; // 程序执行类型
            cmd.CommandText = procedure;
            cmd.ExecuteNonQuery(); // 执行存储过程

            object obj = cmd.Parameters["@maintainer_id"].Value; // 接收存储过程输出的参数
            string tmp_id = Convert.ToString(obj);
            MessageBox.Show($"已将任务派遣给维修人员{tmp_id}", "任务派遣", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 刷新表格
            showTable("select * from 维修派工表", this.fixSent, this.uiDataGridView7);
            showTable("select * from 维修记录表", this.fixLog, this.uiDataGridView8);
            // sql
            con.Close();
        }
        private void uiButton6_Click(object sender, EventArgs e)
        {
            // 维修活动管理-派遣按钮
            this.Invalidate();
            this.Refresh();
        }
        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            //气象信息管理-查询按钮
            SqlConnection con = getConnected();
            string query = "select 温度,降水状况,出行建议 from 气象信息表 where 时间 = ' " + uiDatetimePicker1.Text + " '";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            showTable(query, this.climateInfo, this.uiDataGridView5);
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            //气象信息管理-预测按钮
            SqlConnection connection = getConnected();
            DateTime selectedDate = uiDatetimePicker1.Value;
            DateTime startDate = selectedDate.AddHours(-24);
            DateTime endDate = selectedDate;
            DataTable dataTable1 = new DataTable();
            string query = "SELECT 温度, 降水状况, 风速, 湿度 FROM 气象信息表 WHERE 时间 BETWEEN @startDate AND @endDate ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataTable1);      //在datatable1中保存选定时间前24小时的气象信息

            DataTable dataTable2 = new DataTable();
            int numberOfHours = 5;  // 预测的小时数
            dataTable2.Columns.Add("时间", typeof(DateTime));
            dataTable2.Columns.Add("预测温度", typeof(double));
            dataTable2.Columns.Add("预测降雨量", typeof(double));

            // 获取温度和降雨量的均值和标准差
            double temperatureMean = dataTable1.AsEnumerable().Average(row => row.Field<double>("温度"));
            double temperatureStdDev = Math.Sqrt(dataTable1.AsEnumerable().Average(row 
                => Math.Pow(row.Field<double>("温度") - temperatureMean, 2)));
            double rainfallMean = dataTable1.AsEnumerable().Average(row => row.Field<double>("降水状况"));
            double rainfallStdDev = Math.Sqrt(dataTable1.AsEnumerable().Average(row 
                => Math.Pow(row.Field<double>("降水状况") - rainfallMean, 2)));

            double PredictValue(double mean, double stdDev)
            {
                Random random = new Random();
                double u1 = 1.0 - random.NextDouble();
                double u2 = 1.0 - random.NextDouble();
                double randomNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                if (mean + stdDev * randomNormal >= 0){return mean + stdDev * randomNormal;}
                else{ return 0; }
            }
            // 预测的温度和降雨量列表
            var predictedTemperatures = Enumerable.Range(0, numberOfHours).Select(i => 
            PredictValue(temperatureMean, temperatureStdDev)).ToList();
            var predictedRainfalls = Enumerable.Range(0, numberOfHours).Select(i => 
            PredictValue(rainfallMean, rainfallStdDev)).ToList();

            for (int i = 0; i < numberOfHours; i++)
            {
                dataTable2.Rows.Add(selectedDate.AddHours(1 + i), predictedTemperatures[i], predictedRainfalls[i]);
            }

            DataTable dataTable3 = new DataTable();
            dataTable3.Columns.Add("时间", typeof(DateTime));
            dataTable3.Columns.Add("预测温度", typeof(double));
            dataTable3.Columns.Add("预测降雨量", typeof(double));
            // 添加“出行建议”列
            //DataColumn travelAdviceColumn = new DataColumn("出行建议", typeof(string));
            //travelAdviceColumn.DefaultValue = "";
            //dataTable3.Columns.Add(travelAdviceColumn);
            dataTable3.Columns.Add("出行建议", typeof(string));
            foreach (DataRow row in dataTable2.Rows)
            {
                int rainfall = Convert.ToInt32(row["预测降雨量"]);
                
                for (int i = 0; i < numberOfHours; i++)
                {
                    string travelAdvice = (predictedRainfalls[i] > 0) ? "不能出行" : "可以出行";
                    dataTable3.Rows.Add(selectedDate.AddHours(1 + i), predictedTemperatures[i], predictedRainfalls[i], travelAdvice);
                }

            }

            /*DataTable rowsDataTable = dataTable3.Clone();
            for (int i = 0; i < 5 && i < dataTable3.Rows.Count; i++)
            {
                rowsDataTable.ImportRow(dataTable3.Rows[i]);
            }*/

            uiDataGridView6.DataSource = dataTable3;
            connection.Close(); 
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //投入使用
            SqlConnection con = getConnected();

            String para0 = equipmentIdTextBox.Text;
            String para1 = typeTextBox.Text;
            String para2 = rateTextBox.Text;
            String para3 = produceTextBox.Text;
            DateTime para4 = DateTime.Parse(useTimeTimePicker.Text);
            String para5 = pileTextBox.Text;

            string sql = "insert into 设备信息表 (设备编号,设备类型,额定功率,生产厂家,投入使用时间,桩位号) values(@para0, @para1, @para2, @para3, @para4, @para5)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@para0", para0);
            cmd.Parameters.AddWithValue("@para1", para1);
            cmd.Parameters.AddWithValue("@para2", para2);
            cmd.Parameters.AddWithValue("@para3", para3);
            cmd.Parameters.AddWithValue("@para4", para4);
            cmd.Parameters.AddWithValue("@para5", para5);
            cmd.ExecuteNonQuery();
            con.Close();

            // FormMain_Load(sender, e);//窗体重载，显示数据更新效果
        }

    }
}
