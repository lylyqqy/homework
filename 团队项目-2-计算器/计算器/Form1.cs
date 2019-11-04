using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public static void DrawRoundRectangle(Graphics g, Pen pen, Rectangle rect, int cornerRadius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius))
            {
                g.DrawPath(pen, path);
            }
        }
        public static void FillRoundRectangle(Graphics g, Brush brush, Rectangle rect, int cornerRadius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius))
            {
                g.FillPath(brush, path);

               
            }
        }
        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
        Graphics g;
        Font font = new Font("宋体", 15, FontStyle.Bold);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {          
            this.BackColor = Color.FromArgb(228, 227, 226);
            
            g = e.Graphics;
                  
           
            g.Dispose();
           

        }

        private void UserControl12_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            int s = 14;
            Rectangle rect = new Rectangle(s, s, userControl12.Width - 2 * s, userControl12.Height - 2 * s);
            //LinearGradientBrush lb = new LinearGradientBrush(rect, a, b, 90f);
            Brush brush = new SolidBrush(Color.FromArgb(255, 204, 205, 179));
            FillRoundRectangle(g, brush, rect, 8);
            Pen pen = new Pen(Color.FromArgb(255, 96, 92, 89), 5);
            DrawRoundRectangle(g, pen, rect, 8);

            Brush brush1 = new SolidBrush(Color.FromArgb(255, 199, 199, 175));
            Font font = new Font("DigifaceWide", 40);
            g.DrawString("8888888", font, brush1, new Point(20, 18));

        }

        private void UserControl15_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("mc", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl13_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("m+", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl14_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("m-", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl16_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("mr", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl17_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("AC", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl18_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("+/-", font, Brushes.White, new Point(20, 20));
        }

        private void UserControl19_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("÷", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl110_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("×", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl115_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("7", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl114_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("8", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl113_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("9", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl111_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("-", font, Brushes.White, new Point(25, 19));
        }

        private void UserControl116_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("4", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl117_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("5", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl118_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("6", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl112_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("+", font, Brushes.White, new Point(25, 19));

        }

        private void UserControl119_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("1", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl120_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("2", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl121_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("3", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl122_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString(".", font, Brushes.Black, new Point(30, 20));
        }

        private void UserControl123_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("0", font, Brushes.Black, new Point(70, 19));
        }

        private void UserControl124_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString("=", font, Brushes.White, new Point(30, 56));
        }

        string num1;
        private void UserControl115_Click(object sender, EventArgs e)
        {
            userControl125.num += 7;
            num1 += 7;
            userControl125.Refresh();
        }
        private void UserControl114_Click(object sender, EventArgs e)
        {
            userControl125.num += 8;
            userControl125.Refresh();
            num1 += 8;
        }
        private void UserControl113_Click(object sender, EventArgs e)
        {
            userControl125.num += 9;
            userControl125.Refresh();
            num1 += 9;
        }

        private void UserControl118_Click(object sender, EventArgs e)
        {
            userControl125.num += 6;
            userControl125.Refresh();
            num1 += 6;
        }

        private void UserControl117_Click(object sender, EventArgs e)
        {
            userControl125.num += 5;
            userControl125.Refresh();
            num1 += 5;
        }

        private void UserControl119_Click(object sender, EventArgs e)
        {
            userControl125.num += 1;
            userControl125.Refresh();
            num1 += 1;
        }

        private void UserControl120_Click(object sender, EventArgs e)
        {
            userControl125.num += 2;
            userControl125.Refresh();
            num1 += 2;
        }

        private void UserControl121_Click(object sender, EventArgs e)
        {
            userControl125.num += 3;
            userControl125.Refresh();
            num1 += 3;
        }

        private void UserControl122_Click(object sender, EventArgs e)
        {
            userControl125.num += ".";
            userControl125.Refresh();
            num1 += ".";
        }

        private void UserControl123_Click(object sender, EventArgs e)
        {
            userControl125.num += 0;
            userControl125.Refresh();
            num1 += 0;
        }

        private void UserControl116_Click(object sender, EventArgs e)
        {
            userControl125.num += 4;
            userControl125.Refresh();
            num1 += 4;
        }

        double x; //运算数1
        double m; //结果
        string s; //运算符
        private void UserControl19_Click(object sender, EventArgs e)
        {
            x = double.Parse(num1);
            s = "/";
            num1 = "";

            userControl125.num = "";
            userControl125.num = "÷";
            userControl125.Refresh();
        }

        private void UserControl110_Click(object sender, EventArgs e)
        {
            x = double.Parse(num1);
            s = "*";
            num1 = "";

            userControl125.num = "";
            userControl125.num = "×";
            userControl125.Refresh();
        }

        private void UserControl111_Click(object sender, EventArgs e)
        {
            x = double.Parse(num1);
            s = "-";
            num1 = "";

            userControl125.num = "";
            userControl125.num = "-";
            userControl125.Refresh();
        }

        private void UserControl112_Click(object sender, EventArgs e)
        {
            x = double.Parse(num1);
            s = "+";
            num1 = "";

            userControl125.num = "";
            userControl125.num = "+";
            userControl125.Refresh();
        }

        private void UserControl124_Click(object sender, EventArgs e)
        {
            switch (s)
            {
                case "+": m = x + double.Parse(num1); break;
                case "-": m = x - double.Parse(num1); break;
                case "*": m = x * double.Parse(num1); break;
                case "/": m = x / double.Parse(num1); break;
                
            }
            userControl125.num = "";
            userControl125.num = m.ToString();
            userControl125.Refresh();
        }

        private void UserControl17_Click(object sender, EventArgs e)
        {
            m = 0;
            s = "";
            num1 = "";
            x = 0;
            userControl125.num = "";
            userControl125.Refresh();
        }
    }
}
