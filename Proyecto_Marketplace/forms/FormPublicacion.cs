using Proyecto_Marketplace.clases;
using System.Diagnostics;


namespace Proyecto_Marketplace.forms
{
    public partial class FormPublicacion : Form
    {
        private Publicacion publicacion;
        private Usuario usuarioActual;
        public FormPublicacion(Usuario usuario, Publicacion publi)
        {
            InitializeComponent();
            this.Load += FormPublicacion_Load;
            // Usuario actual
            usuarioActual = usuario ?? new Usuario("Invitado");
            publicacion = publi;
        }

        private void FormPublicacion_Load(object sender, EventArgs e)
        {

            labelTitulo.Text = publicacion.Titulo;
            labelDescripcion.Text = publicacion.Descripcion;
            labelPrecio.Text = $"${publicacion.Precio}";
            labelTipo.Text = publicacion.Tipo;
            labelUsuario.Text = publicacion.UsuarioCreador;
            labelFechaPublicacion.Text = $"Publicado el: {publicacion.FechaPublicacion.ToString("dd / MM / yyyy")}";
            pictureBoxImagenPubli.Image = publicacion.Imagen;
        }

        private void botonEnviarMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = $"Hola, quiero más información sobre: {publicacion.Titulo}"; // Mensaje opcional
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

       
    }

}

