using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            //abrir el formulario que calcula el sueldo
            frmSueldo frm1 = new frmSueldo();
            frm1.Show(); //mostrar el formulario
        }

        private void btnNumEnBinario_Click(object sender, EventArgs e)
        {
            frmNumEnBinario frm1 = new frmNumEnBinario();
            frm1.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
