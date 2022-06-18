﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using DBA;

namespace Ormeño.Diego._2A.tp3
{
    public partial class FormAddProduct : Form
    {
        Deposito<Producto> depositoFrmAdd;

        public FormAddProduct()
        {
            InitializeComponent();
            this.txt_autor.MaxLength = 20;
            this.txt_titulo.MaxLength = 40;
            this.txt_paginas.MaxLength = 9;
            this.txt_precio.MaxLength = 9;
        }

        public FormAddProduct(Deposito<Producto> deposito) 
            : this()
        {
            this.depositoFrmAdd = deposito;
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            foreach (EOrigen item in Enum.GetValues(typeof(EOrigen)))
            {
                this.cmb_origen.Items.Add(item);
            }

            foreach (EGeneroLiterario item in Enum.GetValues(typeof(EGeneroLiterario)))
            {
                this.cmb_genero.Items.Add(item);
            }
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (InputsCompletos())
            {
                string autor = this.txt_autor.Text;
                string titulo = this.txt_titulo.Text;
                EOrigen origen = (EOrigen)cmb_origen.SelectedItem;
                int paginas = Convert.ToInt32(this.txt_paginas.Text);
                double precio = Convert.ToDouble(this.txt_precio.Text);
                EGeneroLiterario genero = (EGeneroLiterario)cmb_genero.SelectedItem;

                Libro libro = new Libro(precio, origen, paginas, genero, autor, titulo);

                if (DBA.Libros.Guardar(libro))
                {
                    libro.Codigo = DBA.Libros.TraerUltimoCodigo();
                    this.depositoFrmAdd.Agregar(libro);
                    MessageBox.Show("Producto agregado");
                    this.LimpiarDatos();
                }
                else
                    MessageBox.Show("Erro al intentar agregar el producto.");
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void LimpiarDatos()
        {
            this.txt_autor.Text = String.Empty;
            this.txt_titulo.Text = String.Empty;
            this.txt_paginas.Text = String.Empty;
            this.txt_precio.Text = String.Empty;
            this.cmb_genero.SelectedItem = null;
            this.cmb_origen.SelectedItem = null;
        }

        /// <summary>
        ///  Filtrara para que solo se ingresen valores numericos y ','.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Filtrara para que solo se puedan ingresar numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_paginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

    }
}
