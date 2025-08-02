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
    public partial class StudentForm : UserControl
    {
        string connectionString = "Data Source=5lgo8sik\\SQLEXPRESS;Initial Catalog=SIS;Integrated Security=True;TrustServerCertificate=True";
        public StudentForm()
        {
            InitializeComponent();
        }
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT student_id, first_name, last_name, email, phone, status FROM student";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudents.DataSource = dt;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!panelAddStudent.Visible)
            {
                panelAddStudent.Visible = true;
                panelAddStudent.BringToFront();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO student (student_id, first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status, role_id) VALUES (@student_id, @first_name, @last_name, @dob, @gender, @email, @phone, @address, @enrollment, @status, @role_id)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@student_id", int.Parse(txtStudentID.Text));
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@enrollment", dtpEnrollDate.Value);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@role_id", 2);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            panelAddStudent.Visible = false;

            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            dtpEnrollDate.Value = DateTime.Now;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }
    }
}
