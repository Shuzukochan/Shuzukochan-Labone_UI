﻿using System;
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
    public partial class About : BaseForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting_1(), groundPanel);
        }
    }
}
