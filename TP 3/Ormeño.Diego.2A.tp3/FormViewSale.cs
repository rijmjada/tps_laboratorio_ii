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
    public partial class FormViewSale : Form
    {
        Ventas ventas;
        double totalFacturacionDia = 0;
        public FormViewSale(Ventas ventas)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.lbl_monto.Text = $"$ {this.totalFacturacionDia.ToString()}";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.totalFacturacionDia = 0;

            DateTime fecha = this.dateTimePicker1.Value;
            foreach (Factura item in this.ventas.Lista)
            {
                if (item.Fecha.DayOfYear == fecha.DayOfYear)
                {
                    this.totalFacturacionDia += item.Monto;
                    this.dataGridView1.Rows.Add(((Libro)item.Producto).Titulo, item.Monto);
                }
            }
            this.lbl_monto.Text = $"$ {this.totalFacturacionDia.ToString()}";
        }
        
      
    }
}
