using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbayPreisBot
{
    public partial class Form3 : Form
    {
        public string search;
        public List<double> avg;
        public List<double> min;
        public List<double> max;
        public List<string> date;

        public Form3(string psearch, List<double> pavg, List<double> pmin, List<double> pmax, List<string> pdate)
        {
            InitializeComponent();
            avg = pavg;
            min = pmin;
            max = pmax;
            date = pdate;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < date.Count; i++)
                {
                    listBox1.Items.Add(date[i] + ": Avg: " + avg[i].ToString("0.00") + "€" + " Min: " + min[i].ToString("0.00") + "€" + " Max: " + max[i].ToString("0.00") + "€");
                    chart1.Series["AVG"].Points.AddXY(date[i], avg[i]);
                    chart1.Series["MIN"].Points.AddXY(date[i], min[i]);
                    chart1.Series["MAX"].Points.AddXY(date[i], max[i]);
                }
            }
            catch (Exception E)
            {

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
