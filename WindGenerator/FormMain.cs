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
        private DataTable compoentInfo; // 部件信息表
        private DataTable shipInfo; // 船舶信息表
        private DataTable climateInfo; // 气象信息表
        private DataTable equipmentInfo; // 设备运行表
        private DataTable equipmentRun; // 设备运行表
        private DataTable fixLog; // 维修记录表
        private DataTable fixSent; // 维修派工表
        private DataTable resourceInfo; // 物资信息表
        private DataTable employee; // 职工表
        private DataTable employeeInfo; // 职工信息表
        private DataTable pilePosition; // 桩位表

        public FormMain()
        {
            InitializeComponent();
            // 气象信息管理数据显示
            showTable("select * from 气象信息表", this.climateInfo, this.uiDataGridView4);

            // 维修管理活动数据显示
            showTable("select * from 维修派工表", this.fixSent, this.uiDataGridView7);
            showTable("select * from 维修记录表", this.fixLog, this.uiDataGridView8);
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
            SqlConnection connection;
            string connectionString = "Data Source=LAPTOP-P5D3L2Q5\\MSSQLSERVER01;Initial Catalog=海上风电场;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select * from 船舶信息表";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }

        public void filter()
        {
            SqlConnection connection;
            string connectionString = "Data Source=LAPTOP-P5D3L2Q5\\MSSQLSERVER01;Initial Catalog=海上风电场;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select * from 船舶信息表 where 船舶型号 = '" + uiComboBox2.SelectedItem.ToString() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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

            // sql
            con.Close();
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
