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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenido.Visible=true;
        }

        private void lblBienvenido_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenido.Location = new Point(534);
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
