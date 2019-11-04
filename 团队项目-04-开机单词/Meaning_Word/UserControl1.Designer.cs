namespace Meaning_Word
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
            this.wordBt1 = new System.Windows.Forms.Button();
            this.wordBt2 = new System.Windows.Forms.Button();
            this.wordBt3 = new System.Windows.Forms.Button();
            this.wordBt4 = new System.Windows.Forms.Button();
            this.meanLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // wordBt1
            // 
            this.wordBt1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBt1.Location = new System.Drawing.Point(41, 128);
            this.wordBt1.Name = "wordBt1";
            this.wordBt1.Size = new System.Drawing.Size(382, 40);
            this.wordBt1.TabIndex = 1;
            this.wordBt1.Text = "button1";
            this.wordBt1.UseVisualStyleBackColor = true;
            this.wordBt1.Click += new System.EventHandler(this.WordBt1_Click);
            // 
            // wordBt2
            // 
            this.wordBt2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBt2.Location = new System.Drawing.Point(41, 82);
            this.wordBt2.Name = "wordBt2";
            this.wordBt2.Size = new System.Drawing.Size(382, 40);
            this.wordBt2.TabIndex = 1;
            this.wordBt2.Text = "button1";
            this.wordBt2.UseVisualStyleBackColor = true;
            this.wordBt2.Click += new System.EventHandler(this.WordBt2_Click);
            // 
            // wordBt3
            // 
            this.wordBt3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBt3.Location = new System.Drawing.Point(41, 179);
            this.wordBt3.Name = "wordBt3";
            this.wordBt3.Size = new System.Drawing.Size(382, 40);
            this.wordBt3.TabIndex = 1;
            this.wordBt3.Text = "button1";
            this.wordBt3.UseVisualStyleBackColor = true;
            this.wordBt3.Click += new System.EventHandler(this.WordBt3_Click);
            // 
            // wordBt4
            // 
            this.wordBt4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBt4.Location = new System.Drawing.Point(41, 229);
            this.wordBt4.Name = "wordBt4";
            this.wordBt4.Size = new System.Drawing.Size(382, 40);
            this.wordBt4.TabIndex = 1;
            this.wordBt4.Text = "button1";
            this.wordBt4.UseVisualStyleBackColor = true;
            this.wordBt4.Click += new System.EventHandler(this.WordBt4_Click);
            // 
            // meanLb
            // 
            this.meanLb.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meanLb.Location = new System.Drawing.Point(31, 14);
            this.meanLb.Name = "meanLb";
            this.meanLb.Size = new System.Drawing.Size(411, 44);
            this.meanLb.TabIndex = 0;
            this.meanLb.Text = "label1";
            this.meanLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Meaning_Word.Properties.Resources.未通过;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(86, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 325);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(377, 35);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wordBt4);
            this.Controls.Add(this.wordBt3);
            this.Controls.Add(this.wordBt2);
            this.Controls.Add(this.wordBt1);
            this.Controls.Add(this.meanLb);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(467, 329);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button wordBt1;
        private System.Windows.Forms.Button wordBt2;
        private System.Windows.Forms.Button wordBt3;
        private System.Windows.Forms.Button wordBt4;
        private System.Windows.Forms.Label meanLb;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
