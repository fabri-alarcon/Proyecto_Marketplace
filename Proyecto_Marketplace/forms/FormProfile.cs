using Proyecto_Marketplace.clases;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Marketplace.forms
{
    public partial class FormProfile : Form
    {
        private Usuario usuarioActual;
        public event Action FotoPerfilCambiada; // Evento público
        public FormProfile(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));

            // Configuración visual de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Al cargar el formulario, se muestra la foto guardada (si tiene)
            this.Load += FormPerfil_Load;

            // --- CÓDIGO CORREGIDO EN PASO ANTERIOR ---
            // Carga los datos del usuario en los TextBoxes editables
            txtNombreUsuario.Text = usuarioActual.NombreUsuario;
            txtNombreUsuario.ReadOnly = true; // No dejamos cambiar el nombre
            txtNombreUsuario.BackColor = Color.Gray;
            txtContacto.Text = usuarioActual.contacto;
            txtCuil.Text = usuarioActual.Cuil;

            // Conectamos el botón de guardar
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // --- FIN DE CORRECCIÓN ---
        }

        // --- INICIO DE LA SOLUCIÓN AL ERROR DE BLOQUEO ---
        private void FormPerfil_Load(object sender, EventArgs e)
        {
            // Si el usuario tiene una ruta guardada y el archivo existe, mostrar la foto
            // En FormProfile.cs, dentro de FormPerfil_Load
            string rutaFoto = usuarioActual.obtenerRutaFotoPerfil();
            if (!string.IsNullOrEmpty(rutaFoto) && File.Exists(rutaFoto))
            {
                // Usamos un FileStream para cargar la imagen sin bloquear el archivo
                // (Igual que haces en tu boton_cambiarFoto_Click)
                using (var fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxPerfil.Image = new Bitmap(fs);
                }
            }
        }
        // --- FIN DE LA SOLUCIÓN ---

        // --- CÓDIGO CORREGIDO EN PASO ANTERIOR ---
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string nuevoContacto = txtContacto.Text.Trim();
            string nuevoCuil = txtCuil.Text.Trim();

            if (string.IsNullOrEmpty(nuevoContacto) || string.IsNullOrEmpty(nuevoCuil))
            {
                MessageBox.Show("El Contacto y el CUIL no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(nuevoContacto, out _) || !long.TryParse(nuevoCuil, out _))
            {
                MessageBox.Show("El Contacto y el CUIL deben ser solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuarioActual.contacto = nuevoContacto;
            usuarioActual.Cuil = nuevoCuil;

            bool exito = RepositorioUsuarios.ActualizarUsuario(usuarioActual);

            if (exito)
            {
                MessageBox.Show("Perfil actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar el perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // --- FIN DE CORRECCIÓN ---

        // Botón para cambiar la foto
        private void boton_cambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Seleccionar nueva foto de perfil";
            dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string carpetaFotos = Path.Combine(Application.StartupPath, "FotosPerfil");
                if (!Directory.Exists(carpetaFotos))
                    Directory.CreateDirectory(carpetaFotos);

                string nombreArchivo = $"{usuarioActual.NombreUsuario}_perfil{Path.GetExtension(dialogo.FileName)}";
                string rutaDestino = Path.Combine(carpetaFotos, nombreArchivo);

                // Liberar imagen previa (Tu código ya hacía esto bien)
                if (pictureBoxPerfil.Image != null)
                {
                    pictureBoxPerfil.Image.Dispose();
                    pictureBoxPerfil.Image = null;
                }

                File.Copy(dialogo.FileName, rutaDestino, true);

                // Cargar nueva imagen sin bloquear archivo
                using (var fs = new FileStream(rutaDestino, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxPerfil.Image = new Bitmap(fs);
                }

                // ACTUALIZAR el objeto actual y el repositorio
                usuarioActual.cambiarRutaFotoPerfil(rutaDestino);
                RepositorioUsuarios.ActualizarUsuario(usuarioActual);

                // Notificar cambio
                FotoPerfilCambiada?.Invoke();

                MessageBox.Show("Foto de perfil actualizada correctamente.");
            }
        }

        private void boton_eliminarFoto_Click(object sender, EventArgs e)
        {
            // En FormProfile.cs, dentro de boton_eliminarFoto_Click

            // 1. Guardamos la ruta en una variable local
            string ruta = usuarioActual.obtenerRutaFotoPerfil();

            // 2. Comprobamos esa variable
            if (!string.IsNullOrWhiteSpace(ruta) && File.Exists(ruta))
            {
                DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar la foto de perfil?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    if (pictureBoxPerfil.Image != null)
                    {
                        pictureBoxPerfil.Image.Dispose();
                        pictureBoxPerfil.Image = null;
                    }

                    // 3. Usamos la variable local 'ruta', que ya sabemos que no es null
                    File.Delete(ruta);

                    usuarioActual.cambiarRutaFotoPerfil("");
                    RepositorioUsuarios.ActualizarUsuario(usuarioActual);
                    FotoPerfilCambiada?.Invoke(); // Dispara el evento

                    MessageBox.Show("Foto de perfil eliminada correctamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna foto de perfil para eliminar.",
                   "Aviso",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void botonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}