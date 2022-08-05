using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO; // Directory.Exists

namespace Backup_Time_Writer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ConfigModel model = new ConfigModel();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (!Directory.Exists(model.BackupDrive)) // No backup drive connected
            {
                MessageBox.Show("The backup drive " + model.BackupDrive + " isn't connected to the computer.", "Backup Drive Not Found", MessageBoxButton.OK);
                this.Shutdown((int)ExitCode.Code.NO_BACKUP_DRIVE);
            }
        }
    }
}
