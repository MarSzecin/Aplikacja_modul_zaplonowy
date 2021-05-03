namespace Pierwsza_apka_Formsy
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Combobox_Port = new System.Windows.Forms.ComboBox();
            this.Combobox_Predkosc = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Kontrolka = new System.Windows.Forms.Button();
            this.Close_app = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(411, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PoKliknieciu_Wroc);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONNECTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "SELECT  PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "SELECT SPEED";
            // 
            // Combobox_Port
            // 
            this.Combobox_Port.FormattingEnabled = true;
            this.Combobox_Port.Location = new System.Drawing.Point(250, 157);
            this.Combobox_Port.Name = "Combobox_Port";
            this.Combobox_Port.Size = new System.Drawing.Size(156, 24);
            this.Combobox_Port.TabIndex = 4;
            // 
            // Combobox_Predkosc
            // 
            this.Combobox_Predkosc.FormattingEnabled = true;
            this.Combobox_Predkosc.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800"});
            this.Combobox_Predkosc.Location = new System.Drawing.Point(250, 275);
            this.Combobox_Predkosc.Name = "Combobox_Predkosc";
            this.Combobox_Predkosc.Size = new System.Drawing.Size(156, 24);
            this.Combobox_Predkosc.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(411, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "CONNECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Po_Kliknieciu_Polacz);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONNECTION STATUS";
            // 
            // Kontrolka
            // 
            this.Kontrolka.BackColor = System.Drawing.Color.Green;
            this.Kontrolka.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.Kontrolka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kontrolka.Location = new System.Drawing.Point(309, 369);
            this.Kontrolka.Name = "Kontrolka";
            this.Kontrolka.Size = new System.Drawing.Size(41, 41);
            this.Kontrolka.TabIndex = 8;
            this.Kontrolka.UseVisualStyleBackColor = false;
            // 
            // Close_app
            // 
            this.Close_app.BackColor = System.Drawing.Color.Red;
            this.Close_app.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_app.ForeColor = System.Drawing.Color.Black;
            this.Close_app.Location = new System.Drawing.Point(508, 12);
            this.Close_app.Name = "Close_app";
            this.Close_app.Size = new System.Drawing.Size(25, 29);
            this.Close_app.TabIndex = 54;
            this.Close_app.Text = "X";
            this.Close_app.UseVisualStyleBackColor = false;
            this.Close_app.Click += new System.EventHandler(this.PoKliknieciu_Close_app);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(546, 479);
            this.ControlBox = false;
            this.Controls.Add(this.Close_app);
            this.Controls.Add(this.Kontrolka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Combobox_Predkosc);
            this.Controls.Add(this.Combobox_Port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combobox_Port;
        private System.Windows.Forms.ComboBox Combobox_Predkosc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Kontrolka;
        private System.Windows.Forms.Button Close_app;
    }
}