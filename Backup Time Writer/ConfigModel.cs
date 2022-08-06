using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_Time_Writer
{
    internal static class ConfigModel
    {
        public static string BackupDrive { get; set; } = "F:\\";
        public static string ConfigFile { get; set; } = "config.json";
    }
}
