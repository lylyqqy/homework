using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Location = new Point(750, 20);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point pMouse;
        bool isMoving;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pMouse = e.Location;
            if(e.Button==System.Windows.Forms.MouseButtons.Left)
            {
            isMoving = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.Location = new Point(this.Location.X + (e.X - pMouse.X), this.Location.Y + (e.Y - pMouse.Y));
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }


        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        //FrmWeather frm;

        Weather1.Form1 weatherForm = new Weather1.Form1();
        private void PictureBox17_MouseEnter(object sender, EventArgs e)
        {
            weatherForm.Location = new Point(this.Location.X + this.Width , this.Location.Y);
            weatherForm.Show();
        }

        private void PictureBox17_MouseLeave(object sender, EventArgs e)
        {
            weatherForm.Hide();
        }
    }
}
