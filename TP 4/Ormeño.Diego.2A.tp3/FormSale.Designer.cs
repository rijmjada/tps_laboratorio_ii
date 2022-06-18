
namespace Ormeño.Diego._2A.tp3
{
    partial class FormSale
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
            this.txt_VFecha = new System.Windows.Forms.TextBox();
            this.txt_VDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_VPrecio = new System.Windows.Forms.TextBox();
            this.txt_VProducto = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_VFecha
            // 
            this.txt_VFecha.Location = new System.Drawing.Point(35, 116);
            this.txt_VFecha.Name = "txt_VFecha";
            this.txt_VFecha.Size = new System.Drawing.Size(100, 23);
            this.txt_VFecha.TabIndex = 0;
            // 
            // txt_VDni
            // 
            this.txt_VDni.Location = new System.Drawing.Point(163, 116);
            this.txt_VDni.Name = "txt_VDni";
            this.txt_VDni.Size = new System.Drawing.Size(100, 23);
            this.txt_VDni.TabIndex = 3;
            this.txt_VDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_VDni_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dni Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Producto";
            // 
            // txt_VPrecio
            // 
            this.txt_VPrecio.Location = new System.Drawing.Point(163, 59);
            this.txt_VPrecio.Name = "txt_VPrecio";
            this.txt_VPrecio.Size = new System.Drawing.Size(100, 23);
            this.txt_VPrecio.TabIndex = 9;
            // 
            // txt_VProducto
            // 
            this.txt_VProducto.Location = new System.Drawing.Point(35, 59);
            this.txt_VProducto.Name = "txt_VProducto";
            this.txt_VProducto.Size = new System.Drawing.Size(100, 23);
            this.txt_VProducto.TabIndex = 8;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.Gold;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirmar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirmar.Location = new System.Drawing.Point(36, 161);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(227, 34);
            this.btn_Confirmar.TabIndex = 12;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 218);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_VPrecio);
            this.Controls.Add(this.txt_VProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_VDni);
            this.Controls.Add(this.txt_VFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_VFecha;
        private System.Windows.Forms.TextBox txt_VDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_VPrecio;
        private System.Windows.Forms.TextBox txt_VProducto;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}