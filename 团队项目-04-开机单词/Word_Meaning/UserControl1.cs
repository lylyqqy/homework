using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;


namespace Word_Meaning
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        FileStream fs;

        int[] arr = getRandomNum(4, 1, 410);
        int[] num = getRandomNum(1, 0, 3);
       
        private void UserControl1_Load(object sender, EventArgs e)
        {
            

            fs = new FileStream(@"C:\桌面设计\团队项目-04-开机单词\ForceRemWord\bin\Debug\EnglishWord1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);  //读文件

            string str = sr.ReadToEnd();
            string[] pixel = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            int a = pixel[arr[0]].IndexOf(" ");
            meanBt1.Text = pixel[arr[0]].Substring(a);
            int b = pixel[arr[1]].IndexOf(" ");
            meanBt2.Text = pixel[arr[1]].Substring(b);
            int c = pixel[arr[2]].IndexOf(" ");
            meanBt3.Text = pixel[arr[2]].Substring(c);
            int d = pixel[arr[3]].IndexOf(" ");
            meanBt4.Text = pixel[arr[3]].Substring(d);

            int f = pixel[arr[num[0]]].IndexOf(" ");
            wordLb.Text = pixel[arr[num[0]]].Substring(0, f);
            sr.Close();
            fs.Close();
        }
        public static int[] getRandomNum(int num, int minValue, int maxValue)
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int[] arrNum = new int[num];
            int tmp = 0;
            for (int i = 0; i <= num - 1; i++)
            {
                tmp = ra.Next(minValue, maxValue); //随机取数
                arrNum[i] = getNum(arrNum, tmp, minValue, maxValue, ra); //取出值赋到数组中
            }
            return arrNum;
        }
        public static int getNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            int n = 0;
            while (n < arrNum.Length - 1)
            {
                if (arrNum[n] == tmp) //利用循环判断是否有重复
                {
                    tmp = ra.Next(minValue, maxValue); //重新随机获取。
                    getNum(arrNum, tmp, minValue, maxValue, ra);//递归:如果取出来的数字和已取得的数字有重复就重新随机获取。
                }
                n++;
            }
            return tmp;
        }

        SpeechSynthesizer Synthesizer = new SpeechSynthesizer();
        int rate = 0;
        private void MeanBt1_Click(object sender, EventArgs e)
        {
            if (num[0] == 0)
            {
                meanBt1.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
                //Synthesizer.SelectVoice();
                Synthesizer.SpeakAsync("" + wordLb.Text + "");

                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201702/8334.mp3";
                axWindowsMediaPlayer1.settings.volume = 10;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201812/10986.mp3";
                axWindowsMediaPlayer1.settings.volume = 50;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void MeanBt2_Click(object sender, EventArgs e)
        {
            if (num[0] == 1)
            {
                meanBt2.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
                //Synthesizer.SelectVoice();
                Synthesizer.SpeakAsync("" + wordLb.Text + "");

                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201702/8334.mp3";
                axWindowsMediaPlayer1.settings.volume = 10;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201812/10986.mp3";
                axWindowsMediaPlayer1.settings.volume = 50;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void MeanBt3_Click(object sender, EventArgs e)
        {
            if (num[0] == 2)
            {
                meanBt3.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
                //Synthesizer.SelectVoice();
                Synthesizer.SpeakAsync("" + wordLb.Text + "");

                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201702/8334.mp3";
                axWindowsMediaPlayer1.settings.volume = 10;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201812/10986.mp3";
                axWindowsMediaPlayer1.settings.volume = 50;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void MeanBt4_Click(object sender, EventArgs e)
        {
            if (num[0] == 3)
            {
                meanBt4.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
                //Synthesizer.SelectVoice();
                Synthesizer.SpeakAsync("" + wordLb.Text + "");

                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201702/8334.mp3";
                axWindowsMediaPlayer1.settings.volume = 10;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201812/10986.mp3";
                axWindowsMediaPlayer1.settings.volume = 50;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Size.Width / 5;
            this.Height = Screen.PrimaryScreen.Bounds.Size.Height / 3;
            int h = 5;
            wordLb.Width = this.Width - 60;
            wordLb.Height = this.Height / 7;
            wordLb.Location = new Point((this.Width - wordLb.Width) / 2, 10);

            meanBt1.Width = this.Width - 80;
            meanBt1.Height = this.Height / 7 + h;
            meanBt1.Location = new Point((this.Width - meanBt1.Width) / 2, this.Height / 5);

            meanBt2.Width = this.Width - 80;
            meanBt2.Height = this.Height / 7 + h;
            meanBt2.Location = new Point((this.Width - meanBt2.Width) / 2, 2 * this.Height / 5);

            meanBt3.Width = this.Width - 80;
            meanBt3.Height = this.Height / 7 + h;
            meanBt3.Location = new Point((this.Width - meanBt3.Width) / 2, 3 * this.Height / 5);

            meanBt4.Width = this.Width - 80;
            meanBt4.Height = this.Height / 7 + h;
            meanBt4.Location = new Point((this.Width - meanBt4.Width) / 2, 4 * this.Height / 5);

            panel1.Width = this.Width;
            panel1.Height = this.Height;
            panel1.Location = new Point(0, 0);
        }
    }
}
