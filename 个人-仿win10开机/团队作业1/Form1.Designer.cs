namespace 团队作业1
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblWarn = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picClose1 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.picSleep = new System.Windows.Forms.PictureBox();
            this.lblSleep = new System.Windows.Forms.Label();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.lblReload = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(89, 224);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 12);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(89, 257);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 12);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(328, 146);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(23, 12);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "qqy";
            this.lblUser.Visible = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(289, 168);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.Visible = false;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // picArrow
            // 
            this.picArrow.BackgroundImage = global::团队作业1.Properties.Resources.youjiantou;
            this.picArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picArrow.Location = new System.Drawing.Point(380, 168);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(24, 20);
            this.picArrow.TabIndex = 5;
            this.picArrow.TabStop = false;
            this.picArrow.Visible = false;
            this.picArrow.Click += new System.EventHandler(this.picArrow_Click);
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = global::团队作业1.Properties.Resources.yonghutubiao1;
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.Location = new System.Drawing.Point(320, 106);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(42, 37);
            this.picUser.TabIndex = 6;
            this.picUser.TabStop = false;
            this.picUser.Visible = false;
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.BackColor = System.Drawing.Color.Transparent;
            this.lblWarn.ForeColor = System.Drawing.Color.White;
            this.lblWarn.Location = new System.Drawing.Point(278, 171);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(149, 12);
            this.lblWarn.TabIndex = 7;
            this.lblWarn.Text = "密码不正确，请再输一次。";
            this.lblWarn.Visible = false;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(289, 195);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(84, 26);
            this.btn.TabIndex = 8;
            this.btn.Text = "确定";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Visible = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::团队作业1.Properties.Resources.guanji;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Location = new System.Drawing.Point(601, 308);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 25);
            this.picClose.TabIndex = 9;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picClose1
            // 
            this.picClose1.BackColor = System.Drawing.Color.Transparent;
            this.picClose1.BackgroundImage = global::团队作业1.Properties.Resources.guanji;
            this.picClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose1.Location = new System.Drawing.Point(583, 266);
            this.picClose1.Name = "picClose1";
            this.picClose1.Size = new System.Drawing.Size(15, 12);
            this.picClose1.TabIndex = 10;
            this.picClose1.TabStop = false;
            this.picClose1.Visible = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(604, 266);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(29, 12);
            this.lblClose.TabIndex = 11;
            this.lblClose.Text = "关机";
            this.lblClose.Visible = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // picSleep
            // 
            this.picSleep.BackColor = System.Drawing.Color.Transparent;
            this.picSleep.BackgroundImage = global::团队作业1.Properties.Resources.yueliang;
            this.picSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSleep.Location = new System.Drawing.Point(583, 245);
            this.picSleep.Name = "picSleep";
            this.picSleep.Size = new System.Drawing.Size(15, 15);
            this.picSleep.TabIndex = 12;
            this.picSleep.TabStop = false;
            this.picSleep.Visible = false;
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.BackColor = System.Drawing.Color.Transparent;
            this.lblSleep.ForeColor = System.Drawing.Color.White;
            this.lblSleep.Location = new System.Drawing.Point(604, 248);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(29, 12);
            this.lblSleep.TabIndex = 13;
            this.lblSleep.Text = "睡眠";
            this.lblSleep.Visible = false;
            this.lblSleep.Click += new System.EventHandler(this.lblSleep_Click);
            // 
            // picReload
            // 
            this.picReload.BackColor = System.Drawing.Color.Transparent;
            this.picReload.BackgroundImage = global::团队作业1.Properties.Resources.zhongqi;
            this.picReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picReload.Location = new System.Drawing.Point(583, 284);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(15, 15);
            this.picReload.TabIndex = 14;
            this.picReload.TabStop = false;
            this.picReload.Visible = false;
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.BackColor = System.Drawing.Color.Transparent;
            this.lblReload.ForeColor = System.Drawing.Color.White;
            this.lblReload.Location = new System.Drawing.Point(604, 287);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(29, 12);
            this.lblReload.TabIndex = 15;
            this.lblReload.Text = "重启";
            this.lblReload.Visible = false;
            this.lblReload.Click += new System.EventHandler(this.lblReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::团队作业1.Properties.Resources.锁屏;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 407);
            this.Controls.Add(this.lblReload);
            this.Controls.Add(this.picReload);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.picSleep);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.picClose1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblWarn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.PictureBox picArrow;
        public System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picClose1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox picSleep;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.Label lblReload;
    }
}

