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
    }
}
