
namespace Ormeño.Diego._2A.tp3
{
    partial class FormEditClient
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Gold;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_modificar.Location = new System.Drawing.Point(40, 182);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(266, 39);
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(188, 118);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.TabIndex = 16;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(41, 116);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.TabIndex = 15;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(188, 62);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_apellido.TabIndex = 14;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(40, 63);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 13;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(188, 138);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(118, 23);
            this.txt_dni.TabIndex = 12;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(41, 137);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(118, 23);
            this.txt_direccion.TabIndex = 11;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(188, 83);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(118, 23);
            this.txt_apellido.TabIndex = 10;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(41, 83);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(118, 23);
            this.txt_nombre.TabIndex = 9;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // FormEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 278);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Name = "FormEditClient";
            this.Text = "FormEditarCliente";
            this.Load += new System.EventHandler(this.FormEditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}