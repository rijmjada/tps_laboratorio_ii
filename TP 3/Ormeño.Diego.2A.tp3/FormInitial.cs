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

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormInitial : Form
    {
        private string path_productos;
        private string path_ventas;
        private string path_clientes;
        private Deposito<Producto> deposito;
        private Ventas ventas;
        private List<Cliente> listaClientes;

        public FormInitial()
        {
            InitializeComponent();
            this.deposito = new Deposito<Producto>(10);
            this.ventas = new Ventas();
            this.listaClientes = new List<Cliente>();
            this.path_productos = FormInitial.CrearDirectorioYArchivo("deposito.xml", "XML_Productos");
            this.path_ventas = FormInitial.CrearDirectorioYArchivo("ventas.xml", "XML_Ventas");
            this.path_clientes = FormInitial.CrearDirectorioYArchivo("clientes.xml", "XML_Clientes");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.deposito = this.deposito.DeserializarXml(path_productos);
            }
            catch (Exception)
            {
                this.deposito = new Deposito<Producto>(10);
            }

            try
            {
                this.ventas = XML<Ventas>.DeserializarXML(path_ventas);
            }
            catch (Exception)
            {
                this.ventas = new Ventas();
            }

            try
            {
                this.listaClientes = XML<List<Cliente>>.DeserializarXML(path_clientes);
            }
            catch (Exception)
            {
                this.listaClientes = new List<Cliente>();
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
            FormStock frmDepo = new FormStock(this.deposito, this.ventas, this.listaClientes);

            frmDepo.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmDepo.ShowDialog();
        }
        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            FormAddClient frmAltaCliente = new FormAddClient(this.listaClientes);

            frmAltaCliente.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmAltaCliente.ShowDialog();

            if (ret == DialogResult.OK)
                MessageBox.Show("Alta exitosa");
        }
        private void btn_listarClientes_Click(object sender, EventArgs e)
        {
            FormViewClients frmClientes = new FormViewClients(this.listaClientes);

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

        private void FormInitial_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.deposito.Serializar(path_productos);
                XML<Ventas>.SerializarXML(this.ventas, path_ventas);
                XML<List<Cliente>>.SerializarXML(this.listaClientes, path_clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio algun error al deserializar{ex.Message}");
            }
        }

       
    }
}
