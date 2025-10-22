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


            labelNombreUsuario.Text = usuarioActual.NombreUsuario;
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            // Si el usuario tiene una ruta guardada y el archivo existe, mostrar la foto
            if (!string.IsNullOrEmpty(usuarioActual.obtenerRutaFotoPerfil()) && File.Exists(usuarioActual.obtenerRutaFotoPerfil()))
            {
                pictureBoxPerfil.Image = new Bitmap(usuarioActual.obtenerRutaFotoPerfil());
            }
        }

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

                // Liberar imagen previa
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
            if (!string.IsNullOrWhiteSpace(usuarioActual.obtenerRutaFotoPerfil()) && File.Exists(usuarioActual.obtenerRutaFotoPerfil()))
            {
                DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar la foto de perfil?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

                if (resultado == DialogResult.Yes)
                {
                    string ruta = usuarioActual.obtenerRutaFotoPerfil();

                    if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                    {
                        // 1. Liberar el recurso antes de eliminar
                        if (pictureBoxPerfil.Image != null)
                        {
                            pictureBoxPerfil.Image.Dispose();
                            pictureBoxPerfil.Image = null;
                        }

                        //  2. Intentar eliminar ahora que está liberado
                        File.Delete(ruta);
                    }

                    // 3. Actualizar la información del usuario
                    usuarioActual.cambiarRutaFotoPerfil("");
                    RepositorioUsuarios.ActualizarUsuario(usuarioActual);

                    // 4. Notificar cambio
                    FotoPerfilCambiada?.Invoke();

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
