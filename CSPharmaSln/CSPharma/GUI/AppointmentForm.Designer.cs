namespace CSPharma.GUI
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDoctorErr = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAgeError = new System.Windows.Forms.Label();
            this.lblPhoneErr = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblAppointmentForm = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblDoctorErr);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnCreate);
            this.pnlMain.Controls.Add(this.lblAgeError);
            this.pnlMain.Controls.Add(this.lblPhoneErr);
            this.pnlMain.Controls.Add(this.lblNameError);
            this.pnlMain.Controls.Add(this.lblDoctorName);
            this.pnlMain.Controls.Add(this.comboBoxDoctor);
            this.pnlMain.Controls.Add(this.dtpAppointmentDate);
            this.pnlMain.Controls.Add(this.lblAppointmentDate);
            this.pnlMain.Controls.Add(this.txtPatientAge);
            this.pnlMain.Controls.Add(this.txtPatientPhone);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.lblAppointmentForm);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(391, 475);
            this.pnlMain.TabIndex = 0;
            // 
            // lblDoctorErr
            // 
            this.lblDoctorErr.AutoSize = true;
            this.lblDoctorErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblDoctorErr.Location = new System.Drawing.Point(192, 332);
            this.lblDoctorErr.Name = "lblDoctorErr";
            this.lblDoctorErr.Size = new System.Drawing.Size(158, 18);
            this.lblDoctorErr.TabIndex = 19;
            this.lblDoctorErr.Text = "!Must Select Doctor";
            this.lblDoctorErr.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(206, 372);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 48);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(14, 372);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(165, 48);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAgeError
            // 
            this.lblAgeError.AutoSize = true;
            this.lblAgeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblAgeError.Location = new System.Drawing.Point(11, 232);
            this.lblAgeError.Name = "lblAgeError";
            this.lblAgeError.Size = new System.Drawing.Size(141, 18);
            this.lblAgeError.TabIndex = 16;
            this.lblAgeError.Text = "!Enter A Valid Age";
            this.lblAgeError.Visible = false;
            // 
            // lblPhoneErr
            // 
            this.lblPhoneErr.AutoSize = true;
            this.lblPhoneErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblPhoneErr.Location = new System.Drawing.Point(11, 169);
            this.lblPhoneErr.Name = "lblPhoneErr";
            this.lblPhoneErr.Size = new System.Drawing.Size(299, 18);
            this.lblPhoneErr.TabIndex = 15;
            this.lblPhoneErr.Text = "!Enter A Valid Phone Number (11 Digit)";
            this.lblPhoneErr.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblNameError.Location = new System.Drawing.Point(11, 107);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(157, 18);
            this.lblNameError.TabIndex = 14;
            this.lblNameError.Text = "!Enter A Valid Name";
            this.lblNameError.Visible = false;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.White;
            this.lblDoctorName.Location = new System.Drawing.Point(10, 303);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(132, 21);
            this.lblDoctorName.TabIndex = 14;
            this.lblDoctorName.Text = "SELECT DOCTOR";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(159, 299);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(212, 30);
            this.comboBoxDoctor.Sorted = true;
            this.comboBoxDoctor.TabIndex = 13;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.CustomFormat = "yyyy-MM-dd";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(195, 257);
            this.dtpAppointmentDate.MaxDate = new System.DateTime(2100, 12, 12, 0, 0, 0, 0);
            this.dtpAppointmentDate.MinDate = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(176, 20);
            this.dtpAppointmentDate.TabIndex = 12;
            this.dtpAppointmentDate.Value = new System.DateTime(2020, 4, 12, 0, 0, 0, 0);
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentDate.Location = new System.Drawing.Point(10, 257);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(178, 21);
            this.lblAppointmentDate.TabIndex = 11;
            this.lblAppointmentDate.Text = "APPOINTMENT DATE: ";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPatientAge.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientAge.ForeColor = System.Drawing.Color.Silver;
            this.txtPatientAge.Location = new System.Drawing.Point(14, 193);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(357, 36);
            this.txtPatientAge.TabIndex = 5;
            this.txtPatientAge.Text = "AGE";
            this.txtPatientAge.Enter += new System.EventHandler(this.txtPatientAge_Enter);
            this.txtPatientAge.Leave += new System.EventHandler(this.txtPatientAge_Leave);
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPatientPhone.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPatientPhone.Location = new System.Drawing.Point(14, 130);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(357, 36);
            this.txtPatientPhone.TabIndex = 4;
            this.txtPatientPhone.Text = "PHONE";
            this.txtPatientPhone.Enter += new System.EventHandler(this.txtPatientPhone_Enter);
            this.txtPatientPhone.Leave += new System.EventHandler(this.txtPatientPhone_Leave);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPatientName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.Silver;
            this.txtPatientName.Location = new System.Drawing.Point(14, 68);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(357, 36);
            this.txtPatientName.TabIndex = 3;
            this.txtPatientName.Text = "NAME";
            this.txtPatientName.Enter += new System.EventHandler(this.txtPatientName_Enter);
            this.txtPatientName.Leave += new System.EventHandler(this.txtPatientName_Leave);
            // 
            // lblAppointmentForm
            // 
            this.lblAppointmentForm.AutoSize = true;
            this.lblAppointmentForm.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblAppointmentForm.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppointmentForm.Location = new System.Drawing.Point(16, 0);
            this.lblAppointmentForm.Name = "lblAppointmentForm";
            this.lblAppointmentForm.Size = new System.Drawing.Size(355, 45);
            this.lblAppointmentForm.TabIndex = 2;
            this.lblAppointmentForm.Text = "APPOINTMENT FORM";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(415, 499);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblAppointmentForm;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblAgeError;
        private System.Windows.Forms.Label lblPhoneErr;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDoctorErr;
    }
}