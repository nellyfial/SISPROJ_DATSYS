using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_PROJ
{
    public partial class Admin : Form
    {
        private string userAdmin;

        UserControl StudentForm;
        UserControl TeacherForm;
        public Admin(string admin)
        {
            InitializeComponent();
            this.userAdmin = admin;

            StudentForm = new StudentForm();
            StudentForm.Visible = false;
            this.Controls.Add(StudentForm);

            TeacherForm = new TeacherForm();
            TeacherForm.Visible = false;
            this.Controls.Add(TeacherForm);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = $"Welcome {userAdmin}!";
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm.Visible = true;
            StudentForm.Dock = DockStyle.Left;
            TeacherForm.Visible = false;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm.Visible = true;
            TeacherForm.Dock = DockStyle.Left;
            StudentForm.Visible = false;
        }
    }
}
