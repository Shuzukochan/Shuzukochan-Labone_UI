using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labone_UI
{
    public partial class CelibrationAction : Form
    {
        public CelibrationAction(string programName)
        {
            InitializeComponent();
            programNameLabel.Text = programName;
            if (programName == "Program 10")
            {
                programNameLabel.Location = new Point(425, 6);
            }
        }
    }
}
