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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmAlacena VentanaAlmacena = new frmAlacena();
            
            VentanaAlmacena.ShowDialog();


        }

        private void cmdGestionDeGastos_Click(object sender, EventArgs e)
        {
           FrmPantallaPrincipal VentanaPantallaPrincipal = new FrmPantallaPrincipal();
            VentanaPantallaPrincipal.ShowDialog();

        }
    }
}
