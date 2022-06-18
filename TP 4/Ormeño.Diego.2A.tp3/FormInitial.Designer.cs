
namespace Ormeño.Diego._2A.tp3
{
    partial class FormInitial
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
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_altaCliente = new System.Windows.Forms.Button();
            this.btn_listarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_stock.Location = new System.Drawing.Point(186, 67);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(120, 40);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.Text = "Ver Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(186, 189);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(120, 40);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregarProducto.Location = new System.Drawing.Point(38, 67);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(120, 40);
            this.btn_agregarProducto.TabIndex = 0;
            this.btn_agregarProducto.Text = "Agregar Producto";
            this.btn_agregarProducto.UseVisualStyleBackColor = true;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ventas.Location = new System.Drawing.Point(38, 189);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(120, 40);
            this.btn_ventas.TabIndex = 4;
            this.btn_ventas.Text = "Ver Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_altaCliente
            // 
            this.btn_altaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_altaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_altaCliente.Location = new System.Drawing.Point(38, 129);
            this.btn_altaCliente.Name = "btn_altaCliente";
            this.btn_altaCliente.Size = new System.Drawing.Size(120, 40);
            this.btn_altaCliente.TabIndex = 2;
            this.btn_altaCliente.Text = "Agregar Cliente";
            this.btn_altaCliente.UseVisualStyleBackColor = true;
            this.btn_altaCliente.Click += new System.EventHandler(this.btn_altaCliente_Click);
            // 
            // btn_listarClientes
            // 
            this.btn_listarClientes.Location = new System.Drawing.Point(186, 129);
            this.btn_listarClientes.Name = "btn_listarClientes";
            this.btn_listarClientes.Size = new System.Drawing.Size(120, 40);
            this.btn_listarClientes.TabIndex = 3;
            this.btn_listarClientes.Text = "Ver Clientes";
            this.btn_listarClientes.UseVisualStyleBackColor = true;
            this.btn_listarClientes.Click += new System.EventHandler(this.btn_listarClientes_Click);
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 278);
            this.Controls.Add(this.btn_listarClientes);
            this.Controls.Add(this.btn_altaCliente);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_altaCliente;
        private System.Windows.Forms.Button btn_listarClientes;
    }
}

