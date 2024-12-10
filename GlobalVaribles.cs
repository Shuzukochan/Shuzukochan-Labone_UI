using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labone_UI
{
    public static class GlobalVariables
    {
        public static string DayString { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public static string TimeString { get; set; } = DateTime.Now.ToString("HH:mm:ss");
    }

}
