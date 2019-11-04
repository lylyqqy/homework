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
            singerImg=Properties.Resources._default.GetThumbnailImage(this.Width,this.Height, null, IntPtr.Zero);
        }
        private Image singerImg;

       

        double avaterRotAnt = 0.0; //头像旋转角度

        Graphics g;
        int offset = 8;
        int angle = 0;
        int cutPosRadiud = 10;

        int innerCirRadiud=35;

        int borderWidth = 4;


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
            //get => singerImg;
           // set => singerImg = value;
            //singerImg = singerImg.GetThumbnailImage(this.Width, this.Height, null, IntPtr.Zero);
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
            SingerImg= Properties.Resources._default;


            //Image img = Properties.Resources.;
            SingerImg = SingerImg.GetThumbnailImage(this.Width, this.Height, null, IntPtr.Zero); //图片缩放
            TextureBrush tb = new TextureBrush(SingerImg);

            g.FillEllipse(tb,
                new Rectangle(offset + borderWidth, offset + borderWidth, this.Width - 2 * (offset + borderWidth), this.Height - 2 * (offset + borderWidth)));


            g.ResetTransform();
            g.Save();

            //画弧线
            g.DrawArc(new Pen(Color.FromArgb(175, 188, 233), 7), rect, 270, angle);  

            double r = this.Width / 2 - offset;
            double x = this.Width/2+ r * Math.Sin(angle / 180.0 * Math.PI);
            double y =this.Width/2- r * Math.Cos(angle / 180.0 * Math.PI);
            g.FillEllipse(new SolidBrush(Color.FromArgb(175,188,233)), new Rectangle((int)x-cutPosRadiud, (int)y-cutPosRadiud, 2*cutPosRadiud, 2*cutPosRadiud));


           g.FillEllipse(new SolidBrush(Color.FromArgb(127, 0, 0,0)), 
                this.Width / 2 - innerCirRadiud, this.Height / 2 - innerCirRadiud, innerCirRadiud *2, innerCirRadiud * 2);
           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            avaterRotAnt++;
            angle++;
            this.Invalidate();
        }
    }
}
