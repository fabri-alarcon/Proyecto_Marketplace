using Proyecto_Marketplace.clases;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Marketplace.forms
{
    public partial class FormPublicacion : Form
    {
        private Publicacion publicacion;
        private Usuario usuarioActual;

        // Variable para rastrear la imagen actual
        private int indiceImagenActual = 0;

        public FormPublicacion(Usuario usuario, Publicacion publi)
        {
            InitializeComponent();
            this.Load += FormPublicacion_Load;
            usuarioActual = usuario ?? new Usuario("Invitado");
            publicacion = publi;

            // Conexión de eventos para el siguiente y anterior
            BtnSiguiente.Click += BtnSiguiente_Click;
            BtnAnterior.Click += BtnAnterior_Click;

            // Conexión de evento para el Zoom
            pictureBoxImagenPubli.Click += PictureBoxImagenPubli_Click;
            pictureBoxImagenPubli.Cursor = Cursors.Hand;
        }

        private void FormPublicacion_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = publicacion.Titulo;
            labelDescripcion.Text = publicacion.Descripcion;

            // Lógica de Precio y Gratis
            if (decimal.TryParse(publicacion.Precio, out decimal precio) && precio > 0)
            {
                labelPrecio.Text = precio.ToString("C2");
            }
            else
            {
                labelPrecio.Text = "Gratis";
            }

            labelTipo.Text = publicacion.Tipo;
            labelUsuario.Text = publicacion.UsuarioCreador;
            labelFechaPublicacion.Text = $"Publicado el día: {publicacion.FechaPublicacion.ToString("dd / MM / yyyy")}";

            CargarImagen(indiceImagenActual);
            ActualizarContadorYBotones();
        }

        //Funcion de zoom para la imagen, osea un click a la imagen abre el formulario de zoom
        private void PictureBoxImagenPubli_Click(object sender, EventArgs e)
        {
            if (publicacion.RutasImagenes.Count > 0)
            {
                string rutaImagenActual = publicacion.RutasImagenes[indiceImagenActual];


                using (FormZoomImagen formZoom = new FormZoomImagen(rutaImagenActual))
                {
                    formZoom.ShowDialog();
                }
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual < publicacion.RutasImagenes.Count - 1)
            {
                indiceImagenActual++;
                CargarImagen(indiceImagenActual);
                ActualizarContadorYBotones();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual > 0)
            {
                indiceImagenActual--;
                CargarImagen(indiceImagenActual);
                ActualizarContadorYBotones();
            }
        }

        private void CargarImagen(int indice)
        {
            if (publicacion.RutasImagenes != null && publicacion.RutasImagenes.Count > indice)
            {
                string ruta = publicacion.RutasImagenes[indice];

                if (pictureBoxImagenPubli.Image != null)
                {
                    pictureBoxImagenPubli.Image.Dispose();
                }

                pictureBoxImagenPubli.Image = CargarImagenSegura(ruta);
            }
        }

        private void ActualizarContadorYBotones()
        {
            int total = publicacion.RutasImagenes.Count;

            if (total <= 1)
            {
                BtnAnterior.Visible = false;
                BtnSiguiente.Visible = false;
                lblContadorImagenes.Visible = false;
            }
            else
            {
                lblContadorImagenes.Visible = true;
                lblContadorImagenes.Text = $"{indiceImagenActual + 1} / {total}";
                BtnAnterior.Visible = (indiceImagenActual > 0);
                BtnSiguiente.Visible = (indiceImagenActual < total - 1);
            }
        }

        private Image CargarImagenSegura(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        return new Bitmap(fs);
                    }
                }
            }
            catch { }

            try
            {
                string placeholderPath = Path.Combine(Application.StartupPath, "media", "placeholder.png");
                if (File.Exists(placeholderPath))
                    return Image.FromFile(placeholderPath);
            }
            catch { }
            return new Bitmap(100, 100);
        }

        private void botonEnviarMensaje_Click(object sender, EventArgs e)
        {
            // Verifica si el usuario es Invitado
            if (usuarioActual.Rol == "Invitado")
            {
                MessageBox.Show(
                    "Debe iniciar sesión o registrarse para poder contactar al vendedor.",
                    "Acción Requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Detiene la ejecución del método aquí
            }

            // 2. Si no es invitado, procede a enviar el mensaje
            string mensaje = $"Hola, quiero más información sobre: {publicacion.Titulo}";
            string url = $"https://wa.me/549{publicacion.Contacto}?text={Uri.EscapeDataString(mensaje)}";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir WhatsApp: " + ex.Message);
            }
        }
        private void botonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}