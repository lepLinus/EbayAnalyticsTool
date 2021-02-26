namespace EbayPreisBot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Run = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.priceSearch = new System.Windows.Forms.TextBox();
            this.sumtxt = new System.Windows.Forms.Label();
            this.avgtxt = new System.Windows.Forms.Label();
            this.mintxt = new System.Windows.Forms.Label();
            this.maxtxt = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.priceovertimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.search = new System.Windows.Forms.ComboBox();
            this.k117886_ebayscoutDataSet = new EbayPreisBot.k117886_ebayscoutDataSet();
            this.priceovertimeTableAdapter = new EbayPreisBot.k117886_ebayscoutDataSetTableAdapters.priceovertimeTableAdapter();
            this.esCuserTableAdapter1 = new EbayPreisBot.k117886_ebayscoutDataSetTableAdapters.ESCuserTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxplatform = new System.Windows.Forms.ComboBox();
            this.searchstate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceovertimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k117886_ebayscoutDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.progressBar1.Location = new System.Drawing.Point(18, 638);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1162, 35);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(237)))));
            this.Run.FlatAppearance.BorderSize = 0;
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.ForeColor = System.Drawing.Color.White;
            this.Run.Location = new System.Drawing.Point(1051, 598);
            this.Run.Margin = new System.Windows.Forms.Padding(0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(129, 35);
            this.Run.TabIndex = 1;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(855, 598);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 29);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 566);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1162, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "To run the programm please type in your item name, select your browser and click " +
    "run.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // avg
            // 
            this.avg.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg.ForeColor = System.Drawing.Color.White;
            this.avg.Location = new System.Drawing.Point(312, 451);
            this.avg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(284, 115);
            this.avg.TabIndex = 7;
            this.avg.Text = "N/A";
            this.avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Location = new System.Drawing.Point(604, 451);
            this.min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(284, 115);
            this.min.TabIndex = 8;
            this.min.Text = "N/A";
            this.min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.ForeColor = System.Drawing.Color.White;
            this.max.Location = new System.Drawing.Point(897, 451);
            this.max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(284, 115);
            this.max.TabIndex = 9;
            this.max.Text = "N/A";
            this.max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(18, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 342);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(615, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Legend = "Legend1";
            series1.Name = "AVG";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Turquoise;
            series2.Legend = "Legend1";
            series2.Name = "MIN";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "MAX";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(566, 386);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // priceSearch
            // 
            this.priceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.priceSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceSearch.ForeColor = System.Drawing.Color.White;
            this.priceSearch.Location = new System.Drawing.Point(18, 18);
            this.priceSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceSearch.Name = "priceSearch";
            this.priceSearch.Size = new System.Drawing.Size(568, 19);
            this.priceSearch.TabIndex = 12;
            this.priceSearch.Text = "Search for price";
            this.priceSearch.TextChanged += new System.EventHandler(this.priceSearch_TextChanged);
            // 
            // sumtxt
            // 
            this.sumtxt.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumtxt.ForeColor = System.Drawing.Color.White;
            this.sumtxt.Location = new System.Drawing.Point(18, 415);
            this.sumtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumtxt.Name = "sumtxt";
            this.sumtxt.Size = new System.Drawing.Size(290, 35);
            this.sumtxt.TabIndex = 13;
            this.sumtxt.Text = "SUM:";
            this.sumtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgtxt
            // 
            this.avgtxt.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgtxt.ForeColor = System.Drawing.Color.White;
            this.avgtxt.Location = new System.Drawing.Point(316, 415);
            this.avgtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avgtxt.Name = "avgtxt";
            this.avgtxt.Size = new System.Drawing.Size(279, 35);
            this.avgtxt.TabIndex = 14;
            this.avgtxt.Text = "AVG:";
            this.avgtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mintxt
            // 
            this.mintxt.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintxt.ForeColor = System.Drawing.Color.White;
            this.mintxt.Location = new System.Drawing.Point(604, 415);
            this.mintxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mintxt.Name = "mintxt";
            this.mintxt.Size = new System.Drawing.Size(284, 35);
            this.mintxt.TabIndex = 15;
            this.mintxt.Text = "MIN:";
            this.mintxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxtxt
            // 
            this.maxtxt.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtxt.ForeColor = System.Drawing.Color.White;
            this.maxtxt.Location = new System.Drawing.Point(897, 415);
            this.maxtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxtxt.Name = "maxtxt";
            this.maxtxt.Size = new System.Drawing.Size(284, 35);
            this.maxtxt.TabIndex = 16;
            this.maxtxt.Text = "MAX:";
            this.maxtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Cursor = System.Windows.Forms.Cursors.No;
            this.sum.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.ForeColor = System.Drawing.Color.White;
            this.sum.Location = new System.Drawing.Point(18, 451);
            this.sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(290, 115);
            this.sum.TabIndex = 6;
            this.sum.Text = "N/A";
            this.sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // priceovertimeBindingSource
            // 
            this.priceovertimeBindingSource.DataMember = "priceovertime";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.search.FormattingEnabled = true;
            this.search.IntegralHeight = false;
            this.search.Location = new System.Drawing.Point(18, 598);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.MaxDropDownItems = 3;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(630, 29);
            this.search.TabIndex = 17;
            this.search.Text = "Search";
            this.search.SelectedIndexChanged += new System.EventHandler(this.search_SelectedIndexChanged);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // k117886_ebayscoutDataSet
            // 
            this.k117886_ebayscoutDataSet.DataSetName = "k117886_ebayscoutDataSet";
            this.k117886_ebayscoutDataSet.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.k117886_ebayscoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceovertimeTableAdapter
            // 
            this.priceovertimeTableAdapter.ClearBeforeFill = true;
            // 
            // esCuserTableAdapter1
            // 
            this.esCuserTableAdapter1.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 5);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // comboBoxplatform
            // 
            this.comboBoxplatform.BackColor = System.Drawing.Color.White;
            this.comboBoxplatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxplatform.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxplatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.comboBoxplatform.FormattingEnabled = true;
            this.comboBoxplatform.Location = new System.Drawing.Point(663, 598);
            this.comboBoxplatform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxplatform.Name = "comboBoxplatform";
            this.comboBoxplatform.Size = new System.Drawing.Size(184, 29);
            this.comboBoxplatform.TabIndex = 19;
            this.comboBoxplatform.SelectedIndexChanged += new System.EventHandler(this.comboBoxplatform_SelectedIndexChanged);
            // 
            // searchstate
            // 
            this.searchstate.BackColor = System.Drawing.Color.Transparent;
            this.searchstate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchstate.ForeColor = System.Drawing.Color.White;
            this.searchstate.Location = new System.Drawing.Point(18, 633);
            this.searchstate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchstate.Name = "searchstate";
            this.searchstate.Size = new System.Drawing.Size(1162, 25);
            this.searchstate.TabIndex = 20;
            this.searchstate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1216, 689);
            this.Controls.Add(this.searchstate);
            this.Controls.Add(this.comboBoxplatform);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.maxtxt);
            this.Controls.Add(this.mintxt);
            this.Controls.Add(this.avgtxt);
            this.Controls.Add(this.sumtxt);
            this.Controls.Add(this.priceSearch);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1238, 745);
            this.MinimumSize = new System.Drawing.Size(1238, 745);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ebay-Scouter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceovertimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k117886_ebayscoutDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox priceSearch;
        private System.Windows.Forms.Label sumtxt;
        private System.Windows.Forms.Label avgtxt;
        private System.Windows.Forms.Label mintxt;
        private System.Windows.Forms.Label maxtxt;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.ComboBox search;
        protected k117886_ebayscoutDataSet k117886_ebayscoutDataSet;
        protected System.Windows.Forms.BindingSource priceovertimeBindingSource;
        protected k117886_ebayscoutDataSetTableAdapters.priceovertimeTableAdapter priceovertimeTableAdapter;
        private k117886_ebayscoutDataSetTableAdapters.ESCuserTableAdapter esCuserTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxplatform;
        public System.Windows.Forms.Label searchstate;
    }
}

