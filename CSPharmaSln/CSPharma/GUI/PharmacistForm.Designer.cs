namespace CSPharma.GUI
{
    partial class PharmacistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistForm));
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.lblSellMedicine = new System.Windows.Forms.Label();
            this.lblPharmacistId = new System.Windows.Forms.Label();
            this.lblPharmacistI = new System.Windows.Forms.Label();
            this.lblPharmacistName = new System.Windows.Forms.Label();
            this.lblPharmacistN = new System.Windows.Forms.Label();
            this.lblViewSalesList = new System.Windows.Forms.Label();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.lblViewSaleDetails = new System.Windows.Forms.Label();
            this.lblSaleIdErr = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblLogo.Location = new System.Drawing.Point(322, 10);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(155, 26);
            this.lblLogo.TabIndex = 37;
            this.lblLogo.Text = "C# PHARMA";
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnEditPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditPassword.ForeColor = System.Drawing.Color.White;
            this.btnEditPassword.Location = new System.Drawing.Point(12, 421);
            this.btnEditPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(149, 46);
            this.btnEditPassword.TabIndex = 35;
            this.btnEditPassword.Text = "Change Password";
            this.btnEditPassword.UseVisualStyleBackColor = false;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // lblSellMedicine
            // 
            this.lblSellMedicine.AutoSize = true;
            this.lblSellMedicine.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellMedicine.ForeColor = System.Drawing.Color.White;
            this.lblSellMedicine.Location = new System.Drawing.Point(47, 168);
            this.lblSellMedicine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellMedicine.Name = "lblSellMedicine";
            this.lblSellMedicine.Size = new System.Drawing.Size(295, 40);
            this.lblSellMedicine.TabIndex = 33;
            this.lblSellMedicine.Text = "SELL MEDICINE";
            this.lblSellMedicine.Click += new System.EventHandler(this.lblSellMedicine_Click);
            this.lblSellMedicine.MouseLeave += new System.EventHandler(this.lblSellMedicine_MouseLeave);
            this.lblSellMedicine.MouseHover += new System.EventHandler(this.lblSellMedicine_MouseHover);
            // 
            // lblPharmacistId
            // 
            this.lblPharmacistId.AutoSize = true;
            this.lblPharmacistId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblPharmacistId.Location = new System.Drawing.Point(151, 103);
            this.lblPharmacistId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPharmacistId.Name = "lblPharmacistId";
            this.lblPharmacistId.Size = new System.Drawing.Size(27, 23);
            this.lblPharmacistId.TabIndex = 32;
            this.lblPharmacistId.Text = "ID";
            // 
            // lblPharmacistI
            // 
            this.lblPharmacistI.AutoSize = true;
            this.lblPharmacistI.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblPharmacistI.Location = new System.Drawing.Point(11, 103);
            this.lblPharmacistI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPharmacistI.Name = "lblPharmacistI";
            this.lblPharmacistI.Size = new System.Drawing.Size(124, 23);
            this.lblPharmacistI.TabIndex = 31;
            this.lblPharmacistI.Text = "Pharmacist ID:";
            // 
            // lblPharmacistName
            // 
            this.lblPharmacistName.AutoSize = true;
            this.lblPharmacistName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblPharmacistName.Location = new System.Drawing.Point(185, 64);
            this.lblPharmacistName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPharmacistName.Name = "lblPharmacistName";
            this.lblPharmacistName.Size = new System.Drawing.Size(61, 23);
            this.lblPharmacistName.TabIndex = 30;
            this.lblPharmacistName.Text = "NAME";
            // 
            // lblPharmacistN
            // 
            this.lblPharmacistN.AutoSize = true;
            this.lblPharmacistN.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblPharmacistN.Location = new System.Drawing.Point(11, 64);
            this.lblPharmacistN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPharmacistN.Name = "lblPharmacistN";
            this.lblPharmacistN.Size = new System.Drawing.Size(158, 23);
            this.lblPharmacistN.TabIndex = 29;
            this.lblPharmacistN.Text = "Pharmacist Name :";
            // 
            // lblViewSalesList
            // 
            this.lblViewSalesList.AutoSize = true;
            this.lblViewSalesList.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSalesList.ForeColor = System.Drawing.Color.White;
            this.lblViewSalesList.Location = new System.Drawing.Point(48, 235);
            this.lblViewSalesList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewSalesList.Name = "lblViewSalesList";
            this.lblViewSalesList.Size = new System.Drawing.Size(289, 36);
            this.lblViewSalesList.TabIndex = 38;
            this.lblViewSalesList.Text = "VIEW SALES LIST";
            this.lblViewSalesList.Click += new System.EventHandler(this.lblViewSalesList_Click);
            this.lblViewSalesList.MouseLeave += new System.EventHandler(this.lblViewSalesList_MouseLeave);
            this.lblViewSalesList.MouseHover += new System.EventHandler(this.lblViewSalesList_MouseHover);
            // 
            // txtSalesID
            // 
            this.txtSalesID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtSalesID.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesID.ForeColor = System.Drawing.Color.Silver;
            this.txtSalesID.Location = new System.Drawing.Point(441, 167);
            this.txtSalesID.MaxLength = 6;
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(271, 41);
            this.txtSalesID.TabIndex = 39;
            this.txtSalesID.Text = "SALE ID";
            this.txtSalesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalesID.Enter += new System.EventHandler(this.txtSalesID_Enter);
            this.txtSalesID.Leave += new System.EventHandler(this.txtSalesID_Leave);
            // 
            // lblViewSaleDetails
            // 
            this.lblViewSaleDetails.AutoSize = true;
            this.lblViewSaleDetails.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSaleDetails.ForeColor = System.Drawing.Color.White;
            this.lblViewSaleDetails.Location = new System.Drawing.Point(408, 235);
            this.lblViewSaleDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewSaleDetails.Name = "lblViewSaleDetails";
            this.lblViewSaleDetails.Size = new System.Drawing.Size(336, 36);
            this.lblViewSaleDetails.TabIndex = 40;
            this.lblViewSaleDetails.Text = "VIEW SALE DETAILS";
            this.lblViewSaleDetails.Click += new System.EventHandler(this.lblViewSaleDetails_Click);
            this.lblViewSaleDetails.MouseLeave += new System.EventHandler(this.lblViewSaleDetails_MouseLeave);
            this.lblViewSaleDetails.MouseHover += new System.EventHandler(this.lblViewSaleDetails_MouseHover);
            // 
            // lblSaleIdErr
            // 
            this.lblSaleIdErr.AutoSize = true;
            this.lblSaleIdErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleIdErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblSaleIdErr.Location = new System.Drawing.Point(493, 211);
            this.lblSaleIdErr.Name = "lblSaleIdErr";
            this.lblSaleIdErr.Size = new System.Drawing.Size(167, 18);
            this.lblSaleIdErr.TabIndex = 41;
            this.lblSaleIdErr.Text = "!Enter A Valid Sale ID";
            this.lblSaleIdErr.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(646, 429);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 39);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(784, 477);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblSaleIdErr);
            this.Controls.Add(this.lblViewSaleDetails);
            this.Controls.Add(this.txtSalesID);
            this.Controls.Add(this.lblViewSalesList);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnEditPassword);
            this.Controls.Add(this.lblSellMedicine);
            this.Controls.Add(this.lblPharmacistId);
            this.Controls.Add(this.lblPharmacistI);
            this.Controls.Add(this.lblPharmacistName);
            this.Controls.Add(this.lblPharmacistN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PharmacistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Label lblSellMedicine;
        private System.Windows.Forms.Label lblPharmacistId;
        private System.Windows.Forms.Label lblPharmacistI;
        private System.Windows.Forms.Label lblPharmacistName;
        private System.Windows.Forms.Label lblPharmacistN;
        private System.Windows.Forms.Label lblViewSalesList;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.Label lblViewSaleDetails;
        private System.Windows.Forms.Label lblSaleIdErr;
        private System.Windows.Forms.Button btnLogout;
    }
}