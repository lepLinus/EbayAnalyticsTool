namespace EbayPreisBot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.userIDinput = new System.Windows.Forms.TextBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.priceovertimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.k117886_ebayscoutDataSet1 = new EbayPreisBot.k117886_ebayscoutDataSet();
            this.esCuserTableAdapter1 = new EbayPreisBot.k117886_ebayscoutDataSetTableAdapters.ESCuserTableAdapter();
            this.savekeycheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceovertimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k117886_ebayscoutDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDinput
            // 
            this.userIDinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.userIDinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIDinput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDinput.ForeColor = System.Drawing.Color.White;
            this.userIDinput.Location = new System.Drawing.Point(13, 172);
            this.userIDinput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userIDinput.Name = "userIDinput";
            this.userIDinput.Size = new System.Drawing.Size(395, 28);
            this.userIDinput.TabIndex = 0;
            this.userIDinput.Text = "UserID";
            this.userIDinput.TextChanged += new System.EventHandler(this.userIDinput_TextChanged);
            this.userIDinput.Enter += new System.EventHandler(this.userIDinput_Enter);
            this.userIDinput.Leave += new System.EventHandler(this.userIDinput_Leave);
            // 
            // keyInput
            // 
            this.keyInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.keyInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput.ForeColor = System.Drawing.Color.White;
            this.keyInput.Location = new System.Drawing.Point(13, 249);
            this.keyInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(396, 28);
            this.keyInput.TabIndex = 3;
            this.keyInput.Text = "Key";
            this.keyInput.Enter += new System.EventHandler(this.keyInput_Enter);
            this.keyInput.Leave += new System.EventHandler(this.keyInput_Leave);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(237)))));
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(125, 400);
            this.login.Margin = new System.Windows.Forms.Padding(0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 60);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // priceovertimeBindingSource
            // 
            this.priceovertimeBindingSource.DataMember = "priceovertime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(14, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 5);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(13, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 5);
            this.panel2.TabIndex = 8;
            // 
            // k117886_ebayscoutDataSet1
            // 
            this.k117886_ebayscoutDataSet1.DataSetName = "k117886_ebayscoutDataSet";
            this.k117886_ebayscoutDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // esCuserTableAdapter1
            // 
            this.esCuserTableAdapter1.ClearBeforeFill = true;
            // 
            // savekeycheck
            // 
            this.savekeycheck.AutoSize = true;
            this.savekeycheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savekeycheck.ForeColor = System.Drawing.Color.White;
            this.savekeycheck.Location = new System.Drawing.Point(14, 288);
            this.savekeycheck.Name = "savekeycheck";
            this.savekeycheck.Size = new System.Drawing.Size(102, 24);
            this.savekeycheck.TabIndex = 9;
            this.savekeycheck.Text = "Save data";
            this.savekeycheck.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(418, 500);
            this.Controls.Add(this.savekeycheck);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.userIDinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBay-Scouter - Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.priceovertimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k117886_ebayscoutDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIDinput;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Button login;
        private k117886_ebayscoutDataSet k117886_ebayscoutDataSet1;
        private k117886_ebayscoutDataSetTableAdapters.ESCuserTableAdapter esCuserTableAdapter1;
        protected System.Windows.Forms.BindingSource priceovertimeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox savekeycheck;
    }
}