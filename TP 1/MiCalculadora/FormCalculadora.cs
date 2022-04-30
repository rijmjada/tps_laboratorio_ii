using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Constructor
        public FormCalculadora()
        {
            InitializeComponent();

            this.cmbOperador.SelectedIndex = -1;
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
        }
        #endregion

        #region Eventos

        /// <summary>
        /// El botón btnCerrar deberá cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNumero1.Text) && !string.IsNullOrWhiteSpace(this.txtNumero2.Text))
            {
                if (this.cmbOperador.SelectedIndex == -1)
                {
                    this.cmbOperador.Text = "+";
                }
                this.lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                this.lstOperaciones.Items.Add(this.txtNumero1.Text + cmbOperador.Text + this.txtNumero2.Text + " = " + this.lblResultado.Text);
                this.btnConvertirABinario.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar ambos operandos.");
            }
        }

        /// <summary>
        /// El evento Load del formulario deberá llamar al método Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != ','
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != ','
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando n1 = new Operando();
            this.lblResultado.Text = n1.DecimalBinario(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando n2 = new Operando();
            this.lblResultado.Text = n2.BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Implementar el manejador de evento necesario para que al intentar cerrar el formulario por cualquier método pregunte "¿Está seguro de querer salir?". 
        /// Si contesta SI se cerrará, si contesta NO debe continuar en ejecución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta;
            rta = MessageBox.Show("¿Está seguro de querer salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.No)
            {
                e.Cancel = true;
            }
        } 
        #endregion

        #region Metodos

        /// <summary>
        /// El método Limpiar será llamado por el evento click del botón btnLimpiar y borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = -1;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// El método Operar será estático recibirá los dos números y el operador para luego llamar al método Operar de Calculadora
        /// y retornar el resultado al método de evento del botón btnOperar que reflejará el resultado en el Label txtResultado.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Calculadora calculadora = new Calculadora();

            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            return calculadora.Operar(operando1, operando2, operador[0]);
        } 

        #endregion
    }
}
