using Proyecto_Marketplace.clases;
using Proyecto_Marketplace.forms;
using System.Text;
using Proyecto_Marketplace.Controls; 

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
            comboCategoriaFiltro.Items.Add("Deporte");
            comboCategoriaFiltro.Items.Add("Vehiculos");
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
                // 1. Creamos nuestra nueva tarjeta personalizada
                PublicacionCard card = new PublicacionCard(pub);
                card.Tag = pub; // Asignamos la publicación al Tag (para el clic)
                card.Margin = new Padding(10); // El margen que tenías

                // 2. Conectamos el clic (reutilizamos tu método AgregarClickRecursivo)
                // Esto hará que la tarjeta Y sus hijos (imagen, texto) abran la publicación.
                AgregarClickRecursivo(card, Post_Click);

                // 3. Lógica de Admin (El menú "...")
                if (usuarioActual.Rol == "Admin")
                {
                    Button btnMenu = new Button
                    {
                        Text = "...",
                        Tag = pub,
                        Left = 150, // Posición en la esquina (200 - 30)
                        Top = 5,
                        Width = 25,
                        Height = 25,
                        Cursor = Cursors.Default
                    };
                    btnMenu.Click += BtnMenu_Click;

                    
                    card.Controls.Add(btnMenu);
                   
                    btnMenu.BringToFront();
                }

                flowPanel.Controls.Add(card);
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
            // 1. Identificamos qué control disparó el evento (puede ser la tarjeta, el texto o la imagen)
            Control control = sender as Control;

            // 2. Escalamos hacia arriba en la jerarquía hasta encontrar la "tarjeta" principal
            // (que es de tipo 'PublicacionCard')
            while (control != null && control is not PublicacionCard)
            {
                control = control.Parent;
            }

            // 3. Si encontramos la tarjeta (control) y no es nula...
            if (control is PublicacionCard card)
            {
                // 4. obtenemos la publicación que guardamos en su 'Tag' y abrimos el detalle
                if (card.Tag is Publicacion pub)
                {
                    FormPublicacion ventana = new FormPublicacion(usuarioActual, pub);
                    ventana.ShowDialog();
                }
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

            // --- ¡MODIFICACIÓN! ---
            // Ahora le pasamos el 'usuarioActual' Y el 'repoPublicaciones'
            FormProfile ventanaPerfil = new FormProfile(usuarioActual, repoPublicaciones);
            // --- FIN DE LA MODIFICACIÓN ---

            ventanaPerfil.FotoPerfilCambiada += ActualizarFotoPerfil;
            ventanaPerfil.ShowDialog();

            // Actualizamos al usuario por si cambió su Contacto/CUIL
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