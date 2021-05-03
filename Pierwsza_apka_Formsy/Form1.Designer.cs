namespace Pierwsza_apka_Formsy
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Wroc1 = new System.Windows.Forms.Button();
            this.Przycisk_Usun_Mape = new System.Windows.Forms.Button();
            this.Przycisk_Zapisz_Punkty = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Przycisk_zapisz_nazwy_mapy = new System.Windows.Forms.Button();
            this.Przycisk_Edytuj_Nazwe = new System.Windows.Forms.Button();
            this.Przycisk_Edytuj_Punkty = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Tabela_RPM_KAT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista_Map = new System.Windows.Forms.ListBox();
            this.pierwsza_apka_FormsyDataSet = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet();
            this.pierwsza_apka_FormsyDataSet1 = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet1();
            this.pUNKTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUNKTYTableAdapter = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet1TableAdapters.PUNKTYTableAdapter();
            this.Przycisk_Kopiuj_Nazwe_Punkty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_app = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_RPM_KAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUNKTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Wroc1
            // 
            this.Wroc1.BackColor = System.Drawing.Color.Black;
            this.Wroc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wroc1.ForeColor = System.Drawing.Color.White;
            this.Wroc1.Location = new System.Drawing.Point(621, 579);
            this.Wroc1.Name = "Wroc1";
            this.Wroc1.Size = new System.Drawing.Size(116, 46);
            this.Wroc1.TabIndex = 0;
            this.Wroc1.Text = "BACK";
            this.Wroc1.UseVisualStyleBackColor = false;
            this.Wroc1.Click += new System.EventHandler(this.Po_Kliknieciu_Wroc1);
            // 
            // Przycisk_Usun_Mape
            // 
            this.Przycisk_Usun_Mape.BackColor = System.Drawing.Color.Black;
            this.Przycisk_Usun_Mape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_Usun_Mape.ForeColor = System.Drawing.Color.White;
            this.Przycisk_Usun_Mape.Location = new System.Drawing.Point(538, 261);
            this.Przycisk_Usun_Mape.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_Usun_Mape.Name = "Przycisk_Usun_Mape";
            this.Przycisk_Usun_Mape.Size = new System.Drawing.Size(199, 50);
            this.Przycisk_Usun_Mape.TabIndex = 64;
            this.Przycisk_Usun_Mape.Text = "DELETE MAPS";
            this.Przycisk_Usun_Mape.UseVisualStyleBackColor = false;
            this.Przycisk_Usun_Mape.Click += new System.EventHandler(this.PoKliknieciu_Usun_Mape);
            // 
            // Przycisk_Zapisz_Punkty
            // 
            this.Przycisk_Zapisz_Punkty.BackColor = System.Drawing.Color.Black;
            this.Przycisk_Zapisz_Punkty.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Przycisk_Zapisz_Punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_Zapisz_Punkty.ForeColor = System.Drawing.Color.White;
            this.Przycisk_Zapisz_Punkty.Location = new System.Drawing.Point(301, 203);
            this.Przycisk_Zapisz_Punkty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_Zapisz_Punkty.Name = "Przycisk_Zapisz_Punkty";
            this.Przycisk_Zapisz_Punkty.Size = new System.Drawing.Size(199, 50);
            this.Przycisk_Zapisz_Punkty.TabIndex = 63;
            this.Przycisk_Zapisz_Punkty.Text = "SAVE POINTS";
            this.Przycisk_Zapisz_Punkty.UseVisualStyleBackColor = false;
            this.Przycisk_Zapisz_Punkty.Click += new System.EventHandler(this.PoKliknieciu_Zapisz_Punkty);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Black;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(152, 145);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(95, 22);
            this.textBox10.TabIndex = 62;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Black;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(152, 496);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(95, 22);
            this.textBox9.TabIndex = 61;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(152, 457);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(95, 22);
            this.textBox8.TabIndex = 60;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(152, 425);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 22);
            this.textBox7.TabIndex = 59;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(152, 390);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 22);
            this.textBox6.TabIndex = 58;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(152, 352);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 22);
            this.textBox5.TabIndex = 57;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(152, 316);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 22);
            this.textBox4.TabIndex = 56;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(152, 278);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 22);
            this.textBox3.TabIndex = 55;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(152, 238);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 22);
            this.textBox2.TabIndex = 54;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(152, 203);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 22);
            this.textBox1.TabIndex = 53;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(22, 147);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "MAP NAME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(22, 498);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "8000 RPM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(22, 461);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "7000 RPM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(22, 427);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "6000 RPM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(22, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "5000 RPM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(22, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "4000 RPM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(22, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "1000 RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "3000 RPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "2000 RPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "0 RPM";
            // 
            // Przycisk_zapisz_nazwy_mapy
            // 
            this.Przycisk_zapisz_nazwy_mapy.BackColor = System.Drawing.Color.Black;
            this.Przycisk_zapisz_nazwy_mapy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Przycisk_zapisz_nazwy_mapy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_zapisz_nazwy_mapy.ForeColor = System.Drawing.Color.White;
            this.Przycisk_zapisz_nazwy_mapy.Location = new System.Drawing.Point(301, 145);
            this.Przycisk_zapisz_nazwy_mapy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_zapisz_nazwy_mapy.Name = "Przycisk_zapisz_nazwy_mapy";
            this.Przycisk_zapisz_nazwy_mapy.Size = new System.Drawing.Size(199, 50);
            this.Przycisk_zapisz_nazwy_mapy.TabIndex = 41;
            this.Przycisk_zapisz_nazwy_mapy.Text = "SAVE MAP NAME";
            this.Przycisk_zapisz_nazwy_mapy.UseVisualStyleBackColor = false;
            this.Przycisk_zapisz_nazwy_mapy.Click += new System.EventHandler(this.Pokliknieciu_Zapisz_Nazwe_Mapy);
            // 
            // Przycisk_Edytuj_Nazwe
            // 
            this.Przycisk_Edytuj_Nazwe.BackColor = System.Drawing.Color.Black;
            this.Przycisk_Edytuj_Nazwe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Przycisk_Edytuj_Nazwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_Edytuj_Nazwe.ForeColor = System.Drawing.Color.White;
            this.Przycisk_Edytuj_Nazwe.Location = new System.Drawing.Point(538, 145);
            this.Przycisk_Edytuj_Nazwe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_Edytuj_Nazwe.Name = "Przycisk_Edytuj_Nazwe";
            this.Przycisk_Edytuj_Nazwe.Size = new System.Drawing.Size(199, 50);
            this.Przycisk_Edytuj_Nazwe.TabIndex = 66;
            this.Przycisk_Edytuj_Nazwe.Text = "EDIT MAP NAME";
            this.Przycisk_Edytuj_Nazwe.UseVisualStyleBackColor = false;
            this.Przycisk_Edytuj_Nazwe.Click += new System.EventHandler(this.PoKliknieciu_Edytuj_Nazwe);
            // 
            // Przycisk_Edytuj_Punkty
            // 
            this.Przycisk_Edytuj_Punkty.BackColor = System.Drawing.Color.Black;
            this.Przycisk_Edytuj_Punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_Edytuj_Punkty.ForeColor = System.Drawing.Color.White;
            this.Przycisk_Edytuj_Punkty.Location = new System.Drawing.Point(538, 203);
            this.Przycisk_Edytuj_Punkty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_Edytuj_Punkty.Name = "Przycisk_Edytuj_Punkty";
            this.Przycisk_Edytuj_Punkty.Size = new System.Drawing.Size(199, 50);
            this.Przycisk_Edytuj_Punkty.TabIndex = 65;
            this.Przycisk_Edytuj_Punkty.Text = "EDIT POINTS";
            this.Przycisk_Edytuj_Punkty.UseVisualStyleBackColor = false;
            this.Przycisk_Edytuj_Punkty.Click += new System.EventHandler(this.PoKliknieciu_Edytuj_Punkty);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(604, 331);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 25);
            this.label16.TabIndex = 70;
            this.label16.Text = "POINTS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(297, 331);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "AVAILABLE MAPS";
            // 
            // Tabela_RPM_KAT
            // 
            this.Tabela_RPM_KAT.AllowUserToAddRows = false;
            this.Tabela_RPM_KAT.AllowUserToDeleteRows = false;
            this.Tabela_RPM_KAT.AllowUserToResizeColumns = false;
            this.Tabela_RPM_KAT.AllowUserToResizeRows = false;
            this.Tabela_RPM_KAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabela_RPM_KAT.BackgroundColor = System.Drawing.Color.Black;
            this.Tabela_RPM_KAT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_RPM_KAT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabela_RPM_KAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela_RPM_KAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela_RPM_KAT.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tabela_RPM_KAT.EnableHeadersVisualStyles = false;
            this.Tabela_RPM_KAT.GridColor = System.Drawing.Color.Black;
            this.Tabela_RPM_KAT.Location = new System.Drawing.Point(588, 357);
            this.Tabela_RPM_KAT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Tabela_RPM_KAT.Name = "Tabela_RPM_KAT";
            this.Tabela_RPM_KAT.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_RPM_KAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela_RPM_KAT.RowHeadersVisible = false;
            this.Tabela_RPM_KAT.RowHeadersWidth = 51;
            this.Tabela_RPM_KAT.RowTemplate.Height = 16;
            this.Tabela_RPM_KAT.Size = new System.Drawing.Size(123, 184);
            this.Tabela_RPM_KAT.TabIndex = 68;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RPM";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "KĄT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Lista_Map
            // 
            this.Lista_Map.BackColor = System.Drawing.Color.Black;
            this.Lista_Map.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lista_Map.ForeColor = System.Drawing.Color.White;
            this.Lista_Map.FormattingEnabled = true;
            this.Lista_Map.ItemHeight = 18;
            this.Lista_Map.Location = new System.Drawing.Point(336, 357);
            this.Lista_Map.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Lista_Map.Name = "Lista_Map";
            this.Lista_Map.Size = new System.Drawing.Size(121, 184);
            this.Lista_Map.TabIndex = 67;
            this.Lista_Map.SelectedIndexChanged += new System.EventHandler(this.listBox1_Zmiana_Indeksu);
            // 
            // pierwsza_apka_FormsyDataSet
            // 
            this.pierwsza_apka_FormsyDataSet.DataSetName = "Pierwsza_apka_FormsyDataSet";
            this.pierwsza_apka_FormsyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pierwsza_apka_FormsyDataSet1
            // 
            this.pierwsza_apka_FormsyDataSet1.DataSetName = "Pierwsza_apka_FormsyDataSet1";
            this.pierwsza_apka_FormsyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUNKTYBindingSource
            // 
            this.pUNKTYBindingSource.DataMember = "PUNKTY";
            this.pUNKTYBindingSource.DataSource = this.pierwsza_apka_FormsyDataSet1;
            // 
            // pUNKTYTableAdapter
            // 
            this.pUNKTYTableAdapter.ClearBeforeFill = true;
            // 
            // Przycisk_Kopiuj_Nazwe_Punkty
            // 
            this.Przycisk_Kopiuj_Nazwe_Punkty.BackColor = System.Drawing.Color.Black;
            this.Przycisk_Kopiuj_Nazwe_Punkty.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Przycisk_Kopiuj_Nazwe_Punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_Kopiuj_Nazwe_Punkty.ForeColor = System.Drawing.Color.White;
            this.Przycisk_Kopiuj_Nazwe_Punkty.Location = new System.Drawing.Point(301, 261);
            this.Przycisk_Kopiuj_Nazwe_Punkty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_Kopiuj_Nazwe_Punkty.Name = "Przycisk_Kopiuj_Nazwe_Punkty";
            this.Przycisk_Kopiuj_Nazwe_Punkty.Size = new System.Drawing.Size(199, 50);
            this.Przycisk_Kopiuj_Nazwe_Punkty.TabIndex = 71;
            this.Przycisk_Kopiuj_Nazwe_Punkty.Text = "COPY";
            this.Przycisk_Kopiuj_Nazwe_Punkty.UseVisualStyleBackColor = false;
            this.Przycisk_Kopiuj_Nazwe_Punkty.Click += new System.EventHandler(this.PoKliknieciu_Kopiuj);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(287, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 54);
            this.label3.TabIndex = 72;
            this.label3.Text = "MAPS";
            // 
            // Close_app
            // 
            this.Close_app.BackColor = System.Drawing.Color.Red;
            this.Close_app.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_app.ForeColor = System.Drawing.Color.Black;
            this.Close_app.Location = new System.Drawing.Point(711, 12);
            this.Close_app.Name = "Close_app";
            this.Close_app.Size = new System.Drawing.Size(26, 29);
            this.Close_app.TabIndex = 73;
            this.Close_app.Text = "X";
            this.Close_app.UseVisualStyleBackColor = false;
            this.Close_app.Click += new System.EventHandler(this.Close_app_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(750, 636);
            this.ControlBox = false;
            this.Controls.Add(this.Close_app);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Przycisk_Kopiuj_Nazwe_Punkty);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Tabela_RPM_KAT);
            this.Controls.Add(this.Lista_Map);
            this.Controls.Add(this.Przycisk_Edytuj_Nazwe);
            this.Controls.Add(this.Przycisk_Edytuj_Punkty);
            this.Controls.Add(this.Przycisk_Usun_Mape);
            this.Controls.Add(this.Przycisk_Zapisz_Punkty);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Przycisk_zapisz_nazwy_mapy);
            this.Controls.Add(this.Wroc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_RPM_KAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUNKTYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wroc1;
        private System.Windows.Forms.Button Przycisk_Usun_Mape;
        private System.Windows.Forms.Button Przycisk_Zapisz_Punkty;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Przycisk_zapisz_nazwy_mapy;
        private System.Windows.Forms.Button Przycisk_Edytuj_Nazwe;
        private System.Windows.Forms.Button Przycisk_Edytuj_Punkty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView Tabela_RPM_KAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListBox Lista_Map;
        private Pierwsza_apka_FormsyDataSet pierwsza_apka_FormsyDataSet;
        private Pierwsza_apka_FormsyDataSet1 pierwsza_apka_FormsyDataSet1;
        private System.Windows.Forms.BindingSource pUNKTYBindingSource;
        private Pierwsza_apka_FormsyDataSet1TableAdapters.PUNKTYTableAdapter pUNKTYTableAdapter;
        private System.Windows.Forms.Button Przycisk_Kopiuj_Nazwe_Punkty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close_app;
    }
}