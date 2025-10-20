using Proyecto_Marketplace.clases;
using Proyecto_Marketplace.forms;

namespace Proyecto_Marketplace
{
    public partial class FormApp : Form
    {
        private Usuario usuarioActual;
        private FlowLayoutPanel flowPanel;
        private RepositorioPublicaciones repoPublicaciones = new RepositorioPublicaciones();

        public FormApp(Usuario usuario)
        {
            InitializeComponent();

            // Usuario actual
            usuarioActual = usuario ?? new Usuario("Invitado");

            // Configuración visual
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);

            // Foto de perfil
            pictureBox2.ImageLocation = usuarioActual.obtenerRutaFotoPerfil();

            // Crear y configurar el FlowLayoutPanel
            flowPanel = new FlowLayoutPanel
            {
                Width = 760,
                Height = 500,
                Left = 110,
                Top = 80,
                AutoScroll = true,
                Margin = new Padding(50),
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };
            this.Controls.Add(flowPanel);

            // Suscribirse al evento Load
            this.Load += FormApp_Load;

            // Mostrar botones según usuario
            if (usuarioActual.NombreUsuario == "Invitado")
            {
                botonCerrarSesion.Visible = false;
            }
            else
            {
                botonCerrarSesion.Visible = true;
                botonVolverLogin.Visible = false;
            }
        }

        // ========================
        // EVENTO LOAD DEL FORM
        // ========================
        private void FormApp_Load(object sender, EventArgs e)
        {
            // Si no hay publicaciones en JSON, cargar unas por defecto
            if (repoPublicaciones.Publicaciones.Count == 0)
            {
                repoPublicaciones.AgregarPublicacion(new Publicacion(
                    "Auriculares Inalámbricos",
                    "232",
                    "Excelente calidad de sonido",
                    CargarImagenSegura("media/auricularesImagen.jpeg"),
                    "43232",
                    "3644175829",
                    "Disponible",
                    "hdksa"
                ));

                repoPublicaciones.AgregarPublicacion(new Publicacion(
                    "Enanos en venta",
                    "500",
                    "Alta precisión y diseño ergonómico",
                    CargarImagenSegura("media/auricularesImagen.jpeg"),
                    "43232",
                    "3644544662",
                    "Vendido",
                    "Facundo Aguila"
                ));

                repoPublicaciones.GuardarPublicaciones();
            }

            MostrarPublicaciones();
        }

        // ========================
        // FUNCIONES AUXILIARES
        // ========================
        private Image CargarImagenSegura(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                    return Image.FromFile(ruta);
            }
            catch { }
            return null;
        }

        private void MostrarPublicaciones()
        {
            flowPanel.Controls.Clear();

            foreach (var pub in repoPublicaciones.Publicaciones)
            {
                Panel post = new Panel
                {
                    Width = 200,
                    Height = 250,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = pub,
                    Cursor = Cursors.Hand
                };

                PictureBox pb = new PictureBox
                {
                    Image = pub.Imagen ?? CargarImagenSegura("media/placeholder.png"),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 180,
                    Height = 170,
                    Top = 10,
                    Left = 10,
                    Cursor = Cursors.Hand
                };

                Label lblTitulo = new Label
                {
                    Text = pub.Titulo,
                    Top = 185,
                    Left = 10,
                    Width = 180,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };

                Label lblPrecio = new Label
                {
                    Text = "$" + pub.Precio,
                    Top = 205,
                    Left = 10,
                    Width = 180,
                    ForeColor = Color.Green,
                    Cursor = Cursors.Hand
                };

                post.Controls.Add(pb);
                post.Controls.Add(lblTitulo);
                post.Controls.Add(lblPrecio);

                // Registramos el evento click en todos los controles
                AgregarClickRecursivo(post, Post_Click);

                flowPanel.Controls.Add(post);
            }
        }

        // Función auxiliar que agrega el mismo evento click a todos los hijos
        private void AgregarClickRecursivo(Control control, EventHandler clickHandler)
        {
            control.Click += clickHandler;
            foreach (Control child in control.Controls)
            {
                AgregarClickRecursivo(child, clickHandler);
            }
        }

        private void Post_Click(object sender, EventArgs e)
        {
            //Buscamos el panel contenedor(sin importar cuántos niveles haya)
            Control actual = sender as Control;
            while (actual != null && actual is not Panel)
                actual = actual.Parent;

            if (actual is Panel panel && panel.Tag is Publicacion pub)
            {
                FormPublicacion ventana = new FormPublicacion(usuarioActual, pub);
                ventana.ShowDialog();
            }


        }

        // ========================
        // BOTONES GENERALES
        // ========================
        private void botonPerfil_Click(object sender, EventArgs e)
        {
            if (usuarioActual.NombreUsuario == "Invitado")
            {
                MessageBox.Show("Inicie sesión para acceder a más opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormProfile ventanaPerfil = new FormProfile(usuarioActual);
            ventanaPerfil.FotoPerfilCambiada += ActualizarFotoPerfil;
            ventanaPerfil.ShowDialog();

            RepositorioUsuarios.ActualizarUsuario(usuarioActual);
        }

        private void ActualizarFotoPerfil()
        {
            string ruta = usuarioActual.obtenerRutaFotoPerfil();
            if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
            {
                pictureBox2.Image?.Dispose();
                using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    pictureBox2.Image = new Bitmap(fs);
                }
            }
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            usuarioActual.NombreUsuario = "Invitado";
            MessageBox.Show("Has cerrado sesión.", "Sesión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonVolverLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonPublicar_Click_1(object sender, EventArgs e)
        {
            if (usuarioActual.NombreUsuario == "Invitado")
            {
                MessageBox.Show("Inicie sesión para acceder a más opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pasamos el usuario y el repositorio al constructor
            FormCrearPublicacion ventana = new FormCrearPublicacion(usuarioActual, repoPublicaciones);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                // 🔄 Refrescar publicaciones después de crear una nueva
                MostrarPublicaciones();
            }
        }
    }
}
