using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Pierwsza_apka_Formsy
{
    public partial class Form2 : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        String[] ports;
        
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public Form2()
        {
            InitializeComponent();
            //Thread ListenArduino = new Thread(ListenSerial);
            //ListenArduino.Start();

            ports = SerialPort.GetPortNames();
            foreach (string ArduinoSerialPort in ports)
            {
                Combobox_Port.Items.Add(ArduinoSerialPort);
            }

            Kontrolka.BackColor = System.Drawing.Color.Red;
        }


        private void ListenSerial()
        {
            while (true)
                if (Device.ArduinoSerialPort != null && Device.ArduinoSerialPort.IsOpen && System.IO.Ports.SerialPort.GetPortNames().Contains(Device.SerialPortName))
                {
                    string nazwa = Device.ArduinoSerialPort.ReadLine();
                    if (nazwa.Length > 0)
                        Console.WriteLine(nazwa);
                }
        }


        private void PoKliknieciu_Wroc(object sender, EventArgs e)
        {

            Visible = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void Po_Kliknieciu_Polacz(object sender, EventArgs e)
        {
            int temp;
            Device.ArduinoSerialPort = new SerialPort();
            Device.SerialPortName = Combobox_Port.SelectedItem.ToString();
            Device.ArduinoSerialPort.PortName = Device.SerialPortName;

            bool canConvert = Int32.TryParse(Combobox_Predkosc.SelectedItem.ToString(), out temp);
            if (canConvert)
                temp = Int32.Parse(Combobox_Predkosc.SelectedItem.ToString());
            else
                temp = 0;
            Device.BaudRate = temp;
            Device.ArduinoSerialPort.BaudRate = Device.BaudRate;
            Device.ArduinoSerialPort.DtrEnable = true;
            Device.ArduinoSerialPort.Open();

            if (Device.ArduinoSerialPort.IsOpen)
                Kontrolka.BackColor = System.Drawing.Color.LightGreen;
            else
                Kontrolka.BackColor = System.Drawing.Color.Red;
        }


        private void PoKliknieciu_Close_app(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
