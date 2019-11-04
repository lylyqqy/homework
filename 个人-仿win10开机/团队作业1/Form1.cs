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

namespace 团队作业1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }
        private Timer Timer1;
        private Timer Timer2;

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1 = new Timer();
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(timer1_Tick);
            Timer1.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("HH:mm");
            this.lblDate.Text = DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日" + "," + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            lblTime.Visible = false;
            //picUser.Visible = true;
            picUser.Visible = true;
            txtPwd.Visible = true;
            picArrow.Visible = true;
            lblUser.Visible = true;
            Bitmap bmp = new Bitmap(this.BackgroundImage);

            Random rand = new Random();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    int dx = i + rand.Next() % 10;
                    int dy = j + rand.Next() % 10;
                    if (dx >= bmp.Width)
                    {
                        dx = bmp.Width - 1;
                    }
                    if (dy >= bmp.Height)
                    {
                        dy = bmp.Height - 1;
                    }
                    Color pixel = bmp.GetPixel(dx, dy);
                    bmp.SetPixel(i, j, pixel);
                }
            }
            //将图片显示
            this.BackgroundImage = bmp;
           

        }

        int i = 0;

        private void picClose_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 1)
            {
                picSleep.Visible = true;
                picClose1.Visible = true;
                picReload.Visible = true;
                lblSleep.Visible = true;
                lblClose.Visible = true;
                lblReload.Visible = true;
                
            }else
            {
                picSleep.Visible = false;
                picClose1.Visible = false;
                picReload.Visible = false;
                lblSleep.Visible = false;
                lblClose.Visible = false;
                lblReload.Visible = false;
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (txtPwd.Text != "123")
                {
                    txtPwd.Visible = false;
                    picArrow.Visible = false;
                    lblUser.Visible = true;
                    btn.Visible = true;
                    lblWarn.Visible = true;
                }
            }
        }

        private void lblSleep_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, false, false);


        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process bootProcess = new System.Diagnostics.Process();
            bootProcess.StartInfo.FileName = "shutdown";

            bootProcess.StartInfo.Arguments = "/s";

            bootProcess.Start();
        }
        
        private void lblReload_Click(object sender, EventArgs e)
        {
           
            Process.Start("shutdown.exe", "-r");
            // By Default the Restart will take place after 30 Seconds
            //if you want to change the Delay try this one
            Process.Start("shutdown.exe", "-r -t 10");
            //Replace xx with Seconds example 10,20 etc

        }

        private void picArrow_Click(object sender, EventArgs e)
        {
            
                if (txtPwd.Text != "123")
                {
                    txtPwd.Visible = false;
                    picArrow.Visible = false;
                    lblUser.Visible = true;
                    btn.Visible = true;
                    lblWarn.Visible = true;
                }
            
        }
    }
}
