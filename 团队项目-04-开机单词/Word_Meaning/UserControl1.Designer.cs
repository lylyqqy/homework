namespace Word_Meaning
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.wordLb = new System.Windows.Forms.Label();
            this.meanBt1 = new System.Windows.Forms.Button();
            this.meanBt2 = new System.Windows.Forms.Button();
            this.meanBt3 = new System.Windows.Forms.Button();
            this.meanBt4 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // wordLb
            // 
            this.wordLb.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLb.Location = new System.Drawing.Point(25, 10);
            this.wordLb.Name = "wordLb";
            this.wordLb.Size = new System.Drawing.Size(286, 43);
            this.wordLb.TabIndex = 0;
            this.wordLb.Text = "label1";
            this.wordLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meanBt1
            // 
            this.meanBt1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meanBt1.Location = new System.Drawing.Point(64, 56);
            this.meanBt1.Name = "meanBt1";
            this.meanBt1.Size = new System.Drawing.Size(198, 31);
            this.meanBt1.TabIndex = 1;
            this.meanBt1.Text = "button1";
            this.meanBt1.UseVisualStyleBackColor = true;
            this.meanBt1.Click += new System.EventHandler(this.MeanBt1_Click);
            // 
            // meanBt2
            // 
            this.meanBt2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meanBt2.Location = new System.Drawing.Point(64, 93);
            this.meanBt2.Name = "meanBt2";
            this.meanBt2.Size = new System.Drawing.Size(198, 31);
            this.meanBt2.TabIndex = 1;
            this.meanBt2.Text = "button1";
            this.meanBt2.UseVisualStyleBackColor = true;
            this.meanBt2.Click += new System.EventHandler(this.MeanBt2_Click);
            // 
            // meanBt3
            // 
            this.meanBt3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meanBt3.Location = new System.Drawing.Point(64, 140);
            this.meanBt3.Name = "meanBt3";
            this.meanBt3.Size = new System.Drawing.Size(198, 31);
            this.meanBt3.TabIndex = 1;
            this.meanBt3.Text = "button1";
            this.meanBt3.UseVisualStyleBackColor = true;
            this.meanBt3.Click += new System.EventHandler(this.MeanBt3_Click);
            // 
            // meanBt4
            // 
            this.meanBt4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meanBt4.Location = new System.Drawing.Point(64, 189);
            this.meanBt4.Name = "meanBt4";
            this.meanBt4.Size = new System.Drawing.Size(198, 31);
            this.meanBt4.TabIndex = 1;
            this.meanBt4.Text = "button1";
            this.meanBt4.UseVisualStyleBackColor = true;
            this.meanBt4.Click += new System.EventHandler(this.MeanBt4_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(282, 148);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Word_Meaning.Properties.Resources.未通过;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(15, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 269);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.meanBt4);
            this.Controls.Add(this.meanBt3);
            this.Controls.Add(this.meanBt2);
            this.Controls.Add(this.meanBt1);
            this.Controls.Add(this.wordLb);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(355, 273);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wordLb;
        private System.Windows.Forms.Button meanBt1;
        private System.Windows.Forms.Button meanBt2;
        private System.Windows.Forms.Button meanBt3;
        private System.Windows.Forms.Button meanBt4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
    }
}
