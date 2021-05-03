using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using System.IO.Ports;

namespace Pierwsza_apka_Formsy
{
    public partial class Plots : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        SqlConnection connection;
        string connectionString2;

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }
        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainPage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PoKliknieciu_Close_app(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Plots()
        {
            InitializeComponent();
            connectionString2 = ConfigurationManager.ConnectionStrings["Pierwsza_apka_Formsy.Properties.Settings.LOGIConnectionString"].ConnectionString;
        }

        private void Plots_Load(object sender, EventArgs e)
        {

        }

        private void Wroc1_Click(object sender, EventArgs e)
        {
                Visible = false;
                MainPage mainPage = new MainPage();
                mainPage.Show();
        }

        private void logiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logiBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lOGIDataSet);

        }

        private void Plots_Load_1(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'lOGIDataSet.Logi' . Możesz go przenieść lub usunąć.
            this.logiTableAdapter.Fill(this.lOGIDataSet.Logi);

        }

        private void Usun_dane_Click(object sender, EventArgs e)
        {
                string kwerenda = " TRUNCATE TABLE LOGI ";
                using (connection = new SqlConnection(connectionString2))
                using (SqlCommand command = new SqlCommand(kwerenda, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Baza została wyczyszczona. ", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Wykres_Speed_Time.Update();
            Wykres_Angle_Time.Update();
            Wykres_Temp_Time.Update();
        }


    }
}
