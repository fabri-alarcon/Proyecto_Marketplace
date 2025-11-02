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
            usuarioActual = usuario ?? new Usuario("Invitado");
            publicacion = publi;
        }

        private void FormPublicacion_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = publicacion.Titulo;
            labelDescripcion.Text = publicacion.Descripcion;
            labelPrecio.Text = $"${publicacion.Precio}";
            labelTipo.Text = publicacion.Tipo;
            
            // Esta línea es correcta. Si 'publicacion.UsuarioCreador' está vacío,
            // es un problema de datos viejos en tu 'publicaciones.json'.
            labelUsuario.Text = publicacion.UsuarioCreador; 
            
            // Esta línea es correcta y NO muestra la hora.
            labelFechaPublicacion.Text = $"Publicado el: {publicacion.FechaPublicacion.ToString("dd / MM / yyyy")}";

            pictureBoxImagenPubli.Image = CargarImagenSegura(publicacion.RutaImagen);
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

            // Devolver placeholder si falla o no existe
            try
            {
                string placeholderPath = Path.Combine(Application.StartupPath, "media", "placeholder.png");
                if (File.Exists(placeholderPath))
                    return Image.FromFile(placeholderPath);
            }
            catch { }

            // MODIFICACIÓN: Devolvemos un Bitmap vacío en lugar de 'null'
            // para evitar que el programa falle si no encuentra el placeholder.
            return new Bitmap(100, 100); 
        }
        
        private void botonEnviarMensaje_Click(object sender, EventArgs e)
        {
            // (Tu código aquí es perfecto y no necesita cambios)
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