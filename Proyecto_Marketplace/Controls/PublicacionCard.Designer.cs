namespace Proyecto_Marketplace.Controls
{
    partial class PublicacionCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagen = new PictureBox();
            lblTitulo = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.Transparent;
            pbImagen.Cursor = Cursors.Hand;
            pbImagen.Dock = DockStyle.Top;
            pbImagen.Location = new Point(0, 0);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(200, 170);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoEllipsis = true;
            lblTitulo.AutoSize = true;
            lblTitulo.Cursor = Cursors.Hand;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 170);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(5, 5, 5, 0);
            lblTitulo.Size = new Size(61, 24);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "label1";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Cursor = Cursors.Hand;
            lblPrecio.Dock = DockStyle.Fill;
            lblPrecio.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Green;
            lblPrecio.Location = new Point(0, 194);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Padding = new Padding(5, 0, 5, 5);
            lblPrecio.Size = new Size(56, 22);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "label1";
            // 
            // PublicacionCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblPrecio);
            Controls.Add(lblTitulo);
            Controls.Add(pbImagen);
            Name = "PublicacionCard";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagen;
        private Label lblTitulo;
        private Label lblPrecio;
    }
}
