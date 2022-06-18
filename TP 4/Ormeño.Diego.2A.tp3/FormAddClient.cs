using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormAddClient : Form
    {
        List<Cliente> lista;

        public FormAddClient()
        {
            InitializeComponent();
            this.txt_nombre.MaxLength = 15;
            this.txt_apellido.MaxLength = 15;
            this.txt_dni.MaxLength = 9;
            this.txt_direccion.MaxLength = 20;
        }

        public FormAddClient(List<Cliente> lista)
            : this()
        {
            this.lista = lista;
        }

        public FormAddClient(List<Cliente> lista, string dni)
            : this(lista)
        {
            this.txt_dni.Text = dni;
            this.txt_dni.Enabled = false;
        }

        /// <summary>
        /// Confirmara si los campos estan completos.
        /// </summary>
        /// <returns></returns>
        private bool InputsCompletos()
        {
            foreach (Control item in this.Controls)
            {
                if (String.IsNullOrEmpty(item.Text))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Confirmara si exite un cliente en la lista (por parametro) con el mismo DNI (por parametro).
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        private bool YaExisteCliente(List<Cliente> lista, string dni)
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

        /// <summary>
        /// Filtrara que solo se ingresen numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Filtrara que solo se ingresen letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Filtrara que solo se ingresen letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Filtrara que solo se ingresen valores alfanumericos y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (this.InputsCompletos())
            {
                if (!this.YaExisteCliente(this.lista, this.txt_dni.Text))
                {
                    string nombre = this.txt_nombre.Text;
                    string apellido = this.txt_apellido.Text;
                    string direccion = this.txt_direccion.Text;
                    int dni = Convert.ToInt32(this.txt_dni.Text);

                    Cliente nuevo = new Cliente(nombre, apellido, dni, direccion);
                    if (DBA.Clientes.Guardar(nuevo))
                    {
                        nuevo.Id = DBA.Clientes.TraerUltimoCodigo();
                        this.lista.Add(nuevo);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Se produjo un error en el alta");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente cargado con mismo DNI!");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }
    }
}
