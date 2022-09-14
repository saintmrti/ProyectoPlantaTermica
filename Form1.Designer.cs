namespace ProyectoBasePlantaTermica
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.Verifica = new System.Windows.Forms.Timer(this.components);
            this.MuestraDatos = new System.Windows.Forms.TextBox();
            this.DatoEnviar = new System.Windows.Forms.TextBox();
            this.BotonEnviar = new System.Windows.Forms.Button();
            this.BtnVentilador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Potencia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Conectar = new System.Windows.Forms.Button();
            this.CambiarDatos = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.SetPoint = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Histeresis = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckH = new System.Windows.Forms.CheckBox();
            this.Proporcional = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.MuestraControl = new System.Windows.Forms.TextBox();
            this.MuestraError = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IniciaControl = new System.Windows.Forms.Button();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.Integral = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.AccionControl = new System.Windows.Forms.ComboBox();
            this.MuestraIntegral = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CboFrequency = new System.Windows.Forms.ComboBox();
            this.Derivativo = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.MuestraDerivada = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Potencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histeresis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proporcional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Integral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Derivativo)).BeginInit();
            this.SuspendLayout();
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.BaudRate = 250000;
            this.PuertoSerie.PortName = "COM2";
            // 
            // Verifica
            // 
            this.Verifica.Interval = 50;
            this.Verifica.Tick += new System.EventHandler(this.Verifica_Tick);
            // 
            // MuestraDatos
            // 
            this.MuestraDatos.BackColor = System.Drawing.Color.Snow;
            this.MuestraDatos.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraDatos.Location = new System.Drawing.Point(169, 38);
            this.MuestraDatos.Multiline = true;
            this.MuestraDatos.Name = "MuestraDatos";
            this.MuestraDatos.Size = new System.Drawing.Size(296, 100);
            this.MuestraDatos.TabIndex = 0;
            this.MuestraDatos.Text = "HOLA";
            this.MuestraDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatoEnviar
            // 
            this.DatoEnviar.Location = new System.Drawing.Point(169, 254);
            this.DatoEnviar.Name = "DatoEnviar";
            this.DatoEnviar.Size = new System.Drawing.Size(98, 20);
            this.DatoEnviar.TabIndex = 1;
            this.DatoEnviar.Text = "152";
            // 
            // BotonEnviar
            // 
            this.BotonEnviar.Location = new System.Drawing.Point(169, 280);
            this.BotonEnviar.Name = "BotonEnviar";
            this.BotonEnviar.Size = new System.Drawing.Size(98, 33);
            this.BotonEnviar.TabIndex = 2;
            this.BotonEnviar.Text = "ENVIAR";
            this.BotonEnviar.UseVisualStyleBackColor = true;
            this.BotonEnviar.Click += new System.EventHandler(this.BotonEnviar_Click);
            // 
            // BtnVentilador
            // 
            this.BtnVentilador.Location = new System.Drawing.Point(65, 280);
            this.BtnVentilador.Name = "BtnVentilador";
            this.BtnVentilador.Size = new System.Drawing.Size(98, 33);
            this.BtnVentilador.TabIndex = 3;
            this.BtnVentilador.Text = "ENCENDER";
            this.BtnVentilador.UseVisualStyleBackColor = true;
            this.BtnVentilador.Click += new System.EventHandler(this.BotonEncender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventilador";
            // 
            // Potencia
            // 
            this.Potencia.Location = new System.Drawing.Point(368, 150);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(98, 20);
            this.Potencia.TabIndex = 6;
            this.Potencia.ValueChanged += new System.EventHandler(this.Potencia_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Potencia (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "By: Saint-Martin Mendez Martinez";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo";
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(65, 183);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(98, 33);
            this.Conectar.TabIndex = 13;
            this.Conectar.Text = "CONECTAR";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // CambiarDatos
            // 
            this.CambiarDatos.Location = new System.Drawing.Point(65, 144);
            this.CambiarDatos.Name = "CambiarDatos";
            this.CambiarDatos.Size = new System.Drawing.Size(98, 33);
            this.CambiarDatos.TabIndex = 14;
            this.CambiarDatos.Text = "Buscar Puertos";
            this.CambiarDatos.UseVisualStyleBackColor = true;
            this.CambiarDatos.Click += new System.EventHandler(this.CambiarDatos_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(169, 151);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(98, 21);
            this.CboPuertos.TabIndex = 15;
            // 
            // SetPoint
            // 
            this.SetPoint.Location = new System.Drawing.Point(367, 176);
            this.SetPoint.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SetPoint.Name = "SetPoint";
            this.SetPoint.Size = new System.Drawing.Size(98, 20);
            this.SetPoint.TabIndex = 17;
            this.SetPoint.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "SetPoint";
            // 
            // Histeresis
            // 
            this.Histeresis.DecimalPlaces = 2;
            this.Histeresis.Enabled = false;
            this.Histeresis.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Histeresis.Location = new System.Drawing.Point(396, 202);
            this.Histeresis.Name = "Histeresis";
            this.Histeresis.Size = new System.Drawing.Size(70, 20);
            this.Histeresis.TabIndex = 19;
            this.Histeresis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Histéresis";
            // 
            // CheckH
            // 
            this.CheckH.AutoSize = true;
            this.CheckH.Location = new System.Drawing.Point(375, 204);
            this.CheckH.Name = "CheckH";
            this.CheckH.Size = new System.Drawing.Size(15, 14);
            this.CheckH.TabIndex = 21;
            this.CheckH.UseVisualStyleBackColor = true;
            // 
            // Proporcional
            // 
            this.Proporcional.DecimalPlaces = 2;
            this.Proporcional.Enabled = false;
            this.Proporcional.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Proporcional.Location = new System.Drawing.Point(396, 228);
            this.Proporcional.Name = "Proporcional";
            this.Proporcional.Size = new System.Drawing.Size(70, 20);
            this.Proporcional.TabIndex = 46;
            this.Proporcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Kp";
            // 
            // MuestraControl
            // 
            this.MuestraControl.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.MuestraControl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraControl.Location = new System.Drawing.Point(65, 38);
            this.MuestraControl.Multiline = true;
            this.MuestraControl.Name = "MuestraControl";
            this.MuestraControl.Size = new System.Drawing.Size(98, 45);
            this.MuestraControl.TabIndex = 48;
            this.MuestraControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MuestraError
            // 
            this.MuestraError.BackColor = System.Drawing.Color.Pink;
            this.MuestraError.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraError.Location = new System.Drawing.Point(65, 93);
            this.MuestraError.Multiline = true;
            this.MuestraError.Name = "MuestraError";
            this.MuestraError.Size = new System.Drawing.Size(98, 45);
            this.MuestraError.TabIndex = 49;
            this.MuestraError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 26);
            this.label8.TabIndex = 50;
            this.label8.Text = "Accion de \r\n    Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Error";
            // 
            // IniciaControl
            // 
            this.IniciaControl.Location = new System.Drawing.Point(273, 280);
            this.IniciaControl.Name = "IniciaControl";
            this.IniciaControl.Size = new System.Drawing.Size(98, 33);
            this.IniciaControl.TabIndex = 52;
            this.IniciaControl.Text = "INICIA CTRL";
            this.IniciaControl.UseVisualStyleBackColor = true;
            this.IniciaControl.Click += new System.EventHandler(this.IniciaControl_Click);
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200",
            "250000"});
            this.CboBaudRate.Location = new System.Drawing.Point(169, 178);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(98, 21);
            this.CboBaudRate.TabIndex = 53;
            this.CboBaudRate.Text = "250000";
            // 
            // Integral
            // 
            this.Integral.DecimalPlaces = 2;
            this.Integral.Enabled = false;
            this.Integral.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Integral.Location = new System.Drawing.Point(396, 254);
            this.Integral.Name = "Integral";
            this.Integral.Size = new System.Drawing.Size(70, 20);
            this.Integral.TabIndex = 54;
            this.Integral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(375, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ki";
            // 
            // AccionControl
            // 
            this.AccionControl.Enabled = false;
            this.AccionControl.FormattingEnabled = true;
            this.AccionControl.Items.AddRange(new object[] {
            "Control On-Off",
            "Control Proporcional",
            "Control Integral",
            "Control PD",
            "Control PID"});
            this.AccionControl.Location = new System.Drawing.Point(273, 253);
            this.AccionControl.Name = "AccionControl";
            this.AccionControl.Size = new System.Drawing.Size(98, 21);
            this.AccionControl.TabIndex = 57;
            // 
            // MuestraIntegral
            // 
            this.MuestraIntegral.Font = new System.Drawing.Font("Segoe Print", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraIntegral.Location = new System.Drawing.Point(78, 222);
            this.MuestraIntegral.Multiline = true;
            this.MuestraIntegral.Name = "MuestraIntegral";
            this.MuestraIntegral.Size = new System.Drawing.Size(70, 19);
            this.MuestraIntegral.TabIndex = 58;
            this.MuestraIntegral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 59;
            this.label11.Text = "I:";
            // 
            // CboFrequency
            // 
            this.CboFrequency.FormattingEnabled = true;
            this.CboFrequency.Items.AddRange(new object[] {
            "0.25 HZ",
            "0.50 HZ",
            "1.00 HZ",
            "5.00 HZ",
            "10.0 HZ"});
            this.CboFrequency.Location = new System.Drawing.Point(169, 205);
            this.CboFrequency.Name = "CboFrequency";
            this.CboFrequency.Size = new System.Drawing.Size(98, 21);
            this.CboFrequency.TabIndex = 60;
            this.CboFrequency.Text = "1.00 HZ";
            this.CboFrequency.SelectedIndexChanged += new System.EventHandler(this.CboFrequency_SelectedIndexChanged_1);
            // 
            // Derivativo
            // 
            this.Derivativo.DecimalPlaces = 2;
            this.Derivativo.Enabled = false;
            this.Derivativo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Derivativo.Location = new System.Drawing.Point(396, 280);
            this.Derivativo.Name = "Derivativo";
            this.Derivativo.Size = new System.Drawing.Size(70, 20);
            this.Derivativo.TabIndex = 61;
            this.Derivativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(370, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "Kd";
            // 
            // MuestraDerivada
            // 
            this.MuestraDerivada.Font = new System.Drawing.Font("Segoe Print", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraDerivada.Location = new System.Drawing.Point(78, 242);
            this.MuestraDerivada.Multiline = true;
            this.MuestraDerivada.Name = "MuestraDerivada";
            this.MuestraDerivada.Size = new System.Drawing.Size(70, 19);
            this.MuestraDerivada.TabIndex = 63;
            this.MuestraDerivada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 18);
            this.label13.TabIndex = 64;
            this.label13.Text = "D:";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(534, 346);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MuestraDerivada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Derivativo);
            this.Controls.Add(this.CboFrequency);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MuestraIntegral);
            this.Controls.Add(this.AccionControl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Integral);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.IniciaControl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MuestraError);
            this.Controls.Add(this.MuestraControl);
            this.Controls.Add(this.Proporcional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Histeresis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetPoint);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.CambiarDatos);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVentilador);
            this.Controls.Add(this.BotonEnviar);
            this.Controls.Add(this.DatoEnviar);
            this.Controls.Add(this.MuestraDatos);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Control Planta Termica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Potencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histeresis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proporcional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Integral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Derivativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Timer Verifica;
        private System.Windows.Forms.TextBox MuestraDatos;
        private System.Windows.Forms.TextBox DatoEnviar;
        private System.Windows.Forms.Button BotonEnviar;
        private System.Windows.Forms.Button BtnVentilador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Potencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button CambiarDatos;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.NumericUpDown SetPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Histeresis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckH;
        private System.Windows.Forms.NumericUpDown Proporcional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MuestraControl;
        private System.Windows.Forms.TextBox MuestraError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button IniciaControl;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.NumericUpDown Integral;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox AccionControl;
        private System.Windows.Forms.TextBox MuestraIntegral;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboFrequency;
        private System.Windows.Forms.NumericUpDown Derivativo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MuestraDerivada;
        private System.Windows.Forms.Label label13;
    }
}

