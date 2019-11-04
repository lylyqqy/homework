using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KuWoMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> lstLyricTime=new List<double>();
        List<Label> lstlbl = new List<Label>();
        private void button1_Click(object sender, EventArgs e)
        {
            //读取文件

            Encoding encode = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream("陈一发儿-童话镇.lrc", FileMode.Open); //打开
            StreamReader sr = new StreamReader(fs,encode);
            string s;
            int y=100;
            while((s = sr.ReadLine()) != null)
            {
                if(s=="")
                {
                    continue;

                }
                //用代码的方式添加控件设置属性
                Label lbl = new Label();
                lbl.Location = new Point(200, y);
                y += 20;
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.White;
                lbl.Width = 300;
                lbl.Font = new System.Drawing.Font("微软雅黑", 12);
                //从10截取子字符串
                lbl.Text = s.Substring(10);

                lstlbl.Add(lbl);
                int minute=int.Parse(s.Substring(1, 2));
               double second =double.Parse(s.Substring(4, 5));
                this.Controls.Add(lbl);
            }
            axWindowsMediaPlayer1.URL = "陈一发儿-童话镇.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
            sr.Close();
            fs.Close();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPlayTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            lblDuration.Text = axWindowsMediaPlayer1.currentMedia.durationString;

            progressBar1.Maximum= (int)axWindowsMediaPlayer1.currentMedia.duration;
            progressBar1.Value=(int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            int curTime= (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            int curLyricIdx;
            for(int i=0;i<lstlbl.Count;i++)
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
