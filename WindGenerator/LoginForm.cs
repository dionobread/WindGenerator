using Sunny.UI;
using System.Data.SqlClient;
using System.Data;

namespace WindGenerator
{
    public partial class LoginForm : UIForm
    {
        public LoginForm()
        {
            InitializeComponent();
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
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection SqlCon = getConnected();
            // 存储过程名
            string procedure = "LoginVerify";
            // 指令类
            SqlCommand cmd = new SqlCommand();

            // SelectOperator存储过程中的参数
            SqlParameter account_name = new SqlParameter("@account_name", accountNumTextBox.Text);
            account_name.Direction = ParameterDirection.Input;  // 必须设置参数的类型

            SqlParameter pwd = new SqlParameter("@pwd", passwordTextBox.Text.ToString());
            pwd.Direction = ParameterDirection.Input;

            SqlParameter re = new SqlParameter("@rel", SqlDbType.Int);
            re.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(account_name);
            cmd.Parameters.Add(pwd);
            cmd.Parameters.Add(re);

            cmd.Connection = SqlCon;
            cmd.CommandType = CommandType.StoredProcedure; // 程序执行类型
            cmd.CommandText = procedure;
            cmd.ExecuteNonQuery(); // 执行存储过程

            object obj = cmd.Parameters["@rel"].Value; // 接收存储过程输出的参数
            int flag = Convert.ToInt16(obj);
            if (flag == 0)
            {
                MessageBox.Show("用户名或密码不正确！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flag == 1 && occupationComboBox.SelectedIndex == 0)
            {
                FormMain fm = new FormMain();
                fm.ShowDialog();
                this.Close();
            }
            else if (flag == 1 && occupationComboBox.SelectedIndex == 1)
            {
                FormMain fm = new FormMain();
                fm.emInfoTabPage.Parent = null; // 普通管理员不能访问人员管理页面
                fm.ShowDialog();
                this.Close();
            }
            else if (flag == 1 && occupationComboBox.SelectedIndex == 2)
            {
                MaintainerForm mf = new MaintainerForm();
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名与职位不匹配！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}