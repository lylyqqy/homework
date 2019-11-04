using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace 仿win10登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            CurTime.Location = new Point(10,3*this.Height/4);
            CurDate.Location = new Point(9, CurTime.Location.Y + CurTime.Height+3);

            HeadPicBox.Location = new Point((this.Width-HeadPicBox.Width)/2-40,this.Height/4);
            HeadPicBox.Width= 200;
            HeadPicBox.Height = 200;
            userLb.Location = new Point((this.Width - userLb.Width) / 2, HeadPicBox.Location.Y+HeadPicBox.Height+3);

            richTextBox1.Location= new Point((this.Width - richTextBox1.Width) / 2, userLb.Location.Y + userLb.Height + 15);
            PasswodrTB.Location = new Point(richTextBox1.Location.X, richTextBox1.Location.Y+12);
            EnterPictBox.Location = new Point(richTextBox1.Location.X + richTextBox1.Width - EnterPictBox.Width, richTextBox1.Location.Y);

            ClosePicBox.Location = new Point(this.Width - ClosePicBox.Width - 30, this.Height - ClosePicBox.Height - 25);
            panel1.Location = new Point(this.Width - panel1.Width, ClosePicBox.Location.Y - panel1.Height-5);



            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._2;

        

            PasswodrTB.Visible = false;
            EnterPictBox.Visible = false;

            richTextBox1.Visible = false;
            userLb.Visible = false;
            HeadPicBox.Visible = false;
            ClosePicBox.Visible = false;
            panel1.Visible = false;
            timer1.Enabled = true;
        }
        int FormClick=0;
        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            FormClick++;
           // Form1 form1 = new Form1();
            Bitmap bmp = new Bitmap(Properties.Resources._2);
            if(FormClick==1)
            {
                float BlurRadius = 30;
                Rectangle Rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                bmp.GaussianBlur(ref Rect, BlurRadius, false);
                


                this.BackgroundImage = bmp;
            }
            /*for (int i = 0; i < bmp.Width; i++)   //改变透明度
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cOrg = bmp.GetPixel(i, j);
                    int r = cOrg.R;
                    int g = cOrg.G;
                    int b = cOrg.B;
                    int a = 60;

                    Color cAfter = Color.FromArgb(a, r, g, b);
                    bmp.SetPixel(i, j, cAfter);
                }
            }
            this.BackgroundImage = bmp;*/



            CurTime.Visible = false;
            CurDate.Visible = false;

            PasswodrTB.Visible = true;
            EnterPictBox.Visible = true;
            richTextBox1.Visible = true;
            userLb.Visible = true;
            HeadPicBox.Visible = true;
            ClosePicBox.Visible = true;


            panel1.Visible = false;


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CurTime.Text = DateTime.Now.ToShortTimeString().ToString();
            CurDate.Text = DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日，" + DateTime.Now.DayOfWeek.ToString();

        }

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        private void 睡眠TS_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, true);
        }

        private void 关机TS_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void 重启TS_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

     

        private void ClosePicBox_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = true;


        }

        private void EnterPictBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 睡眠TS_MouseEnter(object sender, EventArgs e)
        {
            睡眠TS.BackColor = Color.Silver;
        }
        private void 睡眠TS_MouseLeave(object sender, EventArgs e)
        {
            睡眠TS.BackColor = Color.Transparent;
        }

        private void 关机TS_MouseEnter(object sender, EventArgs e)
        {
            关机TS.BackColor = Color.Silver;
        }
        private void 关机TS_MouseLeave(object sender, EventArgs e)
        {
            关机TS.BackColor = Color.Transparent;
        }

        private void 重启TS_MouseLeave(object sender, EventArgs e)
        {
            重启TS.BackColor = Color.Transparent;
        }
        private void 重启TS_MouseEnter(object sender, EventArgs e)
        {
            重启TS.BackColor = Color.Silver;
        }
    }
}
