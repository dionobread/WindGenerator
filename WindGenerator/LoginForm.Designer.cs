namespace WindGenerator
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            occupationComboBox = new ComboBox();
            accountNumTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Sunny.UI.UIButton();
            exitButton = new Sunny.UI.UIButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // occupationComboBox
            // 
            occupationComboBox.FormattingEnabled = true;
            occupationComboBox.Items.AddRange(new object[] { "高级管理人员", "普通管理人员", "运维人员" });
            occupationComboBox.Location = new Point(104, 174);
            occupationComboBox.Name = "occupationComboBox";
            occupationComboBox.Size = new Size(204, 35);
            occupationComboBox.TabIndex = 0;
            // 
            // accountNumTextBox
            // 
            accountNumTextBox.Location = new Point(104, 43);
            accountNumTextBox.Name = "accountNumTextBox";
            accountNumTextBox.Size = new Size(204, 34);
            accountNumTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(104, 111);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(204, 34);
            passwordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(25, 47);
            label1.Name = "label1";
            label1.Size = new Size(52, 27);
            label1.TabIndex = 3;
            label1.Text = "账号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(25, 115);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 4;
            label2.Text = "密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 5;
            label3.Text = "职位";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(25, 259);
            loginButton.MinimumSize = new Size(1, 1);
            loginButton.Name = "loginButton";
            loginButton.Radius = 15;
            loginButton.Size = new Size(125, 44);
            loginButton.TabIndex = 6;
            loginButton.Text = "登录";
            loginButton.Click += loginButton_Click_1;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(183, 259);
            exitButton.MinimumSize = new Size(1, 1);
            exitButton.Name = "exitButton";
            exitButton.Radius = 15;
            exitButton.Size = new Size(125, 44);
            exitButton.TabIndex = 7;
            exitButton.Text = "退出";
            exitButton.Click += exitButton_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(accountNumTextBox);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(exitButton);
            materialCard1.Controls.Add(passwordTextBox);
            materialCard1.Controls.Add(loginButton);
            materialCard1.Controls.Add(occupationComboBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(239, 65);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(334, 345);
            materialCard1.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(materialCard1);
            Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "LoginForm";
            Text = "登录";
            TitleFont = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox occupationComboBox;
        private TextBox accountNumTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Sunny.UI.UIButton loginButton;
        private Sunny.UI.UIButton exitButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}