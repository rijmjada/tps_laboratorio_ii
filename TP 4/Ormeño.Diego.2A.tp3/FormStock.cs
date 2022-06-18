using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormStock : Form
    {
        Deposito<Producto> deposito;
        List<Producto> listaBusquedas;
        Ventas ventas;
        List<Cliente> clientes;

        public FormStock()
        {
            InitializeComponent();
        }

        public FormStock(Deposito<Producto> deposito, Ventas ventas, List<Cliente> clientes)
            : this()
        {
            this.Text = "Stock";
            this.deposito = deposito;
            this.ventas = ventas;
            this.clientes = clientes;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            this.txt_busqueda.MaxLength = 25;
            this.txt_busqueda.Enabled = false;
        }

        private void btn_verMas_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;

            if (index >= 0 && index <= this.deposito.Lista.Count)
                MessageBox.Show(this.listaBusquedas[index].ToString());
            else
                MessageBox.Show("Debe seleccionar un producto");
        }

        private void LimpiarCampos()
        {
            this.radio_autor.Checked = false;
            this.radio_codigo.Checked = false;
            this.radio_titulo.Checked = false;
            this.txt_busqueda.Clear();
            this.listBox1.Items.Clear();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem is not null)
            {
                Producto productoSeleccionado = this.listaBusquedas[this.listBox1.SelectedIndex];
                FormSale frmVenta = new FormSale(productoSeleccionado, this.deposito, this.ventas, this.clientes);
                frmVenta.OnEmisionFactura += new EmitirFacturaDelegado(EmisionFactura);

                frmVenta.StartPosition = FormStartPosition.CenterScreen;
                DialogResult ret = frmVenta.ShowDialog();

                this.LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void EmisionFactura(Factura f)
        {
            if(f is not null)
            {
                DialogResult rta = MessageBox.Show("Venta Exitosa, desea imprimir factura?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rta == DialogResult.Yes)
                {
                    Factura.ImprimirFactura(f, (DBA.Clientes.TraerClientePorID(f.Id_cliente)).ToString());
                    FormInvoice frmVerFactura = new FormInvoice(Factura.NombreFactura);

                    frmVerFactura.StartPosition = FormStartPosition.CenterScreen;
                    DialogResult ret = frmVerFactura.ShowDialog();
                }
            }
        }
        
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.listaBusquedas = new List<Producto>();
            this.listBox1.Items.Clear();

            if (!String.IsNullOrEmpty(this.txt_busqueda.Text) && this.deposito is not null)
            {
                if (this.radio_autor.Checked)
                {
                    foreach (Producto item in this.deposito.Lista)
                    {
                        if (item is Libro L && L.Autor.ToLower() == this.txt_busqueda.Text.ToLower())
                        {
                            this.listBox1.Items.Add($"Autor: {L.Autor} - Titulo: '{L.Titulo}'");
                            this.listaBusquedas.Add(item);
                        }
                    }
                }
                if (this.radio_codigo.Checked)
                {
                    foreach (Producto item in this.deposito.Lista)
                    {
                        if (item is Libro L && L.Codigo.ToString() == this.txt_busqueda.Text)
                        {
                            this.listBox1.Items.Add($"Autor: {L.Autor} - Titulo: '{L.Titulo}'");
                            this.listaBusquedas.Add(item);
                        }
                    }
                }
                if (this.radio_titulo.Checked)
                {
                    foreach (Producto item in this.deposito.Lista)
                    {
                        if (item is Libro L && L.Titulo.ToLower() == this.txt_busqueda.Text.ToLower())
                        {
                            this.listBox1.Items.Add($"Autor: {L.Autor} - Titulo: '{L.Titulo}'");
                            this.listaBusquedas.Add(item);
                        }
                    }
                }
                if (this.listBox1.Items.Count <= 0)
                    MessageBox.Show("No se encontraron coincidencias.");
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos.");
            }
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.radio_titulo.Checked)
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }

            if (this.radio_codigo.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }

            if (this.radio_autor.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void radio_codigo_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_busqueda.Text = null;
            this.txt_busqueda.Enabled = true;
        }

        private void radio_titulo_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_busqueda.Text = null;
            this.txt_busqueda.Enabled = true;
        }

        private void radio_autor_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_busqueda.Text = null;
            this.txt_busqueda.Enabled = true;
        }
    }
}
