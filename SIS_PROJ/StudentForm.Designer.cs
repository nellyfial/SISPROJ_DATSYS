namespace SIS_PROJ
{
    partial class StudentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelAddStudent = new Panel();
            dtpEnrollDate = new DateTimePicker();
            lblEnrollmentDate = new Label();
            lblGender = new Label();
            lblDateofBirth = new Label();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            btmCancel = new Button();
            btnSave = new Button();
            txtStatus = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtStudentID = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnAddNew = new Button();
            btnUpdate = new Button();
            dgvStudents = new DataGridView();
            panelAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // panelAddStudent
            // 
            panelAddStudent.BorderStyle = BorderStyle.Fixed3D;
            panelAddStudent.Controls.Add(dtpEnrollDate);
            panelAddStudent.Controls.Add(lblEnrollmentDate);
            panelAddStudent.Controls.Add(lblGender);
            panelAddStudent.Controls.Add(lblDateofBirth);
            panelAddStudent.Controls.Add(cmbGender);
            panelAddStudent.Controls.Add(dtpDOB);
            panelAddStudent.Controls.Add(btmCancel);
            panelAddStudent.Controls.Add(btnSave);
            panelAddStudent.Controls.Add(txtStatus);
            panelAddStudent.Controls.Add(txtAddress);
            panelAddStudent.Controls.Add(txtPhone);
            panelAddStudent.Controls.Add(txtEmail);
            panelAddStudent.Controls.Add(txtLastName);
            panelAddStudent.Controls.Add(txtFirstName);
            panelAddStudent.Controls.Add(txtStudentID);
            panelAddStudent.Controls.Add(label1);
            panelAddStudent.Dock = DockStyle.Right;
            panelAddStudent.Location = new Point(505, 0);
            panelAddStudent.Margin = new Padding(3, 2, 3, 2);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(263, 391);
            panelAddStudent.TabIndex = 0;
            panelAddStudent.Visible = false;
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(114, 205);
            dtpEnrollDate.Margin = new Padding(3, 2, 3, 2);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(120, 23);
            dtpEnrollDate.TabIndex = 28;
            // 
            // lblEnrollmentDate
            // 
            lblEnrollmentDate.AutoSize = true;
            lblEnrollmentDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollmentDate.Location = new Point(24, 211);
            lblEnrollmentDate.Name = "lblEnrollmentDate";
            lblEnrollmentDate.Size = new Size(81, 14);
            lblEnrollmentDate.TabIndex = 27;
            lblEnrollmentDate.Text = "EnrollmentDate:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(24, 122);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(46, 14);
            lblGender.TabIndex = 26;
            lblGender.Text = "Gender:";
            // 
            // lblDateofBirth
            // 
            lblDateofBirth.AutoSize = true;
            lblDateofBirth.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateofBirth.Location = new Point(24, 98);
            lblDateofBirth.Name = "lblDateofBirth";
            lblDateofBirth.Size = new Size(64, 14);
            lblDateofBirth.TabIndex = 25;
            lblDateofBirth.Text = "DateofBirth:";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(92, 118);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(142, 23);
            cmbGender.TabIndex = 24;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(92, 92);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(142, 23);
            dtpDOB.TabIndex = 23;
            // 
            // btmCancel
            // 
            btmCancel.BackColor = Color.Gray;
            btmCancel.Location = new Point(144, 259);
            btmCancel.Margin = new Padding(3, 2, 3, 2);
            btmCancel.Name = "btmCancel";
            btmCancel.Size = new Size(89, 35);
            btmCancel.TabIndex = 22;
            btmCancel.Text = "Cancel";
            btmCancel.UseVisualStyleBackColor = false;
            btmCancel.Click += btmCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(24, 259);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 35);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(24, 230);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Status:";
            txtStatus.Size = new Size(210, 19);
            txtStatus.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(24, 184);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(210, 19);
            txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(24, 163);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(210, 19);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(24, 142);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(210, 19);
            txtEmail.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(24, 70);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(210, 19);
            txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(24, 50);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(210, 19);
            txtFirstName.TabIndex = 12;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(24, 28);
            txtStudentID.Margin = new Padding(3, 2, 3, 2);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "StudentID:";
            txtStudentID.Size = new Size(210, 19);
            txtStudentID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 13);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Add New Student Info";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(390, 251);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 33);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(48, 251);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(110, 33);
            btnAddNew.TabIndex = 23;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(220, 251);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 33);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(18, 14);
            dgvStudents.Margin = new Padding(3, 2, 3, 2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(515, 224);
            dgvStudents.TabIndex = 26;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(panelAddStudent);
            Margin = new Padding(0);
            Name = "StudentForm";
            Size = new Size(768, 391);
            Load += StudentForm_Load;
            panelAddStudent.ResumeLayout(false);
            panelAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAddStudent;
        private Label label1;
        private TextBox txtStudentID;
        private TextBox txtStatus;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnSave;
        private Button btmCancel;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvStudents;
        private DateTimePicker dtpDOB;
        private Label lblDateofBirth;
        private ComboBox cmbGender;
        private Label lblGender;
        private DateTimePicker dtpEnrollDate;
        private Label lblEnrollmentDate;
    }
}
