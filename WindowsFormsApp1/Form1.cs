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
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string text);
        public SerialPort ArduinoPort { get; }
        string connectionString = "Server=localhost; Port=3306; Database=Exapractico2; Uid=root; Pwd=;";
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.WriteTimeout = 500;
            ArduinoPort.ReadTimeout = 500;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.TxtConectar.Click += TxtConectar_Click;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }
        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);

                }
                catch { }
            lblTempC.Text = dato;
            float datF = float.Parse(dato)*9/5 +32;
            dato = datF.ToString();
            lblTempF.Text = dato;
        }


        private void insertarRegistros(string nombre, string fecha, string temperatura, string servo)
        {
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string insertar = "INSERT INTO Registro (Nombre, Fecha, Temperatura, Servo) " +
                    "VALUES(@Nombre, @Fecha, @Temperatura, @Servo)";
                using (MySqlCommand command = new MySqlCommand(insertar, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Temperatura", temperatura);
                    command.Parameters.AddWithValue("@Servo", servo);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }

        private void connect_Click(object sender, EventArgs e)
        {
            connect.Enabled = false;
            disconect.Enabled = true;
            ArduinoPort.Open();
            lblEstado.Text = "Encendido";
            lblEstado.ForeColor = System.Drawing.Color.Green;
        }

        private void disconect_Click(object sender, EventArgs e)
        {
            disconect.Enabled = false;
            connect.Enabled = true;
            ArduinoPort.Close();
            lblEstado.Text = "Apagado";
            lblEstado.ForeColor = System.Drawing.Color.Red;
        }

        private void TxtConectar_Click(object sender, EventArgs e)
        {
            //ArduinoPort.Open();
            string Nombre = tbname.Text, Fecha = tbdate.Text, Temperatura = lblTempF.Text, servo = "Encendido";
            ArduinoPort.Write("1");
            insertarRegistros(Nombre, Fecha, Temperatura, servo);
        }

        private void TxtDesconectar_Click(object sender, EventArgs e)
        {
            //ArduinoPort.Close();
            string Nombre = tbname.Text, Fecha = tbdate.Text, Temperatura = lblTempF.Text, servo = "Apagado";
            ArduinoPort.Write("0");
            insertarRegistros(Nombre, Fecha, Temperatura, servo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
