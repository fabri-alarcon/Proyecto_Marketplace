using Proyecto_Marketplace.clases;
using Proyecto_Marketplace.forms;

namespace Proyecto_Marketplace
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //Control de tama�o de la ventana formlogin
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bordes fijos
            this.MaximizeBox = false; // Deshabilita el bot�n maximizar
            this.MinimizeBox = true; // Puedes dejar minimizar si quieres
            this.StartPosition = FormStartPosition.CenterScreen; // Para que aparezca centrada
            this.Size = new Size(600, 400); // Tama�o fijo de la ventana

        }

        public Usuario UsuarioLogeado { get; private set; }




        // Bot�n para iniciar sesi�n
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {

            string nombre = textUsuario.Text.Trim();
            string contrasenia = textContrasenia.Text;

            // Buscar usuario
            var usuario = RepositorioUsuarios.BuscarPorNombre(nombre);

            // Validar credenciales
            if (usuario == null || usuario.Contrase�a != contrasenia)
            {
                MessageBox.Show("Usuario o contrase�a incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar el usuario en la sesi�n actual
            Sesion.UsuarioActual = usuario;
            UsuarioLogeado = usuario;
            this.DialogResult = DialogResult.OK;
            this.Close();


            // Abrir la ventana principal (o perfil)
            FormApp ventana = new FormApp(usuario);
            this.Hide();
            ventana.ShowDialog();
            ventana.Show();

        }

        // Bot�n para registrar un nuevo usuario
        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrar ventanaReg = new FormRegistrar();
            ventanaReg.Show();



        }

        private void botonContinuarInvitado_Click(object sender, EventArgs e)
        {
            Usuario UsuarioActual = new Usuario("Invitado"); // Creo un usuario invitado
            FormApp ventanaPrincipal = new FormApp(UsuarioActual);  //paso el usuario invitado al formapp
            this.Hide();                    //oculta de la ventana actual osea login
            ventanaPrincipal.ShowDialog(); //bloquea el form de login hasta cerrar la ventana principal de la app
            this.Close();                  //cierra la ventana principal de la app
        }   
    }
}
