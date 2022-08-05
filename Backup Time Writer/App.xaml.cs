using System.IO; // Directory.Exists
using System.Windows;

namespace Backup_Time_Writer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /**
        **/
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (!Directory.Exists(ConfigModel.BackupDrive)) // No backup drive connected
            {
                MessageBox.Show("The backup drive " + ConfigModel.BackupDrive + " isn't connected to the computer.", "Backup Drive Not Found", MessageBoxButton.OK);
                this.Shutdown((int)ExitCode.Code.NO_BACKUP_DRIVE);
            }
        }
    }
}
