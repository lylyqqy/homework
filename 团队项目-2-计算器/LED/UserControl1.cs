using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string num;
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics q;
            q = e.Graphics;

            this.BackColor = Color.FromArgb(255, 204, 205, 179);
      
            Font font = new Font("DigifaceWide", 38);

            Brush brush1 = new SolidBrush(Color.FromArgb(255, 199, 199, 175));
            q.DrawString("88888888", font, brush1, new Point(-8, -1));


            int lenth=0;
            if (num!=null)
                lenth = num.Length;
            int a = 38;
            
            q.DrawString(num, font, Brushes.Black, new Point(297-lenth*a, 1));
             
            
        }
    }
}
