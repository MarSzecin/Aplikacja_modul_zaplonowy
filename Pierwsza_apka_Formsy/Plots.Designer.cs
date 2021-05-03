
namespace Pierwsza_apka_Formsy
{
    partial class Plots
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plots));
            this.Wroc1 = new System.Windows.Forms.Button();
            this.Close_app = new System.Windows.Forms.Button();
            this.Usun_dane = new System.Windows.Forms.Button();
            this.Wykres_Angle_Time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOGIDataSet = new Pierwsza_apka_Formsy.LOGIDataSet();
            this.Wykres_Speed_Time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Wykres_Temp_Time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logiTableAdapter = new Pierwsza_apka_Formsy.LOGIDataSetTableAdapters.LogiTableAdapter();
            this.tableAdapterManager = new Pierwsza_apka_Formsy.LOGIDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres_Angle_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres_Speed_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres_Temp_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // Wroc1
            // 
            this.Wroc1.BackColor = System.Drawing.Color.Black;
            this.Wroc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wroc1.ForeColor = System.Drawing.Color.White;
            this.Wroc1.Location = new System.Drawing.Point(520, 810);
            this.Wroc1.Name = "Wroc1";
            this.Wroc1.Size = new System.Drawing.Size(116, 46);
            this.Wroc1.TabIndex = 58;
            this.Wroc1.Text = "BACK";
            this.Wroc1.UseVisualStyleBackColor = false;
            this.Wroc1.Click += new System.EventHandler(this.Wroc1_Click);
            // 
            // Close_app
            // 
            this.Close_app.BackColor = System.Drawing.Color.Red;
            this.Close_app.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_app.ForeColor = System.Drawing.Color.Black;
            this.Close_app.Location = new System.Drawing.Point(613, 12);
            this.Close_app.Name = "Close_app";
            this.Close_app.Size = new System.Drawing.Size(23, 25);
            this.Close_app.TabIndex = 59;
            this.Close_app.Text = "X";
            this.Close_app.UseVisualStyleBackColor = false;
            this.Close_app.Click += new System.EventHandler(this.PoKliknieciu_Close_app);
            // 
            // Usun_dane
            // 
            this.Usun_dane.BackColor = System.Drawing.Color.Black;
            this.Usun_dane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usun_dane.ForeColor = System.Drawing.Color.White;
            this.Usun_dane.Location = new System.Drawing.Point(155, 810);
            this.Usun_dane.Name = "Usun_dane";
            this.Usun_dane.Size = new System.Drawing.Size(182, 46);
            this.Usun_dane.TabIndex = 61;
            this.Usun_dane.Text = "CLEAN DATABASE";
            this.Usun_dane.UseVisualStyleBackColor = false;
            this.Usun_dane.Click += new System.EventHandler(this.Usun_dane_Click);
            // 
            // Wykres_Angle_Time
            // 
            this.Wykres_Angle_Time.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Title = "t[s]";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "ANGLE[°]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Wykres_Angle_Time.ChartAreas.Add(chartArea1);
            this.Wykres_Angle_Time.DataSource = this.logiBindingSource1;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.Wykres_Angle_Time.Legends.Add(legend1);
            this.Wykres_Angle_Time.Location = new System.Drawing.Point(42, 278);
            this.Wykres_Angle_Time.Name = "Wykres_Angle_Time";
            this.Wykres_Angle_Time.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.XValueMember = "Time";
            series1.YValueMembers = "Angle";
            this.Wykres_Angle_Time.Series.Add(series1);
            this.Wykres_Angle_Time.Size = new System.Drawing.Size(531, 260);
            this.Wykres_Angle_Time.TabIndex = 62;
            this.Wykres_Angle_Time.Text = "chart1";
            // 
            // logiBindingSource1
            // 
            this.logiBindingSource1.DataMember = "Logi";
            this.logiBindingSource1.DataSource = this.lOGIDataSet;
            // 
            // lOGIDataSet
            // 
            this.lOGIDataSet.DataSetName = "LOGIDataSet";
            this.lOGIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Wykres_Speed_Time
            // 
            this.Wykres_Speed_Time.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.Title = "t[s]";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.Title = "RPM";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.Wykres_Speed_Time.ChartAreas.Add(chartArea2);
            this.Wykres_Speed_Time.DataSource = this.logiBindingSource1;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.Wykres_Speed_Time.Legends.Add(legend2);
            this.Wykres_Speed_Time.Location = new System.Drawing.Point(42, 12);
            this.Wykres_Speed_Time.Name = "Wykres_Speed_Time";
            this.Wykres_Speed_Time.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.White;
            series2.XValueMember = "Time";
            series2.YValueMembers = "Speed";
            this.Wykres_Speed_Time.Series.Add(series2);
            this.Wykres_Speed_Time.Size = new System.Drawing.Size(531, 260);
            this.Wykres_Speed_Time.TabIndex = 63;
            this.Wykres_Speed_Time.Text = "chart2";
            title1.DockedToChartArea = "ChartArea1";
            title1.Name = "Title1";
            this.Wykres_Speed_Time.Titles.Add(title1);
            // 
            // Wykres_Temp_Time
            // 
            this.Wykres_Temp_Time.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.Title = "t[s]";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.Title = "TEMPERATURE[°C]";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.Wykres_Temp_Time.ChartAreas.Add(chartArea3);
            this.Wykres_Temp_Time.DataSource = this.logiBindingSource1;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.Wykres_Temp_Time.Legends.Add(legend3);
            this.Wykres_Temp_Time.Location = new System.Drawing.Point(42, 544);
            this.Wykres_Temp_Time.Name = "Wykres_Temp_Time";
            this.Wykres_Temp_Time.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.ShadowColor = System.Drawing.Color.White;
            series3.XValueMember = "Time";
            series3.YValueMembers = "Temperature";
            this.Wykres_Temp_Time.Series.Add(series3);
            this.Wykres_Temp_Time.Size = new System.Drawing.Size(531, 260);
            this.Wykres_Temp_Time.TabIndex = 64;
            this.Wykres_Temp_Time.Text = "chart1";
            // 
            // logiTableAdapter
            // 
            this.logiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LogiTableAdapter = this.logiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pierwsza_apka_Formsy.LOGIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Plots
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(656, 868);
            this.Controls.Add(this.Wykres_Temp_Time);
            this.Controls.Add(this.Wykres_Speed_Time);
            this.Controls.Add(this.Wykres_Angle_Time);
            this.Controls.Add(this.Usun_dane);
            this.Controls.Add(this.Close_app);
            this.Controls.Add(this.Wroc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Plots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plots";
            this.Load += new System.EventHandler(this.Plots_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Wykres_Angle_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres_Speed_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres_Temp_Time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wroc1;
        private System.Windows.Forms.Button Close_app;
        private LOGIDataSet lOGIDataSet;
        private LOGIDataSetTableAdapters.LogiTableAdapter logiTableAdapter;
        private LOGIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Usun_dane;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres_Angle_Time;
        private System.Windows.Forms.BindingSource logiBindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres_Speed_Time;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres_Temp_Time;
    }
}