using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierwsza_apka_Formsy
{
    public partial class MainPage : Form
    {
        private bool mouseDown;
        private Point lastLocation;

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
        public MainPage()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void PoKliknieciu_Polaczenie(object sender, EventArgs e)
        {
            Visible = false;

            Form2 form2 = new Form2();
            form2.Show();

        }

        private void PoKliknieciu_Edycja_Map(object sender, EventArgs e)
        {
            Visible = false;

            Form1 form1 = new Form1();
            form1.Show();

        }
        private void PoKliknieciu_Parameters(object sender, EventArgs e)
        {
            Visible = false;

            frmMain frm = new frmMain();
            frm.Show();

        }

        private void PoKliknieciu_Plots(object sender, EventArgs e)
        {
            Visible = false;

            Plots plots = new Plots();
            plots.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tim.timer_global += 0.5;
            Time.Text = DateTime.Now.ToString();
            //Time.Text = DateTime.Now.TimeOfDay.ToString();
            label1.Text = Tim.timer_global.ToString();
            
        }

    }
}
