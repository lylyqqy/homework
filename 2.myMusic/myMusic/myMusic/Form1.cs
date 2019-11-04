using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }









        int y = 300;
        private void Button1_Click(object sender, EventArgs e)
        {           
            axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\Desktop\music\KuwoMusic资源\song\金南玲-逆流成河.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
          
        }
    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Encoding encode = Encoding.GetEncoding("GB2312");   //字符转换
            FileStream fs = new FileStream(@"C:\Users\Lenovo\Desktop\music\KuwoMusic资源\Lyric\金南玲-逆流成河.lrc", FileMode.Open); //打开文件
            StreamReader sr = new StreamReader(fs, encode);  //读文件

            string s;
            int m = y;

            while ((s = sr.ReadLine()) != null)
            {
                if (s == "")
                {
                    continue;
                }

                Label lbl = new Label();
                lbl.Location = new Point(240, m);
                m += 25;
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.Black;
                lbl.Width = 300;
                lbl.Font = new System.Drawing.Font("微软雅黑", 12);
                lbl.Text = s.Substring(10);

                if (m >= 300 && m <= 375)
                    this.Controls.Add(lbl);

                int minute = int.Parse(s.Substring(1, 2));
                double second = double.Parse(s.Substring(4, 5));


            }

            sr.Close();
            fs.Close();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            y = y - 10;
            this.Invalidate();
        }
    }
}
