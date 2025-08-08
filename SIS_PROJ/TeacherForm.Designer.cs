namespace SIS_PROJ
{
    partial class TeacherForm
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
            panelAddTeacher = new Panel();
            txtDepartment = new TextBox();
            dtpHireDate = new DateTimePicker();
            lblHireDate = new Label();
            btmCancel = new Button();
            btnSave = new Button();
            txtStatus = new TextBox();
            txtSpecialization = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtTeacherID = new TextBox();
            lblAddNewTeacher = new Label();
            btnDelete = new Button();
            dgvTeachers = new DataGridView();
            btnAddNew = new Button();
            btnUpdate = new Button();
            panelAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // panelAddTeacher
            // 
            panelAddTeacher.BorderStyle = BorderStyle.Fixed3D;
            panelAddTeacher.Controls.Add(txtDepartment);
            panelAddTeacher.Controls.Add(dtpHireDate);
            panelAddTeacher.Controls.Add(lblHireDate);
            panelAddTeacher.Controls.Add(btmCancel);
            panelAddTeacher.Controls.Add(btnSave);
            panelAddTeacher.Controls.Add(txtStatus);
            panelAddTeacher.Controls.Add(txtSpecialization);
            panelAddTeacher.Controls.Add(txtPhone);
            panelAddTeacher.Controls.Add(txtEmail);
            panelAddTeacher.Controls.Add(txtLastName);
            panelAddTeacher.Controls.Add(txtFirstName);
            panelAddTeacher.Controls.Add(txtTeacherID);
            panelAddTeacher.Controls.Add(lblAddNewTeacher);
            panelAddTeacher.Dock = DockStyle.Right;
            panelAddTeacher.Location = new Point(285, 0);
            panelAddTeacher.Margin = new Padding(3, 2, 3, 2);
            panelAddTeacher.Name = "panelAddTeacher";
            panelAddTeacher.Size = new Size(263, 303);
            panelAddTeacher.TabIndex = 1;
            panelAddTeacher.Visible = false;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(24, 166);
            txtDepartment.Margin = new Padding(3, 2, 3, 2);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(210, 19);
            txtDepartment.TabIndex = 31;
            // 
            // dtpHireDate
            // 
            dtpHireDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(81, 139);
            dtpHireDate.Margin = new Padding(3, 2, 3, 2);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(152, 23);
            dtpHireDate.TabIndex = 30;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHireDate.Location = new Point(24, 147);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(51, 14);
            lblHireDate.TabIndex = 29;
            lblHireDate.Text = "HireDate:";
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
            txtStatus.Location = new Point(24, 212);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Status:";
            txtStatus.Size = new Size(210, 19);
            txtStatus.TabIndex = 20;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.Location = new Point(24, 189);
            txtSpecialization.Margin = new Padding(3, 2, 3, 2);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization:";
            txtSpecialization.Size = new Size(210, 19);
            txtSpecialization.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(24, 116);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(210, 19);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(24, 93);
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
            // txtTeacherID
            // 
            txtTeacherID.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeacherID.Location = new Point(24, 28);
            txtTeacherID.Margin = new Padding(3, 2, 3, 2);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.PlaceholderText = "TeacherID:";
            txtTeacherID.Size = new Size(210, 19);
            txtTeacherID.TabIndex = 11;
            // 
            // lblAddNewTeacher
            // 
            lblAddNewTeacher.AutoSize = true;
            lblAddNewTeacher.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddNewTeacher.Location = new Point(60, 13);
            lblAddNewTeacher.Name = "lblAddNewTeacher";
            lblAddNewTeacher.Size = new Size(137, 15);
            lblAddNewTeacher.TabIndex = 0;
            lblAddNewTeacher.Text = "Add New Teacher Info";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(389, 261);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 33);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvTeachers
            // 
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(18, 15);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.Size = new Size(515, 224);
            dgvTeachers.TabIndex = 2;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(47, 261);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(110, 33);
            btnAddNew.TabIndex = 24;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(211, 261);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 33);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvTeachers);
            Controls.Add(panelAddTeacher);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeacherForm";
            Size = new Size(548, 303);
            Load += TeacherForm_Load;
            panelAddTeacher.ResumeLayout(false);
            panelAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAddTeacher;
        private Button btmCancel;
        private Button btnSave;
        private TextBox txtStatus;
        private TextBox txtSpecialization;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtTeacherID;
        private Label lblAddNewTeacher;
        private TextBox txtDepartment;
        private DateTimePicker dtpHireDate;
        private Label lblHireDate;
        private DataGridView dgvTeachers;
        private Button btnAddNew;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
