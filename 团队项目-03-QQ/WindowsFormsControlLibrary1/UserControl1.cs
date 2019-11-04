using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);



        }

        private string lblMassegeName;
        private string lblDate;
        private string lblInfo;
        private Image backImage;
        public Image BackImage
        {
            get
            {
                return backImage;
            }
            set
            {
                backImage = value;
               
            }
        }

        public string LblMassegeName
        {
            get
            {
                return lblMassegeName;
            }
            set
            {
                lblMassegeName = value;
            }
        }
        public string LblDate
        {
            get
            {
                return lblDate;
            }
            set
            {
                lblDate = value;
            }
        }

        public string LblInfo
        {
            get
            {
                return lblInfo;
            }
            set
            {
                lblInfo = value;
                
                
            }
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            lblMassegeNam.Text = lblMassegeName;
            lblTime.Text = lblDate;
            lblInfor.Text = lblInfo;
            picHead.BackgroundImage = backImage;
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor= Color.FromArgb(245, 245, 245);
            
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
           

        }
    }
}
