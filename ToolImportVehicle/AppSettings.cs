using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolImportVehicle
{
    class AppSettings
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
    }
}
