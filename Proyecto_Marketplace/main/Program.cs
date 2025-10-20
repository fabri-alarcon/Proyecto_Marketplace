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
                                // Usuario cerr� sesi�n => volver al login
                                continue;
                            }
                            else
                            {
                                // Usuario cerr� app => salir
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Se cancel� login o se cerr� => salir
                        break;
                    }
                }
            }

            Application.Exit();
        }
    }
}
