using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSATerm
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form derp = new fSerialConfig();
            derp.ShowDialog();
            btnConfigRSA.Enabled = true;    //Make this dependent upon a state change!  For testing only.
        }

        private void btnConfigRSA_Click(object sender, EventArgs e)
        {
            Form derp = new fRSAConfig();
            derp.ShowDialog();
        }


        
    }
}
