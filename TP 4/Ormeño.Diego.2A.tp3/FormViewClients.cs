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
    public partial class FormViewClients : Form
    {
        List<Cliente> clientes;
        List<Factura> listaCompras;
        public FormViewClients()
        {
            InitializeComponent();
        }

        public FormViewClients(List<Cliente> clientes) 
            : this()
        {
            this.clientes = clientes;
            List<Factura> listaCompras = new List<Factura>();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        /// <summary>
        /// Mostrara la lista de clientes en el DataGrid.
        /// </summary>
        private void CargarDatos()
        {
            if (this.clientes is not null)
            {
                this.dataGridView_Clientes.Rows.Clear();
                foreach (Cliente item in this.clientes)
                {
                    this.dataGridView_Clientes.Rows.Add(item.Nombre, item.Apellido, item.Dni, item.Direccion);
                }
            }
        }

        /// <summary>
        /// Buscara las ventas realizadas por el cliente seleccionado y las mostrara.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_verCompras_Click(object sender, EventArgs e)
        {
            if(this.clientes.Count > 0)
            {
                if (this.dataGridView_Clientes.SelectedRows is not null)
                {
                    int index = dataGridView_Clientes.CurrentRow.Index;
                    int id_cliente = this.clientes[index].Id;
                    this.listaCompras = DBA.Facturas.TraerComprasCliente(id_cliente);

                    if (listaCompras.Count > 0)
                        MostrarCompras(this.listaCompras);
                    else
                        MessageBox.Show("Sin compras realizadas");
                    
                }
                else
                    MessageBox.Show("Nada para mostrar");
            }
            else
                MessageBox.Show("No figuran ventas realizadas");
        }

        private void MostrarCompras(List<Factura> f)
        {
            if(f is not null)
            {
                foreach (Factura item in f)
                {
                    MessageBox.Show(item.ToString());
                }
            }
        }
        /// <summary>
        /// Modificara los datos del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (this.clientes.Count > 0)
            {
                FormEditClient frmModificar = new FormEditClient(this.clientes, clientes[dataGridView_Clientes.CurrentRow.Index]);

                frmModificar.StartPosition = FormStartPosition.CenterScreen;
                DialogResult resultado = frmModificar.ShowDialog();

                if (resultado == DialogResult.OK)
                    MessageBox.Show("Datos modificados");

                this.CargarDatos();
            }
            else
                MessageBox.Show("No hay clientes para modificar");
        }
    }
}
