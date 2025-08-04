using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_PROJ
{
    public partial class TeacherForm : UserControl
    {
        private bool isUpdateMode = false;
        private int TeachertId = -1;
        string connectionString = "Data Source=LAB4-PC15\\LAB3PC31;Initial Catalog=SIS;Integrated Security=True;TrustServerCertificate=True";
        public TeacherForm()
        {
            InitializeComponent();
        }
        private void LoadTeachers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT teacher_id, first_name, last_name, email, phone, hire_date, department, specialization, status FROM teacher";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTeachers.DataSource = dt;
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!panelAddTeacher.Visible)
            {
                panelAddTeacher.Visible = true;
                panelAddTeacher.BringToFront();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            panelAddTeacher.Visible = false;

            txtTeacherID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();
            txtStatus.Clear();
            dtpHireDate.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
