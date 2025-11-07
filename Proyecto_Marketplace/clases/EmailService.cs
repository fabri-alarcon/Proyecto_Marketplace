using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Threading.Tasks;

namespace Proyecto_Marketplace.clases
{
    public static class EmailService
    {
        // --- CONFIGURACIÓN DE TU CORREO (EL QUE ENVÍA) ---
        // DEBES USAR UNA "CONTRASEÑA DE APLICACIÓN" DE GMAIL, NO TU CONTRASEÑA REAL
        private static string SmtpHost = "smtp.gmail.com";
        private static int SmtpPort = 587; // Puerto para TLS
        private static string EmailFrom = "marketplaceprodservsa@gmail.com"; // Tu correo de Gmail
        private static string AppPassword = "zyszlgbqxvfugurw"; // Tu Contraseña de Aplicación de 16 letras

        public static async Task EnviarEmailVerificacion(string emailDestino, string nombreUsuario, string codigoVerificacion)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("S&P Marketplace", EmailFrom));
                message.To.Add(new MailboxAddress(nombreUsuario, emailDestino));
                message.Subject = "¡Bienvenido! Verifica tu cuenta de Marketplace";

                // Cuerpo del correo en HTML (más profesional)
                message.Body = new TextPart("html")
                {
                    Text = $@"
                        <html>
                        <body style='font-family: Arial, sans-serif; line-height: 1.6;'>
                            <h2>¡Hola, {nombreUsuario}!</h2>
                            <p>Gracias por registrarte en nuestro Marketplace. Para activar tu cuenta, por favor usa el siguiente código de verificación:</p>
                            <h1 style='color: #4A90E2; letter-spacing: 2px;'>{codigoVerificacion}</h1>
                            <p>Si no te registraste, por favor ignora este correo.</p>
                            <p>Saludos,<br>El equipo de Marketplace S&P</p>
                        </body>
                        </html>"
                };

                using (var client = new SmtpClient())
                {
                    // Conectar al servidor de Gmail
                    await client.ConnectAsync(SmtpHost, SmtpPort, SecureSocketOptions.StartTls);

                    // Autenticarse con la Contraseña de Aplicación
                    await client.AuthenticateAsync(EmailFrom, AppPassword);

                    // Enviar
                    await client.SendAsync(message);

                    // Desconectar
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                // Manejar el error (ej. mostrarlo en un MessageBox o guardarlo en un log)
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error de Email");
            }
        }
    }
}
