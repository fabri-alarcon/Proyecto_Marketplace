using Proyecto_Marketplace.clases;
using Proyecto_Marketplace.forms;
using System.Text;

namespace Proyecto_Marketplace
{
    public partial class FormApp : Form
    {
        private Usuario usuarioActual;
        private FlowLayoutPanel flowPanel;
        private RepositorioPublicaciones repoPublicaciones = new RepositorioPublicaciones();
        private string filtroModeracionActual = "Aprobado";

        public FormApp(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario ?? new Usuario("Invitado");

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);

            // --- CORRECCIÓN DE ERROR DE NULOS (de antes) ---
            string rutaFoto = usuarioActual.obtenerRutaFotoPerfil();
            if (!string.IsNullOrEmpty(rutaFoto) && File.Exists(rutaFoto))
            {
                pictureBox2.ImageLocation = rutaFoto;
            }

            flowPanel = new FlowLayoutPanel
            {
                Width = 760,
                Height = 460,
                Left = 110,
                Top = 80,
                AutoScroll = true,
                Margin = new Padding(50),
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };
            this.Controls.Add(flowPanel);

            this.Load += FormApp_Load;

            if (usuarioActual.NombreUsuario == "Invitado")
            {
                botonCerrarSesion.Visible = false;
                botonModerar.Visible = false;
            }
            else
            {
                botonCerrarSesion.Visible = true;
                botonVolverLogin.Visible = false;
                botonModerar.Visible = (usuarioActual.Rol == "Admin");
            }

            comboCategoriaFiltro.Items.Add("Todas");
            comboCategoriaFiltro.Items.Add("Tecnología");
            comboCategoriaFiltro.Items.Add("Hogar y Muebles");
            comboCategoriaFiltro.Items.Add("Indumentaria");
            comboCategoriaFiltro.Items.Add("Servicios");
            comboCategoriaFiltro.Items.Add("Otros");
            comboCategoriaFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoriaFiltro.SelectedIndex = 0;

            botonBuscar.Click += new EventHandler(AplicarFiltros_Click);
            botonModerar.Click += new EventHandler(BotonModerar_Click);
            comboCategoriaFiltro.SelectedIndexChanged += new EventHandler(AplicarFiltros_Click);
        }

        // ========================
        // EVENTO LOAD DEL FORM (¡CORREGIDO!)
        // ========================
        private void FormApp_Load(object sender, EventArgs e)
        {
            // --- ¡ESTA LÍNEA ES LA SOLUCIÓN! ---
            // 1. Carga el archivo .json ANTES de hacer nada más.
            repoPublicaciones.CargarPublicaciones();
            // --- FIN DE LA SOLUCIÓN ---

            // 2. Ahora sí, comprueba si el archivo cargado estaba vacío.
            if (repoPublicaciones.Publicaciones.Count == 0)
            {
                // Si estaba vacío, crea las muestras
                Publicacion p1 = new Publicacion(
                    "Auriculares Inalámbricos",
                    "232",
                    "Excelente calidad de sonido",
                    "media/auricularesImagen.jpeg",
                    "43232",
                    "3644175829",
                    "Disponible",
                    "AdminDemo", // Usuario Creador de Muestra
                    "Tecnología"
                );
                p1.EstadoModeracion = "Aprobado"; // Fuerza la aprobación

                Publicacion p2 = new Publicacion(
                    "Enanos en venta",
                    "500",
                    "Alta precisión y diseño ergonómico",
                    "media/auricularesImagen.jpeg",
                    "43232",
                    "3644544662",
                    "Vendido",
                    "AdminDemo", // Usuario Creador de Muestra
                    "Otros"
                );
                p2.EstadoModeracion = "Aprobado"; // Fuerza la aprobación

                repoPublicaciones.AgregarPublicacion(p1);
                repoPublicaciones.AgregarPublicacion(p2);
                // (AgregarPublicacion ya llama a GuardarPublicaciones)
            }

            CargarSugerenciasBusqueda();
            // 3. Muestra las publicaciones "Aprobadas" que se cargaron del JSON
            filtroModeracionActual = "Aprobado";
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

        // (El resto de tus funciones: MostrarPublicaciones, AgregarClickRecursivo, Post_Click, 
        //  CargarSugerenciasBusqueda, AplicarFiltros_Click, BotonModerar_Click, 
        //  los eventos del ContextMenu, botonPerfil_Click, etc.
        //  ya estaban correctas y se mantienen igual)

        private void MostrarPublicaciones()
        {
            flowPanel.Controls.Clear();
            string categoria = comboCategoriaFiltro.SelectedItem?.ToString() ?? "Todas";
            string busqueda = textBoxBusqueda.Text.ToLower();

            var publicacionesAMostrar = repoPublicaciones.Publicaciones
                .Where(p => p.EstadoModeracion == filtroModeracionActual);

            if (categoria != "Todas")
            {
                publicacionesAMostrar = publicacionesAMostrar
                    .Where(p => p.Categoria == categoria);
            }

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                publicacionesAMostrar = publicacionesAMostrar
                    .Where(p => p.Titulo.ToLower().Contains(busqueda) ||
                                p.Descripcion.ToLower().Contains(busqueda));
            }

            foreach (var pub in publicacionesAMostrar)
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
                    Image = CargarImagenSegura(pub.RutaImagen),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 180,
                    Height = 170,
                    Top = 10,
                    Left = 10,
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent
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

                if (usuarioActual.Rol == "Admin")
                {
                    Button btnMenu = new Button
                    {
                        Text = "...",
                        Tag = pub,
                        Left = pb.Width - 30,
                        Top = 5,
                        Width = 25,
                        Height = 25,
                        Font = new Font("Arial", 8, FontStyle.Bold),
                        Cursor = Cursors.Default
                    };

                    btnMenu.Click += BtnMenu_Click;
                    pb.Controls.Add(btnMenu);
                }

                AgregarClickRecursivo(post, Post_Click);

                flowPanel.Controls.Add(post);
            }
        }

        private void AgregarClickRecursivo(Control control, EventHandler clickHandler)
        {
            if (control is not Button)
            {
                control.Click += clickHandler;
            }

            foreach (Control child in control.Controls)
            {
                AgregarClickRecursivo(child, clickHandler);
            }
        }

        private void Post_Click(object sender, EventArgs e)
        {
            Control actual = sender as Control;
            while (actual != null && actual is not Panel)
                actual = actual.Parent;

            if (actual is Panel panel && panel.Tag is Publicacion pub)
            {
                FormPublicacion ventana = new FormPublicacion(usuarioActual, pub);
                ventana.ShowDialog();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Publicacion pubSeleccionada = btn.Tag as Publicacion;

            if (pubSeleccionada != null)
            {
                adminContextMenu.Tag = pubSeleccionada;
                aprobarToolStripMenuItem.Visible = (filtroModeracionActual == "Pendiente");
                adminContextMenu.Show(btn, new Point(0, btn.Height));
            }
        }

        private void aprobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicacion pubAprobar = adminContextMenu.Tag as Publicacion;

            if (pubAprobar != null)
            {
                repoPublicaciones.AprobarPublicacion(pubAprobar);
                MostrarPublicaciones();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicacion pubAEliminar = adminContextMenu.Tag as Publicacion;

            if (pubAEliminar != null)
            {
                var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar '{pubAEliminar.Titulo}'?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    repoPublicaciones.EliminarPublicacion(pubAEliminar);
                    MostrarPublicaciones();
                }
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicacion pubInfo = adminContextMenu.Tag as Publicacion;
            if (pubInfo == null) return;

            Usuario creador = RepositorioUsuarios.BuscarPorNombre(pubInfo.UsuarioCreador);

            StringBuilder info = new StringBuilder();
            info.AppendLine($"--- Info Publicación ---");
            info.AppendLine($"Título: {pubInfo.Titulo}");
            info.AppendLine($"Fecha: {pubInfo.FechaPublicacion.ToString("dd/MM/yyyy HH:mm")}");
            info.AppendLine($"Categoría: {pubInfo.Categoria}");
            info.AppendLine($"Estado: {pubInfo.EstadoModeracion}");
            info.AppendLine();
            info.AppendLine($"--- Info Creador ---");

            if (creador != null)
            {
                info.AppendLine($"Nombre: {creador.NombreUsuario}");
                info.AppendLine($"Contacto (WhatsApp): {creador.contacto}");
                info.AppendLine($"Rol: {creador.Rol}");
            }
            else
            {
                info.AppendLine($"Nombre: {pubInfo.UsuarioCreador} (Usuario no encontrado)");
            }

            MessageBox.Show(info.ToString(), "Información de Publicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarSugerenciasBusqueda()
        {
            var autoComplete = new AutoCompleteStringCollection();
            var titulos = repoPublicaciones.Publicaciones
                .Where(p => p.EstadoModeracion == filtroModeracionActual)
                .Select(p => p.Titulo)
                .Distinct();

            autoComplete.AddRange(titulos.ToArray());

            textBoxBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxBusqueda.AutoCompleteCustomSource = autoComplete;
        }

        private void AplicarFiltros_Click(object sender, EventArgs e)
        {
            if (usuarioActual.Rol != "Admin")
            {
                filtroModeracionActual = "Aprobado";
            }
            MostrarPublicaciones();
        }

        private void BotonModerar_Click(object sender, EventArgs e)
        {
            if (filtroModeracionActual == "Aprobado")
            {
                filtroModeracionActual = "Pendiente";
                botonModerar.Text = "Ver Aprobadas";
                botonModerar.BackColor = Color.Salmon;
            }
            else
            {
                filtroModeracionActual = "Aprobado";
                botonModerar.Text = "Moderar";
                botonModerar.BackColor = SystemColors.Control;
            }

            textBoxBusqueda.Text = "";
            comboCategoriaFiltro.SelectedIndex = 0;

            MostrarPublicaciones();
            CargarSugerenciasBusqueda();
        }

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
            // --- CORRECCIÓN ---
            // No modificamos el 'usuarioActual'. 
            // Creamos un nuevo "Invitado" para la sesión.
            Sesion.UsuarioActual = new Usuario("Invitado");
            // --- FIN DE LA CORRECCIÓN ---

            MessageBox.Show("Has cerrado sesión.", "Sesión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonVolverLogin_Click(object sender, EventArgs e)
        {
            // --- CORRECCIÓN ---
            // También nos aseguramos de limpiar la sesión al volver
            Sesion.UsuarioActual = new Usuario("Invitado");
            // --- FIN DE LA CORRECCIÓN ---

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

            FormCrearPublicacion ventana = new FormCrearPublicacion(usuarioActual, repoPublicaciones);
            ventana.ShowDialog();

            if (usuarioActual.Rol == "Admin" && filtroModeracionActual == "Pendiente")
            {
                MostrarPublicaciones();
            }
        }
    }
}