using Activator.Model.Main;
using Activator.Presenter;
using Activator.View;

namespace Activator
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

            using MainForm view = new();
            var connectionComModel = new ConnectionComModel();
            var validateModel = new ValidateModel();
            _ = new MainPresenter(view, connectionComModel, validateModel);

            Application.Run(view);
        }
    }
}