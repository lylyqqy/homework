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

namespace WindowsFormsControlLibrary2
{
    public partial class Lyric: UserControl
    {
        public Lyric()
        {
            InitializeComponent();
        }
       
        public string s2 = "";
        public FileStream fs;
        private void Lyric_Paint(object sender, PaintEventArgs e)
        {
            int y = 0;
            Encoding encode = Encoding.GetEncoding("GB2312");   //字符转换




            if (s2.Equals("陈一发儿"))
            {
                fs = new FileStream("Lyric\\陈一发儿-童话镇.lrc", FileMode.Open);
            }
            else if (s2.Equals("大壮"))
            {
                fs = new FileStream("Lyric\\大壮-我们不一样.lrc", FileMode.Open);
            }
            else if (s2.Equals("薛之谦"))
            {
                fs = new FileStream("Lyric\\薛之谦-演员.lrc", FileMode.Open);
            }
            else if (s2.Equals("金南玲"))
            {
                fs = new FileStream("Lyric\\金南玲-逆流成河.lrc", FileMode.Open);
            }
            else if (s2.Equals("音阙诗听"))
            {
                fs = new FileStream("Lyric\\音阙诗听-红昭愿.lrc", FileMode.Open);
            }
            else
            {
                fs = null;
            }

          
            if (fs != null)
            {
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
                        lbl.Location = new Point(35, m);
                        m += 25;
                        lbl.BackColor = Color.Transparent;
                        lbl.ForeColor = Color.Black;
                        lbl.Width = 300;
                        lbl.Font = new System.Drawing.Font("微软雅黑", 12);
                        lbl.Text = s.Substring(10);

                        this.Controls.Add(lbl);
                        if (m > 100)
                            break;

                        //int minute = int.Parse(s.Substring(1, 2));
                        //double second = double.Parse(s.Substring(4, 5));

                    }
                    sr.Close();
                    fs.Close();
               
            }
               

        }


    }
}
