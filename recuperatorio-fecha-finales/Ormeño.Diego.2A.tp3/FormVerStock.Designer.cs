
namespace Ormeño.Diego._2A.tp3
{
    partial class FormVerStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_productos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_verMas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_productos
            // 
            this.dataGridView_productos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_productos.AllowUserToAddRows = false;
            this.dataGridView_productos.AllowUserToDeleteRows = false;
            this.dataGridView_productos.AllowUserToResizeColumns = false;
            this.dataGridView_productos.AllowUserToResizeRows = false;
            this.dataGridView_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_productos.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Precio});
            this.dataGridView_productos.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView_productos.Location = new System.Drawing.Point(24, 25);
            this.dataGridView_productos.MultiSelect = false;
            this.dataGridView_productos.Name = "dataGridView_productos";
            this.dataGridView_productos.ReadOnly = true;
            this.dataGridView_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_productos.RowHeadersVisible = false;
            this.dataGridView_productos.RowTemplate.Height = 25;
            this.dataGridView_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_productos.Size = new System.Drawing.Size(589, 286);
            this.dataGridView_productos.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btn_verMas
            // 
            this.btn_verMas.Location = new System.Drawing.Point(515, 328);
            this.btn_verMas.Name = "btn_verMas";
            this.btn_verMas.Size = new System.Drawing.Size(98, 34);
            this.btn_verMas.TabIndex = 2;
            this.btn_verMas.Text = "Ver mas...";
            this.btn_verMas.UseVisualStyleBackColor = true;
            this.btn_verMas.Click += new System.EventHandler(this.btn_verMas_Click);
            // 
            // FormVerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(638, 374);
            this.Controls.Add(this.btn_verMas);
            this.Controls.Add(this.dataGridView_productos);
            this.Name = "FormVerStock";
            this.Text = "Ver Stock";
            this.Load += new System.EventHandler(this.FormVerStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btn_verMas;
    }
}