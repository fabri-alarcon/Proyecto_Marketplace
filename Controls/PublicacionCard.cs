using Proyecto_Marketplace.clases;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Marketplace.Controls
{
    public partial class PublicacionCard : UserControl
    {
        private Publicacion _publicacion;
        private Color colorOriginal;

        public PublicacionCard(Publicacion pub)
        {
            InitializeComponent();
            _publicacion = pub;

            string rutaPrimeraImagen = pub.RutasImagenes.FirstOrDefault();

            lblTitulo.Text = pub.Titulo;

            // --- INICIO DE CORRECCIÓN: Lógica de Precio y "Gratis" ---
            // Esto corrige que se vea "$0.00" en lugar de "Gratis"
            if (decimal.TryParse(_publicacion.Precio, out decimal precio) && precio > 0)
            {
                lblPrecio.Text = precio.ToString("C2");
            }
            else
            {
                lblPrecio.Text = "Gratis";
            }
            // --- FIN DE CORRECCIÓN ---

            pbImagen.Image = CargarImagenSegura(rutaPrimeraImagen);

            // --- Animación Hover ---
            colorOriginal = this.BackColor;
            this.MouseEnter += PublicacionCard_MouseEnter;
            this.MouseLeave += PublicacionCard_MouseLeave;
            lblTitulo.MouseEnter += PublicacionCard_MouseEnter;
            lblTitulo.MouseLeave += PublicacionCard_MouseLeave;
            lblPrecio.MouseEnter += PublicacionCard_MouseEnter;
            lblPrecio.MouseLeave += PublicacionCard_MouseLeave;
            pbImagen.MouseEnter += PublicacionCard_MouseEnter;
            pbImagen.MouseLeave += PublicacionCard_MouseLeave;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // --- Métodos de Hover ---
        private void PublicacionCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void PublicacionCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = colorOriginal;
        }
        // ------------------------

        // Ahora recibe la ruta relativa y la convierte en absoluta para cargar
        private Image CargarImagenSegura(string rutaRelativa)
        {
            try
            {
                if (!string.IsNullOrEmpty(rutaRelativa))
                {
                    // Obtener la ruta absoluta
                    string rutaAbsoluta = Path.Combine(Application.StartupPath, rutaRelativa);

                    if (File.Exists(rutaAbsoluta))
                    {
                        // Intentamos abrir la imagen de la nueva ruta
                        using (var fs = new FileStream(rutaAbsoluta, FileMode.Open, FileAccess.Read))
                        {
                            return new Bitmap(fs);
                        }
                    }
                }
            }
            catch { }

            // Lógica para MANEJAR IMÁGENES VIEJAS O PERDIDAS
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