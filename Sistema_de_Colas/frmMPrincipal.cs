using System;
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
    public partial class frmMPrincipal : Form
    {
        public frmMPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormResultados nuevaVentana = new FormResultados();
            nuevaVentana.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMM1 nuevaVentana = new frmMM1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMG1 nuevaVentana = new frmMG1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMD1 nuevaVentana = new frmMD1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMEk1 nuevaVentana = new frmMEk1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
