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
        public PaidForm()
        {
            InitializeComponent();
            studentBindingSource.Filter = "foundation LIKE 'Платная%'";
            studentBindingSource.Sort = "id DESC";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaidForm_Load(object sender, EventArgs e)
        {
            this.paidStudentTableAdapter.Fill(this.students_dbDataSet.student);
        }
    }
}
