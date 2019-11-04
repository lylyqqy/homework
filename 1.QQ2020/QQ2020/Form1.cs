using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }

        private void picMinimize_MouseEnter(object sender, EventArgs e)
        {
           ((PictureBox)sender).BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void lblFindPwd_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DimGray;
           
        }

        private void lblFindPwd_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DarkGray;
        }
        int movestep;
        enum MOVE_DIR { Left,Right};
        MOVE_DIR move_dir;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(picPlus.Location.X>300&&move_dir==MOVE_DIR.Right)
            {
                return;
            }

            if (picPlus.Location.X <180&&move_dir==MOVE_DIR.Left)
            {
                return;
            }
            picPlus.Location = new Point(picPlus.Location.X + movestep, picPlus.Location.Y);
        }

        private void picHead_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            movestep = 25;
            move_dir = MOVE_DIR.Right;
        }

        private void picHead_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            movestep = -25;
            move_dir = MOVE_DIR.Left;
        }
        Point pMouseDown;
        bool isMoving;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pMouseDown = new Point(e.X, e.Y);
            //pMouseDown=e.Location;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isMoving = true;
            }
        }
       
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.Location = new Point(this.Location.X + (e.X - pMouseDown.X),
                    this.Location.Y + (e.Y - pMouseDown.Y));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
