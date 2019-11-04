using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            timer1.Enabled = true;

            SingerImg = Properties.Resources._default;
            SingerImg = singerImg.GetThumbnailImage(this.Width, this.Height, null, IntPtr.Zero); //图片缩放
        }
       
        double avaterRotAnt = 0.0; //头像旋转角度

        Graphics g;
        int offset = 8;
        public double angle = 0;
        int cutPosRadiud = 10;

        int innerCirRadiud=45;

        int borderWidth = 4;

        Image imgPlay = Properties.Resources.play;
        
        Image imgPause = Properties.Resources.pause;

        private Image singerImg;
        public Image SingerImg
        {
            get
            {
                return singerImg;
            }
            set
            {
                singerImg = value;
                singerImg = singerImg.GetThumbnailImage(this.Width, this.Height, null, IntPtr.Zero);
            }
        }

        public int i = 0;

        //public bool IsPlaying;
        public double MaxValue=1, CurValue=0;

        public void UserControl1_Click(object sender, EventArgs e)
        {
            i++;         
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //画大圆
            Pen pen = new Pen(Color.FromArgb(63, 69, 83), 7);
            Rectangle rect = new Rectangle(offset, offset, this.Width - 2 * offset, this.Height - 2 * offset);
            g.DrawEllipse(pen,rect);

            //坐标原点移动到中间
            g.TranslateTransform(this.Width / 2, this.Height / 2);

            //坐标系旋转
            g.RotateTransform((float)avaterRotAnt);

            //坐标系移动回去
            g.TranslateTransform(-this.Width / 2, -this.Height / 2);

            //在大圆中填充图片            
            TextureBrush tb = new TextureBrush(singerImg);
            g.FillEllipse(tb,
                new Rectangle(offset + borderWidth, offset + borderWidth, this.Width - 2 * (offset + borderWidth), this.Height - 2 * (offset + borderWidth)));


            g.ResetTransform();
            g.Save();

            //画弧线
            
            g.DrawArc(new Pen(Color.FromArgb(175, 188, 233), 7), rect, 270, (float)(angle*180/Math.PI)); 
            
            //画小圆球
            double r = this.Width / 2 - offset;
            double x = this.Width/2+ r * Math.Sin(angle);
            double y =this.Width/2- r * Math.Cos(angle );
            g.FillEllipse(new SolidBrush(Color.FromArgb(175,188,233)), new Rectangle((int)x-cutPosRadiud, (int)y-cutPosRadiud, 2*cutPosRadiud, 2*cutPosRadiud));

            
           g.FillEllipse(new SolidBrush(Color.FromArgb(127, 0, 0,0)), 
                this.Width / 2 - innerCirRadiud, this.Height / 2 - innerCirRadiud, innerCirRadiud *2, innerCirRadiud * 2);


            //加入播放和暂停的图片
            Bitmap imgPlay1 = new Bitmap(imgPlay);
            imgPlay1.MakeTransparent(Color.White);
            TextureBrush imgPlay2 = new TextureBrush(imgPlay1);

            Bitmap imgPause1 = new Bitmap(imgPause);
            imgPause1.MakeTransparent(Color.White);
            TextureBrush imgPause2 = new TextureBrush(imgPause1);

            if (i % 2 == 0)
            {
                g.FillRectangle(imgPlay2, new RectangleF((float)(this.Width - (imgPlay1.Width-8)) / 2, (float)(this.Height - (imgPlay1.Height)) / 2,
                    (float)imgPlay1.Width, (float)imgPlay1.Height));
            }
            else
            {
                g.FillRectangle(imgPause2, new RectangleF((float)(this.Width - imgPause1.Width+8) / 2, (float)(this.Height - imgPause1.Height) / 2, 
                    (float)imgPause1.Width, (float)imgPause1.Height));
                
            }

            
        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            avaterRotAnt++;
           
            this.Invalidate();
        }

                
       
    }
}
