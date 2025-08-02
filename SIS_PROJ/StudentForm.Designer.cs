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
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
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
            panelAddStudent.Location = new Point(578, 0);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(300, 516);
            panelAddStudent.TabIndex = 0;
            panelAddStudent.Visible = false;
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(130, 333);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(128, 27);
            dtpEnrollDate.TabIndex = 28;
            // 
            // lblEnrollmentDate
            // 
            lblEnrollmentDate.AutoSize = true;
            lblEnrollmentDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollmentDate.Location = new Point(24, 341);
            lblEnrollmentDate.Name = "lblEnrollmentDate";
            lblEnrollmentDate.Size = new Size(100, 16);
            lblEnrollmentDate.TabIndex = 27;
            lblEnrollmentDate.Text = "EnrollmentDate:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(27, 202);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(53, 16);
            lblGender.TabIndex = 26;
            lblGender.Text = "Gender:";
            // 
            // lblDateofBirth
            // 
            lblDateofBirth.AutoSize = true;
            lblDateofBirth.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateofBirth.Location = new Point(24, 169);
            lblDateofBirth.Name = "lblDateofBirth";
            lblDateofBirth.Size = new Size(75, 16);
            lblDateofBirth.TabIndex = 25;
            lblDateofBirth.Text = "DateofBirth:";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(105, 198);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(153, 25);
            cmbGender.TabIndex = 24;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(105, 161);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(153, 27);
            dtpDOB.TabIndex = 23;
            // 
            // btmCancel
            // 
            btmCancel.BackColor = Color.Gray;
            btmCancel.Location = new Point(165, 434);
            btmCancel.Name = "btmCancel";
            btmCancel.Size = new Size(102, 47);
            btmCancel.TabIndex = 22;
            btmCancel.Text = "Cancel";
            btmCancel.UseVisualStyleBackColor = false;
            btmCancel.Click += btmCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(27, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 47);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(27, 374);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Status:";
            txtStatus.Size = new Size(231, 22);
            txtStatus.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(27, 298);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(231, 22);
            txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(27, 265);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(231, 22);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(27, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(231, 22);
            txtEmail.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(27, 133);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(231, 22);
            txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(27, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(231, 22);
            txtFirstName.TabIndex = 12;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(27, 67);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "StudentID:";
            txtStudentID.Size = new Size(231, 22);
            txtStudentID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 17);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 0;
            label1.Text = "Add New Student Info";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(44, 428);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(114, 55);
            btnAddNew.TabIndex = 23;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(226, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 55);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(403, 431);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 55);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(20, 19);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(535, 379);
            dgvStudents.TabIndex = 26;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(panelAddStudent);
            Margin = new Padding(0);
            Name = "StudentForm";
            Size = new Size(878, 516);
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
