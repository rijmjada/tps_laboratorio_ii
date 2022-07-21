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
    public partial class FormVerStock : Form
    {
        Deposito<Producto> depoForm; 
        public FormVerStock(Deposito<Producto> depo)
        {
            InitializeComponent();
            this.depoForm = depo;
        }

        private void CargarDatos()
        {
            if (this.depoForm is not null)
            {
                this.dataGridView_productos.Rows.Clear();
                foreach (Libro item in this.depoForm.Lista)
                {
                    this.dataGridView_productos.Rows.Add(item.Titulo, item.Autor, item.Precio, item.Genero);
                }
            }
        }

        private void FormVerStock_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void btn_verMas_Click(object sender, EventArgs e)
        {
            if (this.depoForm.Lista.Count > 0)
            {
                int index = this.dataGridView_productos.CurrentRow.Index;
                MessageBox.Show(this.depoForm.Lista[index].ToString());
            }
          
        }
    }
}
