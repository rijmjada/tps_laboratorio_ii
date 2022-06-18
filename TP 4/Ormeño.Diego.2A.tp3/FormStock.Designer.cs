
namespace Ormeño.Diego._2A.tp3
{
    partial class FormStock
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_articulo = new System.Windows.Forms.Label();
            this.btn_verMas = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.radio_codigo = new System.Windows.Forms.RadioButton();
            this.radio_titulo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_autor = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(25, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 259);
            this.listBox1.TabIndex = 0;
            // 
            // lbl_articulo
            // 
            this.lbl_articulo.AutoSize = true;
            this.lbl_articulo.Location = new System.Drawing.Point(25, 107);
            this.lbl_articulo.Name = "lbl_articulo";
            this.lbl_articulo.Size = new System.Drawing.Size(49, 15);
            this.lbl_articulo.TabIndex = 2;
            this.lbl_articulo.Text = "Articulo";
            // 
            // btn_verMas
            // 
            this.btn_verMas.BackColor = System.Drawing.Color.Transparent;
            this.btn_verMas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_verMas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_verMas.Location = new System.Drawing.Point(27, 416);
            this.btn_verMas.Name = "btn_verMas";
            this.btn_verMas.Size = new System.Drawing.Size(86, 27);
            this.btn_verMas.TabIndex = 4;
            this.btn_verMas.Text = "Ver mas...";
            this.btn_verMas.UseVisualStyleBackColor = false;
            this.btn_verMas.Click += new System.EventHandler(this.btn_verMas_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.Gold;
            this.btn_vender.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_vender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_vender.Location = new System.Drawing.Point(260, 399);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(95, 44);
            this.btn_vender.TabIndex = 5;
            this.btn_vender.Text = "VENDER";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(25, 71);
            this.txt_busqueda.MaxLength = 25;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(233, 23);
            this.txt_busqueda.TabIndex = 7;
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // radio_codigo
            // 
            this.radio_codigo.AutoSize = true;
            this.radio_codigo.Location = new System.Drawing.Point(27, 46);
            this.radio_codigo.Name = "radio_codigo";
            this.radio_codigo.Size = new System.Drawing.Size(64, 19);
            this.radio_codigo.TabIndex = 8;
            this.radio_codigo.TabStop = true;
            this.radio_codigo.Text = "Codigo";
            this.radio_codigo.UseVisualStyleBackColor = true;
            this.radio_codigo.CheckedChanged += new System.EventHandler(this.radio_codigo_CheckedChanged);
            // 
            // radio_titulo
            // 
            this.radio_titulo.AutoSize = true;
            this.radio_titulo.Location = new System.Drawing.Point(97, 46);
            this.radio_titulo.Name = "radio_titulo";
            this.radio_titulo.Size = new System.Drawing.Size(55, 19);
            this.radio_titulo.TabIndex = 9;
            this.radio_titulo.TabStop = true;
            this.radio_titulo.Text = "Titulo";
            this.radio_titulo.UseVisualStyleBackColor = true;
            this.radio_titulo.CheckedChanged += new System.EventHandler(this.radio_titulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar por:";
            // 
            // radio_autor
            // 
            this.radio_autor.AutoSize = true;
            this.radio_autor.Location = new System.Drawing.Point(158, 46);
            this.radio_autor.Name = "radio_autor";
            this.radio_autor.Size = new System.Drawing.Size(55, 19);
            this.radio_autor.TabIndex = 11;
            this.radio_autor.TabStop = true;
            this.radio_autor.Text = "Autor";
            this.radio_autor.UseVisualStyleBackColor = true;
            this.radio_autor.CheckedChanged += new System.EventHandler(this.radio_autor_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(274, 71);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(81, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 464);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.radio_autor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_titulo);
            this.Controls.Add(this.radio_codigo);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.btn_verMas);
            this.Controls.Add(this.lbl_articulo);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_articulo;
        private System.Windows.Forms.Button btn_verMas;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.RadioButton radio_codigo;
        private System.Windows.Forms.RadioButton radio_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_autor;
        private System.Windows.Forms.Button btn_buscar;
    }
}