using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShuiYin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image origImg;
        Image waterImg;
        
        Graphics g;
       
        float opacity;
        ColorMatrix matrix;
        ImageAttributes attributes;
        OpenFileDialog opf;
        //照片多选张数
        int length;
        bool flag = false;
        int i = 1;
        //水印坐标
        int x, y;

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            //选择原始图片
            opf = new OpenFileDialog();
            opf.InitialDirectory = "OrigImg";
            opf.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            origImg = Image.FromFile(opf.FileName);
            picImg.BackgroundImage = origImg;
            
        }

        private void BtnWaterMark_Click(object sender, EventArgs e)
        {
            //选择水印图片
            opf = new OpenFileDialog();
            opf.InitialDirectory = "OrigImg";
            opf.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            waterImg = Image.FromFile(opf.FileName);

          
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //保存更改后的图片
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.InitialDirectory = "AfterImg";
             sfd.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
             if (sfd.ShowDialog() == DialogResult.Cancel)
             {
                  return;
             }
             origImg.Save(sfd.FileName);
           
        }



        private void BtnLargeWater_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(path);
                foreach (FileInfo f in dir.GetFiles("*"))
                {
                    origImg = Image.FromFile(f.FullName);
                    g = Graphics.FromImage(origImg);
                    g.DrawImage(waterImg, new Rectangle(origImg.Width - waterImg.Width, origImg.Height - waterImg.Height, waterImg.Width, waterImg.Height), 0, 0, waterImg.Width, waterImg.Height, GraphicsUnit.Pixel, attributes);
                    picImg.Refresh();
                    origImg.Save(Path.Combine("AfterImg", i.ToString() + ".jpg"));
                    i++;
                }
            }
           
            /*flag = true;
            //批量选择图片
            opf = new OpenFileDialog();
            opf.InitialDirectory ="OrigImg";
            opf.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            opf.Multiselect = true;
            if (opf.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //显示最后一张图片
            length = opf.FileNames.Length;
            picImg.BackgroundImage = Image.FromFile(opf.FileNames[length - 1]);
            //为每一张图片添加水印
            foreach (var tempName in opf.FileNames)
            {

                origImg = Image.FromFile(tempName);
                g = Graphics.FromImage(origImg);
                g.DrawImage(waterImg, new Rectangle(origImg.Width - waterImg.Width, origImg.Height - waterImg.Height, waterImg.Width, waterImg.Height), 0, 0, waterImg.Width, waterImg.Height, GraphicsUnit.Pixel, attributes);
                picImg.Refresh();
                //保存更改后的每一张图片到指定文件夹下
                origImg.Save(Path.Combine("AfterImg", i.ToString() + ".jpg"));
                i++;
            }

    */

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            x = int.Parse(textBox2.Text);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            y = int.Parse(textBox3.Text);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            
            float[][] nArray ={ new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, opacity, 0},
            new float[] {0, 0, 0, 0, 1}};
            opacity = float.Parse(textBox1.Text) * 0.1f;
            matrix = new ColorMatrix(nArray);
            attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            if(flag==false)
            {
                g = Graphics.FromImage(origImg);
                g.DrawImage(waterImg, new Rectangle(x, y, waterImg.Width, waterImg.Height), 0, 0, waterImg.Width, waterImg.Height, GraphicsUnit.Pixel, attributes);
                picImg.Refresh();
            }
            

        }
    }
}
