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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZoomImagen));
            pictureBoxZoom = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZoom).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxZoom
            // 
            pictureBoxZoom.BackColor = Color.Black;
            pictureBoxZoom.Dock = DockStyle.Fill;
            pictureBoxZoom.Location = new Point(0, 0);
            pictureBoxZoom.Name = "pictureBoxZoom";
            pictureBoxZoom.Size = new Size(800, 600);
            pictureBoxZoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxZoom.TabIndex = 0;
            pictureBoxZoom.TabStop = false;
            // 
            // FormZoomImagen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pictureBoxZoom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FormZoomImagen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zoom de Imagen";
            ((System.ComponentModel.ISupportInitialize)pictureBoxZoom).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxZoom;
    }
}