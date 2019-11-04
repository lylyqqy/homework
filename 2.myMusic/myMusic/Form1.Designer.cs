namespace myMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCurPlayTime = new System.Windows.Forms.Label();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.picRandom = new System.Windows.Forms.PictureBox();
            this.picLoop = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.userControl12 = new WindowsFormsControlLibrary1.UserControl1();
            this.lyric1 = new WindowsFormsControlLibrary2.Lyric();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(501, 476);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.AxWindowsMediaPlayer1_MediaChange_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(212, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "歌名";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAuthor.Location = new System.Drawing.Point(206, 39);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(59, 16);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "歌唱者";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurPlayTime
            // 
            this.lblCurPlayTime.AutoSize = true;
            this.lblCurPlayTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurPlayTime.Location = new System.Drawing.Point(214, 316);
            this.lblCurPlayTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurPlayTime.Name = "lblCurPlayTime";
            this.lblCurPlayTime.Size = new System.Drawing.Size(56, 16);
            this.lblCurPlayTime.TabIndex = 4;
            this.lblCurPlayTime.Text = "00：00";
            this.lblCurPlayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMute
            // 
            this.picMute.BackColor = System.Drawing.Color.Transparent;
            this.picMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMute.BackgroundImage")));
            this.picMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMute.Location = new System.Drawing.Point(343, 457);
            this.picMute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(45, 48);
            this.picMute.TabIndex = 16;
            this.picMute.TabStop = false;
            this.picMute.Click += new System.EventHandler(this.PicMute_Click);
            // 
            // picRandom
            // 
            this.picRandom.BackColor = System.Drawing.Color.Transparent;
            this.picRandom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRandom.BackgroundImage")));
            this.picRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRandom.Location = new System.Drawing.Point(203, 457);
            this.picRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picRandom.Name = "picRandom";
            this.picRandom.Size = new System.Drawing.Size(45, 48);
            this.picRandom.TabIndex = 15;
            this.picRandom.TabStop = false;
            this.picRandom.Click += new System.EventHandler(this.PicRandom_Click);
            // 
            // picLoop
            // 
            this.picLoop.BackColor = System.Drawing.Color.Transparent;
            this.picLoop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoop.BackgroundImage")));
            this.picLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoop.Location = new System.Drawing.Point(59, 457);
            this.picLoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLoop.Name = "picLoop";
            this.picLoop.Size = new System.Drawing.Size(45, 48);
            this.picLoop.TabIndex = 14;
            this.picLoop.TabStop = false;
            this.picLoop.Click += new System.EventHandler(this.PicLoop_Click);
            // 
            // picPrev
            // 
            this.picPrev.BackColor = System.Drawing.Color.Transparent;
            this.picPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPrev.BackgroundImage")));
            this.picPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPrev.Location = new System.Drawing.Point(44, 162);
            this.picPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(52, 56);
            this.picPrev.TabIndex = 13;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.PicPrev_Click);
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNext.BackgroundImage")));
            this.picNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNext.Location = new System.Drawing.Point(376, 162);
            this.picNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(52, 56);
            this.picNext.TabIndex = 12;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.PicNext_Click);
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(127, 58);
            this.userControl12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControl12.Name = "userControl12";
            this.userControl12.SingerImg = ((System.Drawing.Image)(resources.GetObject("userControl12.SingerImg")));
            this.userControl12.Size = new System.Drawing.Size(225, 240);
            this.userControl12.TabIndex = 18;
            this.userControl12.Click += new System.EventHandler(this.UserControl12_Click);
            // 
            // lyric1
            // 
            this.lyric1.Location = new System.Drawing.Point(107, 334);
            this.lyric1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lyric1.Name = "lyric1";
            this.lyric1.Size = new System.Drawing.Size(244, 118);
            this.lyric1.TabIndex = 17;
            this.lyric1.Load += new System.EventHandler(this.Lyric1_Load);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 511);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.lyric1);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.picRandom);
            this.Controls.Add(this.picLoop);
            this.Controls.Add(this.picPrev);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.lblCurPlayTime);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private WindowsFormsControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCurPlayTime;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox picLoop;
        private System.Windows.Forms.PictureBox picRandom;
        private System.Windows.Forms.PictureBox picMute;
        private WindowsFormsControlLibrary2.Lyric lyric1;
        private WindowsFormsControlLibrary1.UserControl1 userControl12;
    }
}

