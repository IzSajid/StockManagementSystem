using NSU_PMS.Forms.Client;
using NSU_PMS.Forms.Employee;
using NSU_PMS.Forms.General;
using NSU_PMS.Forms.Products;

namespace NSU_PMS
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
            Application.Run(Global.signin);
            //Application.Run(new AllSales());
        }
    }
}