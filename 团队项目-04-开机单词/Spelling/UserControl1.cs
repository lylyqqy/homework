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
using System.Collections;
using System.Speech.Synthesis;

namespace Spelling
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        FileStream fs;

        int[] word = getRandomNum(4, 1, 410);



        public static void Ran(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
                int a = ra.Next(0, 5);
                int r = arr[i];
                arr[i] = arr[a];
                arr[a] = r;

            }
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
        int clickNum = 0;
        private void CutBt1_MouseClick(object sender, MouseEventArgs e)
        {
            clickNum++;
           
            if (clickNum == 1)
            {
                cutLb1.Text = cutBt1.Text;
            }
            else if (clickNum == 2)
            {
                cutLb2.Text = cutBt1.Text;
            }
            else if (clickNum == 3)
            {
                cutLb3.Text = cutBt1.Text;
            }
            this.Refresh();
        }

        private void CutBt2_MouseClick(object sender, MouseEventArgs e)
        {
            clickNum++;
      
            if (clickNum == 1)
            {
                cutLb1.Text = cutBt2.Text;
            }
            else if (clickNum == 2)
            {
                cutLb2.Text = cutBt2.Text;
            }
            else if (clickNum == 3)
            {
                cutLb3.Text = cutBt2.Text;
            }
            this.Refresh();
        }

        private void CutBt3_MouseClick(object sender, MouseEventArgs e)
        {
            clickNum++;
           if (clickNum == 1)
            {
                cutLb1.Text = cutBt3.Text;
            }
            else if (clickNum == 2)
            {
                cutLb2.Text = cutBt3.Text;
            }
            else if (clickNum == 3)
            {
                cutLb3.Text = cutBt3.Text;
            }
            this.Refresh();
        }

        private void CutBt4_MouseClick(object sender, MouseEventArgs e)
        {
            clickNum++;
        
            if (clickNum == 1)
            {
                cutLb1.Text = cutBt4.Text;
            }
            else if (clickNum == 2)
            {
                cutLb2.Text = cutBt4.Text;
            }
            else if (clickNum == 3)
            {
                cutLb3.Text = cutBt4.Text;
            }
            this.Refresh();
        }

        private void CutBt5_MouseClick(object sender, MouseEventArgs e)
        {
            clickNum++;
          
            if (clickNum == 1)
            {
                cutLb1.Text = cutBt5.Text;
            }
            else if (clickNum == 2)
            {
                cutLb2.Text = cutBt5.Text;
            }
            else if (clickNum == 3)
            {
                cutLb3.Text = cutBt5.Text;
            }
            this.Refresh();
        }

        private void CutBt6_MouseClick(object sender, MouseEventArgs e)
        {
            clickNum++;
           
            if (clickNum == 1)
            {
                cutLb1.Text = cutBt6.Text;
            }
            else if (clickNum == 2)
            {
                cutLb2.Text = cutBt6.Text;
            }
            else if (clickNum == 3)
            {
                cutLb3.Text = cutBt6.Text;
            }
            this.Refresh();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {


            fs = new FileStream(@"C:\桌面设计\团队项目-04-开机单词\ForceRemWord\bin\Debug\EnglishWord2.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);  //读文件

            string str = sr.ReadToEnd();
            string[] pixel = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            fs.Close();
            sr.Close();


            int a = pixel[word[0]].IndexOf(" ");
            meanLb.Text = pixel[word[0]].Substring(a);

            string wordT = pixel[word[0]].Substring(0, a);
            int len = wordT.Length;
            Random c1 = new Random(unchecked((int)DateTime.Now.Ticks));
            int cut1 = c1.Next(1, len / 2);
            Random c2 = new Random(unchecked((int)DateTime.Now.Ticks)+1);
            int cut2 = c1.Next(1, len / 2);

            int cut3 = len - cut1 - cut2;
            
            string[] s = new string[6];
            s[0] = wordT.Substring(0, cut1);
            s[1] = wordT.Substring(cut1, cut2);
            s[2] = wordT.Substring(cut1 + cut2, cut3);

            int b = pixel[word[1]].IndexOf(" ");
            string word1 = pixel[word[1]].Substring(0, b);
            string w1;
            if (word1.Length>3)
            {
                w1 = word1.Substring(1, word1.Length - 2);
            }
            else
            {
                w1 = word1;
            }

            int c = pixel[word[2]].IndexOf(" ");
            string word2 = pixel[word[2]].Substring(0, c);
            string w2;
            if (word2.Length > 3)
            {
                w2= word2.Substring(1, word2.Length - 2);
            }
            else
            {
                w2 = word1;
            }

            int d = pixel[word[3]].IndexOf(" ");
            string word3 = pixel[word[3]].Substring(0, d);
            string w3;
            if (word3.Length > 3)
            {
                w3 = word3.Substring(1, word3.Length - 2);
            }
            else
            {
                w3 = word1;
            }

            s[3] = w1;
            s[4] = w2;
            s[5] = w3;

            int[] arr = new int[6] { 0, 1, 2, 3, 4, 5 };
            Ran(arr);

            cutBt1.Text = s[arr[0]];
            cutBt2.Text = s[arr[1]];
            cutBt3.Text = s[arr[2]];
            cutBt4.Text = s[arr[3]];
            cutBt5.Text = s[arr[4]];
            cutBt6.Text = s[arr[5]];
            
        }
        SpeechSynthesizer Synthesizer = new SpeechSynthesizer();
        int rate = 0;
        private void CutBt_MouseEn(object sender, EventArgs e)
        {
            Synthesizer.SpeakAsyncCancelAll();//停止阅读
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
       
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
           
            panel1.Location = new Point(this.Width / 2 - panel1.Width * 3 / 2 - 30, 60);
            panel2.Location = new Point(this.Width / 2 - panel1.Width / 2, 60);
            panel3.Location = new Point(this.Width / 2 + panel1.Width / 2 + 30, 60);
            cutLb1.Location = new Point(panel1.Location.X, 20);
            cutLb2.Location = new Point(panel2.Location.X, 20);
            cutLb3.Location = new Point(panel3.Location.X, 20);
            meanLb.Location = new Point(this.Width / 2 - meanLb.Width / 2, panel1.Location.Y + 15);
            cutBt1.Location = new Point(60, meanLb.Location.Y + meanLb.Height + 15);
            cutBt2.Location = new Point(this.Width / 2 - cutBt2.Width / 2, meanLb.Location.Y + meanLb.Height + 15);
            cutBt3.Location = new Point(this.Width - 60 - cutBt3.Width, meanLb.Location.Y + meanLb.Height + 15);

            cutBt4.Location = new Point(60, cutBt1.Location.Y + cutBt1.Height + 15);
            cutBt5.Location = new Point(this.Width / 2 - cutBt2.Width / 2, cutBt1.Location.Y + cutBt1.Height + 15);
            cutBt6.Location = new Point(this.Width - 60 - cutBt6.Width, cutBt1.Location.Y + cutBt1.Height + 15);
            panel4.Width = this.Width;
            panel4.Height = this.Height;
            panel4.Location = new Point(0, 0);

            fs = new FileStream(@"C:\桌面设计\团队项目-04-开机单词\ForceRemWord\bin\Debug\EnglishWord3.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);  //读文件

            string str = sr.ReadToEnd();
            string[] pixel = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            fs.Close();
            sr.Close();

            int a = pixel[word[0]].IndexOf(" ");
          
            string wordT = pixel[word[0]].Substring(0, a);
            string word0 = ""+cutLb1.Text+""+cutLb2.Text+""+cutLb3.Text+"";
       
            if (clickNum==3)
            {
               
                if (word0 == wordT)
                {
                    this.BackColor = Color.Gold;
                    cutLb1.BackColor = Color.Green;
                    cutLb2.BackColor = Color.Green;
                    cutLb3.BackColor = Color.Green;

                    Synthesizer.Rate = rate;//发音速度
                    Synthesizer.Volume = 100;//音量
                    //Synthesizer.SelectVoice("Microsoft Anna"); //英文
                    Synthesizer.SpeakAsync("" + wordT + "");

                    axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201702/8334.mp3";
                    axWindowsMediaPlayer1.settings.volume = 10;
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                }
                else
                {
                    clickNum = 0;


                    axWindowsMediaPlayer1.URL = @"http://downsc.chinaz.net/Files/DownLoad/sound1/201812/10986.mp3";
                    axWindowsMediaPlayer1.settings.volume = 50;
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    cutLb1.Text = "";
                    cutLb2.Text = "";
                    cutLb3.Text = "";
                  


                }
            }
           
        }
        private void CutBt_MouseLe(object sender, EventArgs e)
        {
            if(clickNum==3)
            {
                Synthesizer.SpeakAsyncCancelAll();//停止阅读
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
           
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
}
