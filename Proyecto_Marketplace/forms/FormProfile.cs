using Proyecto_Marketplace.clases;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq; 

namespace Proyecto_Marketplace.forms
{
    public partial class FormProfile : Form
    {
        private Usuario usuarioActual;
        private RepositorioPublicaciones repoPublicaciones;
        public event Action FotoPerfilCambiada;
        public FormProfile(Usuario usuario, RepositorioPublicaciones repo)
        {
            InitializeComponent();
            usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            repoPublicaciones = repo;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Load += FormPerfil_Load;

            //Relleno de campos...
            txtNombreUsuario.Text = usuarioActual.NombreUsuario;
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.BackColor = Color.Gray;
            txtContacto.Text = usuarioActual.contacto;
            txtCuil.Text = usuarioActual.Cuil;
            labelNombreUsuario.Text = usuarioActual.NombreUsuario;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            // Cargar la foto (código sin bloqueo)
            string ruta = usuarioActual.obtenerRutaFotoPerfil();
            if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
            {
                using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxPerfil.Image = new Bitmap(fs);
                }
            }

            // --- Carga el historial al abrir el formulario ---
            CargarHistorialPublicaciones();
        }


        private void CargarHistorialPublicaciones()
        {
            // Asumiendo que 'flowHistorial' existe
            flowHistorial.Controls.Clear();

            var misPublicaciones = repoPublicaciones.Publicaciones
                .Where(p => p.UsuarioCreador == usuarioActual.NombreUsuario)
                .OrderByDescending(p => p.FechaPublicacion)
                .ToList();

            if (misPublicaciones.Count == 0)
            {
                Label lblVacio = new Label();
                lblVacio.Text = "Aún no has creado publicaciones.";
                lblVacio.ForeColor = Color.White;
                lblVacio.AutoSize = true;
                flowHistorial.Controls.Add(lblVacio);
                return;
            }

            foreach (var pub in misPublicaciones)
            {
                Panel miniPanel = new Panel
                {
                    Width = 150,
                    Height = 150,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Tag = pub,
                    Cursor = Cursors.Hand
                };

                PictureBox miniPb = new PictureBox
                {

                    Image = CargarImagenSegura(pub.RutasImagenes.FirstOrDefault()),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 100,
                    BackColor = Color.Transparent
                };

                Label miniTitulo = new Label
                {
                    Text = pub.Titulo,
                    ForeColor = Color.Black,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 50
                };
                //Eventos de mouse
                miniPanel.MouseEnter += new EventHandler(miniPanel_MouseEnter);
                miniPanel.MouseLeave += new EventHandler(miniPanel_MouseLeave);
                miniPb.MouseEnter += new EventHandler(miniPanel_MouseEnter);
                miniPb.MouseLeave += new EventHandler(miniPanel_MouseLeave);
                miniTitulo.MouseEnter += new EventHandler(miniPanel_MouseEnter);
                miniTitulo.MouseLeave += new EventHandler(miniPanel_MouseLeave);

                miniPanel.Click += new EventHandler(miniPanel_Click);
                miniPb.Click += new EventHandler(miniPanel_Click);
                miniTitulo.Click += new EventHandler(miniPanel_Click);

                miniPanel.Controls.Add(miniTitulo);
                miniPanel.Controls.Add(miniPb);
                flowHistorial.Controls.Add(miniPanel);
            }
        }

        private void miniPanel_Click(object sender, EventArgs e)
        {
            //Identifico qué control disparó el evento (Panel, Label o PictureBox)
            Control control = sender as Control;

            //Si fue un hijo (Label/PictureBox), subimos al Panel principal
            if (control is not Panel)
            {
                control = control.Parent;
            }
            Panel panel = control as Panel;

            //Obtenemos la publicación que guardamos en el Tag
            if (panel != null && panel.Tag is Publicacion pub)
            {
                //Abre FormPublicacion
                FormPublicacion ventanaDetalle = new FormPublicacion(usuarioActual, pub);
                ventanaDetalle.ShowDialog();
            }
        }
        private void miniPanel_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control is not Panel)
            {
                control = control.Parent;
            }
            Panel panel = control as Panel;

            if (panel != null)
            {
                panel.BackColor = Color.LightGray;
                panel.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void miniPanel_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control is not Panel)
            {
                control = control.Parent;
            }
            Panel panel = control as Panel;

            if (panel != null)
            {
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private Image CargarImagenSegura(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                        return new Bitmap(fs);
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

            // Validación de Contacto (ej: 6 a 15 dígitos)
            if (nuevoContacto.Length < 6 || nuevoContacto.Length > 15)
            {
                MessageBox.Show("El número de Contacto no parece válido. Debe tener entre 6 y 15 dígitos.", "Error de Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de duplicados (Usa la clase estática RepositorioUsuarios)
            if (nuevoCuil != usuarioActual.Cuil && RepositorioUsuarios.ExisteCuil(nuevoCuil))
            {
                MessageBox.Show("Ese CUIL ya está en uso por otra cuenta.", "Error"); return;
            }
            if (nuevoContacto != usuarioActual.contacto && RepositorioUsuarios.ExisteContacto(nuevoContacto))
            {
                MessageBox.Show("Ese Contacto ya está en uso por otra cuenta.", "Error"); return;
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

                if (pictureBoxPerfil.Image != null)
                {
                    pictureBoxPerfil.Image.Dispose();
                    pictureBoxPerfil.Image = null;
                }

                File.Copy(dialogo.FileName, rutaDestino, true);

                using (var fs = new FileStream(rutaDestino, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxPerfil.Image = new Bitmap(fs);
                }

                usuarioActual.cambiarRutaFotoPerfil(rutaDestino);
                RepositorioUsuarios.ActualizarUsuario(usuarioActual);

                FotoPerfilCambiada?.Invoke();

                MessageBox.Show("Foto de perfil actualizada correctamente.");
            }
        }

        private void boton_eliminarFoto_Click(object sender, EventArgs e)
        {
            string ruta = usuarioActual.obtenerRutaFotoPerfil();

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
                    if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                    {
                        if (pictureBoxPerfil.Image != null)
                        {
                            pictureBoxPerfil.Image.Dispose();
                            pictureBoxPerfil.Image = null;
                        }

                        File.Delete(ruta);
                    }

                    usuarioActual.cambiarRutaFotoPerfil("");
                    RepositorioUsuarios.ActualizarUsuario(usuarioActual);

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

        private void flowHistorial_Click(object sender, EventArgs e)
        {
            // Este método está vacío.
        }

       
    }
}