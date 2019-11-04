using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Weather1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
            Weather.cn.com.webxml.www.WeatherWebService w = new Weather.cn.com.webxml.www.WeatherWebService();
            String[] s = new String[23];
            String city = "成都";  //你想要查天气的城市名字            
            s = w.getWeatherbyCityName(city);
            for (int i = 0; i < s.Length; i++) //看看错误情况是怎样的返回，也有23个 
            {
                if (String.IsNullOrWhiteSpace(s[i]))
                {
                    s[i] = "A";
                }
            }
            string[] nowWeather = s[10].Split('；');

            string curTemprtn = nowWeather[0].Substring(10);
            string curNum = curTemprtn.Substring(0, curTemprtn.Length - 1);
            label1.Text = curNum;
            label5.Text = "℃";

            label2.Text = city;

            string[] m = s[6].Split();
            label3.Text = m[1] + " " + s[7];

            int IndexofA = nowWeather[3].IndexOf("。");
            string airQuality = nowWeather[3].Substring(IndexofA + 1);

            label4.Text = airQuality.Substring(0, airQuality.Length - 1);

            label9.Text = s[5];
            label10.Text = s[12];
            label11.Text = s[17];
            pictureBox1.BackgroundImage = Image.FromFile(@"weather\a_" + s[8] + "");
            pictureBox2.BackgroundImage = Image.FromFile(@"weather\a_" + s[15] + "");
            pictureBox3.BackgroundImage = Image.FromFile(@"weather\a_" + s[20] + "");

            
        }

    }
}
