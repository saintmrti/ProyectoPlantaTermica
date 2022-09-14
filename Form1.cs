using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProyectoBasePlantaTermica
{
    public partial class form1  : Form
    {
        int[] datos = new int[4];
        byte[] Control = new byte[1];
        bool Bandera = false;
        double ErrorAnterior = 0;
        double temperatura;
        double ControlPID;
        double ControlPD;
        double ControlI;
        double ControlP;
        double derivada;
        double integra;
        double Error;
        double Hist;
        double Fs = 1;
        double T = 0;

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conectar.Enabled = false;
            BotonEnviar.Enabled = false;
            BtnVentilador.Enabled = false;
            IniciaControl.Enabled = false;
            CheckH.Enabled = false;
        }

        private void Verifica_Tick(object sender, EventArgs e)
        {
            double[] Kp = new double[1];
            double[] Ki = new double[1];
            double[] Kd = new double[1];
            double[] Setpoint = new double[1];
            double[] histeresis = new double[1];

            while (PuertoSerie.BytesToRead > 0)
            {
                datos[0] = PuertoSerie.ReadByte();

                if (datos[3] == 255 && datos[2] == 255)
                {
                    temperatura = datos[0] * 256 + datos[1];
                    temperatura = temperatura / 10;

                    if (temperatura < 110)
                    {
                        Setpoint[0] = double.Parse(SetPoint.Value.ToString());
                        Error = Setpoint[0] - temperatura;

                        byte[] Pt = new byte[1];
                        Pt[0] = byte.Parse(Potencia.Value.ToString());
                        PuertoSerie.Write(Pt, 0, 1);

                        if (AccionControl.Text == "Control On-Off")
                        {
                            CheckH.Enabled = true;

                            if (CheckH.Checked == true)
                            {
                                Histeresis.Enabled = true;
                                Proporcional.Enabled = false;
                                Integral.Enabled = false;
                                Derivativo.Enabled = false;
                                IniciaControl.Enabled = true;

                                if (Bandera == true)
                                {
                                    if (Histeresis.Value > 0)
                                    {
                                        histeresis[0] = double.Parse(Histeresis.Value.ToString());
                                        Hist = histeresis[0];

                                        if (Error > Hist)
                                            Control[0] = 100;

                                        if (Error < (-Hist))
                                            Control[0] = 0;

                                        PuertoSerie.Write(Control, 0, 1);
                                    }
                                }
                            }
                            if (CheckH.Checked == false)
                            {
                                Histeresis.Enabled = false;
                                Proporcional.Enabled = false;
                                Integral.Enabled = false;
                                Derivativo.Enabled = false;
                                IniciaControl.Enabled = true;

                                if (Bandera == true)
                                {
                                    if (Error > 0)
                                        Control[0] = 100;
                                    else
                                        Control[0] = 0;

                                    PuertoSerie.Write(Control, 0, 1);
                                }
                            }
                        }
                        if (AccionControl.Text == "Control Proporcional")
                        {
                            IniciaControl.Enabled = true;
                            Proporcional.Enabled = true;
                            Histeresis.Enabled = false;
                            Derivativo.Enabled = false;
                            Integral.Enabled = false;
                            CheckH.Enabled = false;

                            if (Bandera == true)
                            {
                                if (Proporcional.Value > 0)
                                {
                                    Kp[0] = double.Parse(Proporcional.Value.ToString());

                                    ControlP = Convert.ToInt32(Kp[0] * Error);

                                    if (ControlP > 100)
                                        ControlP = 100;
                                    if (ControlP < 0)
                                        ControlP = 0;

                                    Control[0] = Convert.ToByte(ControlP);
                                    PuertoSerie.Write(Control, 0, 1);
                                }
                            }
                        }
                        if (AccionControl.Text == "Control Integral")
                        {
                            IniciaControl.Enabled = true;
                            Integral.Enabled = true;
                            Proporcional.Enabled = false;
                            Derivativo.Enabled = false;
                            Histeresis.Enabled = false;
                            CheckH.Enabled = false;

                            if (Bandera == true)
                            {
                                T = 1 / Fs;
                                integra = T * Error + integra;
                                Ki[0] = double.Parse(Integral.Value.ToString());
                                double MaxIntegral = 100 / Ki[0];
                                double MinIntegral = -MaxIntegral;

                                if (integra > MaxIntegral)
                                    integra = MaxIntegral;
                                if (integra < MinIntegral)
                                    integra = MinIntegral;

                                ControlI = Ki[0] * integra;

                                if (ControlI < 0)
                                    ControlI = 0;
                                if (ControlI > 100)
                                    ControlI = 100;

                                Control[0] = Convert.ToByte(ControlI);
                                PuertoSerie.Write(Control, 0, 1);
                            }
                            if (Bandera == false)
                            {
                                integra = 0;
                            }
                        }
                        if (AccionControl.Text == "Control PD")
                        {
                            IniciaControl.Enabled = true;
                            Derivativo.Enabled = true;
                            Proporcional.Enabled = true;
                            Integral.Enabled = false;
                            Histeresis.Enabled = false;
                            CheckH.Enabled = false;

                            if (Bandera == true)
                            {
                                if (Derivativo.Value > 0)
                                {
                                    Kd[0] = double.Parse(Derivativo.Value.ToString());
                                    Kp[0] = double.Parse(Proporcional.Value.ToString());

                                    T = 1 / Fs;
                                    derivada = (Error - ErrorAnterior) / T;
                                    if (derivada > (100 / Kd[0]))
                                        derivada = 100 / Kd[0];
                                    if (derivada < (-100 / Kd[0]))
                                        derivada = -100 / Kd[0];

                                    ControlPD = Kp[0] * Error + Kd[0] * derivada;
                                    if (ControlPD > 100)
                                        ControlPD = 100;
                                    if (ControlPD < 0)
                                        ControlPD = 0;

                                    ErrorAnterior = Error;
                                    Control[0] = Convert.ToByte(ControlPD);
                                    PuertoSerie.Write(Control, 0, 1);
                                }
                            }
                        }
                        if (AccionControl.Text== "Control PID")
                        {
                            IniciaControl.Enabled = true;
                            Derivativo.Enabled = true;
                            Proporcional.Enabled = true;
                            Integral.Enabled = true;
                            Histeresis.Enabled = false;
                            CheckH.Enabled = false;

                            if (Bandera == true)
                            {
                                Ki[0] = double.Parse(Integral.Value.ToString());
                                Kd[0] = double.Parse(Derivativo.Value.ToString());
                                Kp[0] = double.Parse(Proporcional.Value.ToString());

                                T = 1 / Fs;
                                integra = T * Error + integra;
                                double MaxIntegral = 100 / Ki[0];
                                double MinIntegral = -MaxIntegral;
                                if (integra > MaxIntegral)
                                    integra = MaxIntegral;
                                if (integra < MinIntegral)
                                    integra = MinIntegral;

                                derivada = (Error - ErrorAnterior) / T;
                                if (derivada > (100 / Kd[0]))
                                    derivada = 100 / Kd[0];
                                if (derivada < (-100 / Kd[0]))
                                    derivada = -100 / Kd[0];

                                ControlPID = Kp[0] * Error + Ki[0] * integra + Kd[0] * derivada;
                                if (ControlPID > 100)
                                    ControlPID = 100;
                                if (ControlPID < 0)
                                    ControlPID = 0;

                                ErrorAnterior = Error;
                                Control[0] = Convert.ToByte(ControlPID);
                                PuertoSerie.Write(Control, 0, 1);
                            }
                        }
                        MuestraError.Text = Error.ToString();
                        MuestraControl.Text = Control[0].ToString();
                        MuestraDerivada.Text = derivada.ToString();
                        MuestraIntegral.Text = integra.ToString();
                        MuestraDatos.Text = temperatura.ToString() + "°C";
                    }
                }
                datos[3] = datos[2];
                datos[2] = datos[1];
                datos[1] = datos[0];
            }
        }

        private void BotonEnviar_Click(object sender, EventArgs e)
        {
            byte[] ParaEnviar = new byte[1];
            ParaEnviar[0] = byte.Parse(DatoEnviar.Text);
            PuertoSerie.Write(ParaEnviar, 0, 1);
        }

        private void BotonEncender_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnVentilador.Text == "ENCENDER")
                {
                    byte[] ParaEnviar = new byte[1];
                    ParaEnviar[0] = byte.Parse("140");
                    PuertoSerie.Write(ParaEnviar, 0, 1);
                    BtnVentilador.Text = "APAGAR";
                }
                else if (BtnVentilador.Text == "APAGAR")
                {
                    byte[] ParaEnviar = new byte[1];
                    ParaEnviar[0] = byte.Parse("141");
                    PuertoSerie.Write(ParaEnviar, 0, 1);
                    BtnVentilador.Text = "ENCENDER";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void Potencia_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Control[0] = byte.Parse(Potencia.Value.ToString());
                PuertoSerie.Write(Control, 0, 1);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void CambiarDatos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            CboPuertos.Items.Clear();
            foreach (string puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }

            if (CboPuertos.Items.Count > 0)
            {
                MessageBox.Show("SELECCIONAR EL PUERTO DE TRABAJO");
                CboPuertos.SelectedIndex = 0;
                Conectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NINGUN PUERTO DETECTADO");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "                    ";
                Conectar.Enabled = false;
                BotonEnviar.Enabled = false;
                BtnVentilador.Enabled = false;
                IniciaControl.Enabled = false;
            }                               
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conectar.Text == "CONECTAR")
                {
                    PuertoSerie.BaudRate = Int32.Parse(CboBaudRate.Text);
                    PuertoSerie.PortName = CboPuertos.Text;
                    try
                    {
                        PuertoSerie.Open();
                        Conectar.Text = "DESCONECTAR";
                        Verifica.Enabled = true;
                        BotonEnviar.Enabled = true;
                        BtnVentilador.Enabled = true;
                        AccionControl.Enabled = true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                }
                else if (Conectar.Text == "DESCONECTAR")
                {
                    PuertoSerie.Close();
                    Conectar.Text = "CONECTAR";
                    Verifica.Enabled = false;
                    BotonEnviar.Enabled = false;
                    BtnVentilador.Enabled = false;
                    IniciaControl.Enabled = false;
                    AccionControl.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }   
        }

        private void IniciaControl_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Bandera)
                {
                    case true:
                        Bandera = false;
                        IniciaControl.Text = "INICIA CTRL";
                        break;
                    case false:
                        Bandera = true;
                        IniciaControl.Text = "DETENER CTRL";
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void CboFrequency_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CboFrequency.Text == "0.25 HZ")
            {
                byte[] ParaEnviar = new byte[1];
                ParaEnviar[0] = byte.Parse("150");
                PuertoSerie.Write(ParaEnviar, 0, 1);
                Fs = 0.25;
            }
            else if (CboFrequency.Text == "0.50 HZ")
            {
                byte[] ParaEnviar = new byte[1];
                ParaEnviar[0] = byte.Parse("151");
                PuertoSerie.Write(ParaEnviar, 0, 1);
                Fs = 0.5;
            }
            else if (CboFrequency.Text == "1.00 HZ")
            {
                byte[] ParaEnviar = new byte[1];
                ParaEnviar[0] = byte.Parse("152");
                PuertoSerie.Write(ParaEnviar, 0, 1);
                Fs = 1;
            }
            else if (CboFrequency.Text == "5.00 HZ")
            {
                byte[] ParaEnviar = new byte[1];
                ParaEnviar[0] = byte.Parse("153");
                PuertoSerie.Write(ParaEnviar, 0, 1);
                Fs = 5;
            }
            else if (CboFrequency.Text == "10.0 HZ")
            {
                byte[] ParaEnviar = new byte[1];
                ParaEnviar[0] = byte.Parse("154");
                PuertoSerie.Write(ParaEnviar, 0, 1);
                Fs = 10;
            }
        }
    }
}
