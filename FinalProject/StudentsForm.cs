using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            studentsDataGridView.AutoGenerateColumns = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.RowCount > 0)
            {
                int id = Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value);
                DBController.DeleteStudent(id);
                studentsDataGridView.Rows.RemoveAt(studentsDataGridView.CurrentRow.Index);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.RowCount > 0)
            {
                int id = Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value);
                EditForm ef = new EditForm(id);
                if (ef.ShowDialog() == DialogResult.OK)
                {
                    this.studentTableAdapter.Fill(this.students_dbDataSet.student);
                    studentsDataGridView.Update();
                }
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.students_dbDataSet.student);
            MainForm mainForm = this.Owner as MainForm;
            if (mainForm.Role == "admin" || mainForm.Role == "user")
            {
                removeButton.Visible = true;
                editButton.Visible = true;
            }
            studentBindingSource.Sort = "id DESC";
        }
    }
}
