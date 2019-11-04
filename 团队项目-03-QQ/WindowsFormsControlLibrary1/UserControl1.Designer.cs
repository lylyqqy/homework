namespace WindowsFormsControlLibrary1
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
            this.lblMassegeNam = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInfor = new System.Windows.Forms.Label();
            this.picHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMassegeNam
            // 
            this.lblMassegeNam.AutoSize = true;
            this.lblMassegeNam.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMassegeNam.Location = new System.Drawing.Point(64, 9);
            this.lblMassegeNam.Name = "lblMassegeNam";
            this.lblMassegeNam.Size = new System.Drawing.Size(88, 16);
            this.lblMassegeNam.TabIndex = 1;
            this.lblMassegeNam.Text = "西柚通知群";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTime.Location = new System.Drawing.Point(255, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "15:57";
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblInfor.Location = new System.Drawing.Point(64, 29);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(37, 20);
            this.lblInfor.TabIndex = 2;
            this.lblInfor.Text = "好的";
            // 
            // picHead
            // 
            this.picHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHead.BackgroundImage")));
            this.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHead.Location = new System.Drawing.Point(5, 5);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(45, 45);
            this.picHead.TabIndex = 0;
            this.picHead.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblInfor);
            this.Controls.Add(this.lblMassegeNam);
            this.Controls.Add(this.picHead);
            this.DoubleBuffered = true;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(307, 63);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.Label lblMassegeNam;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInfor;
    }
}
