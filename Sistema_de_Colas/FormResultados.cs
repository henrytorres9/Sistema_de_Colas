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
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }
        private void FormResultados_Load(object sender, EventArgs e)
        {
            btnCalcularMediaLlegadas.Enabled = false;
            btnCalcularMediaServicio.Enabled = false;
            btnCalcularEspera.Enabled = false;
            btnCalcularEsperaSistema.Enabled = false;
            btnCalcularEsperaClientesSistema.Enabled = false;
            btnCalcularEsperaClientesCola.Enabled = false;
            button2.Enabled = false;
            lblLlegadas.Visible = false;
            lblServicio.Visible = false;
            lblEspera.Visible = false;
            lblEsperaSistema.Visible = false;
            lblEsperaClientesSistema.Visible = false;
            lblEsperaClientesCola.Visible = false;
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtEspera.Text) && !string.IsNullOrEmpty(txtLlegadas.Text)
                && !string.IsNullOrEmpty(txtServicios.Text);

            btnCalcularMediaLlegadas.Enabled = vr;
            btnCalcularMediaServicio.Enabled = vr;
            btnCalcularEspera.Enabled = vr;
            btnCalcularEsperaSistema.Enabled = vr;
            btnCalcularEsperaClientesSistema.Enabled = vr;
            btnCalcularEsperaClientesCola.Enabled = vr;
            button2.Enabled = vr;
        }

        private void btnCalcularMediaLlegadas_Click(object sender, EventArgs e)
        {
            lblLlegadas.Visible = true;

            double llegadas = Convert.ToDouble(txtLlegadas.Text);
            double resultLlegadas = llegadas / 60; //Lambda

            lblLlegadas.Text = resultLlegadas.ToString() + " clientes por minuto.";
        }

        private void btnCalcularMediaServicio_Click(object sender, EventArgs e)
        {
            lblServicio.Visible = true;
            
            double servicio = Convert.ToDouble(txtServicios.Text);
            double resultServicio = servicio / 60; //m

            lblServicio.Text = resultServicio.ToString() + " clientes por minuto.";
        }

        private void btnCalcularEspera_Click(object sender, EventArgs e)
        {
            lblEspera.Visible = true;
            
            double espera = Convert.ToDouble(txtEspera.Text); //Wq

            lblEspera.Text = espera.ToString() + " minuto (s).";
        }

        private void btnCalcularEsperaSistema_Click(object sender, EventArgs e)
        {
            lblEsperaSistema.Visible = true;
            
            double servicio = Convert.ToDouble(txtServicios.Text);
            double resultServicio = servicio / 60; //m
            double espera = Convert.ToDouble(txtEspera.Text); //Wq
            double resultEsperaSistema = espera + (1 / resultServicio);

            lblEsperaSistema.Text = resultEsperaSistema.ToString() + " minuto (s).";
        }

        private void btnCalcularEsperaClientesSistema_Click(object sender, EventArgs e)
        {
            lblEsperaClientesSistema.Visible = true;
            
            double servicio = Convert.ToDouble(txtServicios.Text);
            double resultServicio = servicio / 60; //m
            double espera = Convert.ToDouble(txtEspera.Text); //Wq
            double resultEsperaSistema = espera + (1 / resultServicio); //Ws

            double llegadas = Convert.ToDouble(txtLlegadas.Text);
            double resultLlegadas = llegadas / 60; //Lambda

            int resultEsperaClientesSistema = ((int)(resultLlegadas * resultEsperaSistema)); //Ls

            lblEsperaClientesSistema.Text = resultEsperaClientesSistema.ToString() + " clientes.";
        }

        private void btnCalcularEsperaClientesCola_Click(object sender, EventArgs e)
        {
            lblEsperaClientesCola.Visible = true;

            double llegadas = Convert.ToDouble(txtLlegadas.Text);
            double resultLlegadas = llegadas / 60; //Lambda
            double espera = Convert.ToDouble(txtEspera.Text); //Wq

            double resultEsperaClientesCola = (resultLlegadas * espera);

            lblEsperaClientesCola.Text = resultEsperaClientesCola.ToString() + " promedio de \nclientes.";
        }

        private void txtLlegadas_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtServicios_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtEspera_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLlegadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Solo se aceptara un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Solo se aceptara un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtEspera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Solo se aceptara un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLlegadas_Enter(object sender, EventArgs e)
        {
            txtLlegadas.Text = "";
        }

        private void txtServicios_Enter(object sender, EventArgs e)
        {
            txtServicios.Text = "";
        }

        private void txtEspera_Enter(object sender, EventArgs e)
        {
            txtEspera.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCalcularMediaLlegadas.Enabled = false;
            btnCalcularMediaServicio.Enabled = false;
            btnCalcularEspera.Enabled = false;
            btnCalcularEsperaSistema.Enabled = false;
            btnCalcularEsperaClientesSistema.Enabled = false;
            btnCalcularEsperaClientesCola.Enabled = false;
            button2.Enabled = false;
            lblLlegadas.Visible = false;
            lblServicio.Visible = false;
            lblEspera.Visible = false;
            lblEsperaSistema.Visible = false;
            lblEsperaClientesSistema.Visible = false;
            lblEsperaClientesCola.Visible = false;
            txtLlegadas.Text = "";
            txtServicios.Text = "";
            txtEspera.Text = "";
        }
    }
}
