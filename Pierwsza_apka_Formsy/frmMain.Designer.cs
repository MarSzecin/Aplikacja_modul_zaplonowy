namespace Pierwsza_apka_Formsy
{
    partial class frmMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Przycisk_wgraj_na_mikrokontroler = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lista_Map = new System.Windows.Forms.ListBox();
            this.pierwsza_apka_FormsyDataSet = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet();
            this.Tabela_RPM_KAT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pierwsza_apka_FormsyDataSet1 = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet1();
            this.pUNKTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUNKTYTableAdapter = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet1TableAdapters.PUNKTYTableAdapter();
            this.Close_app = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pierwsza_apka_FormsyDataSet2 = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet2();
            this.pUNKTYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pUNKTYTableAdapter1 = new Pierwsza_apka_Formsy.Pierwsza_apka_FormsyDataSet2TableAdapters.PUNKTYTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Engine_temp = new System.Windows.Forms.Label();
            this.Wroc1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge31 = new Pierwsza_apka_Formsy.Gauge3();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge21 = new Pierwsza_apka_Formsy.Gauge2();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge11 = new Pierwsza_apka_Formsy.Gauge1();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_RPM_KAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUNKTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUNKTYBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Przycisk_wgraj_na_mikrokontroler
            // 
            this.Przycisk_wgraj_na_mikrokontroler.BackColor = System.Drawing.Color.Black;
            this.Przycisk_wgraj_na_mikrokontroler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_wgraj_na_mikrokontroler.ForeColor = System.Drawing.Color.White;
            this.Przycisk_wgraj_na_mikrokontroler.Location = new System.Drawing.Point(173, 709);
            this.Przycisk_wgraj_na_mikrokontroler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Przycisk_wgraj_na_mikrokontroler.Name = "Przycisk_wgraj_na_mikrokontroler";
            this.Przycisk_wgraj_na_mikrokontroler.Size = new System.Drawing.Size(334, 51);
            this.Przycisk_wgraj_na_mikrokontroler.TabIndex = 8;
            this.Przycisk_wgraj_na_mikrokontroler.Text = "UPLOAD TO THE MICROCONTROLLER";
            this.Przycisk_wgraj_na_mikrokontroler.UseVisualStyleBackColor = false;
            this.Przycisk_wgraj_na_mikrokontroler.Click += new System.EventHandler(this.PoKliknieciu_Mapa_Wgrana_Na_Kontroler);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(675, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 29);
            this.label14.TabIndex = 26;
            this.label14.Text = "Rotation Speed";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(636, 322);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(294, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ignition Advance Angle";
            // 
            // Lista_Map
            // 
            this.Lista_Map.BackColor = System.Drawing.Color.Black;
            this.Lista_Map.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lista_Map.ForeColor = System.Drawing.Color.White;
            this.Lista_Map.FormattingEnabled = true;
            this.Lista_Map.ItemHeight = 18;
            this.Lista_Map.Location = new System.Drawing.Point(193, 509);
            this.Lista_Map.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Lista_Map.Name = "Lista_Map";
            this.Lista_Map.Size = new System.Drawing.Size(119, 184);
            this.Lista_Map.TabIndex = 31;
            this.Lista_Map.SelectedIndexChanged += new System.EventHandler(this.ListBox1_Zmiana_Indeksu);
            // 
            // pierwsza_apka_FormsyDataSet
            // 
            this.pierwsza_apka_FormsyDataSet.DataSetName = "Pierwsza_apka_FormsyDataSet";
            this.pierwsza_apka_FormsyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela_RPM_KAT.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela_RPM_KAT.EnableHeadersVisualStyles = false;
            this.Tabela_RPM_KAT.GridColor = System.Drawing.Color.Black;
            this.Tabela_RPM_KAT.Location = new System.Drawing.Point(363, 509);
            this.Tabela_RPM_KAT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Tabela_RPM_KAT.Name = "Tabela_RPM_KAT";
            this.Tabela_RPM_KAT.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_RPM_KAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabela_RPM_KAT.RowHeadersVisible = false;
            this.Tabela_RPM_KAT.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.Tabela_RPM_KAT.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Tabela_RPM_KAT.RowTemplate.Height = 16;
            this.Tabela_RPM_KAT.Size = new System.Drawing.Size(122, 184);
            this.Tabela_RPM_KAT.TabIndex = 36;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(160, 478);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "AVAILABLE MAPS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(378, 479);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 24);
            this.label16.TabIndex = 39;
            this.label16.Text = "POINTS";
            // 
            // Wykres
            // 
            this.Wykres.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Wykres.BorderlineColor = System.Drawing.Color.Transparent;
            this.Wykres.BorderSkin.BorderWidth = 2;
            this.Wykres.BorderSkin.PageColor = System.Drawing.Color.Red;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.Title = "RPM";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 30D;
            chartArea1.AxisY.Title = "ANGLE[°]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8.285714F;
            legend1.Position.Width = 27.61506F;
            legend1.Position.X = 69.38493F;
            legend1.Position.Y = 3F;
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(11, 113);
            this.Wykres.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Wykres.Name = "Wykres";
            this.Wykres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Wyprzedzenie zapłonu";
            series1.YValuesPerPoint = 2;
            this.Wykres.Series.Add(series1);
            this.Wykres.Size = new System.Drawing.Size(599, 351);
            this.Wykres.TabIndex = 41;
            this.Wykres.Text = "chart1";
            this.Wykres.UseWaitCursor = true;
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
            // Close_app
            // 
            this.Close_app.BackColor = System.Drawing.Color.Red;
            this.Close_app.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_app.ForeColor = System.Drawing.Color.Black;
            this.Close_app.Location = new System.Drawing.Point(918, 12);
            this.Close_app.Name = "Close_app";
            this.Close_app.Size = new System.Drawing.Size(29, 30);
            this.Close_app.TabIndex = 53;
            this.Close_app.Text = "X";
            this.Close_app.UseVisualStyleBackColor = false;
            this.Close_app.Click += new System.EventHandler(this.PoKliknieciu_Close_app);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pierwsza_apka_FormsyDataSet2
            // 
            this.pierwsza_apka_FormsyDataSet2.DataSetName = "Pierwsza_apka_FormsyDataSet2";
            this.pierwsza_apka_FormsyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUNKTYBindingSource1
            // 
            this.pUNKTYBindingSource1.DataMember = "PUNKTY";
            this.pUNKTYBindingSource1.DataSource = this.pierwsza_apka_FormsyDataSet2;
            // 
            // pUNKTYTableAdapter1
            // 
            this.pUNKTYTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(654, 531);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Engine Temperature";
            // 
            // Engine_temp
            // 
            this.Engine_temp.AutoSize = true;
            this.Engine_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine_temp.ForeColor = System.Drawing.Color.White;
            this.Engine_temp.Location = new System.Drawing.Point(525, 611);
            this.Engine_temp.Name = "Engine_temp";
            this.Engine_temp.Size = new System.Drawing.Size(72, 33);
            this.Engine_temp.TabIndex = 55;
            this.Engine_temp.Text = "0 °C";
            // 
            // Wroc1
            // 
            this.Wroc1.BackColor = System.Drawing.Color.Black;
            this.Wroc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wroc1.ForeColor = System.Drawing.Color.White;
            this.Wroc1.Location = new System.Drawing.Point(835, 760);
            this.Wroc1.Name = "Wroc1";
            this.Wroc1.Size = new System.Drawing.Size(116, 46);
            this.Wroc1.TabIndex = 57;
            this.Wroc1.Text = "BACK";
            this.Wroc1.UseVisualStyleBackColor = false;
            this.Wroc1.Click += new System.EventHandler(this.Wroc1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(296, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 54);
            this.label2.TabIndex = 58;
            this.label2.Text = "PARAMETERS";
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(635, 563);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(295, 162);
            this.elementHost3.TabIndex = 59;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.gauge31;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(635, 352);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(295, 158);
            this.elementHost2.TabIndex = 51;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.gauge21;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(635, 151);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(295, 155);
            this.elementHost1.TabIndex = 49;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.gauge11;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(960, 813);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wroc1);
            this.Controls.Add(this.Engine_temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_app);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Tabela_RPM_KAT);
            this.Controls.Add(this.Lista_Map);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Przycisk_wgraj_na_mikrokontroler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IGNITION APP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_RPM_KAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUNKTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pierwsza_apka_FormsyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUNKTYBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Przycisk_wgraj_na_mikrokontroler;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Pierwsza_apka_FormsyDataSet pierwsza_apka_FormsyDataSet;
        private System.Windows.Forms.ListBox Lista_Map;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private Pierwsza_apka_FormsyDataSet1 pierwsza_apka_FormsyDataSet1;
        private System.Windows.Forms.BindingSource pUNKTYBindingSource;
        private Pierwsza_apka_FormsyDataSet1TableAdapters.PUNKTYTableAdapter pUNKTYTableAdapter;
        private System.Windows.Forms.DataGridView Tabela_RPM_KAT;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private Gauge2 gauge21;
        private System.Windows.Forms.Button Close_app;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Timer timer1;
        private Pierwsza_apka_FormsyDataSet2 pierwsza_apka_FormsyDataSet2;
        private System.Windows.Forms.BindingSource pUNKTYBindingSource1;
        private Pierwsza_apka_FormsyDataSet2TableAdapters.PUNKTYTableAdapter pUNKTYTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Engine_temp;
        private System.Windows.Forms.Button Wroc1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private Gauge1 gauge11;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private Gauge3 gauge31;
    }
}

