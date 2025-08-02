namespace SIS_PROJ
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnReports = new Button();
            btnLogs = new Button();
            btnSubject = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            btnDashboard = new Button();
            lblWelcomeAdmin = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnLogs);
            panel1.Controls.Add(btnSubject);
            panel1.Controls.Add(btnTeacher);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(lblWelcomeAdmin);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 474);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(42, 413);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(42, 355);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(135, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            btnLogs.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.Location = new Point(42, 313);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(135, 45);
            btnLogs.TabIndex = 6;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnSubject
            // 
            btnSubject.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubject.Location = new Point(42, 271);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(135, 45);
            btnSubject.TabIndex = 5;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnTeacher
            // 
            btnTeacher.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(42, 229);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(135, 45);
            btnTeacher.TabIndex = 4;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(42, 187);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(135, 45);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(42, 145);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(135, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeAdmin.Location = new Point(51, 117);
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(116, 16);
            lblWelcomeAdmin.TabIndex = 1;
            lblWelcomeAdmin.Text = "Welcome Admin!";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(860, 469);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTeacher;
        private Button btnStudent;
        private Button btnDashboard;
        private Label lblWelcomeAdmin;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnReports;
        private Button btnLogs;
        private Button btnSubject;
    }
}