﻿
namespace Sistema_de_Colas
{
    partial class frmMM1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMM1));
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularEsperaClientesCola = new System.Windows.Forms.Button();
            this.btnCalcularEsperaClientesSistema = new System.Windows.Forms.Button();
            this.btnCalcularEsperaSistema = new System.Windows.Forms.Button();
            this.btnCalcularEspera = new System.Windows.Forms.Button();
            this.btnCalcularMediaServicio = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLlegadas = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblEspera = new System.Windows.Forms.Label();
            this.lblEsperaSistema = new System.Windows.Forms.Label();
            this.lblEsperaClientesCola = new System.Windows.Forms.Label();
            this.lblEsperaClientesSistema = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalcularMediaLlegadas = new System.Windows.Forms.Button();
            this.txtEspera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLlegadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUtilizacionSistema = new System.Windows.Forms.Label();
            this.btnCalcularUtilizacion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSistemaVacio = new System.Windows.Forms.Label();
            this.btnSistemaVacio = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(793, 777);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 55);
            this.button2.TabIndex = 23;
            this.button2.Text = "Nuevos Valores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(1192, 777);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 55);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 63);
            this.panel1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(227, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(911, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medidas del desempeño del sistema de colas: Modelo M - M - 1.";
            // 
            // btnCalcularEsperaClientesCola
            // 
            this.btnCalcularEsperaClientesCola.BackColor = System.Drawing.Color.Green;
            this.btnCalcularEsperaClientesCola.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEsperaClientesCola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularEsperaClientesCola.Location = new System.Drawing.Point(1044, 633);
            this.btnCalcularEsperaClientesCola.Name = "btnCalcularEsperaClientesCola";
            this.btnCalcularEsperaClientesCola.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularEsperaClientesCola.TabIndex = 21;
            this.btnCalcularEsperaClientesCola.Text = "Calcular espera clientes en la cola";
            this.btnCalcularEsperaClientesCola.UseVisualStyleBackColor = false;
            this.btnCalcularEsperaClientesCola.Click += new System.EventHandler(this.btnCalcularEsperaClientesCola_Click);
            // 
            // btnCalcularEsperaClientesSistema
            // 
            this.btnCalcularEsperaClientesSistema.BackColor = System.Drawing.Color.Green;
            this.btnCalcularEsperaClientesSistema.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEsperaClientesSistema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularEsperaClientesSistema.Location = new System.Drawing.Point(1044, 575);
            this.btnCalcularEsperaClientesSistema.Name = "btnCalcularEsperaClientesSistema";
            this.btnCalcularEsperaClientesSistema.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularEsperaClientesSistema.TabIndex = 20;
            this.btnCalcularEsperaClientesSistema.Text = "Calcular espera clientes en el sistema";
            this.btnCalcularEsperaClientesSistema.UseVisualStyleBackColor = false;
            this.btnCalcularEsperaClientesSistema.Click += new System.EventHandler(this.btnCalcularEsperaClientesSistema_Click);
            // 
            // btnCalcularEsperaSistema
            // 
            this.btnCalcularEsperaSistema.BackColor = System.Drawing.Color.Green;
            this.btnCalcularEsperaSistema.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEsperaSistema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularEsperaSistema.Location = new System.Drawing.Point(1044, 520);
            this.btnCalcularEsperaSistema.Name = "btnCalcularEsperaSistema";
            this.btnCalcularEsperaSistema.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularEsperaSistema.TabIndex = 19;
            this.btnCalcularEsperaSistema.Text = "Calcular espera en el sistema";
            this.btnCalcularEsperaSistema.UseVisualStyleBackColor = false;
            this.btnCalcularEsperaSistema.Click += new System.EventHandler(this.btnCalcularEsperaSistema_Click);
            // 
            // btnCalcularEspera
            // 
            this.btnCalcularEspera.BackColor = System.Drawing.Color.Green;
            this.btnCalcularEspera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEspera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularEspera.Location = new System.Drawing.Point(1044, 468);
            this.btnCalcularEspera.Name = "btnCalcularEspera";
            this.btnCalcularEspera.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularEspera.TabIndex = 18;
            this.btnCalcularEspera.Text = "Calcular espera en la cola";
            this.btnCalcularEspera.UseVisualStyleBackColor = false;
            this.btnCalcularEspera.Click += new System.EventHandler(this.btnCalcularEspera_Click);
            // 
            // btnCalcularMediaServicio
            // 
            this.btnCalcularMediaServicio.BackColor = System.Drawing.Color.Green;
            this.btnCalcularMediaServicio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMediaServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularMediaServicio.Location = new System.Drawing.Point(1044, 417);
            this.btnCalcularMediaServicio.Name = "btnCalcularMediaServicio";
            this.btnCalcularMediaServicio.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularMediaServicio.TabIndex = 17;
            this.btnCalcularMediaServicio.Text = "Calcular media de servicios";
            this.btnCalcularMediaServicio.UseVisualStyleBackColor = false;
            this.btnCalcularMediaServicio.Click += new System.EventHandler(this.btnCalcularMediaServicio_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(575, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 32);
            this.label16.TabIndex = 57;
            this.label16.Text = "RESULTADOS:";
            // 
            // lblLlegadas
            // 
            this.lblLlegadas.AutoSize = true;
            this.lblLlegadas.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegadas.ForeColor = System.Drawing.Color.Yellow;
            this.lblLlegadas.Location = new System.Drawing.Point(468, 367);
            this.lblLlegadas.Name = "lblLlegadas";
            this.lblLlegadas.Size = new System.Drawing.Size(0, 32);
            this.lblLlegadas.TabIndex = 56;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.Yellow;
            this.lblServicio.Location = new System.Drawing.Point(458, 417);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(0, 32);
            this.lblServicio.TabIndex = 55;
            // 
            // lblEspera
            // 
            this.lblEspera.AutoSize = true;
            this.lblEspera.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspera.ForeColor = System.Drawing.Color.Yellow;
            this.lblEspera.Location = new System.Drawing.Point(569, 468);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(0, 32);
            this.lblEspera.TabIndex = 54;
            // 
            // lblEsperaSistema
            // 
            this.lblEsperaSistema.AutoSize = true;
            this.lblEsperaSistema.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaSistema.ForeColor = System.Drawing.Color.Yellow;
            this.lblEsperaSistema.Location = new System.Drawing.Point(604, 520);
            this.lblEsperaSistema.Name = "lblEsperaSistema";
            this.lblEsperaSistema.Size = new System.Drawing.Size(0, 32);
            this.lblEsperaSistema.TabIndex = 53;
            // 
            // lblEsperaClientesCola
            // 
            this.lblEsperaClientesCola.AutoSize = true;
            this.lblEsperaClientesCola.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaClientesCola.ForeColor = System.Drawing.Color.Yellow;
            this.lblEsperaClientesCola.Location = new System.Drawing.Point(579, 633);
            this.lblEsperaClientesCola.Name = "lblEsperaClientesCola";
            this.lblEsperaClientesCola.Size = new System.Drawing.Size(0, 32);
            this.lblEsperaClientesCola.TabIndex = 52;
            // 
            // lblEsperaClientesSistema
            // 
            this.lblEsperaClientesSistema.AutoSize = true;
            this.lblEsperaClientesSistema.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaClientesSistema.ForeColor = System.Drawing.Color.Yellow;
            this.lblEsperaClientesSistema.Location = new System.Drawing.Point(617, 575);
            this.lblEsperaClientesSistema.Name = "lblEsperaClientesSistema";
            this.lblEsperaClientesSistema.Size = new System.Drawing.Size(0, 32);
            this.lblEsperaClientesSistema.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(542, 32);
            this.label7.TabIndex = 50;
            this.label7.Text = "Número esperado de clientes en la cola (Lq):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(574, 32);
            this.label6.TabIndex = 49;
            this.label6.Text = "Número esperado de clientes en el sistema (Ls):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(566, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tiempo esperado de espera en el sistema (Ws):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(12, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(534, 32);
            this.label13.TabIndex = 47;
            this.label13.Text = "Tiempo esperado de espera en la cola (Wq):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(12, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(427, 32);
            this.label14.TabIndex = 46;
            this.label14.Text = "La tasa media de servicio (𝜇) es de:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(12, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(434, 32);
            this.label15.TabIndex = 45;
            this.label15.Text = "La tasa media de llegadas (λ) es de:";
            // 
            // btnCalcularMediaLlegadas
            // 
            this.btnCalcularMediaLlegadas.BackColor = System.Drawing.Color.Green;
            this.btnCalcularMediaLlegadas.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMediaLlegadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularMediaLlegadas.Location = new System.Drawing.Point(1044, 367);
            this.btnCalcularMediaLlegadas.Name = "btnCalcularMediaLlegadas";
            this.btnCalcularMediaLlegadas.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularMediaLlegadas.TabIndex = 16;
            this.btnCalcularMediaLlegadas.Text = "Calcular media de llegadas";
            this.btnCalcularMediaLlegadas.UseVisualStyleBackColor = false;
            this.btnCalcularMediaLlegadas.Click += new System.EventHandler(this.btnCalcularMediaLlegadas_Click);
            // 
            // txtEspera
            // 
            this.txtEspera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspera.Location = new System.Drawing.Point(906, 198);
            this.txtEspera.Name = "txtEspera";
            this.txtEspera.Size = new System.Drawing.Size(271, 30);
            this.txtEspera.TabIndex = 14;
            this.txtEspera.TextChanged += new System.EventHandler(this.txtEspera_TextChanged);
            this.txtEspera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspera_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(142, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(675, 37);
            this.label4.TabIndex = 42;
            this.label4.Text = "Digite la espera en promedio por minuto (Wq):";
            // 
            // txtServicios
            // 
            this.txtServicios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicios.Location = new System.Drawing.Point(906, 137);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(271, 30);
            this.txtServicios.TabIndex = 13;
            this.txtServicios.TextChanged += new System.EventHandler(this.txtServicios_TextChanged);
            this.txtServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicios_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(142, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 37);
            this.label3.TabIndex = 40;
            this.label3.Text = "Digite la tasa media de servicios por hora (𝜇):";
            // 
            // txtLlegadas
            // 
            this.txtLlegadas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadas.Location = new System.Drawing.Point(906, 73);
            this.txtLlegadas.Name = "txtLlegadas";
            this.txtLlegadas.Size = new System.Drawing.Size(271, 30);
            this.txtLlegadas.TabIndex = 12;
            this.txtLlegadas.TextChanged += new System.EventHandler(this.txtLlegadas_TextChanged);
            this.txtLlegadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLlegadas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(142, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Digite la tasa media de llegadas por hora (λ):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(12, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 32);
            this.label8.TabIndex = 66;
            this.label8.Text = "El factor de utilización del sistema (ρ) es de:";
            // 
            // lblUtilizacionSistema
            // 
            this.lblUtilizacionSistema.AutoSize = true;
            this.lblUtilizacionSistema.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizacionSistema.ForeColor = System.Drawing.Color.Yellow;
            this.lblUtilizacionSistema.Location = new System.Drawing.Point(575, 313);
            this.lblUtilizacionSistema.Name = "lblUtilizacionSistema";
            this.lblUtilizacionSistema.Size = new System.Drawing.Size(0, 32);
            this.lblUtilizacionSistema.TabIndex = 67;
            // 
            // btnCalcularUtilizacion
            // 
            this.btnCalcularUtilizacion.BackColor = System.Drawing.Color.Green;
            this.btnCalcularUtilizacion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularUtilizacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularUtilizacion.Location = new System.Drawing.Point(1044, 313);
            this.btnCalcularUtilizacion.Name = "btnCalcularUtilizacion";
            this.btnCalcularUtilizacion.Size = new System.Drawing.Size(307, 32);
            this.btnCalcularUtilizacion.TabIndex = 15;
            this.btnCalcularUtilizacion.Text = "Calcular utilización del sistema";
            this.btnCalcularUtilizacion.UseVisualStyleBackColor = false;
            this.btnCalcularUtilizacion.Click += new System.EventHandler(this.btnCalcularUtilizacion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(12, 700);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(567, 32);
            this.label10.TabIndex = 69;
            this.label10.Text = "Probabilidad de que el sistema esté vacío P(0):";
            // 
            // lblSistemaVacio
            // 
            this.lblSistemaVacio.AutoSize = true;
            this.lblSistemaVacio.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVacio.ForeColor = System.Drawing.Color.Yellow;
            this.lblSistemaVacio.Location = new System.Drawing.Point(604, 700);
            this.lblSistemaVacio.Name = "lblSistemaVacio";
            this.lblSistemaVacio.Size = new System.Drawing.Size(0, 32);
            this.lblSistemaVacio.TabIndex = 70;
            // 
            // btnSistemaVacio
            // 
            this.btnSistemaVacio.BackColor = System.Drawing.Color.Green;
            this.btnSistemaVacio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemaVacio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSistemaVacio.Location = new System.Drawing.Point(1044, 700);
            this.btnSistemaVacio.Name = "btnSistemaVacio";
            this.btnSistemaVacio.Size = new System.Drawing.Size(307, 32);
            this.btnSistemaVacio.TabIndex = 22;
            this.btnSistemaVacio.Text = "Calcular probabilidad sistema vacío";
            this.btnSistemaVacio.UseVisualStyleBackColor = false;
            this.btnSistemaVacio.Click += new System.EventHandler(this.btnSistemaVacio_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(958, 777);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(228, 55);
            this.btnMenuPrincipal.TabIndex = 24;
            this.btnMenuPrincipal.Text = "Regresar al Menú Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // frmMM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1381, 860);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnSistemaVacio);
            this.Controls.Add(this.lblSistemaVacio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalcularUtilizacion);
            this.Controls.Add(this.lblUtilizacionSistema);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcularEsperaClientesCola);
            this.Controls.Add(this.btnCalcularEsperaClientesSistema);
            this.Controls.Add(this.btnCalcularEsperaSistema);
            this.Controls.Add(this.btnCalcularEspera);
            this.Controls.Add(this.btnCalcularMediaServicio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblLlegadas);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblEspera);
            this.Controls.Add(this.lblEsperaSistema);
            this.Controls.Add(this.lblEsperaClientesCola);
            this.Controls.Add(this.lblEsperaClientesSistema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCalcularMediaLlegadas);
            this.Controls.Add(this.txtEspera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLlegadas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMM1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMM1";
            this.Load += new System.EventHandler(this.frmMM1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularEsperaClientesCola;
        private System.Windows.Forms.Button btnCalcularEsperaClientesSistema;
        private System.Windows.Forms.Button btnCalcularEsperaSistema;
        private System.Windows.Forms.Button btnCalcularEspera;
        private System.Windows.Forms.Button btnCalcularMediaServicio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLlegadas;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblEspera;
        private System.Windows.Forms.Label lblEsperaSistema;
        private System.Windows.Forms.Label lblEsperaClientesCola;
        private System.Windows.Forms.Label lblEsperaClientesSistema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalcularMediaLlegadas;
        private System.Windows.Forms.TextBox txtEspera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLlegadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUtilizacionSistema;
        private System.Windows.Forms.Button btnCalcularUtilizacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSistemaVacio;
        private System.Windows.Forms.Button btnSistemaVacio;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}