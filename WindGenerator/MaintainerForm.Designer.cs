namespace WindGenerator
{
    partial class MaintainerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiTextBox5 = new Sunny.UI.UITextBox();
            uiTextBox6 = new Sunny.UI.UITextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            uiListBox1 = new Sunny.UI.UIListBox();
            uiListBox2 = new Sunny.UI.UIListBox();
            uiTextBox4 = new Sunny.UI.UITextBox();
            uiTextBox7 = new Sunny.UI.UITextBox();
            uiTextBox8 = new Sunny.UI.UITextBox();
            uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            uiButton3 = new Sunny.UI.UIButton();
            uiButton4 = new Sunny.UI.UIButton();
            uiTabControlMenu1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiTabControlMenu1.Controls.Add(tabPage1);
            uiTabControlMenu1.Controls.Add(tabPage2);
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTabControlMenu1.Location = new Point(-3, 33);
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1027, 541);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiButton2);
            tabPage1.Controls.Add(uiButton1);
            tabPage1.Controls.Add(uiDataGridView1);
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(826, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "查看任务详情";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uiButton4);
            tabPage2.Controls.Add(uiButton3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.ImeMode = ImeMode.NoControl;
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(826, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "填写维修记录";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(24, 19);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.RowTemplate.Height = 29;
            uiDataGridView1.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(769, 432);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 0;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(24, 473);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 44);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "确认";
            uiButton1.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(668, 473);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(125, 44);
            uiButton2.TabIndex = 2;
            uiButton2.Text = "已完成";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(uiDatetimePicker1);
            groupBox1.Controls.Add(uiTextBox8);
            groupBox1.Controls.Add(uiTextBox7);
            groupBox1.Controls.Add(uiTextBox4);
            groupBox1.Controls.Add(uiListBox2);
            groupBox1.Controls.Add(uiListBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(uiTextBox5);
            groupBox1.Controls.Add(uiTextBox6);
            groupBox1.Controls.Add(uiTextBox3);
            groupBox1.Controls.Add(uiTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "维修单";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 0;
            label1.Text = "维修编号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 94);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 1;
            label2.Text = "维修人员编号";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 137);
            label3.Name = "label3";
            label3.Size = new Size(132, 27);
            label3.TabIndex = 2;
            label3.Text = "维修设备编号";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 183);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 3;
            label4.Text = "维修桩位编号";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 232);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 4;
            label5.Text = "故障原因：";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(169, 43);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(188, 36);
            uiTextBox1.TabIndex = 5;
            uiTextBox1.Text = "uiTextBox1";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox3.Location = new Point(169, 178);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(188, 36);
            uiTextBox3.TabIndex = 6;
            uiTextBox3.Text = "uiTextBox3";
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
            // 
            // uiTextBox5
            // 
            uiTextBox5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox5.Location = new Point(169, 89);
            uiTextBox5.Margin = new Padding(4, 5, 4, 5);
            uiTextBox5.MinimumSize = new Size(1, 16);
            uiTextBox5.Name = "uiTextBox5";
            uiTextBox5.Padding = new Padding(5);
            uiTextBox5.ShowText = false;
            uiTextBox5.Size = new Size(188, 36);
            uiTextBox5.TabIndex = 6;
            uiTextBox5.Text = "uiTextBox5";
            uiTextBox5.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox5.Watermark = "";
            // 
            // uiTextBox6
            // 
            uiTextBox6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox6.Location = new Point(169, 132);
            uiTextBox6.Margin = new Padding(4, 5, 4, 5);
            uiTextBox6.MinimumSize = new Size(1, 16);
            uiTextBox6.Name = "uiTextBox6";
            uiTextBox6.Padding = new Padding(5);
            uiTextBox6.ShowText = false;
            uiTextBox6.Size = new Size(188, 36);
            uiTextBox6.TabIndex = 6;
            uiTextBox6.Text = "uiTextBox6";
            uiTextBox6.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox6.Watermark = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 48);
            label6.Name = "label6";
            label6.Size = new Size(92, 27);
            label6.TabIndex = 7;
            label6.Text = "维修时间";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 94);
            label7.Name = "label7";
            label7.Size = new Size(92, 27);
            label7.TabIndex = 8;
            label7.Text = "维修天数";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 137);
            label8.Name = "label8";
            label8.Size = new Size(132, 27);
            label8.TabIndex = 9;
            label8.Text = "维修船舶编号";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(393, 183);
            label9.Name = "label9";
            label9.Size = new Size(92, 27);
            label9.TabIndex = 10;
            label9.Text = "维修状态";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(393, 232);
            label10.Name = "label10";
            label10.Size = new Size(112, 27);
            label10.TabIndex = 11;
            label10.Text = "维修内容：";
            // 
            // uiListBox1
            // 
            uiListBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiListBox1.HoverColor = Color.FromArgb(155, 200, 255);
            uiListBox1.ItemSelectForeColor = Color.White;
            uiListBox1.Location = new Point(23, 273);
            uiListBox1.Margin = new Padding(4, 5, 4, 5);
            uiListBox1.MinimumSize = new Size(1, 1);
            uiListBox1.Name = "uiListBox1";
            uiListBox1.Padding = new Padding(2);
            uiListBox1.ShowText = false;
            uiListBox1.Size = new Size(334, 112);
            uiListBox1.TabIndex = 12;
            uiListBox1.Text = "uiListBox1";
            // 
            // uiListBox2
            // 
            uiListBox2.FillColor = Color.White;
            uiListBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiListBox2.Location = new Point(393, 273);
            uiListBox2.Margin = new Padding(4, 5, 4, 5);
            uiListBox2.MinimumSize = new Size(1, 1);
            uiListBox2.Name = "uiListBox2";
            uiListBox2.Padding = new Padding(2);
            uiListBox2.ShowText = false;
            uiListBox2.Size = new Size(334, 112);
            uiListBox2.TabIndex = 13;
            uiListBox2.Text = "uiListBox2";
            // 
            // uiTextBox4
            // 
            uiTextBox4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox4.Location = new Point(539, 89);
            uiTextBox4.Margin = new Padding(4, 5, 4, 5);
            uiTextBox4.MinimumSize = new Size(1, 16);
            uiTextBox4.Name = "uiTextBox4";
            uiTextBox4.Padding = new Padding(5);
            uiTextBox4.ShowText = false;
            uiTextBox4.Size = new Size(188, 36);
            uiTextBox4.TabIndex = 7;
            uiTextBox4.Text = "uiTextBox4";
            uiTextBox4.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox4.Watermark = "";
            // 
            // uiTextBox7
            // 
            uiTextBox7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox7.Location = new Point(539, 132);
            uiTextBox7.Margin = new Padding(4, 5, 4, 5);
            uiTextBox7.MinimumSize = new Size(1, 16);
            uiTextBox7.Name = "uiTextBox7";
            uiTextBox7.Padding = new Padding(5);
            uiTextBox7.ShowText = false;
            uiTextBox7.Size = new Size(188, 36);
            uiTextBox7.TabIndex = 7;
            uiTextBox7.Text = "uiTextBox7";
            uiTextBox7.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox7.Watermark = "";
            // 
            // uiTextBox8
            // 
            uiTextBox8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox8.Location = new Point(539, 178);
            uiTextBox8.Margin = new Padding(4, 5, 4, 5);
            uiTextBox8.MinimumSize = new Size(1, 16);
            uiTextBox8.Name = "uiTextBox8";
            uiTextBox8.Padding = new Padding(5);
            uiTextBox8.ShowText = false;
            uiTextBox8.Size = new Size(188, 36);
            uiTextBox8.TabIndex = 7;
            uiTextBox8.Text = "uiTextBox8";
            uiTextBox8.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox8.Watermark = "";
            // 
            // uiDatetimePicker1
            // 
            uiDatetimePicker1.FillColor = Color.White;
            uiDatetimePicker1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDatetimePicker1.Location = new Point(539, 43);
            uiDatetimePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatetimePicker1.MaxLength = 19;
            uiDatetimePicker1.MinimumSize = new Size(63, 0);
            uiDatetimePicker1.Name = "uiDatetimePicker1";
            uiDatetimePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatetimePicker1.Size = new Size(188, 36);
            uiDatetimePicker1.SymbolDropDown = 61555;
            uiDatetimePicker1.SymbolNormal = 61555;
            uiDatetimePicker1.TabIndex = 14;
            uiDatetimePicker1.Text = "uiDatetimePicker1";
            uiDatetimePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker1.Value = new DateTime(2023, 7, 2, 10, 4, 14, 955);
            uiDatetimePicker1.Watermark = "";
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiButton3.Location = new Point(59, 457);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Radius = 10;
            uiButton3.Size = new Size(334, 44);
            uiButton3.TabIndex = 1;
            uiButton3.Text = "提交维修单";
            uiButton3.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiButton4.Location = new Point(429, 457);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Radius = 10;
            uiButton4.Size = new Size(334, 44);
            uiButton4.TabIndex = 2;
            uiButton4.Text = "清空内容";
            uiButton4.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // MaintainerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1017, 568);
            Controls.Add(uiTabControlMenu1);
            Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "MaintainerForm";
            Text = "维修人员";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiTabControlMenu1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private GroupBox groupBox1;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UITextBox uiTextBox6;
        private Sunny.UI.UITextBox uiTextBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox uiTextBox7;
        private Sunny.UI.UIListBox uiListBox2;
        private Sunny.UI.UIListBox uiListBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UITextBox uiTextBox8;
    }
}