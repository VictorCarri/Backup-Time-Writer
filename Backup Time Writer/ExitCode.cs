using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_Time_Writer
{
    internal class ExitCode
    {
        public enum Code
        {
            NORMAL = 0,
            NO_BACKUP_DRIVE
        }
    }
}
