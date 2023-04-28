using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PySp1MiPrimerApp
{
    public partial class FrmPantallaPrincipal : Form
    {
        decimal varIngresos = 0;
        decimal varAlquiler = 0;
        decimal varImpuestos = 0;
        decimal varComida = 0;
        decimal varExtra = 0;
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            varIngresos = Convert.ToDecimal(txtIngresos.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varImpuestos = Convert.ToDecimal(txtImpuestos.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varExtra = Convert.ToDecimal(txtExtra.Text);
        
        }
    }
}
