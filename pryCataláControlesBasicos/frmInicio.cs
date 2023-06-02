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
            lblDuplicar.Text=txtEscribir.Text;
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

        private void cmdElegir_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";

            if (chkPicante.Checked == true)
            {
                lblSeleccion.Text = "Picante";
                textoConcatenar = textoConcatenar + " Picante";
            }

            if (chkMayonesa.Checked == true)
            {
                lblSeleccion.Text = "Mayonesa";
                textoConcatenar = textoConcatenar + " Mayonesa ";
            }

            if (chkKetchup.Checked == true)
            {
                lblSeleccion.Text = "Ketchup";
                textoConcatenar = textoConcatenar + " Ketchup ";
            }

            lblSeleccion.Text = textoConcatenar;

            lstAdicional.Items.Add(textoConcatenar);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void lstAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSeleccion.Text = grbSeleccionar.Text;
        }
    }
}
