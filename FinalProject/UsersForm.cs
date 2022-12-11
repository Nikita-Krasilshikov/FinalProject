using System;
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
            // Заполнение таблицы из датасета
            this.userTableAdapter.Fill(this.students_dbDataSet.user);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Если строки в таблице есть
            if (usersDataGridView.RowCount > 0)
            {
                // Получаем id клиента из первого столбца
                int id = Convert.ToInt32(usersDataGridView.CurrentRow.Cells[0].Value);
                // Удаляем пользователя с таким id из БД
                DBController.DeleteUser(id);
                // Удаляем пользователя из DataGridView
                usersDataGridView.Rows.RemoveAt(usersDataGridView.CurrentRow.Index);
            }
        }
    }
}
