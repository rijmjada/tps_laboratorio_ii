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

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormFactura : Form
    {
        string nombreFactura;

        public FormFactura(string nombreFactura)
        {
            this.nombreFactura = nombreFactura;
            InitializeComponent();
            AbrirArchivosFacturacion();
            this.textBox1.Enabled = false;
            this.Text = "Factura";
        }
        
        private void AbrirArchivosFacturacion()
        {
            this.openFileDialog1.Title = "Abrir archivo de facturas";
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Facturacion";
            this.openFileDialog1.Filter = "TXT files|*.txt";
            this.openFileDialog1.FileName = this.nombreFactura;
            this.openFileDialog1.CheckPathExists = true;
            this.openFileDialog1.CheckFileExists = false;

            DialogResult rta = this.openFileDialog1.ShowDialog();

            if (rta == DialogResult.OK)
            {
                string facturas = this.LeerArchivo(openFileDialog1.FileName);

                if (facturas is not null)
                {
                    this.textBox1.Clear();
                    this.textBox1.Text = facturas;
                }
            }
        }

        private string LeerArchivo(string path)
        {
            string facturas;
            try
            {
                using (StreamReader w = new StreamReader(path))
                {
                    facturas = w.ReadToEnd();
                }
            }
            catch (Exception)
            {
                facturas = null;
            }

            return facturas;
        }
    }
}
