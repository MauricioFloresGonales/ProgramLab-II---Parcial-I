namespace Kwik_E_Mart_App
{
    partial class FrmCompras
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtgvCompras = new System.Windows.Forms.DataGridView();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(896, 258);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgvCompras
            // 
            this.dtgvCompras.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dtgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCompras.Location = new System.Drawing.Point(101, 297);
            this.dtgvCompras.Name = "dtgvCompras";
            this.dtgvCompras.RowHeadersWidth = 51;
            this.dtgvCompras.RowTemplate.Height = 24;
            this.dtgvCompras.Size = new System.Drawing.Size(895, 241);
            this.dtgvCompras.TabIndex = 1;
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(101, 12);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.RowHeadersWidth = 51;
            this.dgvAlmacen.RowTemplate.Height = 24;
            this.dgvAlmacen.Size = new System.Drawing.Size(895, 215);
            this.dgvAlmacen.TabIndex = 2;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(605, 257);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(103, 31);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(220, 260);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(100, 22);
            this.txtIdCompra.TabIndex = 2;
            this.txtIdCompra.TextChanged += new System.EventHandler(this.txtIdCompra_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Location = new System.Drawing.Point(426, 261);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(193, 263);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 17);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID :";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(356, 263);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 17);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(761, 257);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(100, 29);
            this.btnDevolver.TabIndex = 5;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.ControlBox = false;
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dgvAlmacen);
            this.Controls.Add(this.dtgvCompras);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dtgvCompras;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnDevolver;
    }
}