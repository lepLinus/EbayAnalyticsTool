using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace EbayPreisBot
{
    public partial class Form1 : Form
    {
        static Preisbekommen preisbekommen = new Preisbekommen();
        public DataTable dataTable;

        int currentID;
        string currentKey;
        public List<double> avglist = new List<double>();
        public List<double> minlist = new List<double>();
        public List<double> maxlist = new List<double>();
        public List<string> datelist = new List<string>();


        public Form1(int id, string key)
        {
            InitializeComponent();
            search.DataSource = priceovertimeTableAdapter.GetData();
            search.DisplayMember = "SearchString";
            search.AutoCompleteMode = AutoCompleteMode.Suggest;
            search.AutoCompleteSource = AutoCompleteSource.ListItems;
            search.SelectedIndex = -1;

            currentID = id;
            currentKey = key;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            preisbekommen.search = search.Text;
            if (preisbekommen.search.Length > 0)
            {
                Run.Enabled = true;
            }
            else
            {
                Run.Enabled = false;
            }
        }
        private void search_SelectedIndexChanged(object sender, EventArgs e)
        {
            preisbekommen.search = search.Text;

            if (preisbekommen.search.Length > 0)
            {
                Run.Enabled = true;
            }
            else
            {
                Run.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Run.Enabled = false;
            priceovertimeTableAdapter.Fill(k117886_ebayscoutDataSet.priceovertime);

            comboBox1.Items.Add(Preisbekommen.driverAvailable.Google_Chrome);
            comboBox1.Items.Add(Preisbekommen.driverAvailable.Mozilla_Firefox);
            comboBox1.SelectedIndex = 0;

            sum.Text = "N/A";
            avg.Text = "N/A";
            min.Text = "N/A";
            max.Text = "N/A";

            priceSearch.Enabled = false;
            listBox1.Items.Clear();
            priceSearch.Text = null;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            esCuserTableAdapter1.Update(currentID, currentKey, 0, currentID, currentKey, 1);
            Application.Exit();
        }

        public void AddProgress(int max)
        {
            progressBar1.Maximum = max;
            progressBar1.Increment(1);
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            TaskbarManager.Instance.SetProgressValue(progressBar1.Value, max);
        }

        public void ResetProgress()
        {
            progressBar1.Value = 0;
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
            TaskbarManager.Instance.SetProgressValue(0, 0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate);
            chart1.Series["AVG"].Points.Clear();
            chart1.Series["MAX"].Points.Clear();
            chart1.Series["MIN"].Points.Clear();
            priceSearch.Enabled = false;
            listBox1.Items.Clear();
            priceSearch.Text = null;
            progressBar1.Value = 1;
            progressBar1.Maximum = 2;
            progressBar1.Step = 1;
            preisbekommen.search = preisbekommen.search.ToLower();
            try{
                preisbekommen.Test(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Error starting search. Please restart the search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                progressBar1.Value = 0;
                return;
            }
            progressBar1.Value = 0;

            sum.Text = "N/A";
            avg.Text = "N/A";
            min.Text = "N/A";
            max.Text = "N/A";

            //Show result data
            sum.Text = preisbekommen.prices.Count.ToString();
            avg.Text = (preisbekommen.sum / preisbekommen.prices.Count).ToString("0.00") + "€";
            min.Text = preisbekommen.min.ToString("0.00") + "€";
            max.Text = preisbekommen.max.ToString("0.00") + "€";

            priceSearch.Enabled = true;

            for (int i = 0; i < preisbekommen.prices.Count; i++)
            {
                listBox1.Items.Add(preisbekommen.prices[i].ToString() + "€");
                try
                {
                    listBox1.Items.Add(preisbekommen.links[i].ToString());
                }
                catch (Exception) { }
            }

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            System.Media.SystemSounds.Beep.Play();

            for (int i = 0; i < priceovertimeTableAdapter.GetData().Rows.Count; i++)
            {
                if (priceovertimeTableAdapter.GetData().Rows[i].Field<string>("SearchString") != preisbekommen.search)
                {
                    if (i == priceovertimeTableAdapter.GetData().Rows.Count - 1)
                    {
                        break;
                    }
                }
                else
                {
                    if (priceovertimeTableAdapter.GetData().Rows[i].Field<string>("Date") == System.DateTime.Now.Date.ToString("dd/MM/yyyy"))
                    {
                        for (int j = 0; j < priceovertimeTableAdapter.GetData().Rows.Count; j++)
                        {
                            if (priceovertimeTableAdapter.GetData().Rows[j].Field<string>("SearchString") == preisbekommen.search)
                            {
                                chart1.Series["AVG"].Points.AddXY(priceovertimeTableAdapter.GetData().Rows[j].Field<string>("Date"), priceovertimeTableAdapter.GetData().Rows[j].Field<double>("AVGPrice"));
                                chart1.Series["MIN"].Points.AddXY(priceovertimeTableAdapter.GetData().Rows[j].Field<string>("Date"), priceovertimeTableAdapter.GetData().Rows[j].Field<double>("MINPrice"));
                                chart1.Series["MAX"].Points.AddXY(priceovertimeTableAdapter.GetData().Rows[j].Field<string>("Date"), priceovertimeTableAdapter.GetData().Rows[j].Field<double>("MAXPrice"));
                                datelist.Add(priceovertimeTableAdapter.GetData().Rows[j].Field<string>("Date"));
                                avglist.Add(priceovertimeTableAdapter.GetData().Rows[j].Field<double>("AVGPrice"));
                                minlist.Add(priceovertimeTableAdapter.GetData().Rows[j].Field<double>("MINPrice"));
                                maxlist.Add(priceovertimeTableAdapter.GetData().Rows[j].Field<double>("MAXPrice"));
                            }
                        }
                        return;
                    }
                    else
                    {
                        if (i == priceovertimeTableAdapter.GetData().Rows.Count - 1)
                        {
                            break;
                        }
                    }
                }
            }
            try
            {
                priceovertimeTableAdapter.Insert(priceovertimeTableAdapter.GetData().Rows.Count, System.DateTime.Now.Date.ToString("dd/MM/yyyy"), preisbekommen.search, preisbekommen.sum / preisbekommen.prices.Count, preisbekommen.max, preisbekommen.min);
                for (int i = 0; i < priceovertimeTableAdapter.GetData().Rows.Count; i++)
                {
                    if (priceovertimeTableAdapter.GetData().Rows[i].Field<string>("SearchString") == preisbekommen.search)
                    {
                        chart1.Series["AVG"].Points.AddXY(priceovertimeTableAdapter.GetData().Rows[i].Field<string>("Date"), priceovertimeTableAdapter.GetData().Rows[i].Field<double>("AVGPrice"));
                        chart1.Series["MIN"].Points.AddXY(priceovertimeTableAdapter.GetData().Rows[i].Field<string>("Date"), priceovertimeTableAdapter.GetData().Rows[i].Field<double>("MINPrice"));
                        chart1.Series["MAX"].Points.AddXY(priceovertimeTableAdapter.GetData().Rows[i].Field<string>("Date"), priceovertimeTableAdapter.GetData().Rows[i].Field<double>("MAXPrice"));
                        datelist.Add(priceovertimeTableAdapter.GetData().Rows[i].Field<string>("Date"));
                        avglist.Add(priceovertimeTableAdapter.GetData().Rows[i].Field<double>("AVGPrice"));
                        minlist.Add(priceovertimeTableAdapter.GetData().Rows[i].Field<double>("MINPrice"));
                        maxlist.Add(priceovertimeTableAdapter.GetData().Rows[i].Field<double>("MAXPrice"));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting Data, no data found. Please restart the search.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                progressBar1.Value = 0;
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preisbekommen.driverSelected = (Preisbekommen.driverAvailable)comboBox1.SelectedItem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (string)listBox1.SelectedItem;

            if (str.StartsWith("http"))
            {
                System.Diagnostics.Process.Start(str);
            }
        }

        private void priceSearch_TextChanged(object sender, EventArgs e)
        {
            string input = priceSearch.Text;
            input = input.Replace("€", null);

            try
            {
                double inputNum = Convert.ToDouble(input);

                double closestPriceDifference = 999999;
                int closestPriceIndex = 0;

                List<double> priceWOC = new List<double>();

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        priceWOC.Add(Convert.ToDouble(listBox1.Items[i].ToString().Replace("€", null)));
                    }
                    else
                    {
                        priceWOC.Add(-999999999999999);
                    }
                }

                for (int i = 0; i < priceWOC.Count; i++)
                {
                    if (Math.Abs(inputNum - priceWOC[i]) < closestPriceDifference)
                    {
                        closestPriceDifference = Math.Abs(inputNum - priceWOC[i]);
                        closestPriceIndex = i;
                    }
                }

                listBox1.SelectedIndex = closestPriceIndex;
            }
            catch (Exception)
            {
            
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(preisbekommen.search,avglist,minlist,maxlist,datelist);
            form.Show();
        }

        
    }
}
