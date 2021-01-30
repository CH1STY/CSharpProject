namespace CSPharma.GUI
{
    partial class UserRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistration));
            this.pnlReg = new System.Windows.Forms.Panel();
            this.lblUserTypeErr = new System.Windows.Forms.Label();
            this.lblConPassErr = new System.Windows.Forms.Label();
            this.lblPasswordErr = new System.Windows.Forms.Label();
            this.lblPhoneErr = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblHiredate = new System.Windows.Forms.Label();
            this.dtpHiredate = new System.Windows.Forms.DateTimePicker();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.radioBtnPharmacist = new System.Windows.Forms.RadioButton();
            this.radioBtnReceptionist = new System.Windows.Forms.RadioButton();
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.pnlReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReg
            // 
            this.pnlReg.Controls.Add(this.lblUserTypeErr);
            this.pnlReg.Controls.Add(this.lblConPassErr);
            this.pnlReg.Controls.Add(this.lblPasswordErr);
            this.pnlReg.Controls.Add(this.lblPhoneErr);
            this.pnlReg.Controls.Add(this.lblNameError);
            this.pnlReg.Controls.Add(this.btnBack);
            this.pnlReg.Controls.Add(this.btnRegister);
            this.pnlReg.Controls.Add(this.lblHiredate);
            this.pnlReg.Controls.Add(this.dtpHiredate);
            this.pnlReg.Controls.Add(this.txtConfirmPass);
            this.pnlReg.Controls.Add(this.radioBtnPharmacist);
            this.pnlReg.Controls.Add(this.radioBtnReceptionist);
            this.pnlReg.Controls.Add(this.radioBtnAdmin);
            this.pnlReg.Controls.Add(this.txtUserPassword);
            this.pnlReg.Controls.Add(this.txtUserPhone);
            this.pnlReg.Controls.Add(this.txtUserName);
            this.pnlReg.Controls.Add(this.lblRegistration);
            this.pnlReg.Location = new System.Drawing.Point(12, 5);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(400, 484);
            this.pnlReg.TabIndex = 0;
            // 
            // lblUserTypeErr
            // 
            this.lblUserTypeErr.AutoSize = true;
            this.lblUserTypeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTypeErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblUserTypeErr.Location = new System.Drawing.Point(5, 369);
            this.lblUserTypeErr.Name = "lblUserTypeErr";
            this.lblUserTypeErr.Size = new System.Drawing.Size(192, 18);
            this.lblUserTypeErr.TabIndex = 17;
            this.lblUserTypeErr.Text = "!Must Pick an User Type";
            this.lblUserTypeErr.Visible = false;
            // 
            // lblConPassErr
            // 
            this.lblConPassErr.AutoSize = true;
            this.lblConPassErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPassErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblConPassErr.Location = new System.Drawing.Point(5, 289);
            this.lblConPassErr.Name = "lblConPassErr";
            this.lblConPassErr.Size = new System.Drawing.Size(201, 18);
            this.lblConPassErr.TabIndex = 16;
            this.lblConPassErr.Text = "!Password Doesn\'t Match";
            this.lblConPassErr.Visible = false;
            // 
            // lblPasswordErr
            // 
            this.lblPasswordErr.AutoSize = true;
            this.lblPasswordErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblPasswordErr.Location = new System.Drawing.Point(5, 229);
            this.lblPasswordErr.Name = "lblPasswordErr";
            this.lblPasswordErr.Size = new System.Drawing.Size(337, 18);
            this.lblPasswordErr.TabIndex = 15;
            this.lblPasswordErr.Text = "!Enter a Valid Password(Minimum Size is 4)";
            this.lblPasswordErr.Visible = false;
            // 
            // lblPhoneErr
            // 
            this.lblPhoneErr.AutoSize = true;
            this.lblPhoneErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblPhoneErr.Location = new System.Drawing.Point(5, 167);
            this.lblPhoneErr.Name = "lblPhoneErr";
            this.lblPhoneErr.Size = new System.Drawing.Size(299, 18);
            this.lblPhoneErr.TabIndex = 14;
            this.lblPhoneErr.Text = "!Enter A Valid Phone Number (11 Digit)";
            this.lblPhoneErr.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblNameError.Location = new System.Drawing.Point(5, 106);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(157, 18);
            this.lblNameError.TabIndex = 13;
            this.lblNameError.Text = "!Enter A Valid Name";
            this.lblNameError.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(200, 405);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 48);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(5, 405);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(165, 48);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblHiredate
            // 
            this.lblHiredate.AutoSize = true;
            this.lblHiredate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiredate.ForeColor = System.Drawing.Color.White;
            this.lblHiredate.Location = new System.Drawing.Point(4, 314);
            this.lblHiredate.Name = "lblHiredate";
            this.lblHiredate.Size = new System.Drawing.Size(205, 21);
            this.lblHiredate.TabIndex = 10;
            this.lblHiredate.Text = "HIREDATE(YYYY-MM-DD)";
            // 
            // dtpHiredate
            // 
            this.dtpHiredate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHiredate.CustomFormat = "yyyy-MM-dd";
            this.dtpHiredate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHiredate.Location = new System.Drawing.Point(215, 315);
            this.dtpHiredate.MaxDate = new System.DateTime(2100, 12, 12, 0, 0, 0, 0);
            this.dtpHiredate.MinDate = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.dtpHiredate.Name = "dtpHiredate";
            this.dtpHiredate.Size = new System.Drawing.Size(150, 20);
            this.dtpHiredate.TabIndex = 6;
            this.dtpHiredate.Value = new System.DateTime(2020, 4, 12, 0, 0, 0, 0);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtConfirmPass.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.Silver;
            this.txtConfirmPass.Location = new System.Drawing.Point(8, 250);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(357, 36);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.Text = "CONFIRM PASSWORD";
            this.txtConfirmPass.Enter += new System.EventHandler(this.txtConfirmPass_Enter);
            this.txtConfirmPass.Leave += new System.EventHandler(this.txtConfirmPass_Leave);
            // 
            // radioBtnPharmacist
            // 
            this.radioBtnPharmacist.AutoSize = true;
            this.radioBtnPharmacist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPharmacist.ForeColor = System.Drawing.Color.White;
            this.radioBtnPharmacist.Location = new System.Drawing.Point(237, 341);
            this.radioBtnPharmacist.Name = "radioBtnPharmacist";
            this.radioBtnPharmacist.Size = new System.Drawing.Size(130, 25);
            this.radioBtnPharmacist.TabIndex = 9;
            this.radioBtnPharmacist.TabStop = true;
            this.radioBtnPharmacist.Text = "PHARMACIST";
            this.radioBtnPharmacist.UseVisualStyleBackColor = true;
            // 
            // radioBtnReceptionist
            // 
            this.radioBtnReceptionist.AutoSize = true;
            this.radioBtnReceptionist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnReceptionist.ForeColor = System.Drawing.Color.White;
            this.radioBtnReceptionist.Location = new System.Drawing.Point(97, 341);
            this.radioBtnReceptionist.Name = "radioBtnReceptionist";
            this.radioBtnReceptionist.Size = new System.Drawing.Size(138, 25);
            this.radioBtnReceptionist.TabIndex = 8;
            this.radioBtnReceptionist.TabStop = true;
            this.radioBtnReceptionist.Text = "RECEPTIONIST";
            this.radioBtnReceptionist.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdmin.ForeColor = System.Drawing.Color.White;
            this.radioBtnAdmin.Location = new System.Drawing.Point(7, 341);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(84, 25);
            this.radioBtnAdmin.TabIndex = 7;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "ADMIN";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtUserPassword.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtUserPassword.Location = new System.Drawing.Point(8, 190);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(357, 36);
            this.txtUserPassword.TabIndex = 4;
            this.txtUserPassword.Text = "PASSWORD";
            this.txtUserPassword.Enter += new System.EventHandler(this.txtUserPassword_Enter);
            this.txtUserPassword.Leave += new System.EventHandler(this.txtUserPassword_Leave);
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtUserPhone.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtUserPhone.Location = new System.Drawing.Point(8, 128);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(357, 36);
            this.txtUserPhone.TabIndex = 3;
            this.txtUserPhone.Text = "PHONE";
            this.txtUserPhone.Enter += new System.EventHandler(this.txtUserPhone_Enter);
            this.txtUserPhone.Leave += new System.EventHandler(this.txtUserPhone_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtUserName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(8, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(357, 36);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "NAME";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblRegistration.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRegistration.Location = new System.Drawing.Point(-3, 4);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(250, 45);
            this.lblRegistration.TabIndex = 1;
            this.lblRegistration.Text = "REGISTRATION";
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(415, 499);
            this.Controls.Add(this.pnlReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserRegistration_KeyDown);
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.RadioButton radioBtnPharmacist;
        private System.Windows.Forms.RadioButton radioBtnReceptionist;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblHiredate;
        private System.Windows.Forms.DateTimePicker dtpHiredate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblConPassErr;
        private System.Windows.Forms.Label lblPasswordErr;
        private System.Windows.Forms.Label lblPhoneErr;
        private System.Windows.Forms.Label lblUserTypeErr;
    }
}