using Proyecto_Marketplace.clases;

namespace Proyecto_Marketplace.forms
{
    public partial class FormCrearPublicacion : Form
    {
        private RepositorioPublicaciones repoPublicaciones;
        private Usuario usuarioActual;
        private string rutaImagenSeleccionada;



        public FormCrearPublicacion(Usuario usuarioActual, RepositorioPublicaciones repoPublicaciones)
        {
            InitializeComponent();
            this.repoPublicaciones = repoPublicaciones;
            this.usuarioActual = usuarioActual; // guardamos el usuario logueado
        }

        private void botonPublicar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rutaImagenSeleccionada == null)
            {
                MessageBox.Show("Seleccione una imagen antes de publicar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear publicación dependiendo del tipo
            string tipo = radioButtonProducto.Checked ? "Producto" : "Servicio";

            Publicacion nueva = new Publicacion(
                textBoxTitulo.Text,
                textBoxPrecio.Text,
                textBoxDescripcion.Text,
                Image.FromFile(rutaImagenSeleccionada),
                usuarioActual.NombreUsuario,
                usuarioActual.contacto,
                "Disponible",
                tipo
            );

            repoPublicaciones.AgregarPublicacion(nueva);
            repoPublicaciones.GuardarPublicaciones();

            MessageBox.Show("Publicación creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonSeleccionarImagen_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Title = "Seleccionar nueva foto de Publicación";
                dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string carpetaFotos = Path.Combine(Application.StartupPath, "FotosPublicacion");
                    if (!Directory.Exists(carpetaFotos))
                        Directory.CreateDirectory(carpetaFotos);

                    // Generar un nombre único
                    string nombreArchivo = $"{Guid.NewGuid()}{Path.GetExtension(dialogo.FileName)}";
                    string rutaDestino = Path.Combine(carpetaFotos, nombreArchivo);

                    // Liberar imagen previa si ya había una cargada
                    if (pictureBoxPublicacion.Image != null)
                    {
                        pictureBoxPublicacion.Image.Dispose();
                        pictureBoxPublicacion.Image = null;
                    }

                    // Copiar la imagen seleccionada
                    File.Copy(dialogo.FileName, rutaDestino, true);

                    // Mostrar la imagen cargada en el PictureBox sin bloquear archivo
                    using (var fs = new FileStream(rutaDestino, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxPublicacion.Image = new Bitmap(fs);
                    }

                    // Guardamos internamente la ruta para usar al guardar la publicación
                    rutaImagenSeleccionada = rutaDestino;

                    MessageBox.Show("Imagen actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
