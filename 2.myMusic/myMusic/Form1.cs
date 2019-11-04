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

namespace myMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        bool IsPlaying=false;

       
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] alFileNames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("fy","");
            foreach (string strFile in alFileNames)
            {
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(strFile));

            }
        
            
          
            timer1.Enabled = true;
        }
        string sAuthor;

        //public string s2 = "";
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia.duration <= 0)
            {
                return;
            }
            else
            {
                string sTitle = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
                sAuthor = axWindowsMediaPlayer1.currentMedia.getItemInfo("Author");

                lblAuthor.Text = sAuthor;
                lblTitle.Text = sTitle;
                
                lyric1.s2 = sAuthor;
                lyric1.Refresh();
            }
            lblCurPlayTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            userControl12.MaxValue = axWindowsMediaPlayer1.currentMedia.duration;
            userControl12.CurValue = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            userControl12.angle = userControl12. CurValue /userControl12.MaxValue * 2 * Math.PI;

            

            userControl12.Refresh();

                       

        }

        

        Graphics a;
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*a = e.Graphics;
            //this.Show();
            a.DrawLine(Pens.Black, new Point(120, 535), new Point(506, 535));
            Rectangle rect = new Rectangle(120, 535, 10, 10);
            a.FillEllipse(Brushes.Yellow, rect);*/
        }

        private void PicPrev_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
           
        }

        private void PicNext_Click(object sender, EventArgs e)
        {            
            axWindowsMediaPlayer1.Ctlcontrols.next();
            
        }

        private void PicLoop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    

        private void PicRandom_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("shuffle", true);
        }

        private void PicMute_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = !axWindowsMediaPlayer1.settings.mute;
        }
        FileStream fs;
        private void AxWindowsMediaPlayer1_MediaChange_1(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            string s2 = axWindowsMediaPlayer1.currentMedia.getItemInfo("Author");
            if (s2.Equals("陈一发儿"))
            {
                userControl12.SingerImg = Properties.Resources.cyf2;
                
            }
            else if (s2.Equals("大壮"))
            {
                userControl12.SingerImg = Properties.Resources.dz;
                
            }
            else if (s2.Equals("薛之谦"))
            {
                userControl12.SingerImg = Properties.Resources.xzq;
               
            }
            else if (s2.Equals("金南玲"))
            {
                userControl12.SingerImg = Properties.Resources.llch;
               
            }
            else if (s2.Equals("音阙诗听"))
            {
                userControl12.SingerImg = Properties.Resources.yqst;
              
                
            }
            else
            {
                userControl12.SingerImg = Properties.Resources._default;
               
            }
        }

        private void UserControl12_Click(object sender, EventArgs e)
        {
            IsPlaying = !IsPlaying;
            if (IsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            
        }

        private void Lyric1_Load(object sender, EventArgs e)
        {
            lyric1.Refresh();
        }

    }
}
