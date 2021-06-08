﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Colas
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if (panel1.Width >= 599)
            {
                timerSplash.Stop();
                frmMPrincipal fMPrincipal = new frmMPrincipal();
                fMPrincipal.Show();
                this.Hide();
            }
        }
    }
}
