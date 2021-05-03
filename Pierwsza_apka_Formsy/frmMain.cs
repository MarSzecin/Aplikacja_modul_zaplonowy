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
using System.Configuration;
using System.Data.SqlClient;
using System.IO.Ports;


namespace Pierwsza_apka_Formsy
{
    public partial class frmMain : Form
    {
        SqlConnection connection;
        string connectionString1;
        string connectionString2;
        int speedvaluenoscale;
        double speedvalue;
        int anglevaluenoscale;
        int engine_temperaturenoscale;
        double engine_temperature;
        double anglevalue;
        private bool mouseDown;
        private Point lastLocation;
        int temp1;
        int temp2;
        int temp3;
        Thread ListenArduino;

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PoKliknieciu_Close_app(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public frmMain()
        {   
            ListenArduino = new Thread(ListenSerial);
            if (!ListenArduino.IsAlive)
                ListenArduino.Start();
            else
            {
                ListenArduino.Abort();
                ListenArduino.Start();
            }

            InitializeComponent();
            connectionString1 = ConfigurationManager.ConnectionStrings["Pierwsza_apka_Formsy.Properties.Settings.Pierwsza_apka_FormsyConnectionString"].ConnectionString;
            connectionString2 = ConfigurationManager.ConnectionStrings["Pierwsza_apka_Formsy.Properties.Settings.LOGIConnectionString"].ConnectionString;
            timer1.Start();
            timer2.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pierwsza_apka_FormsyDataSet2.PUNKTY' . Możesz go przenieść lub usunąć.
            this.pUNKTYTableAdapter1.Fill(this.pierwsza_apka_FormsyDataSet2.PUNKTY);
            Pokaz_mapy();


        }

        private void Pokaz_mapy()
        {
            using (connection = new SqlConnection(connectionString1))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MAPY", connection))
            {

                DataTable mapaTable = new DataTable();
                adapter.Fill(mapaTable);

                Lista_Map.DisplayMember = "Nazwa";
                Lista_Map.ValueMember = "Mapa_Id";

                Lista_Map.DataSource = mapaTable;
            }
        }


        private void Pokaz_punkty()
        {

            Tabela_RPM_KAT.Rows.Clear();
            string kwerenda = "SELECT PUNKTY.X, PUNKTY.Y FROM PUNKTY INNER JOIN MAPY ON " +
                "PUNKTY.Mapa_Id = MAPY.Mapa_Id WHERE MAPY.Mapa_Id = @MAPA_Id";
            using (connection = new SqlConnection(connectionString1))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@MAPA_Id", Lista_Map.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Tabela_RPM_KAT.Rows.Add(reader["X"].ToString(), reader["Y"].ToString());
                }

                reader.Close();

            }

        }


        private void PoKliknieciu_Mapa_Wgrana_Na_Kontroler(object sender, EventArgs e)
        {
            string mapa = "<";
            for (int i = 0; i < 9; i++)
            {
                if (i < 8)
                    mapa = mapa + Tabela_RPM_KAT.Rows[i].Cells[1].Value.ToString() + ",";
                else
                    mapa = mapa + Tabela_RPM_KAT.Rows[i].Cells[1].Value.ToString() + ">";

            }

            Device.ArduinoSerialPort.WriteLine(mapa);
            Device.ArduinoSerialPort.DiscardInBuffer();

        }

       

        private  void ListenSerial()
        {
            if (Device.ArduinoSerialPort != null && Device.ArduinoSerialPort.IsOpen) 
            {
                Device.ArduinoSerialPort.Close();
                Device.ArduinoSerialPort.Open();
            }

            while (Device.ArduinoSerialPort != null && Device.ArduinoSerialPort.IsOpen)
            {
                try
                {
                    string message = Device.ArduinoSerialPort.ReadLine();
                    if (message.Length > 0)
                    {
                        if (message[0] == 'm' && message[message.Length - 2] == '#')
                        {
                            string[] words = message.Split(',');

                            bool canConvert1 = Int32.TryParse(words[0].Substring(1), out temp1);
                            speedvaluenoscale = temp1;
                            //Console.WriteLine(speedvaluenoscale.ToString());
                            speedvalue = (double)Map(temp1, 0, 9000, -90, 90);

                            bool canConvert2 = Int32.TryParse(words[1], out temp2);
                            anglevaluenoscale = temp2;
                            //Console.WriteLine(anglevaluenoscale.ToString());
                            anglevalue = (double)Map(temp2, 0, 40, -90, 90);

                            bool canConvert3 = Int32.TryParse(words[2].Substring(0, words[2].Length - 2), out temp3);
                            engine_temperaturenoscale = temp3;
                            //Console.WriteLine(engine_temperature.ToString()); 
                            engine_temperature = (double)Map(temp3, 0, 120, -90, 90);
                        }

                    }

                }
                catch { }
            }
        }


        private void ListBox1_Zmiana_Indeksu(object sender, EventArgs e)
        {

            Pokaz_punkty();

            Wykres.Series["Wyprzedzenie zapłonu"].Points.Clear();
            int j = 0;
            Wykres.Series["Wyprzedzenie zapłonu"].Points.AddXY(j, Tabela_RPM_KAT.Rows[0].Cells[1].Value.ToString());
            for (int i = 1; i < Tabela_RPM_KAT.Rows.Count ; i++)
            {
                Wykres.Series["Wyprzedzenie zapłonu"].Points.AddXY(Tabela_RPM_KAT.Rows[i].Cells[0].Value.ToString(), 
                    Tabela_RPM_KAT.Rows[i].Cells[1].Value.ToString());
            }
            Wykres.ChartAreas[0].AxisX.Minimum = double.NaN;
            Wykres.ChartAreas[0].AxisY.Minimum = double.NaN;
            Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
            Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;

        }



        float Map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }


        private void Zapisz_predkosc_kat_temp()
        {

            string kwerenda = "INSERT INTO LOGI VALUES (@Time, @Predkosc, @Kat, @Temperatura)";
            using (connection = new SqlConnection(connectionString2))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Time", Tim.timer_global.ToString());
                command.Parameters.AddWithValue("@Predkosc", speedvaluenoscale.ToString());
                command.Parameters.AddWithValue("@Kat", anglevaluenoscale.ToString());
                command.Parameters.AddWithValue("@Temperatura", engine_temperature.ToString());
                command.ExecuteNonQuery();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            gauge11.pointervalue_1 = speedvalue;
            gauge11.ChangeValue();
            gauge11.gauge1_value = speedvaluenoscale;

            gauge21.pointervalue_2 = anglevalue;
            gauge21.ChangeValue();
            gauge21.gauge2_value = anglevaluenoscale;

            gauge31.pointervalue_3 = engine_temperature;
            gauge31.ChangeValue();
            gauge31.gauge3_value = engine_temperaturenoscale;

            Engine_temp.Text = engine_temperature.ToString() + " °C";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (speedvaluenoscale > 0)
            {
                Zapisz_predkosc_kat_temp();
            }
            
        }

        private void Wroc1_Click(object sender, EventArgs e)
        {
                Visible = false;
                MainPage mainPage = new MainPage();
                mainPage.Show(); 
        }
    }


}



   



