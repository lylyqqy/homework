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

namespace 团队项目四图片水印
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image imgOrigin;
        Image imgWaterMark;
        string imgFileName; 
        string imgFileName1;
        string imgFileNameGroup;
        Graphics g;
        OpenFileDialog ofd;
        OpenFileDialog ofd2;
        int WaterMarKClickCount = 0;
        int PicCount = 0;
        float WaterMarkLocationX=200;
        float WaterMarkLocationY=150;

        //打开一张图片
        private void button1_Click(object sender, EventArgs e)
        {
            PicCount = 1;
            ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\桌面设计\团队项目-05-图片水印\imgs";
            ofd.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            //当选择取消时
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            //获得文件名
            imgFileName = ofd.FileName;

            //获得图片
            imgOrigin = Image.FromFile(imgFileName);
            //将图片显示
            pictureBox1.BackgroundImage = imgOrigin;
      }

        //获得水印图片
        private void button2_Click(object sender, EventArgs e)
        {
            WaterMarKClickCount = 1;
            ofd2 = new OpenFileDialog();
            ofd2.InitialDirectory = @"C:\桌面设计\团队项目-05-图片水印\WaterMark";
            ofd2.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            //当选择取消时
            if (ofd2.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            
          //获得文件名
           imgFileName1 = ofd2.FileName;

          //获得图片
           imgWaterMark = Image.FromFile(imgFileName1);

           Bitmap imgO = new Bitmap(imgOrigin);
           g = Graphics.FromImage(imgO);
           g.DrawImage(imgWaterMark, WaterMarkLocationX, WaterMarkLocationY);
           pictureBox1.BackgroundImage = imgO;
           
        }

        
        //批量加载图片
        private void button4_Click(object sender, EventArgs e)
        {
            PicCount = 1;
            ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\桌面设计\团队项目-05-图片水印\imgs";
            ofd.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            //多选属性
            ofd.Multiselect = true;
            //当选择取消时
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //显示最后一张图片
            int length = ofd.FileNames.Length;
            imgFileName = ofd.FileNames[length - 1];
            imgOrigin = Image.FromFile(ofd.FileNames[length - 1]);
            pictureBox1.BackgroundImage = imgOrigin;


        }

        //透明度选择
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //确保选择图片和水印，否则弹出警告信息
            if (PicCount == 0 || WaterMarKClickCount == 0)
            {
                label1.Visible = true;
            }
            else
            {
               label1.Visible = false;
                
                Bitmap bmp = new Bitmap(imgWaterMark);
                Bitmap bmpNew = new Bitmap(imgWaterMark.Width, imgWaterMark.Height);
                Color pixel;
                for (int i = 0; i < imgWaterMark.Width; i++)
                {
                    for (int j = 0; j < imgWaterMark.Height; j++)
                    {
                        pixel = bmp.GetPixel(i, j);
                        int r1 = pixel.R;
                        int g1 = pixel.G;
                        int b1 = pixel.B;

                        bmpNew.SetPixel(i, j, Color.FromArgb(trackBar1.Value, r1, g1, b1));
                    }
                }
                imgWaterMark = bmpNew;
                if (ofd.FileNames.Length == 1)
                {
                    Bitmap imgO = new Bitmap(imgOrigin);
                    g = Graphics.FromImage(imgO);
                    g.DrawImage(imgWaterMark, WaterMarkLocationX, WaterMarkLocationY);
                    pictureBox1.BackgroundImage = imgO;

                }
                else
                {
                    foreach (string fileName in ofd.FileNames)
                    {
                        imgFileNameGroup = fileName;

                        //获得图片
                        Image imgGroup = Image.FromFile(imgFileNameGroup);
                        g = Graphics.FromImage(imgGroup);
                        g.DrawImage(imgWaterMark, WaterMarkLocationX, WaterMarkLocationY);
                        pictureBox1.BackgroundImage = imgGroup;
                      
                    }
                }
            }
        }

        //获取水印x坐标
        private void WaterMarkLocX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WaterMarkLocationX = Convert.ToSingle(WaterMarkLocX.Text);
                SendKeys.Send("{tab}");

            }
        }
        //获取水印y坐标
        private void WaterMarkLocY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                WaterMarkLocationY = Convert.ToSingle(WaterMarkLocY.Text);

                Bitmap imgO = new Bitmap(imgOrigin);
                g = Graphics.FromImage(imgO);
                g.DrawImage(imgWaterMark, WaterMarkLocationX, WaterMarkLocationY);

                pictureBox1.BackgroundImage = imgO;
            }
        }

        //保存加水印后图片
        private void button3_Click(object sender, EventArgs e)
        {

            //一张图片时
            if (ofd.FileNames.Length == 1)
            {
                string path = @"C:\桌面设计\团队项目-05-图片水印\imgAfter";

              
                string extension = Path.GetExtension(imgFileName);//文件扩展名
                int counter = 1;
                string newFullPath;

                Image imgAfter = pictureBox1.BackgroundImage;
               
                //获取文件名
                string[] str = imgFileName.Split('\\');
                string[] str1= str[str.Length - 1].Split('.');
                string filename = str1[0];
                do
                {
                    string newFilename = string.Format("{0}({1}).{2}",filename, counter, extension);
                    newFullPath = Path.Combine(path, newFilename);
                   
                    counter++;
                } while (System.IO.File.Exists(newFullPath)); //文件路径如果存在，继续循环

                imgAfter.Save(newFullPath);
            }
            // 批量保存
            else
            {

                foreach (string fileName in ofd.FileNames)
                {
                    imgFileNameGroup = fileName;

                    //获得图片
                    Image imgGroup = Image.FromFile(imgFileNameGroup);
                    g = Graphics.FromImage(imgGroup);
                    g.DrawImage(imgWaterMark, WaterMarkLocationX, WaterMarkLocationY);

                    string path = @"C:\桌面设计\团队项目-05-图片水印\批量保存After";
                    string extension = Path.GetExtension(imgFileNameGroup);//文件扩展名
                    int counter = 1;
                    string newFullPath;

                    Image imgAfter = pictureBox1.BackgroundImage;
               
                    //获取文件名
                    string[] str = imgFileNameGroup.Split('\\');
                    string[] str1 = str[str.Length - 1].Split('.');
                    string filename = str1[0];
                    do
                    {
                        string newFilename = string.Format("{0}({1}).{2}", filename, counter, extension);
                        newFullPath = Path.Combine(path, newFilename);

                        counter++;
                    } while (System.IO.File.Exists(newFullPath)); //文件路径如果存在，继续循环

                    imgGroup.Save(newFullPath);

                }

            }
            //保存成功信息提示
            label3.Visible = true;

        }

        //关闭
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

