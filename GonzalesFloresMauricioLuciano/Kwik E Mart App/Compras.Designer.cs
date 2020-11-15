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
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lblAPagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(546, 253);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 31);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgvCompras
            // 
            this.dtgvCompras.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dtgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlmacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.btnComprar.Location = new System.Drawing.Point(367, 253);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(103, 31);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(177, 253);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(100, 29);
            this.btnDevolver.TabIndex = 5;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblAPagar
            // 
            this.lblAPagar.AutoSize = true;
            this.lblAPagar.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPagar.Location = new System.Drawing.Point(685, 250);
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.Size = new System.Drawing.Size(89, 29);
            this.lblAPagar.TabIndex = 6;
            this.lblAPagar.Text = "label1";
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.ControlBox = false;
            this.Controls.Add(this.lblAPagar);
            this.Controls.Add(this.btnDevolver);
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
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lblAPagar;
    }
}