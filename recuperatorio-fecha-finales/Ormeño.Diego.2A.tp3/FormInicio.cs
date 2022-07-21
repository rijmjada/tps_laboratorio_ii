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
using System.Runtime.InteropServices;

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormInicio : Form
    {
        
        private Deposito<Producto> deposito;
        private Ventas ventas;
        private List<Cliente> clientes;
        List<Task> listTareas;
       
        public FormInicio()
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
            catch (Exception )
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
            catch (Exception )
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
            catch (Exception )
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
            FormBuscarStock frmDepo = new FormBuscarStock(this.deposito, this.ventas, this.clientes);

            frmDepo.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmDepo.ShowDialog();
        }
        
        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            FormAddClient frmAltaCliente = new FormAddClient(this.clientes);

            frmAltaCliente.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmAltaCliente.ShowDialog();

            if (ret == DialogResult.OK)
                MessageBox.Show("Cliente Agregado");
        }
        
        private void btn_listarClientes_Click(object sender, EventArgs e)
        {
            FormVerCliente frmClientes = new FormVerCliente(this.clientes);

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

        private void btn_verStock_Click(object sender, EventArgs e)
        {
            FormVerStock frmVerStock = new FormVerStock(this.deposito);
            frmVerStock.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmVerStock.ShowDialog();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
