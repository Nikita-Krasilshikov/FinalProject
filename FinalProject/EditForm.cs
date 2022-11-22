using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditForm : Form
    {
        Student student;
        public EditForm(Student student)
        {
            this.student = student;
            InitializeComponent();
            // Получение значений для каждого элемента формы
            firstNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName;
            middleNameTextBox.Text = student.MiddleName;
            genderComboBox.Text = student.Gender;
            studentsIDTextBox.Text = student.StudentID.ToString();
            foundationComboBox.Text = student.Foundation;
            debtsTextBox.Text = student.Debts.ToString();
            noteTextBox.Text = student.Note;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Установка указателя на то, как завершилась работа с формой (просто закрытие или обновление данных)
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int studentID;
            try
            {
                studentID = int.Parse(studentsIDTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Поле ID студента должно быть числом!", "Ошибка ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName, lastName;
            int debts = 0;
            StudentsForm parent = this.Owner as StudentsForm;
            if (this.student.StudentID != studentID && parent.students.Count(o => o.StudentID == studentID) > 0)
            {
                MessageBox.Show("Студент с таким ID уже существует!", "Ошибка уникальности", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (debtsTextBox.Text.Trim().Length == 0)
            {
                try
                {
                    debts = int.Parse(debtsTextBox.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Поле Кол-во долгов должно быть числом!", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            firstName = firstNameTextBox.Text;
            if (firstName.Trim().Length == 0)
            {
                MessageBox.Show("Поле Имя студента не может быть пустым", "Ошибка Имени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lastName = lastNameTextBox.Text;
            if (lastName.Trim().Length == 0)
            {
                MessageBox.Show("Поле Фамилия студента не может быть пустым", "Ошибка Фамилии", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student.FirstName = firstName;
            student.LastName = lastName;
            student.MiddleName = middleNameTextBox.Text;
            student.Gender = genderComboBox.Text;
            student.StudentID = studentID;
            student.Foundation = foundationComboBox.Text;
            student.Debts = debts;
            student.Note = noteTextBox.Text;

            // Установка указателя на то, как завершилась работа с формой (просто закрытие или обновление данных)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
