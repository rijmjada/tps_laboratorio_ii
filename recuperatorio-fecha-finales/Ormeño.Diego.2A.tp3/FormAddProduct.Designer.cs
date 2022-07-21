
namespace Ormeño.Diego._2A.tp3
{
    partial class FormAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_paginas = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmb_origen = new System.Windows.Forms.ComboBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_paginas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(35, 59);
            this.txt_autor.MaxLength = 15;
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(122, 23);
            this.txt_autor.TabIndex = 0;
            this.txt_autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_autor_KeyPress);
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_autor.ForeColor = System.Drawing.Color.Olive;
            this.lbl_autor.Location = new System.Drawing.Point(34, 40);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(43, 16);
            this.lbl_autor.TabIndex = 6;
            this.lbl_autor.Text = "Autor";
            // 
            // lbl_paginas
            // 
            this.lbl_paginas.AutoSize = true;
            this.lbl_paginas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_paginas.ForeColor = System.Drawing.Color.Olive;
            this.lbl_paginas.Location = new System.Drawing.Point(35, 95);
            this.lbl_paginas.Name = "lbl_paginas";
            this.lbl_paginas.Size = new System.Drawing.Size(57, 16);
            this.lbl_paginas.TabIndex = 7;
            this.lbl_paginas.Text = "Paginas";
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_origen.ForeColor = System.Drawing.Color.Olive;
            this.lbl_origen.Location = new System.Drawing.Point(191, 146);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(49, 16);
            this.lbl_origen.TabIndex = 14;
            this.lbl_origen.Text = "Origen";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.ForeColor = System.Drawing.Color.Olive;
            this.lbl_precio.Location = new System.Drawing.Point(191, 95);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(47, 16);
            this.lbl_precio.TabIndex = 13;
            this.lbl_precio.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(191, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Titulo";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(191, 113);
            this.txt_precio.MaxLength = 10;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(121, 23);
            this.txt_precio.TabIndex = 3;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(190, 59);
            this.txt_titulo.MaxLength = 20;
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(122, 23);
            this.txt_titulo.TabIndex = 1;
            this.txt_titulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_titulo_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Gold;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_agregar.Location = new System.Drawing.Point(113, 216);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(121, 41);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmb_origen
            // 
            this.cmb_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_origen.FormattingEnabled = true;
            this.cmb_origen.Location = new System.Drawing.Point(190, 164);
            this.cmb_origen.Name = "cmb_origen";
            this.cmb_origen.Size = new System.Drawing.Size(121, 23);
            this.cmb_origen.TabIndex = 4;
            // 
            // cmb_genero
            // 
            this.cmb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Location = new System.Drawing.Point(39, 164);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(121, 23);
            this.cmb_genero.TabIndex = 6;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_genero.ForeColor = System.Drawing.Color.Olive;
            this.lbl_genero.Location = new System.Drawing.Point(37, 145);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(53, 16);
            this.lbl_genero.TabIndex = 21;
            this.lbl_genero.Text = "Genero";
            // 
            // txt_paginas
            // 
            this.txt_paginas.Location = new System.Drawing.Point(38, 113);
            this.txt_paginas.MaxLength = 10;
            this.txt_paginas.Name = "txt_paginas";
            this.txt_paginas.Size = new System.Drawing.Size(122, 23);
            this.txt_paginas.TabIndex = 2;
            this.txt_paginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paginas_KeyPress);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(345, 278);
            this.Controls.Add(this.txt_paginas);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.cmb_origen);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_paginas);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.txt_autor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddProduct";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Producto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_paginas;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_origen;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.TextBox txt_paginas;
    }
}