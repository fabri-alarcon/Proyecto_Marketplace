using Proyecto_Marketplace.main;

namespace Proyecto_Marketplace.main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Crear e iniciar el formulario de login
            using (var loginForm = new FormLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar el formulario principal con el usuario autenticado
                    Application.Run(new FormApp(loginForm.UsuarioLogeado));
                }
                else
                {
                    Application.Exit();
                }
            }
  
        }
    }
}