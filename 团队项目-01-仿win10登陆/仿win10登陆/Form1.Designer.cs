namespace 仿win10登陆
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CurTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurDate = new System.Windows.Forms.Label();
            this.HeadPicBox = new System.Windows.Forms.PictureBox();
            this.userLb = new System.Windows.Forms.Label();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.重启TS = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.关机TS = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.睡眠TS = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.EnterPictBox = new System.Windows.Forms.PictureBox();
            this.PasswodrTB = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.重启TS.SuspendLayout();
            this.关机TS.SuspendLayout();
            this.睡眠TS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnterPictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurTime
            // 
            this.CurTime.AutoSize = true;
            this.CurTime.BackColor = System.Drawing.Color.Transparent;
            this.CurTime.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurTime.ForeColor = System.Drawing.Color.White;
            this.CurTime.Location = new System.Drawing.Point(-4, 345);
            this.CurTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurTime.Name = "CurTime";
            this.CurTime.Size = new System.Drawing.Size(314, 80);
            this.CurTime.TabIndex = 0;
            this.CurTime.Text = "CurTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CurDate
            // 
            this.CurDate.AutoSize = true;
            this.CurDate.BackColor = System.Drawing.Color.Transparent;
            this.CurDate.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurDate.ForeColor = System.Drawing.Color.White;
            this.CurDate.Location = new System.Drawing.Point(24, 436);
            this.CurDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurDate.Name = "CurDate";
            this.CurDate.Size = new System.Drawing.Size(117, 33);
            this.CurDate.TabIndex = 1;
            this.CurDate.Text = "label2";
            // 
            // HeadPicBox
            // 
            this.HeadPicBox.BackColor = System.Drawing.Color.Transparent;
            this.HeadPicBox.BackgroundImage = global::仿win10登陆.Properties.Resources.touxiang;
            this.HeadPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadPicBox.Location = new System.Drawing.Point(335, 10);
            this.HeadPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeadPicBox.Name = "HeadPicBox";
            this.HeadPicBox.Size = new System.Drawing.Size(150, 160);
            this.HeadPicBox.TabIndex = 5;
            this.HeadPicBox.TabStop = false;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.BackColor = System.Drawing.Color.Transparent;
            this.userLb.Font = new System.Drawing.Font("Verdana", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.ForeColor = System.Drawing.Color.White;
            this.userLb.Location = new System.Drawing.Point(342, 192);
            this.userLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(198, 52);
            this.userLb.TabIndex = 6;
            this.userLb.Text = "Lenovo";
            // 
            // ClosePicBox
            // 
            this.ClosePicBox.BackgroundImage = global::仿win10登陆.Properties.Resources.guanji;
            this.ClosePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePicBox.Location = new System.Drawing.Point(808, 445);
            this.ClosePicBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClosePicBox.Name = "ClosePicBox";
            this.ClosePicBox.Size = new System.Drawing.Size(30, 32);
            this.ClosePicBox.TabIndex = 7;
            this.ClosePicBox.TabStop = false;
            this.ClosePicBox.Click += new System.EventHandler(this.ClosePicBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.重启TS);
            this.panel1.Controls.Add(this.关机TS);
            this.panel1.Controls.Add(this.睡眠TS);
            this.panel1.Location = new System.Drawing.Point(621, 299);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 141);
            this.panel1.TabIndex = 8;
            // 
            // 重启TS
            // 
            this.重启TS.AutoSize = false;
            this.重启TS.BackColor = System.Drawing.Color.Transparent;
            this.重启TS.Dock = System.Windows.Forms.DockStyle.None;
            this.重启TS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.重启TS.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.重启TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripLabel3});
            this.重启TS.Location = new System.Drawing.Point(0, 91);
            this.重启TS.Name = "重启TS";
            this.重启TS.Size = new System.Drawing.Size(216, 50);
            this.重启TS.TabIndex = 2;
            this.重启TS.Text = "toolStrip3";
            this.重启TS.Click += new System.EventHandler(this.重启TS_Click);
            this.重启TS.MouseEnter += new System.EventHandler(this.重启TS_MouseEnter);
            this.重启TS.MouseLeave += new System.EventHandler(this.重启TS_MouseLeave);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::仿win10登陆.Properties.Resources.zhongqi_1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(37, 47);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(163, 47);
            this.toolStripLabel3.Text = " 重启                              ";
            // 
            // 关机TS
            // 
            this.关机TS.AutoSize = false;
            this.关机TS.BackColor = System.Drawing.Color.Transparent;
            this.关机TS.Dock = System.Windows.Forms.DockStyle.None;
            this.关机TS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.关机TS.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.关机TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripLabel2});
            this.关机TS.Location = new System.Drawing.Point(0, 46);
            this.关机TS.Name = "关机TS";
            this.关机TS.Size = new System.Drawing.Size(216, 50);
            this.关机TS.TabIndex = 1;
            this.关机TS.Text = "toolStrip2";
            this.关机TS.Click += new System.EventHandler(this.关机TS_Click);
            this.关机TS.MouseEnter += new System.EventHandler(this.关机TS_MouseEnter);
            this.关机TS.MouseLeave += new System.EventHandler(this.关机TS_MouseLeave);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::仿win10登陆.Properties.Resources.guanji_1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 47);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(163, 47);
            this.toolStripLabel2.Text = " 关机                              ";
            // 
            // 睡眠TS
            // 
            this.睡眠TS.AutoSize = false;
            this.睡眠TS.BackColor = System.Drawing.Color.Transparent;
            this.睡眠TS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.睡眠TS.Dock = System.Windows.Forms.DockStyle.None;
            this.睡眠TS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.睡眠TS.ImageScalingSize = new System.Drawing.Size(37, 37);
            this.睡眠TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.睡眠TS.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.睡眠TS.Location = new System.Drawing.Point(0, 0);
            this.睡眠TS.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.睡眠TS.Name = "睡眠TS";
            this.睡眠TS.Padding = new System.Windows.Forms.Padding(0);
            this.睡眠TS.Size = new System.Drawing.Size(216, 51);
            this.睡眠TS.Stretch = true;
            this.睡眠TS.TabIndex = 0;
            this.睡眠TS.Text = "toolStrip1";
            this.睡眠TS.Click += new System.EventHandler(this.睡眠TS_Click);
            this.睡眠TS.MouseEnter += new System.EventHandler(this.睡眠TS_MouseEnter);
            this.睡眠TS.MouseLeave += new System.EventHandler(this.睡眠TS_MouseLeave);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::仿win10登陆.Properties.Resources.yueliang;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(41, 48);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(155, 48);
            this.toolStripLabel1.Text = "睡眠                             ";
            // 
            // EnterPictBox
            // 
            this.EnterPictBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EnterPictBox.BackColor = System.Drawing.Color.LightGray;
            this.EnterPictBox.BackgroundImage = global::仿win10登陆.Properties.Resources.duanjiantou;
            this.EnterPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterPictBox.Location = new System.Drawing.Point(520, 260);
            this.EnterPictBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnterPictBox.Name = "EnterPictBox";
            this.EnterPictBox.Size = new System.Drawing.Size(32, 34);
            this.EnterPictBox.TabIndex = 4;
            this.EnterPictBox.TabStop = false;
            this.EnterPictBox.Click += new System.EventHandler(this.EnterPictBox_Click);
            // 
            // PasswodrTB
            // 
            this.PasswodrTB.BackColor = System.Drawing.SystemColors.Window;
            this.PasswodrTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswodrTB.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswodrTB.ForeColor = System.Drawing.Color.DimGray;
            this.PasswodrTB.Location = new System.Drawing.Point(293, 271);
            this.PasswodrTB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswodrTB.Name = "PasswodrTB";
            this.PasswodrTB.PasswordChar = '.';
            this.PasswodrTB.Size = new System.Drawing.Size(220, 14);
            this.PasswodrTB.TabIndex = 3;
            this.PasswodrTB.UseSystemPasswordChar = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(293, 260);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(258, 34);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 494);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PasswodrTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClosePicBox);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.HeadPicBox);
            this.Controls.Add(this.EnterPictBox);
            this.Controls.Add(this.CurDate);
            this.Controls.Add(this.CurTime);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick_1);
            ((System.ComponentModel.ISupportInitialize)(this.HeadPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.重启TS.ResumeLayout(false);
            this.重启TS.PerformLayout();
            this.关机TS.ResumeLayout(false);
            this.关机TS.PerformLayout();
            this.睡眠TS.ResumeLayout(false);
            this.睡眠TS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnterPictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CurDate;
        private System.Windows.Forms.PictureBox HeadPicBox;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip 重启TS;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip 关机TS;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip 睡眠TS;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox EnterPictBox;
        private System.Windows.Forms.TextBox PasswodrTB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

