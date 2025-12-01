using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Marketplace.forms
{
    public partial class FormZoomImagen : Form
    {
        private string rutaImagen;
        public FormZoomImagen(string rutaImagen)
        {
            InitializeComponent();
            this.rutaImagen = rutaImagen;
            this.Load += FormZoomImagen_Load;

            // Configuración visual
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = false;
        }

        private void FormZoomImagen_Load(object sender, EventArgs e)
        {
            this.Text = "Imagen en Zoom (Click para cerrar)";

            // Intenta cargar la imagen
            try
            {
                if (File.Exists(rutaImagen))
                {
                    // Liberar imagen anterior si exi 
                    if (pictureBoxZoom.Image != null)
                    {
                        pictureBoxZoom.Image.Dispose();
                    }

                    using (var fs = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxZoom.Image = new Bitmap(fs);
                    }
                }

                // Ajuste importante el picturebox debe rellenar el formulario
                pictureBoxZoom.Dock = DockStyle.Fill;
                pictureBoxZoom.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            // Cerrar el formulario al hacer clic en la imagen
            pictureBoxZoom.Click += PictureBoxZoom_Click;
        }

        private void PictureBoxZoom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Liberar el recurso de la imagen al cerrar el formulario
            if (pictureBoxZoom.Image != null)
            {
                pictureBoxZoom.Image.Dispose();
            }
            base.OnFormClosed(e);
        }
    }
}