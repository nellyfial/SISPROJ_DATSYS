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
        private bool isUpdateMode = false;
        private int selectedStudentId = -1;
        string connectionString = "Data Source=LAB4-PC15\\LAB3PC31;Initial Catalog=SIS;Integrated Security=True;TrustServerCertificate=True";
        public StudentForm()
        {
            InitializeComponent();
        }
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT student_id, first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status FROM student";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudents.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
            dtpDOB.Value = DateTime.Today;
            dtpEnrollDate.Value = DateTime.Today;
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
                connection.Open();

                if (isUpdateMode && selectedStudentId > 0)
                {
                    // UPDATE existing student
                    string updateQuery = @"UPDATE student SET  
                first_name = @first_name,
                last_name = @last_name,
                date_of_birth = @dob,
                gender = @gender,
                email = @email,
                phone = @phone,
                address = @address,
                enrollment_date = @enroll,
                status = @status
                WHERE student_id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@enroll", dtpEnrollDate.Value.Date);
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedStudentId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Student updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Student not found.");
                        }
                    }
                }
                else
                {
                    // INSERT new student
                    string insertQuery = @"INSERT INTO student 
                (student_id, first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status, role_id) 
                VALUES (@student_id, @first_name, @last_name, @dob, @gender, @email, @phone, @address, @enrollment, @status, @role_id)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@student_id", int.Parse(txtStudentID.Text));
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@enrollment", dtpEnrollDate.Value.Date);
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@role_id", 2); // fixed role_id for student

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Reset form
                ClearFields();
                panelAddStudent.Visible = false;
                isUpdateMode = false;
                selectedStudentId = -1;

                // Reload the data
                LoadStudents();
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
            if (dgvStudents.CurrentRow != null)
            {
                DataGridViewRow row = dgvStudents.CurrentRow;

                selectedStudentId = Convert.ToInt32(row.Cells["student_id"].Value);
                isUpdateMode = true;

                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["date_of_birth"].Value);
                cmbGender.SelectedItem = row.Cells["gender"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                dtpEnrollDate.Value = Convert.ToDateTime(row.Cells["enrollment_date"].Value);
                txtStatus.Text = row.Cells["status"].Value.ToString();

                panelAddStudent.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }
    }
}
