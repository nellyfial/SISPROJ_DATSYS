using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SIS_PROJ
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=LAB4-PC15\\LAB3PC31;Initial Catalog=SIS;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role_id FROM user_login WHERE username = @username AND password_hash = @password_hash";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password_hash", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int roleID = Convert.ToInt32(result);
                        switch (roleID)
                        {
                            case 1:
                                Admin dashboard = new Admin(username);
                                dashboard.Show();
                                this.Hide();
                                break;
                            case 2:
                                Student student = new Student(username);
                                student.Show();
                                this.Hide();
                                break;
                            case 3:
                                Teacher teacher = new Teacher(username);
                                teacher.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Unknown user.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password. Please try again");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
