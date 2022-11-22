using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PaidForm : Form
    {
        public PaidForm(List<Student> students)
        {
            InitializeComponent();
            students = students.OrderByDescending(o => o.StudentID).ToList();
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.DataSource = students;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
