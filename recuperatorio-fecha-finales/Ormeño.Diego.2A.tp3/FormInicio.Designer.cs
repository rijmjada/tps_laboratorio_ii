
namespace Ormeño.Diego._2A.tp3
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.btn_verStock = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.VerticalIzq = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmini1 = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_listarClientes = new System.Windows.Forms.Button();
            this.btn_altaCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.VerticalIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarProducto.FlatAppearance.BorderSize = 0;
            this.btn_BuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarProducto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarProducto.ForeColor = System.Drawing.Color.Olive;
            this.btn_BuscarProducto.Location = new System.Drawing.Point(7, 102);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(174, 40);
            this.btn_BuscarProducto.TabIndex = 1;
            this.btn_BuscarProducto.Text = "Buscar Producto";
            this.btn_BuscarProducto.UseVisualStyleBackColor = true;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(3, 404);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(177, 40);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.Olive;
            this.btn_agregarProducto.Location = new System.Drawing.Point(6, 39);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(174, 40);
            this.btn_agregarProducto.TabIndex = 0;
            this.btn_agregarProducto.Text = "Agregar Producto";
            this.btn_agregarProducto.UseVisualStyleBackColor = true;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // btn_verStock
            // 
            this.btn_verStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verStock.FlatAppearance.BorderSize = 0;
            this.btn_verStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_verStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verStock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_verStock.ForeColor = System.Drawing.Color.Olive;
            this.btn_verStock.Location = new System.Drawing.Point(6, 161);
            this.btn_verStock.Name = "btn_verStock";
            this.btn_verStock.Size = new System.Drawing.Size(174, 40);
            this.btn_verStock.TabIndex = 6;
            this.btn_verStock.Text = "Ver Stock";
            this.btn_verStock.UseVisualStyleBackColor = true;
            this.btn_verStock.Click += new System.EventHandler(this.btn_verStock_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Orange;
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(800, 35);
            this.BarraTitulo.TabIndex = 7;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "EL ATENEO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(760, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VerticalIzq
            // 
            this.VerticalIzq.BackColor = System.Drawing.Color.Bisque;
            this.VerticalIzq.Controls.Add(this.panel5);
            this.VerticalIzq.Controls.Add(this.panel4);
            this.VerticalIzq.Controls.Add(this.panel3);
            this.VerticalIzq.Controls.Add(this.panel2);
            this.VerticalIzq.Controls.Add(this.panel1);
            this.VerticalIzq.Controls.Add(this.panelmini1);
            this.VerticalIzq.Controls.Add(this.btn_ventas);
            this.VerticalIzq.Controls.Add(this.btn_listarClientes);
            this.VerticalIzq.Controls.Add(this.btn_salir);
            this.VerticalIzq.Controls.Add(this.btn_altaCliente);
            this.VerticalIzq.Controls.Add(this.btn_agregarProducto);
            this.VerticalIzq.Controls.Add(this.btn_BuscarProducto);
            this.VerticalIzq.Controls.Add(this.btn_verStock);
            this.VerticalIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalIzq.Location = new System.Drawing.Point(0, 35);
            this.VerticalIzq.Name = "VerticalIzq";
            this.VerticalIzq.Size = new System.Drawing.Size(195, 455);
            this.VerticalIzq.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Location = new System.Drawing.Point(0, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 40);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(1, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 40);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(1, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 40);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 40);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(1, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 40);
            this.panel1.TabIndex = 10;
            // 
            // panelmini1
            // 
            this.panelmini1.BackColor = System.Drawing.Color.Gold;
            this.panelmini1.Location = new System.Drawing.Point(1, 39);
            this.panelmini1.Name = "panelmini1";
            this.panelmini1.Size = new System.Drawing.Size(6, 40);
            this.panelmini1.TabIndex = 9;
            // 
            // btn_ventas
            // 
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ventas.ForeColor = System.Drawing.Color.Olive;
            this.btn_ventas.Location = new System.Drawing.Point(6, 344);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(174, 40);
            this.btn_ventas.TabIndex = 4;
            this.btn_ventas.Text = "Ver Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_listarClientes
            // 
            this.btn_listarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listarClientes.FlatAppearance.BorderSize = 0;
            this.btn_listarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_listarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listarClientes.ForeColor = System.Drawing.Color.Olive;
            this.btn_listarClientes.Location = new System.Drawing.Point(6, 284);
            this.btn_listarClientes.Name = "btn_listarClientes";
            this.btn_listarClientes.Size = new System.Drawing.Size(174, 40);
            this.btn_listarClientes.TabIndex = 3;
            this.btn_listarClientes.Text = "Ver Clientes";
            this.btn_listarClientes.UseVisualStyleBackColor = true;
            this.btn_listarClientes.Click += new System.EventHandler(this.btn_listarClientes_Click);
            // 
            // btn_altaCliente
            // 
            this.btn_altaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altaCliente.FlatAppearance.BorderSize = 0;
            this.btn_altaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_altaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altaCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_altaCliente.ForeColor = System.Drawing.Color.Olive;
            this.btn_altaCliente.Location = new System.Drawing.Point(7, 221);
            this.btn_altaCliente.Name = "btn_altaCliente";
            this.btn_altaCliente.Size = new System.Drawing.Size(174, 40);
            this.btn_altaCliente.TabIndex = 2;
            this.btn_altaCliente.Text = "Agregar Cliente";
            this.btn_altaCliente.UseVisualStyleBackColor = true;
            this.btn_altaCliente.Click += new System.EventHandler(this.btn_altaCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VerticalIzq);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.VerticalIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarProducto;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.Button btn_verStock;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel VerticalIzq;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_listarClientes;
        private System.Windows.Forms.Button btn_altaCliente;
        private System.Windows.Forms.Panel panelmini1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

