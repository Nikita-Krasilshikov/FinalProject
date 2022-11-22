using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class StudentsForm : Form
    {
        public List<Student> students;
        // Передача коллекции студентов в конструктор
        public StudentsForm(List<Student> students)
        {
            InitializeComponent();
            studentsDataGridView.AutoGenerateColumns = false;
            // Сортировка коллекции по убыванию ID студента
            students = students.OrderByDescending(o => o.StudentID).ToList();
            this.students = students;
            // Установка источника данных для таблицы
            studentsDataGridView.DataSource = students;
        }
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчик нажатия на кнопку "удалить"
        private void removeButton_Click(object sender, EventArgs e)
        {
            // Проверка на то, что таблица не пустая
            if (studentsDataGridView.RowCount > 0)
            {
                // Получение экземпляра студента из таблицы (выделенная запись в таблице)
                Student student = (Student)studentsDataGridView.CurrentRow.DataBoundItem;
                // Удаление студента из коллекции
                students.Remove(student);
                // Обновление источника данных таблицы, чтобы таблица перерисовалась
                studentsDataGridView.DataSource = null;
                studentsDataGridView.DataSource = students;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.RowCount > 0)
            {
                // Получение экземпляра студента из таблицы (выделенная запись в таблице)
                Student student = (Student)studentsDataGridView.CurrentRow.DataBoundItem;
                EditForm ef = new EditForm(student);
                // Утсановка владельца формы, для доступа к коллекции студентов
                ef.Owner = this;
                if (ef.ShowDialog() == DialogResult.OK)
                {
                    studentsDataGridView.DataSource = null;
                    studentsDataGridView.DataSource = students;
                }
            }
        }
    }
}
