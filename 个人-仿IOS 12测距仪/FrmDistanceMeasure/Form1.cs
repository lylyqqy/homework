using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDistanceMeasure
{
    public partial class FrmDistanceMeasure : Form
    {
        public FrmDistanceMeasure()
        {
            InitializeComponent();
        }
        Graphics g;
        private void FrmDistanceMeasure_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Image img = Image.FromFile("yaoming.jpg");
            g.DrawImage(img, 0, 0);

        }
    }
}
