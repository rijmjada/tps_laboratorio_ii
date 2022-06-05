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

    public partial class FormEditClient : Form
    {
        Cliente cliente;
        List<Cliente> listaClientes;
        public FormEditClient()
        {
            InitializeComponent();
            this.txt_nombre.MaxLength = 10;
            this.txt_apellido.MaxLength = 10;
            this.txt_direccion.MaxLength = 10;
            this.txt_dni.MaxLength = 9;
        }
        public FormEditClient(List<Cliente> listaClientes, Cliente cliente)
            : this()
        {
            this.cliente = cliente;
            this.listaClientes = listaClientes;
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            this.txt_apellido.Text = cliente.Apellido;
            this.txt_nombre.Text = cliente.Nombre;
            this.txt_dni.Text = cliente.Dni.ToString();
            this.txt_direccion.Text = cliente.Direccion;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (InputsCompletos())
            {
                int dni = Convert.ToInt32(txt_dni.Text);
                if (!this.YaExiteCliente(dni))
                {
                    this.cliente.Direccion = txt_direccion.Text;
                    this.cliente.Apellido = txt_apellido.Text;
                    this.cliente.Nombre = txt_nombre.Text;
                    this.cliente.Dni = dni;
                    if (cliente is not null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al intentar modificar los datos!.");
                        this.DialogResult = DialogResult.Abort;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ya exite un cliente con el mismo DNI.");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private bool YaExiteCliente(int dni)
        {
            if (this.listaClientes is not null)
            {
                int indiceClienteActual = this.listaClientes.IndexOf(this.cliente);
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Dni == dni && indiceClienteActual != this.listaClientes.IndexOf(item))
                        return true;
                }
            }
            return false;
        }
        private bool InputsCompletos()
        {
            foreach (Control item in this.Controls)
            {
                if (String.IsNullOrEmpty(item.Text))
                    return false;
            }
            return true;
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
