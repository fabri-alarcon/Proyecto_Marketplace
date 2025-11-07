using Proyecto_Marketplace.clases;
using System.IO;

// Asegúrate de que el namespace coincida con tu nueva carpeta
namespace Proyecto_Marketplace.Controls
{
    public partial class PublicacionCard : UserControl
    {
        private Publicacion _publicacion; // Para guardar la publicación

        // Este es el "cerebro": un constructor que recibe la publicación
        public PublicacionCard(Publicacion pub)
        {
            InitializeComponent();
            _publicacion = pub;

            // Llenamos los controles que diseñamos
            lblTitulo.Text = pub.Titulo;
            lblPrecio.Text = $"${pub.Precio}";
            pbImagen.Image = CargarImagenSegura(pub.RutaImagen);
        }

        // Copiamos la función auxiliar que ya tenías en FormApp
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
    }
}
