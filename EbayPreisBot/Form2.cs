﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            esCuserTableAdapter1.Fill(k117886_ebayscoutDataSet1.ESCuser);
        }

        private void login_Click(object sender, EventArgs e)
        {
            int correctID = -1;

            if (userIDinput.Text == esCuserTableAdapter1.GetData().Rows[Convert.ToInt32(userIDinput.Text)].Field<int>("Id").ToString())
            {
                correctID = Convert.ToInt32(userIDinput.Text);
            }
            else
            {
                //ID not found
                return;
            }

            if (keyInput.Text != esCuserTableAdapter1.GetData().Rows[correctID].Field<string>("Key"))
            {
                return;
            }

            if (esCuserTableAdapter1.GetData().Rows[correctID].Field<Int16>("Isused") == 1)
            {
                return;
            }

            //Login
            esCuserTableAdapter1.Update(correctID, keyInput.Text, 1, correctID, keyInput.Text, 0);
            Form1 form = new Form1(correctID, keyInput.Text);
            form.Show();
            this.Hide();
        }
    }
}
