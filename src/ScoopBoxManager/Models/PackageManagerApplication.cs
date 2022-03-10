using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoopBoxManager.Enums;

namespace ScoopBoxManager.Models
{
    public class PackageManagerApplication
    {
        public PackageManagerApplication()
        {
            //
        }

        public PackageManagerType PackageManager { get; set; } = PackageManagerType.Chocolatey;
        public string Package { get; set; } = string.Empty;
    }
}
