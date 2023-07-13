using System;
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
            string connectionString = "Data Source=LAPTOP-N3CG8QGT\\MSSQLSERVER01;Initial Catalog=海上风电场;Integrated Security=True";
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
    }
}
