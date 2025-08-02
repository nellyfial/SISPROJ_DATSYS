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
    public partial class Teacher : Form
    {
        private string userTeacher;
        public Teacher(string teacher)
        {
            InitializeComponent();
            this.userTeacher = teacher;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            lblWelcomeTeacher.Text = $"Welcome {userTeacher}!";
        }
    }
}
