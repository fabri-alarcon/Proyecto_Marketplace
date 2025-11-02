using Proyecto_Marketplace.clases;
using Proyecto_Marketplace.forms;

namespace Proyecto_Marketplace
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //Control de tamaño de la ventana formlogin
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bordes fijos
            this.MaximizeBox = false; // Deshabilita el botón maximizar
            this.MinimizeBox = true; // Puedes dejar minimizar si quieres
            this.StartPosition = FormStartPosition.CenterScreen; // Para que aparezca centrada
            this.Size = new Size(600, 400); // Tamaño fijo de la ventana

        }

        public Usuario UsuarioLogeado { get; private set; }




        // Botón para iniciar sesión
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {

            string nombre = textUsuario.Text.Trim();
            string contrasenia = textContrasenia.Text;

            // Buscar usuario
            var usuario = RepositorioUsuarios.BuscarPorNombre(nombre);

            // Validar credenciales
            if (usuario == null || usuario.Contraseña != contrasenia)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar el usuario en la sesión actual
            Sesion.UsuarioActual = usuario;
            UsuarioLogeado = usuario;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Botón para registrar un nuevo usuario
        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrar ventanaReg = new FormRegistrar();
            ventanaReg.Show();
        }

        private void botonContinuarInvitado_Click(object sender, EventArgs e)
        {
            this.UsuarioLogeado = new Usuario("Invitado");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }   
    }
}
