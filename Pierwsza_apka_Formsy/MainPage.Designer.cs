
namespace Pierwsza_apka_Formsy
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Napis_MainPage = new System.Windows.Forms.Label();
            this.Polaczenie = new System.Windows.Forms.Button();
            this.Edycja_map = new System.Windows.Forms.Button();
            this.Parametry = new System.Windows.Forms.Button();
            this.Wykresy = new System.Windows.Forms.Button();
            this.Close_app = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Napis_MainPage
            // 
            this.Napis_MainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Napis_MainPage.Location = new System.Drawing.Point(72, 78);
            this.Napis_MainPage.Name = "Napis_MainPage";
            this.Napis_MainPage.Size = new System.Drawing.Size(318, 60);
            this.Napis_MainPage.TabIndex = 0;
            this.Napis_MainPage.Text = "MAIN PAGE";
            this.Napis_MainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Polaczenie
            // 
            this.Polaczenie.BackColor = System.Drawing.Color.Black;
            this.Polaczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Polaczenie.ForeColor = System.Drawing.Color.White;
            this.Polaczenie.Location = new System.Drawing.Point(129, 208);
            this.Polaczenie.Name = "Polaczenie";
            this.Polaczenie.Size = new System.Drawing.Size(200, 53);
            this.Polaczenie.TabIndex = 47;
            this.Polaczenie.Text = "CONNECTION";
            this.Polaczenie.UseVisualStyleBackColor = false;
            this.Polaczenie.Click += new System.EventHandler(this.PoKliknieciu_Polaczenie);
            // 
            // Edycja_map
            // 
            this.Edycja_map.BackColor = System.Drawing.Color.Black;
            this.Edycja_map.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edycja_map.ForeColor = System.Drawing.Color.White;
            this.Edycja_map.Location = new System.Drawing.Point(129, 285);
            this.Edycja_map.Name = "Edycja_map";
            this.Edycja_map.Size = new System.Drawing.Size(200, 53);
            this.Edycja_map.TabIndex = 48;
            this.Edycja_map.Text = "MAPS";
            this.Edycja_map.UseVisualStyleBackColor = false;
            this.Edycja_map.Click += new System.EventHandler(this.PoKliknieciu_Edycja_Map);
            // 
            // Parametry
            // 
            this.Parametry.BackColor = System.Drawing.Color.Black;
            this.Parametry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Parametry.ForeColor = System.Drawing.Color.White;
            this.Parametry.Location = new System.Drawing.Point(129, 361);
            this.Parametry.Name = "Parametry";
            this.Parametry.Size = new System.Drawing.Size(200, 53);
            this.Parametry.TabIndex = 49;
            this.Parametry.Text = "PARAMETERS";
            this.Parametry.UseVisualStyleBackColor = false;
            this.Parametry.Click += new System.EventHandler(this.PoKliknieciu_Parameters);
            // 
            // Wykresy
            // 
            this.Wykresy.BackColor = System.Drawing.Color.Black;
            this.Wykresy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wykresy.ForeColor = System.Drawing.Color.White;
            this.Wykresy.Location = new System.Drawing.Point(129, 437);
            this.Wykresy.Name = "Wykresy";
            this.Wykresy.Size = new System.Drawing.Size(200, 53);
            this.Wykresy.TabIndex = 50;
            this.Wykresy.Text = "PLOTS";
            this.Wykresy.UseVisualStyleBackColor = false;
            this.Wykresy.Click += new System.EventHandler(this.PoKliknieciu_Plots);
            // 
            // Close_app
            // 
            this.Close_app.BackColor = System.Drawing.Color.Red;
            this.Close_app.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_app.ForeColor = System.Drawing.Color.Black;
            this.Close_app.Location = new System.Drawing.Point(430, 12);
            this.Close_app.Name = "Close_app";
            this.Close_app.Size = new System.Drawing.Size(23, 25);
            this.Close_app.TabIndex = 54;
            this.Close_app.Text = "X";
            this.Close_app.UseVisualStyleBackColor = false;
            this.Close_app.Click += new System.EventHandler(this.PoKliknieciu_Close_app);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(283, 542);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(60, 25);
            this.Time.TabIndex = 57;
            this.Time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 542);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "timer";
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(465, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Close_app);
            this.Controls.Add(this.Wykresy);
            this.Controls.Add(this.Parametry);
            this.Controls.Add(this.Edycja_map);
            this.Controls.Add(this.Polaczenie);
            this.Controls.Add(this.Napis_MainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Napis_MainPage;
        private System.Windows.Forms.Button Polaczenie;
        private System.Windows.Forms.Button Edycja_map;
        private System.Windows.Forms.Button Parametry;
        private System.Windows.Forms.Button Wykresy;
        private System.Windows.Forms.Button Close_app;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}