using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Sunny.UI;

namespace WindGenerator
{
    public partial class MaintainerForm : UIForm
    {
        private DataTable fixSent = new DataTable(); // 维修派工表
        public MaintainerForm(string id)
        {
            InitializeComponent();
            // 维修活动管理-派遣维修按钮
            // 调用案例，显示部件信息表：showTable(sqlQuery, this.compoentInfo, this.uiDataGridView9)
            SqlConnection con = getConnected();
            string query = $"select * from 维修派工表 where 维修人员编号={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader(); // 运行sql语句并将结果存储在读取器中
            DataTable tmp = new DataTable();
            tmp.Load(reader);
            this.fixSent = tmp;
            uiDataGridView1.DataSource = tmp;
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

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string maintenance_id = uiTextBox1.Text;
            string maintainer_id = uiTextBox5.Text;
            string facility_id = uiTextBox6.Text;
            string location_id = uiTextBox3.Text;
            string reason = uiTextBox9.Text;
            string time = uiDatetimePicker1.Text;
            string duration = uiTextBox4.Text;
            string ship_id = uiTextBox7.Text;
            string state = uiTextBox8.Text;
            string content = uiTextBox10.Text;

            SqlConnection con = getConnected();

            string query = "insert into 维修记录表([维修编号], [维修人员编号], [维修设备编号], [维修桩位编号], " +
                            "[故障原因], [维修时间], [维修天数], [维修船舶编号], [维修状态], [维修内容])" +
                            "values(@maintenance_id, @maintainer_id, @facility_id, @location_id, @reason," +
                            "@time, @duration, @ship_id, @state, @content)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@maintenance_id", maintenance_id);
            cmd.Parameters.AddWithValue("@maintainer_id", maintainer_id);
            cmd.Parameters.AddWithValue("@facility_id", facility_id);
            cmd.Parameters.AddWithValue("@location_id", location_id);
            cmd.Parameters.AddWithValue("@reason", reason);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@ship_id", ship_id);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@content", content);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            this.uiTextBox1.Text = null;
            this.uiTextBox5.Text = null;
            this.uiTextBox6.Text = null;
            this.uiTextBox3.Text = null;
            this.uiTextBox9.Text = null;
            this.uiDatetimePicker1.Text = null;
            this.uiTextBox4.Text = null;
            this.uiTextBox7.Text = null;
            this.uiTextBox8.Text = null;
            this.uiTextBox10.Text = null;
        }
    }
}
