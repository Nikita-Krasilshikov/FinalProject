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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'students_dbDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.students_dbDataSet.user);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.RowCount > 0)
            {
                int id = Convert.ToInt32(usersDataGridView.CurrentRow.Cells[0].Value);
                DBController.DeleteUser(id);
                usersDataGridView.Rows.RemoveAt(usersDataGridView.CurrentRow.Index);
            }
        }
    }
}
