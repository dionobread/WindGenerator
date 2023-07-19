using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace WindGenerator
{
    public partial class FormMain : UIForm
    {
        private DataTable compoentInfo = new DataTable(); // 部件信息表
        private DataTable shipInfo = new DataTable(); // 船舶信息表
        private DataTable climateInfo = new DataTable(); // 气象信息表
        private DataTable equipmentInfo = new DataTable(); // 设备信息表
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

            //设备运行情况表格显示
            showTable("select * from 设备运行表", this.equipmentInfo, this.uiDataGridView2);

            //故障设备信息显示
            showTable("select * from 设备运行表 where 运行状态='故障'", this.equipmentInfo, this.uiDataGridView3);

            //人员信息管理数据显示
            showTable("select * from 职工信息表", this.employeeInfo, this.infoDataGridView);

            //设备信息管理数据显示
            showTable("select * from 桩位表", this.pilePosition, this.uiDataGridView1);
            showTable("select * from 设备信息表", this.equipmentInfo, this.uiDataGridView14);

            // 气象信息管理数据显示
            showTable("select * from 气象信息表", this.climateInfo, this.uiDataGridView4);

            // 维修管理活动数据显示
            showTable("select * from 维修派工表", this.fixSent, this.uiDataGridView7);
            showTable("select * from 维修记录表", this.fixLog, this.uiDataGridView8);

            // 物资信息管理数据显示
            showTable("Select * from 部件信息表 ", this.compoentInfo, this.uiDataGridView9);//显示部件信息
            showTable("Select * from 船舶信息表 ", this.shipInfo, this.uiDataGridView11);//显示船舶信息
            showTable("Select * from 物资信息表 ", this.resourceInfo, this.uiDataGridView10);//显示物资信息
            populate1();
            populate2();
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
        public void populate1()//未分类船舶信息显示
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

        public void populate2()//未分类物资信息显示
        {
            SqlConnection connection = getConnected();
            string query1 = "select * from 物资信息表";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, connection);
            SqlCommandBuilder builder1 = new SqlCommandBuilder(sda1);
            var ds1 = new DataSet();
            sda1.Fill(ds1);
            uiDataGridView13.DataSource = ds1.Tables[0];
            connection.Close();
        }

        public void filter()//船舶信息分类显示
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

        public void filter1()//物资信息分类显示
        {

            SqlConnection connection = getConnected();
            string query1 = "select * from 物资信息表 where 名称 = '" + uiComboBox3.SelectedItem.ToString() + "' ";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, connection);
            SqlCommandBuilder builder1 = new SqlCommandBuilder(sda1);
            var ds1 = new DataSet();
            sda1.Fill(ds1);
            uiDataGridView13.DataSource = ds1.Tables[0];
            connection.Close();
        }
        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)//执行船舶分类显示和空闲数量统计
        {
            filter();

            SqlConnection connection = getConnected();
            SqlDataAdapter sda = new SqlDataAdapter("select count(船舶状态)from 船舶信息表 where 船舶型号 = '" + uiComboBox2.SelectedItem.ToString() + "'and 船舶状态 = '空闲' ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            uiTextBox5.Text = dt.Rows[0][0].ToString();
            connection.Close();

        }

        private void uiComboBox3_SelectedIndexChanged(object sender, EventArgs e)//执行物资分类显示
        {
            filter1();
        }

        private void uiDataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)//物资数量显示
        {
            uiTextBox4.Text = uiDataGridView13.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void uiButton7_Click(object sender, EventArgs e)//物资补货
        {
            SqlConnection con = getConnected();

            string sql = "UPDATE 物资信息表 set 数量=数量+1 where 名称 = '" + uiComboBox3.SelectedItem.ToString() + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            showTable("Select * from 物资信息表 ", this.resourceInfo, this.uiDataGridView13);//显示物资信息
            populate2();//物资信息显示方法

            MessageBox.Show("补货完成");
        }

        private void uiButton8_Click(object sender, EventArgs e)//物资消耗
        {
            SqlConnection con = getConnected();

            string sql = "UPDATE 物资信息表 set 数量=数量-1 where 名称 = '" + uiComboBox3.SelectedItem.ToString() + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            showTable("Select * from 物资信息表 ", this.resourceInfo, this.uiDataGridView13);//显示物资信息
            populate2();//物资信息显示方法

            MessageBox.Show("消耗完成");
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
            DataTable input_data = new DataTable(); // 输入数据

            SqlConnection con = getConnected();
            string query = "select top 10 温度, 降水状况, 风速, 湿度 from 气象信息表 order by 时间 desc;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tmp = new DataTable();
            tmp.Load(reader);
            input_data = tmp;
            con.Close();

            string csvFilePath = "input_data.csv";
            SaveDataTableToCsv(input_data, csvFilePath);

            // 将datatable转为数组
            int rowCount = input_data.Rows.Count;
            int colCount = input_data.Columns.Count;
            object[,] dataArray = new object[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                DataRow row = input_data.Rows[i];
                for (int j = 0; j < colCount; j++)
                {
                    dataArray[i, j] = row[j];
                }
            }

            //调用Python程序
            Process p = new Process();
            string filePath = "LSTM/main.py";
            p.StartInfo.FileName = "LSTM/pytorch_inter/python.exe";
            p.StartInfo.Arguments = filePath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;

            p.Start();

            StreamReader sReader = p.StandardOutput;
            string output = sReader.ReadToEnd();

            StreamReader errorReader = p.StandardError;
            string errorOutput = errorReader.ReadToEnd();

            p.WaitForExit();
            p.Close();
            p.Dispose();

            MessageBox.Show("预测完成", "天气预测", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable output_data = new DataTable();
            output_data.Columns.Add("温度", typeof(double));
            output_data.Columns.Add("降水状况", typeof(double));
            output_data.Columns.Add("风速", typeof(double));
            output_data.Columns.Add("湿度", typeof(double));

            // 分割字符串
            string[] rows = output.Split(new string[] { "]\r\n [" }, StringSplitOptions.RemoveEmptyEntries);

            // 解析每一行并添加到DataTable
            foreach (string row in rows)
            {
                // 去除多余的空格和"]"字符
                string cleanedRow = row.Replace("]", "").Replace("[", "").Trim();
                // 分割每个值
                string[] values = cleanedRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // 将值添加到DataRow
                DataRow dataRow = output_data.NewRow();
                dataRow["温度"] = double.Parse(values[0]);
                dataRow["降水状况"] = double.Parse(values[1]);
                dataRow["风速"] = double.Parse(values[2]);
                dataRow["湿度"] = double.Parse(values[3]);
                output_data.Rows.Add(dataRow);
            }

            uiDataGridView6.DataSource = output_data;

        }

        static void SaveDataTableToCsv(DataTable dataTable, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // 写入表头
            foreach (DataColumn column in dataTable.Columns)
            {
                sb.Append(column.ColumnName).Append(",");
            }
            sb.AppendLine();

            // 写入数据行
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    sb.Append(item.ToString()).Append(",");
                }
                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString());
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

            string sql_updatepile = "update 桩位表 set 占用状态 = '占用' where 桩位号 = (select 桩位号 from 设备信息表 where 桩位表.桩位号=设备信息表.桩位号)";
            SqlCommand cmd0 = new SqlCommand(sql_updatepile, con);

            string sql_updatepile2 = "update 桩位表 set 设备编号 = @para0 where 桩位号 = @para5";
            SqlCommand cmd1 = new SqlCommand(sql_updatepile2, con);

            cmd.Parameters.AddWithValue("@para0", para0);
            cmd.Parameters.AddWithValue("@para1", para1);
            cmd.Parameters.AddWithValue("@para2", para2);
            cmd.Parameters.AddWithValue("@para3", para3);
            cmd.Parameters.AddWithValue("@para4", para4);
            cmd.Parameters.AddWithValue("@para5", para5);
            cmd.ExecuteNonQuery();

            cmd0.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@para5", para5);
            cmd1.Parameters.AddWithValue("@para0", para0);
            cmd1.ExecuteNonQuery();//必须声明标量变量

            con.Close();


            // 刷新表格数据
            showTable("select * from 桩位表", this.pilePosition, this.uiDataGridView1);
            showTable("select * from 设备信息表", this.equipmentInfo, this.uiDataGridView14);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            //老化退役
            SqlConnection con = getConnected();

            String para0 = equipmentIdTextBox.Text;

            string sql_delete = "delete from 设备信息表 where 设备编号 = @para0 ";
            string sql_update = "update 桩位表 set 占用状态 = '空闲' ,设备编号 = NULL where 设备编号 = @para0";


            SqlCommand cmd = new SqlCommand(sql_delete, con);
            SqlCommand cmd1 = new SqlCommand(sql_update, con);

            cmd.Parameters.AddWithValue("@para0", para0);
            cmd1.Parameters.AddWithValue("@para0", para0);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            con.Close();

            //刷新表格数据
            showTable("select * from 桩位表", this.pilePosition, this.uiDataGridView1);
            showTable("select * from 设备信息表", this.equipmentInfo, this.uiDataGridView14);

        }

        private void uiDataGridView14_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            equipmentIdTextBox.Text = uiDataGridView14.Rows[e.RowIndex].Cells[0].Value.ToString();
            typeTextBox.Text = uiDataGridView14.Rows[e.RowIndex].Cells[1].Value.ToString();
            rateTextBox.Text = uiDataGridView14.Rows[e.RowIndex].Cells[2].Value.ToString();
            produceTextBox.Text = uiDataGridView14.Rows[e.RowIndex].Cells[3].Value.ToString();
            useTimeTimePicker.Text = uiDataGridView14.Rows[e.RowIndex].Cells[4].Value.ToString();
            pileTextBox.Text = uiDataGridView14.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        //人员信息管理

        Byte[] imageByte = null;
        BindingSource bs = new BindingSource();



        private void emInfoTabPage_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //上传头像
        private void uiButton6_Click_1(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {//根据打开的图像文件创建原始图像大小的Bitmap 对象
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                //按比例缩放显示（因为Picture 的SizeMode 属性为Zoom）,但原始图像大小未变
                pictureBox.Image = image;
                path = openFileDialog1.FileName;
                //paras[5] = imagepath;

                using (FileStream filestream = new FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite))
                {
                    imageByte = new byte[filestream.Length];
                    filestream.Read(imageByte, 0, imageByte.Length);//将图片数据读入比特数组存储
                }
                MemoryStream ms = new MemoryStream(imageByte);//创建图片数据流
                Bitmap bmap = new Bitmap(ms);//获取图片
                ms.Close();
                pictureBox.Image = bmap;
            }
        }

        private void uiButton9_Click_1(object sender, EventArgs e)
        {
            string path = "";

            Image image = pictureBox.Image;
            Bitmap bitmap = new Bitmap(image);
            byte[] imageBytes;
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            imageBytes = ms.ToArray();

            string account = accountTextBox.Text;
            string name = nameTextBox.Text;
            string sex = maleRadioButton.Text;
            if (maleRadioButton.Checked)
            {
                sex = maleRadioButton.Text;
            }
            if (femaleRadioButton.Checked)
            {
                sex = femaleRadioButton.Text;
            }
            string birth = birthDatetimePicker.Text;
            string address = addressTextBox.Text;
            string dep = depComboBox.Text;

            SqlConnection con = getConnected();


            string query = "update 职工信息表 set 账号=@account, 姓名= @name, 性别=@sex, 出生日期=@birth,家庭住址= @address," +
                            "部门类型=@dep, 头像=@imageBytes" + " where 账号=@account";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dep", dep);
            cmd.Parameters.AddWithValue("@imageBytes", imageBytes);
            cmd.ExecuteNonQuery();
            //人员信息管理数据显示
            showTable("select * from 职工信息表", this.employeeInfo, this.infoDataGridView);
            con.Close();
        }

        private void importButton_Click_1(object sender, EventArgs e)
        {
            string path = "";

            Image image = pictureBox.Image;
            Bitmap bitmap = new Bitmap(image);
            byte[] imageBytes;
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            imageBytes = ms.ToArray();

            string account = accountTextBox.Text;
            string name = nameTextBox.Text;
            string sex = maleRadioButton.Text;
            if (maleRadioButton.Checked)
            {
                sex = maleRadioButton.Text;
            }
            if (femaleRadioButton.Checked)
            {
                sex = femaleRadioButton.Text;
            }
            string birth = birthDatetimePicker.Text;
            string address = addressTextBox.Text;
            string dep = depComboBox.Text;

            SqlConnection con = getConnected();


            string query = "insert into 职工信息表([账号], [姓名], [性别], [出生日期], " +
                            "[家庭住址], [部门类型], [头像])" +
                            "values(@account, @name, @sex, @birth, @address," +
                            "@dep, @imageBytes)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dep", dep);
            cmd.Parameters.AddWithValue("@imageBytes", imageBytes);
            cmd.ExecuteNonQuery();
            //人员信息管理数据显示
            showTable("select * from 职工信息表", this.employeeInfo, this.infoDataGridView);
            con.Close();
        }

        private void removeButton_Click_1(object sender, EventArgs e)
        {
            string account = accountTextBox.Text;
            SqlConnection con = getConnected();
            string query = "delete from 职工信息表 where 账号=@account";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.ExecuteNonQuery();
            MessageBox.Show("记录删除成功！");
            //人员信息管理数据显示
            showTable("select * from 职工信息表", this.employeeInfo, this.infoDataGridView);
            con.Close();
        }

        private void infoDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                accountTextBox.Text = infoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                nameTextBox.Text = infoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //if (infoDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == '男'.ToString())
                char male = '男';
                string strmale = male.ToString();
                string findmale = infoDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string newfindmale = findmale.Replace(" ", "");
                if (newfindmale == strmale)
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }
                else
                {
                    femaleRadioButton.Checked = true;
                    maleRadioButton.Checked = false;
                    //MessageBox.Show(strmale);
                }
                birthDatetimePicker.Text = infoDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                addressTextBox.Text = infoDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                depComboBox.Text = infoDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (infoDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() != "")
                {
                    byte[] imagebytes = (byte[])infoDataGridView.Rows[e.RowIndex].Cells[6].Value;
                    MemoryStream ms = new MemoryStream(imagebytes);//创建图片数据流
                    Bitmap bmap = new Bitmap(ms);//获取图片
                    ms.Close();
                    pictureBox.Image = bmap;
                    //pictureBox1.Image = Image.FromFile(@dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkButton_Click_1(object sender, EventArgs e)
        {
            //故障设备信息显示--刷新
            showTable("select * from 设备运行表 where 运行状态='故障'", this.equipmentInfo, this.uiDataGridView3);
        }

       
        
        
    }
}
