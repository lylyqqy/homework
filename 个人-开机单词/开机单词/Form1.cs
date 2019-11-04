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

namespace 开机单词
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //全屏显示
            this.WindowState = FormWindowState.Maximized;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox0.Location = new Point(0, 0);
            pictureBox0.BackgroundImage = null;
            pictureBox1.Location = new Point(this.Width / 3, 0);
            pictureBox2.Location = new Point(this.Width * 2 / 3, 0);
            
            pictureBox3.Location = new Point(0, this.Height / 5);
            pictureBox4.Location = new Point(this.Width / 3, this.Height / 5);
            pictureBox5.Location = new Point(this.Width * 2 / 3, this.Height / 5);
            pictureBox6.Location = new Point(0, this.Height * 2 / 5);
            pictureBox7.Location = new Point(this.Width / 3, this.Height * 2 / 5);
            pictureBox8.Location = new Point(this.Width * 2 / 3, this.Height * 2 / 5);
            
            pictureBox9.Location = new Point(0, this.Height * 3 / 5);
            pictureBox10.Location = new Point(this.Width / 3, this.Height * 3 / 5);
            pictureBox11.Location = new Point(this.Width * 2 / 3, this.Height * 3 / 5);
            pictureBox12.Location = new Point(0, this.Height * 4 / 5);
            pictureBox13.Location = new Point(this.Width / 3, this.Height * 4 / 5);
            pictureBox14.Location = new Point(this.Width * 2 / 3, this.Height * 4 / 5);
            pictureBox0.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox1.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox2.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox3.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox4.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox5.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox6.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox7.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox8.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox9.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox10.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox11.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox12.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox13.Size = new Size(this.Width / 3, this.Height / 5);
            pictureBox14.Size = new Size(this.Width / 3, this.Height / 5);



            //单词显示
            label1.Text = "banker";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dict.youdao.com/speech?audio= +'label1.Text'");
        
        }
    }
}
