namespace Parcial1_Labo_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// Borrar fotos extras
        /// podemos usar sets?
        /// 
        /// 
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_Login());
        }
    }
}