using Proyecto_Marketplace.clases;
using System.Text.RegularExpressions; // Para validar email

namespace Proyecto_Marketplace.forms
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(600, 600);
        }

        public void botonCancelarReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void botonConfirmarReg_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textRegUsuario.Text.Trim();
            string contrasenia = textRegContrasenia.Text;
            string confirmarContrasenia = textRegConfirmarContrasenia.Text;
            string contacto = textContacto.Text.Trim();
            string cuil = textCuil.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Validaciones de campos vacíos
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia) ||
                string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(cuil) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error"); return;
            }
            if (contrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error"); return;
            }

            //Validaciones de Formato (Regex)
            if (!long.TryParse(contacto, out _) || !long.TryParse(cuil, out _))
            {
                MessageBox.Show("El Contacto y el CUIL deben ser solo números.", "Error"); return;
            }

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patronEmail))
            {
                MessageBox.Show("El formato del email no es válido.", "Error"); return;
            }

            if (RepositorioUsuarios.BuscarPorNombre(nombreUsuario) != null)
            {
                MessageBox.Show("El nombre de usuario ya está en uso.", "Error"); return;
            }

            if (RepositorioUsuarios.ExisteEmail(email))
            {
                MessageBox.Show("El email ingresado ya está registrado por otro usuario.", "Error"); return;
            }

            if (RepositorioUsuarios.ExisteCuil(cuil))
            {
                MessageBox.Show("El CUIL ingresado ya está registrado por otro usuario.", "Error"); return;
            }

            if (RepositorioUsuarios.ExisteContacto(contacto))
            {
                MessageBox.Show("El número de contacto ya está registrado por otro usuario.", "Error"); return;
            }

            //Generar Código y Crear Usuario, no recomiendo mucho el random, pero para este caso es suficiente
            string codigoVerificacion = new Random().Next(100000, 999999).ToString();
            Usuario nuevoUsuario = new Usuario(nombreUsuario, contrasenia, contacto, cuil, email);



            //Guardar Usuario (como NO verificado)
            RepositorioUsuarios.AgregarUsuario(nuevoUsuario);


            label6.Visible = true;

            //Enviar Email asíncrono
            await EmailService.EnviarEmailVerificacion(email, nombreUsuario, codigoVerificacion);
            
            label6.Visible = false;


            MessageBox.Show("Registro casi completo. Te hemos enviado un código a tu email. Por favor, ingrésalo para activar tu cuenta.", "Verifica tu Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Abrir el formulario de verificación
            this.Hide();
            Verificación formVer = new Verificación(codigoVerificacion, nuevoUsuario);
            DialogResult verificacionResult = formVer.ShowDialog();

            if (verificacionResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Si el usuario cerró la ventana de verificación,
                // el usuario queda guardado pero NO verificado.
                // Mostramos el formulario de registro de nuevo.
                this.Show();
            }
        }

       
    }
}