namespace CSPharma.GUI
{
    partial class ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistForm));
            this.lblReceptionistId = new System.Windows.Forms.Label();
            this.lblReceptionistI = new System.Windows.Forms.Label();
            this.lblReceptionistName = new System.Windows.Forms.Label();
            this.lblReceptionistN = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.lblUpdateAnAppointment = new System.Windows.Forms.Label();
            this.lblCreateAnAppointMent = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.lblViewAptList = new System.Windows.Forms.Label();
            this.lblAptIdError = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceptionistId
            // 
            this.lblReceptionistId.AutoSize = true;
            this.lblReceptionistId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblReceptionistId.Location = new System.Drawing.Point(150, 102);
            this.lblReceptionistId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceptionistId.Name = "lblReceptionistId";
            this.lblReceptionistId.Size = new System.Drawing.Size(27, 23);
            this.lblReceptionistId.TabIndex = 18;
            this.lblReceptionistId.Text = "ID";
            // 
            // lblReceptionistI
            // 
            this.lblReceptionistI.AutoSize = true;
            this.lblReceptionistI.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblReceptionistI.Location = new System.Drawing.Point(10, 102);
            this.lblReceptionistI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceptionistI.Name = "lblReceptionistI";
            this.lblReceptionistI.Size = new System.Drawing.Size(136, 23);
            this.lblReceptionistI.TabIndex = 17;
            this.lblReceptionistI.Text = "Receptionist ID:";
            // 
            // lblReceptionistName
            // 
            this.lblReceptionistName.AutoSize = true;
            this.lblReceptionistName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblReceptionistName.Location = new System.Drawing.Point(184, 63);
            this.lblReceptionistName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceptionistName.Name = "lblReceptionistName";
            this.lblReceptionistName.Size = new System.Drawing.Size(61, 23);
            this.lblReceptionistName.TabIndex = 16;
            this.lblReceptionistName.Text = "NAME";
            // 
            // lblReceptionistN
            // 
            this.lblReceptionistN.AutoSize = true;
            this.lblReceptionistN.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblReceptionistN.Location = new System.Drawing.Point(10, 63);
            this.lblReceptionistN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceptionistN.Name = "lblReceptionistN";
            this.lblReceptionistN.Size = new System.Drawing.Size(170, 23);
            this.lblReceptionistN.TabIndex = 15;
            this.lblReceptionistN.Text = "Receptionist Name :";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblLogo.Location = new System.Drawing.Point(321, 9);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(155, 26);
            this.lblLogo.TabIndex = 25;
            this.lblLogo.Text = "C# PHARMA";
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnEditPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditPassword.ForeColor = System.Drawing.Color.White;
            this.btnEditPassword.Location = new System.Drawing.Point(11, 420);
            this.btnEditPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(149, 46);
            this.btnEditPassword.TabIndex = 23;
            this.btnEditPassword.Text = "Change Password";
            this.btnEditPassword.UseVisualStyleBackColor = false;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // lblUpdateAnAppointment
            // 
            this.lblUpdateAnAppointment.AutoSize = true;
            this.lblUpdateAnAppointment.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAnAppointment.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAnAppointment.Location = new System.Drawing.Point(437, 238);
            this.lblUpdateAnAppointment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateAnAppointment.Name = "lblUpdateAnAppointment";
            this.lblUpdateAnAppointment.Size = new System.Drawing.Size(290, 26);
            this.lblUpdateAnAppointment.TabIndex = 20;
            this.lblUpdateAnAppointment.Text = "UPDATE APPOINTMENT";
            this.lblUpdateAnAppointment.Click += new System.EventHandler(this.lblUpdateAnAppointment_Click);
            this.lblUpdateAnAppointment.MouseLeave += new System.EventHandler(this.lblUpdateAnAppointment_MouseLeave);
            this.lblUpdateAnAppointment.MouseHover += new System.EventHandler(this.lblUpdateAnAppointment_MouseHover);
            // 
            // lblCreateAnAppointMent
            // 
            this.lblCreateAnAppointMent.AutoSize = true;
            this.lblCreateAnAppointMent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAnAppointMent.ForeColor = System.Drawing.Color.White;
            this.lblCreateAnAppointMent.Location = new System.Drawing.Point(30, 176);
            this.lblCreateAnAppointMent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAnAppointMent.Name = "lblCreateAnAppointMent";
            this.lblCreateAnAppointMent.Size = new System.Drawing.Size(330, 26);
            this.lblCreateAnAppointMent.TabIndex = 19;
            this.lblCreateAnAppointMent.Text = "CREATE AN APPOINTMENT";
            this.lblCreateAnAppointMent.Click += new System.EventHandler(this.lblCreateAnAppointMent_Click);
            this.lblCreateAnAppointMent.MouseLeave += new System.EventHandler(this.lblCreateAnAppointMent_MouseLeave);
            this.lblCreateAnAppointMent.MouseHover += new System.EventHandler(this.lblCreateAnAppointMent_MouseHover);
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtAppointmentID.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentID.ForeColor = System.Drawing.Color.Silver;
            this.txtAppointmentID.Location = new System.Drawing.Point(442, 166);
            this.txtAppointmentID.MaxLength = 8;
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(271, 41);
            this.txtAppointmentID.TabIndex = 26;
            this.txtAppointmentID.Text = "APPOINTMENT ID";
            this.txtAppointmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAppointmentID.Enter += new System.EventHandler(this.txtAppointmentID_Enter);
            this.txtAppointmentID.Leave += new System.EventHandler(this.txtAppointmentID_Leave);
            // 
            // lblViewAptList
            // 
            this.lblViewAptList.AutoSize = true;
            this.lblViewAptList.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAptList.ForeColor = System.Drawing.Color.White;
            this.lblViewAptList.Location = new System.Drawing.Point(30, 238);
            this.lblViewAptList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewAptList.Name = "lblViewAptList";
            this.lblViewAptList.Size = new System.Drawing.Size(319, 26);
            this.lblViewAptList.TabIndex = 27;
            this.lblViewAptList.Text = "VIEW APPOINTMENT LIST";
            this.lblViewAptList.Click += new System.EventHandler(this.lblViewAptList_Click);
            this.lblViewAptList.MouseLeave += new System.EventHandler(this.lblViewAptList_MouseLeave);
            this.lblViewAptList.MouseHover += new System.EventHandler(this.lblViewAptList_MouseHover);
            // 
            // lblAptIdError
            // 
            this.lblAptIdError.AutoSize = true;
            this.lblAptIdError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptIdError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblAptIdError.Location = new System.Drawing.Point(463, 210);
            this.lblAptIdError.Name = "lblAptIdError";
            this.lblAptIdError.Size = new System.Drawing.Size(227, 18);
            this.lblAptIdError.TabIndex = 28;
            this.lblAptIdError.Text = "!Enter A Valid Appointment ID";
            this.lblAptIdError.Visible = false;
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
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(784, 477);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblAptIdError);
            this.Controls.Add(this.lblViewAptList);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnEditPassword);
            this.Controls.Add(this.lblUpdateAnAppointment);
            this.Controls.Add(this.lblCreateAnAppointMent);
            this.Controls.Add(this.lblReceptionistId);
            this.Controls.Add(this.lblReceptionistI);
            this.Controls.Add(this.lblReceptionistName);
            this.Controls.Add(this.lblReceptionistN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Label lblUpdateAnAppointment;
        private System.Windows.Forms.Label lblCreateAnAppointMent;
        private System.Windows.Forms.Label lblReceptionistId;
        private System.Windows.Forms.Label lblReceptionistI;
        private System.Windows.Forms.Label lblReceptionistName;
        private System.Windows.Forms.Label lblReceptionistN;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label lblViewAptList;
        private System.Windows.Forms.Label lblAptIdError;
        private System.Windows.Forms.Button btnLogout;
    }
}

