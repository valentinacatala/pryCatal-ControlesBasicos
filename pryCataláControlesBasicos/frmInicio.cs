using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCataláControlesBasicos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblDuplicar.Text = txtEscribir.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (optAzul.Checked == true)
            {
                lblDuplicar.ForeColor = Color.Blue;
                txtEscribir.ForeColor = Color.Blue;
            }

            if (optRojo.Checked == true)
            {
                lblDuplicar.ForeColor = Color.Red;
                txtEscribir.ForeColor = Color.Red;
            }
        }
    }
}
