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
            string connectionString = "Data Source=LAPTOP-N3CG8QGT\\MSSQLSERVER01;Initial Catalog=���Ϸ�糡;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            bool flag = connection.State == System.Data.ConnectionState.Open;
            if (flag)
            {
                Console.WriteLine("���ݿ�������");
            }
            else
            {
                Console.WriteLine("���ݿ�δ����");
            }

            return connection;
        }
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection SqlCon = getConnected();
            // �洢������
            string procedure = "LoginVerify";
            // ָ����
            SqlCommand cmd = new SqlCommand();

            // SelectOperator�洢�����еĲ���
            SqlParameter account_name = new SqlParameter("@account_name", accountNumTextBox.Text);
            account_name.Direction = ParameterDirection.Input;  // �������ò���������

            SqlParameter pwd = new SqlParameter("@pwd", passwordTextBox.Text.ToString());
            pwd.Direction = ParameterDirection.Input;

            SqlParameter re = new SqlParameter("@rel", SqlDbType.Int);
            re.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(account_name);
            cmd.Parameters.Add(pwd);
            cmd.Parameters.Add(re);

            cmd.Connection = SqlCon;
            cmd.CommandType = CommandType.StoredProcedure; // ����ִ������
            cmd.CommandText = procedure;
            cmd.ExecuteNonQuery(); // ִ�д洢����

            object obj = cmd.Parameters["@rel"].Value; // ���մ洢��������Ĳ���
            int flag = Convert.ToInt16(obj);
            if (flag == 0)
            {
                MessageBox.Show("�û��������벻��ȷ��", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                fm.emInfoTabPage.Parent = null; // ��ͨ����Ա���ܷ�����Ա����ҳ��
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
                MessageBox.Show("�û�����ְλ��ƥ�䣡", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}