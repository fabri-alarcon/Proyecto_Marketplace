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
            this.usuarioActual = usuarioActual;

            // --- Cargar las categorías ---
            comboCategoria.Items.Add("Tecnología");
            comboCategoria.Items.Add("Hogar y Muebles");
            comboCategoria.Items.Add("Indumentaria");
            comboCategoria.Items.Add("Servicios");
            comboCategoria.Items.Add("Otros");
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.SelectedIndex = 0;
        }

        private void botonPublicar_Click_1(object sender, EventArgs e)
        {
            // ... (Todas tus validaciones de campos vacíos, precio y rutaImagenSeleccionada == null) ...
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
            else if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rutaImagenSeleccionada == null)
            {
                MessageBox.Show("Seleccione una imagen antes de publicar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string categoriaSeleccionada = comboCategoria.SelectedItem.ToString();

            string tipo = radioButtonProducto.Checked ? "Producto" : "Servicio";

            // --- Modificamos la creación de la publicación ---
            Publicacion nueva;
            if (tipo == "Producto")
            {
                nueva = new Publicacion(
                    textBoxTitulo.Text,
                    textBoxPrecio.Text,
                    textBoxDescripcion.Text,
                    rutaImagenSeleccionada, // Pasamos la RUTA (string)
                    usuarioActual.NombreUsuario,
                    usuarioActual.contacto,
                    "Disponible",
                    usuarioActual.NombreUsuario,
                    categoriaSeleccionada
                );
            }
            else
            {
                nueva = new Publicacion(
                    textBoxTitulo.Text,
                    rutaImagenSeleccionada, // Pasamos la RUTA (string)
                    textBoxDescripcion.Text,
                    usuarioActual.NombreUsuario,
                    usuarioActual.contacto,
                    usuarioActual.NombreUsuario,
                    categoriaSeleccionada
                );
            }
            // --- Fin de la modificación ---

            repoPublicaciones.AgregarPublicacion(nueva);
            repoPublicaciones.GuardarPublicaciones();

            MessageBox.Show("Publicación creada. Pasará a moderación antes de ser visible.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ... (Tu código de botonSeleccionarImagen_Click_1 y botonVolverAtras_Click se mantiene igual) ...
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

                    string nombreArchivo = $"{Guid.NewGuid()}{Path.GetExtension(dialogo.FileName)}";
                    string rutaDestino = Path.Combine(carpetaFotos, nombreArchivo);

                    if (pictureBoxPublicacion.Image != null)
                    {
                        pictureBoxPublicacion.Image.Dispose();
                        pictureBoxPublicacion.Image = null;
                    }

                    File.Copy(dialogo.FileName, rutaDestino, true);

                    using (var fs = new FileStream(rutaDestino, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxPublicacion.Image = new Bitmap(fs);
                    }

                    rutaImagenSeleccionada = rutaDestino;

                    MessageBox.Show("Imagen actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void botonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}