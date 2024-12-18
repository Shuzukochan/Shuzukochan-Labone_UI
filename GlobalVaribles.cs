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

        public static bool[] ButtonStates = new bool[96];

        public static bool[] ButtonStates_1 = new bool[96];

        public static string ProgramName = "Program 1";

        public static string ProgramName_1 = "Program 1";

        public static bool AreaState = false;
    }

}
