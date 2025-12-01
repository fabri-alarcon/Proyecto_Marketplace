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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(600, 400);

        }

        public Usuario UsuarioLogeado { get; private set; }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombre = textUsuario.Text.Trim();
            string contrasenia = textContrasenia.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u = RepositorioUsuarios.BuscarPorNombre(nombre);

            if (u != null)
            {
                if (u.ValidarLogin(nombre, contrasenia))
                {
                    if (u.IsEmailVerified)
                    {
                        this.UsuarioLogeado = u;
                        Sesion.UsuarioActual = u;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario está registrado pero no ha verificado su email. Por favor, revisa tu correo para encontrar el código de activación.", "Email no verificado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrar ventanaRegistrar = new FormRegistrar();
            ventanaRegistrar.ShowDialog();
        }

        private void botonContinuarInvitado_Click(object sender, EventArgs e)
        {
            this.UsuarioLogeado = new Usuario("Invitado");
            Sesion.UsuarioActual = this.UsuarioLogeado;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}