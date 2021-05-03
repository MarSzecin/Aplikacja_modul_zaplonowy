using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Pierwsza_apka_Formsy
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        string connectionString;
        private bool mouseDown;
        private Point lastLocation;
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Pierwsza_apka_Formsy.Properties.Settings.Pierwsza_apka_FormsyConnectionString"].ConnectionString;
        }

        private void Po_Kliknieciu_Wroc1(object sender, EventArgs e)
        {
            Visible = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pierwsza_apka_FormsyDataSet1.PUNKTY'.Możesz go przenieść lub usunąć.
            //this.pUNKTYTableAdapter.Fill(this.pierwsza_apka_FormsyDataSet1.PUNKTY);
            Pokaz_mapy();
        }

        private void Pokaz_mapy()
        {
            using (connection = new SqlConnection(connectionString))
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
            string kwerenda = "SELECT PUNKTY.X, PUNKTY.Y FROM PUNKTY INNER JOIN MAPY " +
                "ON PUNKTY.Mapa_Id = MAPY.Mapa_Id WHERE MAPY.Mapa_Id = @MAPA_Id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@MAPA_Id", Lista_Map.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Tabela_RPM_KAT.Rows.Add(reader["X"].ToString(), reader["Y"].ToString());
                    //listBox2.Items.Add(reader["Y"].ToString());
                }

                reader.Close();

            }

        }

        private void listBox1_Zmiana_Indeksu(object sender, EventArgs e)
        {
            Pokaz_punkty();
            /*if (Lista_Map.SelectedIndex < 3)
            {
                Przycisk_Usun_Mape.Hide();
                Przycisk_Edytuj_Nazwe.Hide();
                Przycisk_Edytuj_Punkty.Hide();
            }
            else
            {
                Przycisk_Usun_Mape.Show();
                Przycisk_Edytuj_Nazwe.Show();
                Przycisk_Edytuj_Punkty.Show();
            }*/
        }

        private void Pokliknieciu_Zapisz_Nazwe_Mapy(object sender, EventArgs e)
        {
            Dodaj_nazwe_mapy();
            MessageBox.Show("Nazwa została zapisana. ", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox10.Text = "";


        }

        private void Dodaj_punkty()
        {
            string kwerenda = " INSERT INTO PUNKTY VALUES(@Mapa_Id,0, @Kat1)," +
                "(@Mapa_Id,1000, @Kat2),(@Mapa_Id,2000, @Kat3),(@Mapa_Id,3000, @Kat4)" +
                ",(@Mapa_Id,4000, @Kat5),(@Mapa_Id,5000, @Kat6),(@Mapa_Id,6000, @Kat7)" +
                ",(@Mapa_Id,7000, @Kat8),(@Mapa_Id,8000, @Kat9); ";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Mapa_Id", Lista_Map.SelectedValue);
                command.Parameters.AddWithValue("@Kat1", textBox1.Text);
                command.Parameters.AddWithValue("@Kat2", textBox2.Text);
                command.Parameters.AddWithValue("@Kat3", textBox3.Text);
                command.Parameters.AddWithValue("@Kat4", textBox4.Text);
                command.Parameters.AddWithValue("@Kat5", textBox5.Text);
                command.Parameters.AddWithValue("@Kat6", textBox6.Text);
                command.Parameters.AddWithValue("@Kat7", textBox7.Text);
                command.Parameters.AddWithValue("@Kat8", textBox8.Text);
                command.Parameters.AddWithValue("@Kat9", textBox9.Text);
                command.ExecuteNonQuery();
            }

            Pokaz_mapy();
        }

        private void Dodaj_nazwe_mapy()
        {
            string kwerenda = " INSERT INTO MAPY VALUES (@NazwaMapy)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@NazwaMapy", textBox10.Text);
                command.ExecuteNonQuery();
            }

            Pokaz_mapy();
        }

        private void PoKliknieciu_Mapa_Wgrana_Na_Kontroler(object sender, EventArgs e)
        {
            MessageBox.Show("Mapa została wgrana na mikrokontroler. ", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PoKliknieciu_Zapisz_Punkty(object sender, EventArgs e)
        {
            Dodaj_punkty();
            MessageBox.Show("Punkty zostały zapisane. ", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }


        private void Usun_Mape()
        {
            string kwerenda = " DELETE FROM MAPY WHERE Mapa_Id = @Id_Mapy";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id_Mapy", Lista_Map.SelectedValue);
                command.ExecuteNonQuery();
                Pokaz_mapy();
            }

            Pokaz_mapy();
            MessageBox.Show("Mapa została usunięta z bazy. ", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PoKliknieciu_Usun_Mape(object sender, EventArgs e)
        {
            Usun_Mape();
        }

        private void PoKliknieciu_Edytuj_Nazwe(object sender, EventArgs e)
        {
            Edytuj_Nazwe_Mapy();
        }
        private void PoKliknieciu_Edytuj_Punkty(object sender, EventArgs e)
        {

            Edytuj_Punkty_Mapy();
        }

        private void Edytuj_Nazwe_Mapy()
        {
            string kwerenda = " UPDATE MAPY SET Nazwa = @NazwaMapy WHERE Mapa_Id = @Mapa_Id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@NazwaMapy", textBox10.Text);
                command.Parameters.AddWithValue("@Mapa_Id", Lista_Map.SelectedValue);
                command.ExecuteNonQuery();
            }

            Pokaz_mapy();
            textBox10.Text = "";
        }

        private void Edytuj_Punkty_Mapy()
        {
            string kwerenda = "UPDATE PUNKTY SET Y = @Kat1 WHERE (Mapa_Id = @Mapa_Id AND X = 0)" +
                               "UPDATE PUNKTY SET Y = @Kat2 WHERE (Mapa_Id = @Mapa_Id AND X = 1000)" +
                               "UPDATE PUNKTY SET Y =  @Kat3 WHERE (Mapa_Id = @Mapa_Id AND X = 2000)" +
                               "UPDATE PUNKTY SET Y = @Kat4 WHERE (Mapa_Id = @Mapa_Id AND X = 3000)" +
                               "UPDATE PUNKTY SET Y =  @Kat5 WHERE (Mapa_Id = @Mapa_Id AND X = 4000)" +
                               "UPDATE PUNKTY SET Y = @Kat6 WHERE (Mapa_Id = @Mapa_Id AND X = 5000)" +
                               "UPDATE PUNKTY SET Y = @Kat7 WHERE (Mapa_Id = @Mapa_Id AND X = 6000)" +
                               "UPDATE PUNKTY SET Y = @Kat8 WHERE (Mapa_Id = @Mapa_Id AND X = 7000)" +
                               "UPDATE PUNKTY SET Y =  @Kat9 WHERE (Mapa_Id = @Mapa_Id AND X = 8000)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(kwerenda, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Mapa_Id", Lista_Map.SelectedValue);
                command.Parameters.AddWithValue("@Kat1", textBox1.Text);
                command.Parameters.AddWithValue("@Kat2", textBox2.Text);
                command.Parameters.AddWithValue("@Kat3", textBox3.Text);
                command.Parameters.AddWithValue("@Kat4", textBox4.Text);
                command.Parameters.AddWithValue("@Kat5", textBox5.Text);
                command.Parameters.AddWithValue("@Kat6", textBox6.Text);
                command.Parameters.AddWithValue("@Kat7", textBox7.Text);
                command.Parameters.AddWithValue("@Kat8", textBox8.Text);
                command.Parameters.AddWithValue("@Kat9", textBox9.Text);
                command.ExecuteNonQuery();
            }

            Pokaz_mapy();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox bt = (TextBox)sender;

            if (bt.Text.Length > 0)
            {
                int temp;
                bool canConvert = Int32.TryParse(bt.Text, out temp);

                if (canConvert)
                    temp = Int32.Parse(bt.Text);
                else
                    temp = 0;

                if (temp < 5 || temp > 40 || temp == 0)
                {
                    MessageBox.Show("BŁĄD. ", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt.Text = "";
                }
            }
        }

        private void Pokaz_nazwe_mapy()
        {
            DataRowView row = Lista_Map.SelectedItem as DataRowView;
            textBox10.Text = row["Nazwa"].ToString();
        }


        private void Pokaz_wartosc_punktow()
        {

            List<TextBox> textboxes = new List<TextBox> { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            int i = 0;
            foreach (TextBox textbox in textboxes)
            {
                textbox.Text = Tabela_RPM_KAT.Rows[i].Cells[1].Value.ToString();
                i++;
            }
        }

        private void PoKliknieciu_Kopiuj(object sender, EventArgs e)
        {
            Pokaz_nazwe_mapy();
            Pokaz_wartosc_punktow();
        }

        private void Close_app_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
