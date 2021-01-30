namespace CSPharma.GUI
{
    partial class DoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.DoctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resigndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtToolStrip = new System.Windows.Forms.ToolStripTextBox();
            this.changeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.lblAutoSearch = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpResignDate = new System.Windows.Forms.DateTimePicker();
            this.lblResignDate = new System.Windows.Forms.Label();
            this.pnlDoctorForm = new System.Windows.Forms.Panel();
            this.lblPhoneErr = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.pnlDoctorForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorId,
            this.name,
            this.phone,
            this.AdminId,
            this.hiredate,
            this.resigndate});
            this.dgvMain.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvMain.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMain.Location = new System.Drawing.Point(3, 197);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(776, 240);
            this.dgvMain.TabIndex = 0;
            // 
            // DoctorId
            // 
            this.DoctorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorId.DataPropertyName = "DoctorId";
            this.DoctorId.HeaderText = "ID";
            this.DoctorId.Name = "DoctorId";
            this.DoctorId.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Doctor Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // AdminId
            // 
            this.AdminId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdminId.DataPropertyName = "AdminId";
            this.AdminId.HeaderText = "AdminId";
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            // 
            // hiredate
            // 
            this.hiredate.DataPropertyName = "hiredate";
            this.hiredate.HeaderText = "hiredate";
            this.hiredate.Name = "hiredate";
            this.hiredate.ReadOnly = true;
            // 
            // resigndate
            // 
            this.resigndate.DataPropertyName = "resigndate";
            this.resigndate.HeaderText = "resigndate";
            this.resigndate.Name = "resigndate";
            this.resigndate.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStrip,
            this.changeNumberToolStripMenuItem,
            this.changeNameToolStripMenuItem,
            this.resignationToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(163, 95);
            // 
            // txtToolStrip
            // 
            this.txtToolStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtToolStrip.ForeColor = System.Drawing.Color.DimGray;
            this.txtToolStrip.MaxLength = 32;
            this.txtToolStrip.Name = "txtToolStrip";
            this.txtToolStrip.Size = new System.Drawing.Size(100, 23);
            // 
            // changeNumberToolStripMenuItem
            // 
            this.changeNumberToolStripMenuItem.Name = "changeNumberToolStripMenuItem";
            this.changeNumberToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeNumberToolStripMenuItem.Text = "Change Number";
            this.changeNumberToolStripMenuItem.Click += new System.EventHandler(this.editPhoneNumberToolStripMenuItem_Click);
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeNameToolStripMenuItem.Text = "Change Name";
            this.changeNameToolStripMenuItem.Click += new System.EventHandler(this.editNameToolStripMenuItem_Click);
            // 
            // resignationToolStripMenuItem
            // 
            this.resignationToolStripMenuItem.Name = "resignationToolStripMenuItem";
            this.resignationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resignationToolStripMenuItem.Text = "Resignation";
            this.resignationToolStripMenuItem.Click += new System.EventHandler(this.resignationToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(82, 176);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(158, 20);
            this.txtAutoSearch.TabIndex = 7;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // lblAutoSearch
            // 
            this.lblAutoSearch.AutoSize = true;
            this.lblAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSearch.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAutoSearch.Location = new System.Drawing.Point(8, 177);
            this.lblAutoSearch.Name = "lblAutoSearch";
            this.lblAutoSearch.Size = new System.Drawing.Size(53, 17);
            this.lblAutoSearch.TabIndex = 35;
            this.lblAutoSearch.Text = "Search";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblHireDate.Location = new System.Drawing.Point(8, 78);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(68, 17);
            this.lblHireDate.TabIndex = 33;
            this.lblHireDate.Text = "Hire Date";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(82, 46);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 23);
            this.txtPhone.TabIndex = 32;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPhone.Location = new System.Drawing.Point(8, 49);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 31;
            this.lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(82, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 23);
            this.txtName.TabIndex = 30;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblName.Location = new System.Drawing.Point(8, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(82, 75);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(158, 20);
            this.dtpHireDate.TabIndex = 36;
            // 
            // dtpResignDate
            // 
            this.dtpResignDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResignDate.Location = new System.Drawing.Point(391, 175);
            this.dtpResignDate.Name = "dtpResignDate";
            this.dtpResignDate.Size = new System.Drawing.Size(158, 20);
            this.dtpResignDate.TabIndex = 38;
            // 
            // lblResignDate
            // 
            this.lblResignDate.AutoSize = true;
            this.lblResignDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResignDate.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblResignDate.Location = new System.Drawing.Point(268, 175);
            this.lblResignDate.Name = "lblResignDate";
            this.lblResignDate.Size = new System.Drawing.Size(117, 17);
            this.lblResignDate.TabIndex = 39;
            this.lblResignDate.Text = "Resignation Date";
            // 
            // pnlDoctorForm
            // 
            this.pnlDoctorForm.Controls.Add(this.lblPhoneErr);
            this.pnlDoctorForm.Controls.Add(this.lblNameError);
            this.pnlDoctorForm.Controls.Add(this.btnBack);
            this.pnlDoctorForm.Controls.Add(this.txtName);
            this.pnlDoctorForm.Controls.Add(this.lblResignDate);
            this.pnlDoctorForm.Controls.Add(this.btnAdd);
            this.pnlDoctorForm.Controls.Add(this.dgvMain);
            this.pnlDoctorForm.Controls.Add(this.dtpResignDate);
            this.pnlDoctorForm.Controls.Add(this.txtAutoSearch);
            this.pnlDoctorForm.Controls.Add(this.lblName);
            this.pnlDoctorForm.Controls.Add(this.lblPhone);
            this.pnlDoctorForm.Controls.Add(this.dtpHireDate);
            this.pnlDoctorForm.Controls.Add(this.txtPhone);
            this.pnlDoctorForm.Controls.Add(this.lblAutoSearch);
            this.pnlDoctorForm.Controls.Add(this.lblHireDate);
            this.pnlDoctorForm.Location = new System.Drawing.Point(12, 12);
            this.pnlDoctorForm.Name = "pnlDoctorForm";
            this.pnlDoctorForm.Size = new System.Drawing.Size(788, 482);
            this.pnlDoctorForm.TabIndex = 40;
            // 
            // lblPhoneErr
            // 
            this.lblPhoneErr.AutoSize = true;
            this.lblPhoneErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblPhoneErr.Location = new System.Drawing.Point(268, 51);
            this.lblPhoneErr.Name = "lblPhoneErr";
            this.lblPhoneErr.Size = new System.Drawing.Size(299, 18);
            this.lblPhoneErr.TabIndex = 42;
            this.lblPhoneErr.Text = "!Enter A Valid Phone Number (11 Digit)";
            this.lblPhoneErr.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.lblNameError.Location = new System.Drawing.Point(268, 22);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(157, 18);
            this.lblNameError.TabIndex = 41;
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
            this.btnBack.Location = new System.Drawing.Point(702, 440);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 34);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.pnlDoctorForm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Information";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            this.pnlDoctorForm.ResumeLayout(false);
            this.pnlDoctorForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblAutoSearch;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem resignationToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpResignDate;
        private System.Windows.Forms.Label lblResignDate;
        private System.Windows.Forms.Panel pnlDoctorForm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPhoneErr;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.ToolStripMenuItem changeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn resigndate;
    }
}

