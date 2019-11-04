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

namespace Meaning_Word
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
        
        public void UserControl1_Load(object sender, EventArgs e)
        {
            
            fs = new FileStream(@"C:\桌面设计\团队项目-04-开机单词\ForceRemWord\bin\Debug\EnglishWord.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);  //读文件

            string str = sr.ReadToEnd();
            string[] pixel = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            fs.Close();
            sr.Close();

            int a = pixel[arr[0]].IndexOf(" ");
            wordBt1.Text = pixel[arr[0]].Substring(0, a);
            int b = pixel[arr[1]].IndexOf(" ");
            wordBt2.Text = pixel[arr[1]].Substring(0, b);
            int c = pixel[arr[2]].IndexOf(" ");
            wordBt3.Text = pixel[arr[2]].Substring(0, c);
            int d = pixel[arr[3]].IndexOf(" ");
            wordBt4.Text = pixel[arr[3]].Substring(0, d);

            int f= pixel[arr[num[0]]].IndexOf(" ");
            meanLb.Text = pixel[arr[num[0]]].Substring(f);
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

        

        private void WordBt1_Click(object sender, EventArgs e)
        {
            if(num[0]==0)
            {
                wordBt1.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
                //Synthesizer.SelectVoice();
                Synthesizer.SpeakAsync("" + wordBt1.Text + "");

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

        private void WordBt2_Click(object sender, EventArgs e)
        {
            if (num[0] == 1)
            {
                wordBt2.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
               
                Synthesizer.SpeakAsync("" + wordBt2.Text + "");

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

        private void WordBt3_Click(object sender, EventArgs e)
        {
            if (num[0] == 2)
            {
                wordBt3.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
               
                Synthesizer.SpeakAsync("" + wordBt3.Text + "");

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

        private void WordBt4_Click(object sender, EventArgs e)
        {
            if (num[0] == 3)
            {
                wordBt4.BackColor = Color.Green;
                this.BackColor = Color.Gold;

                Synthesizer.Rate = rate;//发音速度
                Synthesizer.Volume = 100;//音量
                //Synthesizer.SelectVoice();
                Synthesizer.SpeakAsync("" + wordBt4.Text + "");

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
            
            this.Width = Screen.PrimaryScreen.Bounds.Width / 5;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 3;
            int h = 5;
            meanLb.Width = this.Width - 60;
            meanLb.Height = this.Height / 7;
            meanLb.Location = new Point((this.Width - meanLb.Width) / 2, 10);

            wordBt1.Width = this.Width - 80;
            wordBt1.Height = this.Height / 7 + h;
            wordBt1.Location = new Point((this.Width - wordBt1.Width) / 2, this.Height / 5);

            wordBt2.Width = this.Width - 80;
            wordBt2.Height = this.Height / 7 + h;
            wordBt2.Location = new Point((this.Width - wordBt2.Width) / 2, 2 * this.Height / 5);

            wordBt3.Width = this.Width - 80;
            wordBt3.Height = this.Height / 7 + h;
            wordBt3.Location = new Point((this.Width - wordBt3.Width) / 2, 3 * this.Height / 5);

            wordBt4.Width = this.Width - 80;
            wordBt4.Height = this.Height / 7 + h;
            wordBt4.Location = new Point((this.Width - wordBt4.Width) / 2, 4 * this.Height / 5);

            panel1.Width = this.Width;
            panel1.Height = this.Height;
            panel1.Location = new Point(0, 0);
        }
    }
}
