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
    public partial class FrmWeather : Form
    {
       
        public FrmWeather(Form f)
        {
            
            InitializeComponent();
            this.Owner =f;
            this.Location = new Point(f.Location.X -260, f.Location.Y);

            
        }

        

    }
}
