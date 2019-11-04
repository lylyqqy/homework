using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿IOS_12测距仪
{
    public partial class FrmDistanceMeasure : Form
    {
        public FrmDistanceMeasure()
        {
            InitializeComponent();
        }

        Graphics g;
        Point clickPoint, movePoint;
        int cliNum = 0;
        bool cli = false,mov=false;
        double distance;

        private void FrmDistanceMeasure_Load(object sender, EventArgs e)
        {

        }

        private void FrmDistanceMeasure_MouseDown(object sender, MouseEventArgs e)
        {
            cliNum++;
            if(cliNum==1)
            {
                cli = true;
                clickPoint = new Point(e.X, e.Y);
            }
           if(cliNum==2)
            {
                mov = true;
                movePoint= new Point(e.X, e.Y);
            }
            this.Refresh();
        }
        
   
        private void FrmDistanceMeasure_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Image img = Image.FromFile("yaoming.jpg");
            g.DrawImage(img, new PointF(0, 0));
            Pen pen = new Pen(Brushes.White);
            if (cli)
            {              
                g.FillEllipse(Brushes.White, new Rectangle(clickPoint.X-10, clickPoint.Y-10, 20, 20));              
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawEllipse(pen, new RectangleF(clickPoint.X-20, clickPoint.Y-20, 40, 40));

                
            }
            if(mov)
            {
                g.FillEllipse(Brushes.White, new Rectangle(movePoint.X-10, movePoint.Y-10, 20, 20));
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawEllipse(pen, new RectangleF(movePoint.X - 20, movePoint.Y - 20, 40, 40));
            }
            if(cli&&mov)
            {
                g.DrawLine(new Pen(Brushes.White, 3), clickPoint.X, clickPoint.Y, movePoint.X, movePoint.Y);
            }
            distance = Math.Sqrt((clickPoint.X - movePoint.X) * (clickPoint.X - movePoint.X) + (clickPoint.Y - movePoint.Y) * (clickPoint.Y - movePoint.Y)) * 0.34;
            g.DrawString(distance.ToString("f0")+"cm", this.Font, Brushes.White, 0, 0);

        }
    }
}
