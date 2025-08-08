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
        private int selectedTeacherId = -1;
        string connectionString = "Data Source=LAB4-PC15\\LAB3PC31;Initial Catalog=sis;Integrated Security=True;TrustServerCertificate=True";
        public TeacherForm()
        {
            InitializeComponent();
        }
        private void LoadTeachers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM teacher";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTeachers.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtTeacherID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();
            txtStatus.Clear();
            dtpHireDate.Value = DateTime.Today;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (isUpdateMode && selectedTeacherId > 0)
                {
                    // UPDATE existing student
                    string updateQuery = @"UPDATE student SET  
                first_name = @first_name,
                last_name = @last_name,
                email = @email,
                phone = @phone,
                hire_date = @hiredate,
                department = @department,
                specialization = @specialization,
                status = @status
                WHERE teacher_id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@hiredate", dtpHireDate.Value.Date);
                        cmd.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedTeacherId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Teacher updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Teacher not found.");
                        }
                    }
                }
                else
                {
                    // INSERT new student
                    string insertQuery = @"INSERT INTO student 
                (teacher_id, first_name, last_name, email, phone, hire_date, department, specialization, status, role_id) 
                VALUES (@teacher_id, @first_name, @last_name, @email, @phone, @hiredate, @department, @specialization, @status, @role_id)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", int.Parse(txtTeacherID.Text));
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@hiredate", dtpHireDate.Value.Date);
                        cmd.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@role_id", 3); // fixed role_id for teacher

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Teacher added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Reset form
                ClearFields();
                panelAddTeacher.Visible = false;
                isUpdateMode = false;
                selectedTeacherId = -1;

                // Reload the data
                LoadTeachers();
            }
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
            if (dgvTeachers.CurrentRow != null)
            {
                DataGridViewRow row = dgvTeachers.CurrentRow;

                selectedTeacherId = Convert.ToInt32(row.Cells["teacher_id"].Value);
                isUpdateMode = true;

                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                dtpHireDate.Value = Convert.ToDateTime(row.Cells["hire_date"].Value);
                txtDepartment.Text = row.Cells["department"].Value.ToString();
                txtSpecialization.Text = row.Cells["specialization"].Value.ToString();
                txtStatus.Text = row.Cells["status"].Value.ToString();

                panelAddTeacher.Visible = true; // make sure this is the panel for teacher form
            }
            else
            {
                MessageBox.Show("Please select a teacher to update.");
            }
        }
    }
}
