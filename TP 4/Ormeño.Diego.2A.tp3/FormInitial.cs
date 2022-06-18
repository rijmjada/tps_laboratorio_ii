using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using DBA;

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormInitial : Form
    {
        
        private Deposito<Producto> deposito;
        private Ventas ventas;
        private List<Cliente> clientes;
        List<Task> listTareas;
       
        public FormInitial()
        {
            InitializeComponent();

            this.deposito = new Deposito<Producto>(1000);
            this.ventas = new Ventas();

            this.listTareas = new List<Task>()
            {
                new Task (CargarClientes),
                new Task (CargarProductos),
                new Task (CargarVentas)
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listTareas.ForEach((x) => x.Start());
            Task.WaitAll(listTareas.ToArray());
        }

        public void CargarProductos()
        {
            try
            {
                this.deposito.Lista = DBA.Libros.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error_form_load_libros");
            }
        }

        public void CargarClientes()
        {
            try
            {
                this.clientes = DBA.Clientes.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error_form_load_clientes");
            }
        }

        public void CargarVentas()
        {
            try
            {
                this.ventas.Lista = DBA.Facturas.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error_form_load_Facturas");
            }
        }

        private static string CrearDirectorioYArchivo(string nombreArchivo, string nombreCarpeta)
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreCarpeta);

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            return ruta = Path.Combine(ruta, nombreArchivo);
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            FormAddProduct frmAdd = new FormAddProduct(this.deposito);

            frmAdd.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmAdd.ShowDialog();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            FormStock frmDepo = new FormStock(this.deposito, this.ventas, this.clientes);

            frmDepo.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmDepo.ShowDialog();
        }
        
        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            FormAddClient frmAltaCliente = new FormAddClient(this.clientes);

            frmAltaCliente.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmAltaCliente.ShowDialog();

            if (ret == DialogResult.OK)
                MessageBox.Show("Alta exitosa");
        }
        
        private void btn_listarClientes_Click(object sender, EventArgs e)
        {
            FormViewClients frmClientes = new FormViewClients(this.clientes);

            frmClientes.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmClientes.ShowDialog();
        }
        
        private void btn_ventas_Click(object sender, EventArgs e)
        {
            FormViewSale frmDatos = new FormViewSale(this.ventas);

            frmDatos.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmDatos.ShowDialog();
        }
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
