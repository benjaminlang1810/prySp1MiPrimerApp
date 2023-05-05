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
        decimal varIngresos;
        decimal varAlquiler;
        decimal varImpuestos;
        decimal varComida;
        decimal varSalidas;
        decimal varGimnasio;
        decimal varSobrante;
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }



        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            decimal varIngresos = 0;
            decimal varAlquiler = 0;
            decimal varImpuestos = 0;
            decimal varComida = 0;
            decimal varSalidas = 0;
            decimal varGimnasio = 0;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            varIngresos = Convert.ToDecimal(txtIngresos.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varImpuestos = Convert.ToDecimal(txtImpuestos.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varSalidas = Convert.ToDecimal(txtSalidas.Text);
            varGimnasio = Convert.ToDecimal(txtGimnasio.Text);


            varSobrante = varIngresos - (varAlquiler + varComida + varSalidas + varImpuestos + varGimnasio);

            txtSobrante.Text = varSobrante.ToString();

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtSobrante_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
