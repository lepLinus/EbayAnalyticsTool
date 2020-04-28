using EbayPreisBot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbayPreisBot
{ 
    public partial class Form2 : Form
    {
        int correctID = -1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                Settings.Default.Reset();
            }
            try
            {
                esCuserTableAdapter1.Fill(k117886_ebayscoutDataSet1.ESCuser);
            }
            catch (Exception E)
            {
                MessageBox.Show("Connection to server lost", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            userIDinput.Text = null;
            keyInput.Text = null;
            correctID = -1;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.UserID > -1)
                {
                    userIDinput.Text = Settings.Default.UserID.ToString();
                    keyInput.Text = Settings.Default.Key;
                    correctID = Settings.Default.UserID;
                    Login();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Saved login data incorrect", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (userIDinput.Text == esCuserTableAdapter1.GetData().Rows[Convert.ToInt32(userIDinput.Text)].Field<int>("Id").ToString())
                {
                    correctID = Convert.ToInt32(userIDinput.Text);
                }
            }
            catch (Exception)
            {
                //ID not found
                MessageBox.Show("UserID not found.", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyInput.Text != esCuserTableAdapter1.GetData().Rows[correctID].Field<string>("Key"))
            {
                MessageBox.Show("Key not found.", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (esCuserTableAdapter1.GetData().Rows[correctID].Field<Int16>("Isused") == 1)
            {
                MessageBox.Show("User already logged in.", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Login
            Login();
        }

        public void Login()
        {
            if (esCuserTableAdapter1.GetData().Rows[correctID].Field<Int16>("Isused") == 0)
            {
                esCuserTableAdapter1.Update(correctID, keyInput.Text, 1, correctID, keyInput.Text, 0);
                Form1 form = new Form1(correctID, keyInput.Text);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User already logged in.", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (savekeycheck.Checked)
            {
                Settings.Default.UserID = correctID;
                Settings.Default.Key = keyInput.Text;
                Settings.Default.Save();
            }
        }

        private void userIDinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void userIDinput_Enter(object sender, EventArgs e)
        {
            if (userIDinput.Text == "UserID")
            {
                userIDinput.Text = "";
            }
        }
        private void userIDinput_Leave(object sender, EventArgs e)
        {
            if (userIDinput.Text == "")
            {
                userIDinput.Text = "UserID";
            }
        }
        private void keyInput_Enter(object sender, EventArgs e)
        {
            if (keyInput.Text == "Key")
            {
                keyInput.Text = "";
            }
        }
        private void keyInput_Leave(object sender, EventArgs e)
        {
            if (keyInput.Text == "")
            {
                keyInput.Text = "Key";
            }
        }
    }
}
