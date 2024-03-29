﻿using System;
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
            search.DataSource = priceovertimeTableAdapter.GetData().Select(item => item.SearchString).Distinct().ToList();
            
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
            comboBoxplatform.Items.Add("Ebay");
            comboBoxplatform.Items.Add("EbayKleinanzeigen");
            comboBoxplatform.SelectedIndex = 0;

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
            datelist.Clear();
            avglist.Clear();
            minlist.Clear();
            maxlist.Clear();
            priceSearch.Enabled = false;
            listBox1.Items.Clear();
            priceSearch.Text = null;
            progressBar1.Value = 1;
            progressBar1.Maximum = 2;
            progressBar1.Step = 1;
            preisbekommen.search = preisbekommen.search.ToLower();
            searchstate.Text = "Searching...";
            try
            {
                preisbekommen.Test(this);
                searchstate.Text = "Search ready";
            }
            catch (Exception E)
            {
                MessageBox.Show("Error starting search. Please restart the search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchstate.Text = "Error on starting search: " + E;
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
            Console.WriteLine("Show Data");
            sum.Text = preisbekommen.prices.Count.ToString();
            avg.Text = (preisbekommen.sum / preisbekommen.prices.Count).ToString("0.00") + "€";
            min.Text = preisbekommen.min.ToString("0.00") + "€";
            max.Text = preisbekommen.max.ToString("0.00") + "€";

            priceSearch.Enabled = true;
            Console.WriteLine("Show links");
            for (int i = 0; i < preisbekommen.prices.Count; i++)
            {
                listBox1.Items.Add(preisbekommen.prices[i].ToString() + "€");
                try
                {
                    listBox1.Items.Add(preisbekommen.links[i].ToString());
                }
                catch (Exception E) {
                    searchstate.Text = "Error adding links: " + E;
                }
            }
            
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            System.Media.SystemSounds.Beep.Play();
            Console.WriteLine("Upload data");
            //Get Data from database
            DataTable priceovertimedata = priceovertimeTableAdapter.GetData();

            //Search database for searchstring
            for (int i = 0; i < priceovertimedata.Rows.Count; i++)
            {
                //Look if data not exists
                if (priceovertimedata.Rows[i].Field<string>("SearchString") != preisbekommen.search)
                {
                    //Look if data not exists break because data already added
                    if (i == priceovertimedata.Rows.Count - 1)
                    {
                        searchstate.Text = "Data already added to Database";
                        Console.WriteLine("Data already added to Database");
                        break;
                    }
                }
                else
                {
                    if (priceovertimedata.Rows[i].Field<string>("Date") == DateTime.Now.Date.ToString("dd/MM/yyyy"))
                    {
                        for (int j = 0; j < priceovertimedata.Rows.Count; j++)
                        {
                            if (priceovertimedata.Rows[j].Field<string>("SearchString") == preisbekommen.search)
                            {
                                chart1.Series["AVG"].Points.AddXY(priceovertimedata.Rows[j].Field<string>("Date"), priceovertimedata.Rows[j].Field<double>("AVGPrice"));
                                chart1.Series["MIN"].Points.AddXY(priceovertimedata.Rows[j].Field<string>("Date"), priceovertimedata.Rows[j].Field<double>("MINPrice"));
                                chart1.Series["MAX"].Points.AddXY(priceovertimedata.Rows[j].Field<string>("Date"), priceovertimedata.Rows[j].Field<double>("MAXPrice"));

                                datelist.Add(priceovertimedata.Rows[j].Field<string>("Date"));
                                avglist.Add(priceovertimedata.Rows[j].Field<double>("AVGPrice"));
                                minlist.Add(priceovertimedata.Rows[j].Field<double>("MINPrice"));
                                maxlist.Add(priceovertimedata.Rows[j].Field<double>("MAXPrice"));

                                searchstate.Text = "Getting data";
                                Console.WriteLine("Getting data");
                            }
                        }
                        return;
                    }
                    else
                    {
                        if (i == priceovertimedata.Rows.Count - 1)
                        {
                            searchstate.Text = "Data already added to Database";
                            Console.WriteLine("Data already added to Database");
                            break;
                        }
                    }
                }
            }
            try
            {
                // Inserte new Data
                priceovertimeTableAdapter.Insert(priceovertimeTableAdapter.GetData().Rows.Count, DateTime.Now.Date.ToString("dd/MM/yyyy"), preisbekommen.search, preisbekommen.sum / preisbekommen.prices.Count, preisbekommen.max, preisbekommen.min);
                // Get new database
                priceovertimedata = priceovertimeTableAdapter.GetData();
                searchstate.Text = "Uploading Data to Database";
                Console.WriteLine("Uploading Data to Database");

                for (int i = 0; i < priceovertimedata.Rows.Count; i++)
                {
                    if (priceovertimedata.Rows[i].Field<string>("SearchString") == preisbekommen.search)
                    {
                        chart1.Series["AVG"].Points.AddXY(priceovertimedata.Rows[i].Field<string>("Date"), priceovertimedata.Rows[i].Field<double>("AVGPrice"));
                        chart1.Series["MIN"].Points.AddXY(priceovertimedata.Rows[i].Field<string>("Date"), priceovertimedata.Rows[i].Field<double>("MINPrice"));
                        chart1.Series["MAX"].Points.AddXY(priceovertimedata.Rows[i].Field<string>("Date"), priceovertimedata.Rows[i].Field<double>("MAXPrice"));

                        datelist.Add(priceovertimedata.Rows[i].Field<string>("Date"));
                        avglist.Add(priceovertimedata.Rows[i].Field<double>("AVGPrice"));
                        minlist.Add(priceovertimedata.Rows[i].Field<double>("MINPrice"));
                        maxlist.Add(priceovertimedata.Rows[i].Field<double>("MAXPrice"));

                        searchstate.Text = "Getting Data from Database";
                        Console.WriteLine("Getting Data from Database");
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error getting Data, no data found. Please restart the search.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchstate.Text = "Error getting Data: " + E;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                progressBar1.Value = 0;
                return;
            }
            priceovertimedata = null;
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

        private void comboBoxplatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            preisbekommen.platform = comboBoxplatform.SelectedItem.ToString();
            Console.WriteLine(preisbekommen.platform);
        }
    }
}
