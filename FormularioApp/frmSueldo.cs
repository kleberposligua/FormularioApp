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
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //validaciones
            if (this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el nombre...");
                this.txtNombre.Focus(); //ubica el cursor en un control
                return; //abandonar
            }
            //tarea:
            //1. validar el ingreso de todos los cuadros de textos
            //2. validar que el dato ingresado sea numérico

            if (!Double.TryParse(txtHorasTrab.Text, out double horasTrab))
            {
                MessageBox.Show("Por favor ingresa solo valores numéricos...");
                this.txtHorasTrab.Focus();
                return;
            }
            

            //no usar try .. catch


            //sumar los ingresos
            // horasTrab = double.Parse( this.txtHorasTrab.Text);
            double valorHora = double.Parse(this.txtValorHora.Text);
            double bono = double.Parse(this.txtBono.Text);
            double totIng = horasTrab * valorHora + bono;

            //mostrar el totIng en el cuadro de texto
            this.txtTotalIng.Text = totIng.ToString();

            //sumar los egresos
            double asoTrab = double.Parse(this.txtAsoTrab.Text);
            double bar = double.Parse(this.txtBar.Text);
            double cuentaxPagar = double.Parse(this.txtCuentaxPagar.Text);
            double totEgre = asoTrab + bar + cuentaxPagar;
            this.txtTotalEgresos.Text = totEgre.ToString();

            //líquido a recibir
            double liquidoRecibir = totIng - totEgre;
            lblResultado.Text = "Estimado, " + this.txtNombre.Text +
                ", tu sueldo es: " + liquidoRecibir.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar el formularion actual
        }
    }
}
