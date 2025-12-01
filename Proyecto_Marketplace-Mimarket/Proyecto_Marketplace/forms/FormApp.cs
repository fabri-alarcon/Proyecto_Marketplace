using Proyecto_Marketplace.clases;
using Proyecto_Marketplace.forms;
using System.Text;
using Proyecto_Marketplace.Controls;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

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

            // --- Carga de Foto de Perfil (USO DE LA FUNCIÓN DE CARGA SEGURA)
            ActualizarFotoPerfil();

            // --- Configuración del FlowLayoutPanel ---
            flowPanel = new FlowLayoutPanel
            {
                Width = 760,
                Height = 500,
                Left = 150,
                Top = 80,
                AutoScroll = true,
                Margin = new Padding(50),
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };
            this.Controls.Add(flowPanel);

            this.Load += FormApp_Load;

            //Lógica de Visibilidad según Rol
            if (usuarioActual.NombreUsuario == "Invitado")
            {
                botonCerrarSesion.Visible = false;
                botonModerar.Visible = false;
                botonPublicar.Visible = false; // Los invitados no pueden publicar
                botonVolverLogin.Visible = true;
            }
            else
            {
                botonCerrarSesion.Visible = true;
                botonVolverLogin.Visible = false;
                botonModerar.Visible = (usuarioActual.Rol == "Admin");

                // Ocultar "Publicar" si es Admin, mostrar si es Usuario normal
                botonPublicar.Visible = (usuarioActual.Rol != "Admin");

            }

            //Carga del ComboBox de Filtro de Categorías
            comboCategoriaFiltro.Items.Add("Todas");
            comboCategoriaFiltro.Items.Add("Tecnología");
            comboCategoriaFiltro.Items.Add("Hogar y Muebles");
            comboCategoriaFiltro.Items.Add("Indumentaria");
            comboCategoriaFiltro.Items.Add("Deporte");
            comboCategoriaFiltro.Items.Add("Vehiculos");
            comboCategoriaFiltro.Items.Add("Otros");
            comboCategoriaFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoriaFiltro.SelectedIndex = 0;

            //Conexión de Eventos
            botonBuscar.Click += new EventHandler(AplicarFiltros_Click);
            botonModerar.Click += new EventHandler(BotonModerar_Click);
            comboCategoriaFiltro.SelectedIndexChanged += new EventHandler(AplicarFiltros_Click);
        }


        private void FormApp_Load(object sender, EventArgs e)
        {
            repoPublicaciones.CargarPublicaciones();

            if (repoPublicaciones.Publicaciones.Count == 0)
            {

                string RutaAuricular = Path.Combine(Application.StartupPath, "media", "auricularesImagen.jpeg");
                string RutaTele = Path.Combine(Application.StartupPath, "media", "tele.jpeg");
                string RutaAlbañil = Path.Combine(Application.StartupPath, "media", "revoque_apli.jpeg");

                Publicacion p1 = new Publicacion(
                    "Auriculares Inalámbricos",
                    "232",
                    "Excelente calidad de sonido",
                    new List<string> { RutaAuricular },
                    "Centro",
                    "3644175829",
                    "Disponible",
                    "AdminDemo",
                    "Tecnología"
                );
                p1.EstadoModeracion = "Aprobado";

                Publicacion p2 = new Publicacion(
                    "Vendo tele smart 42' ",
                    "5000", // precio
                    "¡Tecnología clave para disfrutar en familia!",
                    new List<string> { RutaTele },
                    "Ensanche Sur",
                    "000",
                    "Disponible",
                    "AdminDemo",
                    "Tecnología"
                );
                p2.EstadoModeracion = "Aprobado";
                //La cantidad de parametros diferencian entre producto (9) y servicio (8)
                // (titulo, precio, List<string>, descripcion, ubicacion, contacto, usuario, categoria)
                Publicacion p3 = new Publicacion(
                    "Ofrezco servicios de construcción",
                    "100000", // precio
                    new List<string> { RutaAlbañil },
                    "Buena calidad de construcción",
                    "A domicilio",
                    "000",
                    "AdminDemo",
                    "Otros"
                );
                p3.EstadoModeracion = "Aprobado";

                repoPublicaciones.AgregarPublicacion(p1);
                repoPublicaciones.AgregarPublicacion(p2);
                repoPublicaciones.AgregarPublicacion(p3);
            }

            CargarSugerenciasBusqueda();
            filtroModeracionActual = "Aprobado";
            MostrarPublicaciones();
        }


        // FUNCIONES AUXILIARES
        // Esta función se utiliza para cargar las imágenes de las publicaciones, 
        // donde se le pasa la ruta absoluta.
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
                PublicacionCard card = new PublicacionCard(pub);
                card.Tag = pub;
                card.Margin = new Padding(10);

                // Conectamos el clic principal
                AgregarClickRecursivo(card, Post_Click);

                // Lógica de 3 puntitos arriba del post
                if (usuarioActual.Rol == "Admin" || pub.UsuarioCreador == usuarioActual.NombreUsuario)
                {
                    Button btnMenu = new Button
                    {
                        Text = "...",
                        Tag = pub,
                        Left = 150,
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
            Control control = sender as Control;

            while (control != null && control is not PublicacionCard)
            {
                control = control.Parent;
            }

            if (control is PublicacionCard card)
            {
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
            if (pubSeleccionada == null) return;

            if (usuarioActual.Rol == "Admin")
            {

                adminContextMenu.Tag = pubSeleccionada;
                aprobarToolStripMenuItem.Visible = (filtroModeracionActual == "Pendiente");
                adminContextMenu.Show(btn, new Point(0, btn.Height));
            }
            else if (pubSeleccionada.UsuarioCreador == usuarioActual.NombreUsuario)
            {

                ContextMenuStrip userMenu = new ContextMenuStrip();

                ToolStripMenuItem infoItem = new ToolStripMenuItem("Información");
                infoItem.Tag = pubSeleccionada;
                infoItem.Click += infoToolStripMenuItem_Click;

                ToolStripMenuItem deleteItem = new ToolStripMenuItem("Eliminar");
                deleteItem.Tag = pubSeleccionada;
                deleteItem.Click += eliminarToolStripMenuItem_Click;

                userMenu.Items.Add(infoItem);
                userMenu.Items.Add(new ToolStripSeparator());
                userMenu.Items.Add(deleteItem);

                userMenu.Show(btn, new Point(0, btn.Height));
            }
        }

        private void aprobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicacion pubAprobar = null;
            if (sender is ToolStripMenuItem itemAprobar)
            {
                pubAprobar = itemAprobar.Tag as Publicacion;
            }

            if (pubAprobar == null && (sender as ToolStripItem)?.Owner is ContextMenuStrip menu) // Fallback para Admin
            {
                pubAprobar = menu.Tag as Publicacion;
            }

            if (pubAprobar != null)
            {
                repoPublicaciones.AprobarPublicacion(pubAprobar);
                MostrarPublicaciones();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicacion pubAEliminar = null;
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item != null)
            {
                pubAEliminar = item.Tag as Publicacion;

                if (pubAEliminar == null && item.Owner is ContextMenuStrip menu)
                {
                    pubAEliminar = menu.Tag as Publicacion;
                }
            }


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
            Publicacion pubInfo = null;
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item != null)
            {

                pubInfo = item.Tag as Publicacion;

                if (pubInfo == null && item.Owner is ContextMenuStrip menu)
                {
                    pubInfo = menu.Tag as Publicacion;
                }
            }

            if (pubInfo == null) return;

            // Se usa la clase estática RepositorioUsuarios
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

            FormProfile ventanaPerfil = new FormProfile(usuarioActual, repoPublicaciones);

            ventanaPerfil.FotoPerfilCambiada += ActualizarFotoPerfil;
            ventanaPerfil.ShowDialog();

            // Se usa la clase estática RepositorioUsuarios
            RepositorioUsuarios.ActualizarUsuario(usuarioActual);
        }

        // FUNCIÓN CORREGIDA: Ahora carga la foto personalizada o el placeholder.
        private void ActualizarFotoPerfil()
        {
            string rutaRelativa = usuarioActual.obtenerRutaFotoPerfil();

            pictureBox2.Image?.Dispose();
            pictureBox2.Image = null; // Limpiar

            if (!string.IsNullOrEmpty(rutaRelativa))
            {
                try
                {
                    string rutaAbsoluta = Path.Combine(Application.StartupPath, rutaRelativa);

                    if (File.Exists(rutaAbsoluta))
                    {
                        using (var fs = new FileStream(rutaAbsoluta, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox2.Image = new Bitmap(fs);
                            return; // Imagen personalizada cargada, salir
                        }
                    }
                }
                catch { /* Ignorar errores de carga de la foto personalizada */ }
            }

            // Si la ruta está vacía/nula o la carga falló, cargamos el placeholder (perfilPredeterminado.jpg).
            try
            {
                string placeholderPath = Path.Combine(Application.StartupPath, "media", "perfilPredeterminado.jpg");

                if (File.Exists(placeholderPath))
                {
                    using (var fs = new FileStream(placeholderPath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox2.Image = new Bitmap(fs);
                    }
                }
                else
                {
                    // Fallback final: Bitmap vacío si ni siquiera el placeholder existe.
                    pictureBox2.Image = new Bitmap(100, 100);
                }
            }
            catch { /* Ignorar errores del placeholder */ }
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            Sesion.UsuarioActual = new Usuario("Invitado");

            MessageBox.Show("Has cerrado sesión.", "Sesión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonVolverLogin_Click(object sender, EventArgs e)
        {
            Sesion.UsuarioActual = new Usuario("Invitado");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonPublicar_Click_1(object sender, EventArgs e)
        {

            if (usuarioActual.NombreUsuario == "Invitado" || usuarioActual.Rol == "Admin")
            {
                MessageBox.Show("No tiene permisos para realizar esta acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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