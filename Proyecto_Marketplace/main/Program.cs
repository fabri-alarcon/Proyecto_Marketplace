using Proyecto_Marketplace.main;

namespace Proyecto_Marketplace.main
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Bucle de control principal (main message loop).
            while (true)
            {
                using (FormLogin loginForm = new FormLogin())
                {
                    DialogResult loginResult = loginForm.ShowDialog();

                    if (loginResult == DialogResult.OK)
                    {
                        using (FormApp appForm = new FormApp(loginForm.UsuarioLogeado))
                        {
                            DialogResult appResult = appForm.ShowDialog();

                            if (appResult == DialogResult.OK)
                            {
                                // Usuario cerró sesión => volver al login
                                continue;
                            }
                            else
                            {
                                // Usuario cerró app => salir
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Se canceló login o se cerró => salir
                        break;
                    }
                }
            }

            Application.Exit();
        }
    }
}
