using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EbayPreisBot
{
    public partial class Form_graph_large : Form
    {
        public Chart chart;
        public Form_graph_large(Chart pchart)
        {
            Console.WriteLine("Setting up from graph");
            InitializeComponent();
            chart = pchart;
        }

        private void Form_graph_large_Load(object sender, EventArgs e)
        {
            chart2 = chart;
            Console.WriteLine("Setting up graph in graph large");
            chart2.Series["AVG"] = chart.Series["AVG"];
            chart2.Series["MIN"] = chart.Series["MIN"];
            chart2.Series["MAX"] = chart.Series["MAX"];
        }
    }
}
