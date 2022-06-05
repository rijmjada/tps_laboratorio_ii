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
    public partial class FormSale : Form
    {
        #region Atributos

        Deposito<Producto> depositoFormVenta;
        Ventas ventas;
        Producto productoFormVenta;
        List<Cliente> clientes;

        #endregion

        #region Constructores

        public FormSale()
        {
            InitializeComponent();
            this.txt_VDni.MaxLength = 9;
            
        }
        public FormSale(Producto producto, Deposito<Producto> deposito, Ventas ventas, List<Cliente> clientes)
            : this()
        {
            this.depositoFormVenta = deposito;
            this.productoFormVenta = producto;
            this.ventas = ventas;
            this.clientes = clientes;
        } 
        #endregion

        private void CargarDatos(Producto p)
        {
            this.txt_VProducto.Text = ((Libro)this.productoFormVenta).Titulo;
            this.txt_VPrecio.Text = this.productoFormVenta.Precio.ToString();
            this.txt_VFecha.Text = DateTime.Now.ToString();
        }
        private bool ChequearSiExiteCliente(List<Cliente> lista, string dni)
        {
            if (lista is not null)
            {
                foreach (Cliente item in lista)
                {
                    if (item.Dni.ToString() == dni)
                        return true;
                }
            }
            return false;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            if (this.productoFormVenta is not null)
            {
                this.CargarDatos(this.productoFormVenta);
                this.txt_VProducto.Enabled = false;
                this.txt_VPrecio.Enabled = false;
                this.txt_VFecha.Enabled = false;
            }           
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_VDni.Text))
            {
                if(ChequearSiExiteCliente(this.clientes, this.txt_VDni.Text))
                {
                    DateTime fecha = Convert.ToDateTime(this.txt_VFecha.Text);
                    Producto producto = this.productoFormVenta;
                    double monto = Convert.ToDouble(this.txt_VPrecio.Text);
                    int dniCliente = Convert.ToInt32(this.txt_VDni.Text);

                    Factura nuevaFactura = new Factura(fecha, producto, monto, dniCliente);
                    this.ventas.Lista.Add(nuevaFactura);
                    _ = this.depositoFormVenta.Remover(this.productoFormVenta);
                    this.clientes[GetIndexClienteDni(this.clientes, dniCliente)].ListaCompras.Add(nuevaFactura);
                    
                    if (Factura.ImprimirFactura(nuevaFactura))
                    {
                        DialogResult rta = MessageBox.Show("Venta Exitosa, desea visualizar factura?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rta == DialogResult.Yes)
                        {
                            FormInvoice frmVerFactura = new FormInvoice(Factura.NombreFactura);

                            frmVerFactura.StartPosition = FormStartPosition.CenterScreen;
                            DialogResult ret = frmVerFactura.ShowDialog();
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No figura cliente con tal DNI. Debe generar un alta.");
                    FormAddClient frmAltaCliente = new FormAddClient(this.clientes, this.txt_VDni.Text);

                    frmAltaCliente.StartPosition = FormStartPosition.CenterScreen;
                    DialogResult ret = frmAltaCliente.ShowDialog();
                    this.txt_VDni.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un DNI.");
            }
           
        }

        private void txt_VDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int GetIndexClienteDni(List<Cliente> clientes, int dni)
        {
            if (clientes is  not null)
            {
                for(int i = 0; i<clientes.Count(); i++)
                {
                    if (clientes[i].Dni == dni)
                        return i;
                }
            }
            return -1;
        }
   

    }
}
