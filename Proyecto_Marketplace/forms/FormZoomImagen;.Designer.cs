namespace Proyecto_Marketplace.forms
{
    partial class FormZoomImagen
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
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.BackColor = System.Drawing.Color.Black;
            this.pictureBoxZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxZoom.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // CLAVE para el zoom
            this.pictureBoxZoom.TabIndex = 0;
            this.pictureBoxZoom.TabStop = false;
            // 
            // FormZoomImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBoxZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.Name = "FormZoomImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoom de Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxZoom;
    }
}