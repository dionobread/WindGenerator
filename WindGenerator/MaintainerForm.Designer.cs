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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            tabPage2 = new TabPage();
            uiButton4 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            groupBox1 = new GroupBox();
            uiTextBox10 = new Sunny.UI.UITextBox();
            uiTextBox9 = new Sunny.UI.UITextBox();
            uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            uiTextBox8 = new Sunny.UI.UITextBox();
            uiTextBox7 = new Sunny.UI.UITextBox();
            uiTextBox4 = new Sunny.UI.UITextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            uiTextBox5 = new Sunny.UI.UITextBox();
            uiTextBox6 = new Sunny.UI.UITextBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiTextBox1 = new Sunny.UI.UITextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiTabControlMenu1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            tabPage2.SuspendLayout();
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
            uiTabControlMenu1.Location = new Point(0, 35);
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1014, 535);
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
            tabPage1.Size = new Size(813, 535);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "查看任务详情";
            tabPage1.UseVisualStyleBackColor = true;
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
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(24, 19);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 29;
            uiDataGridView1.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(764, 416);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.Style = Sunny.UI.UIStyle.Custom;
            uiDataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uiButton4);
            tabPage2.Controls.Add(uiButton3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.ImeMode = ImeMode.NoControl;
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(813, 535);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "填写维修记录";
            tabPage2.UseVisualStyleBackColor = true;
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
            uiButton4.Click += uiButton4_Click;
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
            uiButton3.Click += uiButton3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(uiTextBox10);
            groupBox1.Controls.Add(uiTextBox9);
            groupBox1.Controls.Add(uiDatetimePicker1);
            groupBox1.Controls.Add(uiTextBox8);
            groupBox1.Controls.Add(uiTextBox7);
            groupBox1.Controls.Add(uiTextBox4);
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
            groupBox1.Size = new Size(745, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "维修单";
            // 
            // uiTextBox10
            // 
            uiTextBox10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox10.Location = new Point(393, 283);
            uiTextBox10.Margin = new Padding(4, 5, 4, 5);
            uiTextBox10.MinimumSize = new Size(1, 16);
            uiTextBox10.Name = "uiTextBox10";
            uiTextBox10.Padding = new Padding(5);
            uiTextBox10.ShowText = false;
            uiTextBox10.Size = new Size(334, 60);
            uiTextBox10.TabIndex = 16;
            uiTextBox10.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox10.Watermark = "";
            // 
            // uiTextBox9
            // 
            uiTextBox9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox9.Location = new Point(23, 283);
            uiTextBox9.Margin = new Padding(4, 5, 4, 5);
            uiTextBox9.MinimumSize = new Size(1, 16);
            uiTextBox9.Name = "uiTextBox9";
            uiTextBox9.Padding = new Padding(5);
            uiTextBox9.ShowText = false;
            uiTextBox9.Size = new Size(334, 60);
            uiTextBox9.TabIndex = 15;
            uiTextBox9.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox9.Watermark = "";
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
            uiDatetimePicker1.Text = "2023-07-02 10:04:14";
            uiDatetimePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker1.Value = new DateTime(2023, 7, 2, 10, 4, 14, 955);
            uiDatetimePicker1.Watermark = "";
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
            uiTextBox8.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox8.Watermark = "";
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
            uiTextBox7.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox7.Watermark = "";
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
            uiTextBox4.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox4.Watermark = "";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(393, 183);
            label9.Name = "label9";
            label9.Size = new Size(92, 27);
            label9.TabIndex = 10;
            label9.Text = "维修状态";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 94);
            label7.Name = "label7";
            label7.Size = new Size(92, 27);
            label7.TabIndex = 8;
            label7.Text = "维修天数";
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
            uiTextBox6.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox6.Watermark = "";
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
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
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
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 183);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 3;
            label4.Text = "维修桩位编号";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 94);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 1;
            label2.Text = "维修人员编号";
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
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox2.Location = new Point(0, 0);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(334, 60);
            uiTextBox2.Style = Sunny.UI.UIStyle.Custom;
            uiTextBox2.TabIndex = 2;
            uiTextBox2.Text = "uiTextBox2";
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // MaintainerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1017, 573);
            Controls.Add(uiTabControlMenu1);
            Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "MaintainerForm";
            Text = "维修人员";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiTabControlMenu1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
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
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UITextBox uiTextBox8;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox10;
        private Sunny.UI.UITextBox uiTextBox9;
    }
}