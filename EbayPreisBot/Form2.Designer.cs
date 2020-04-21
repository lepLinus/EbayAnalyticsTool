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
            this.userID = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.k117886_ebayscoutDataSet1 = new EbayPreisBot.k117886_ebayscoutDataSet();
            this.esCuserTableAdapter1 = new EbayPreisBot.k117886_ebayscoutDataSetTableAdapters.ESCuserTableAdapter();
            this.priceovertimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.k117886_ebayscoutDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceovertimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDinput
            // 
            this.userIDinput.Location = new System.Drawing.Point(82, 11);
            this.userIDinput.Name = "userIDinput";
            this.userIDinput.Size = new System.Drawing.Size(287, 20);
            this.userIDinput.TabIndex = 0;
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userID.Location = new System.Drawing.Point(12, 9);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(64, 23);
            this.userID.TabIndex = 1;
            this.userID.Text = "UserID:";
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.key.Location = new System.Drawing.Point(16, 42);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(60, 23);
            this.key.TabIndex = 2;
            this.key.Text = "Key:";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(82, 42);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(287, 20);
            this.keyInput.TabIndex = 3;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login.Location = new System.Drawing.Point(12, 77);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(357, 31);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
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
            // priceovertimeBindingSource
            // 
            this.priceovertimeBindingSource.DataMember = "priceovertime";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 117);
            this.Controls.Add(this.login);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.key);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.userIDinput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "eBay-Scouter - Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k117886_ebayscoutDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceovertimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIDinput;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Button login;
        private k117886_ebayscoutDataSet k117886_ebayscoutDataSet1;
        private k117886_ebayscoutDataSetTableAdapters.ESCuserTableAdapter esCuserTableAdapter1;
        protected System.Windows.Forms.BindingSource priceovertimeBindingSource;
    }
}