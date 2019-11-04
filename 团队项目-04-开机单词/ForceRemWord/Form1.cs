using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ForceRemWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Location = new Point(0, 0);
            userControl11.Width = this.Width / 5;
            userControl11.Height = this.Height / 3;
            userControl11.Refresh();
           

            userControl12.Location = new Point(this.Width / 5, 0);
            userControl12.Width = this.Width / 5;
            userControl12.Height = this.Height / 3;

            userControl13.Location = new Point(2*this.Width / 5, 0);
            userControl13.Width = this.Width / 5;
            userControl13.Height = this.Height / 3;

            userControl14.Location = new Point(3* this.Width / 5, 0);
            userControl14.Width = this.Width / 5;
            userControl14.Height = this.Height / 3;

            userControl17.Location = new Point(4* this.Width / 5, 0);
            userControl17.Width = this.Width / 5;
            userControl17.Height = this.Height / 3;

            userControl16.Location = new Point(0, this.Height / 3);
            userControl16.Width = this.Width / 5;
            userControl16.Height = this.Height / 3;

            userControl18.Location = new Point(this.Width / 5, this.Height / 3);
            userControl18.Width = this.Width / 5;
            userControl18.Height = this.Height / 3;

            userControl19.Location = new Point(2* this.Width / 5, this.Height / 3);
            userControl19.Width = this.Width / 5;
            userControl19.Height = this.Height / 3;

            userControl110.Location = new Point(3* this.Width / 5, this.Height / 3);
            userControl110.Width = this.Width / 5;
            userControl110.Height = this.Height / 3;

            userControl111.Location = new Point(4* this.Width / 5, this.Height / 3);
            userControl111.Width = this.Width / 5;
            userControl111.Height = this.Height / 3;

            userControl15.Location = new Point(0,2* this.Height / 3);
            userControl15.Width = this.Width / 5;
            userControl15.Height = this.Height / 3;

            userControl112.Location = new Point(this.Width / 5, 2* this.Height / 3);
            userControl112.Width = this.Width / 5;
            userControl112.Height = this.Height / 3;

            userControl114.Location = new Point(2* this.Width / 5, 2* this.Height / 3);
            userControl114.Width = this.Width / 5;
            userControl114.Height = this.Height / 3;

            userControl116.Location = new Point(3* this.Width / 5, 2* this.Height / 3);
            userControl116.Width = this.Width / 5;
            userControl116.Height = this.Height / 3;

            userControl118.Location = new Point(4* this.Width / 5, 2* this.Height / 3);
            userControl118.Width = this.Width / 5;
            userControl118.Height = this.Height / 3;

            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Pass.Form1 passF = new Pass.Form1();
        private void UserControl_MouseEnter(object sender, EventArgs e)
        {
            if (userControl11.BackColor == Color.Gold&& userControl12.BackColor == Color.Gold && 
                userControl13.BackColor==Color.Gold&& userControl14.BackColor==Color.Gold&& 
                userControl17.BackColor==Color.Gold&&userControl16.BackColor==Color.Gold&&
                userControl18.BackColor==Color.Gold && userControl19.BackColor==Color.Gold&&
                userControl110.BackColor == Color.Gold && userControl111.BackColor == Color.Gold &&
                userControl15.BackColor == Color.Gold && userControl112.BackColor == Color.Gold&&
                userControl114.BackColor == Color.Gold && userControl116.BackColor == Color.Gold && userControl118.BackColor == Color.Gold
                )
            {
                
                    passF.Show();
            }
        }

        private void UserControl_MouseLeave(object sender, EventArgs e)
        {
            if (userControl11.BackColor == Color.Gold && userControl12.BackColor == Color.Gold &&
                userControl13.BackColor == Color.Gold && userControl14.BackColor == Color.Gold &&
                userControl17.BackColor == Color.Gold && userControl16.BackColor == Color.Gold &&
                userControl18.BackColor == Color.Gold && userControl19.BackColor == Color.Gold &&
                userControl110.BackColor == Color.Gold && userControl111.BackColor == Color.Gold &&
                userControl15.BackColor == Color.Gold && userControl112.BackColor == Color.Gold &&
                userControl114.BackColor == Color.Gold && userControl116.BackColor == Color.Gold && userControl118.BackColor == Color.Gold)
            {
                
                    passF.Show();
            }
        }
    }
}
