using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPPMViewer
{
    public partial class FrmPPMViewer : Form
    {
        public FrmPPMViewer()
        {
            InitializeComponent();
        }
      
        Color c;
       
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string fn=ofd.FileName;
            FileStream fs = new FileStream(fn,FileMode.Open);
            StreamReader str = new StreamReader(fs);
            string strline=str.ReadLine();
            string picSize = str.ReadLine();
            string[] res=picSize.Split(' ');
            int width = int.Parse(res[0]);
            int height = int.Parse(res[1]);
            string colMax = str.ReadLine();
            string strTotal = str.ReadToEnd();
            string[] pixels = strTotal.Split(' ');
           
            
            Bitmap btmp = new Bitmap(width , height);
           // int count=0;
            for (int i = 0; i < width; i++)
            {
                for(int j=0;j<height;j++)
                {

                    c = Color.FromArgb(int.Parse(pixels[3*(j*width+i)+0]), int.Parse(pixels[3 * (j * width + i) + 1]), int.Parse(pixels[3*(j * width + i)+ 2]));
                    //c = Color.FromArgb(int.Parse(pixels[count]), int.Parse(pixels[count + 1]), int.Parse(pixels[count + 2]));
                    btmp.SetPixel(i, j, c);
                    //count++;
                }
                //count++;
            }
            this.BackgroundImage = btmp;
            this.Height = height;
            this.Width = width;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
