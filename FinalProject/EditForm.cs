using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditForm : Form
    {
        int studentId;
        List<object> studentInfo;
        public EditForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            studentInfo = DBController.GetStudentInfo(studentId);
            // Заполнение элементов формы данными из БД
            studentsIDTextBox.Text = studentInfo[0].ToString();
            firstNameTextBox.Text = studentInfo[1].ToString();
            lastNameTextBox.Text = studentInfo[2].ToString();
            middleNameTextBox.Text = studentInfo[3].ToString();
            birthDateDateTimePicker.Value = DateTime.Parse(studentInfo[4].ToString());
            genderComboBox.Text = studentInfo[5].ToString();
            foundationComboBox.Text = studentInfo[6].ToString();
            debtsTextBox.Text = studentInfo[7].ToString();
            noteTextBox.Text = studentInfo[8].ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
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
            if (this.studentId != studentID && DBController.HasStudent(studentID))
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

            // Формирование объекта с данными для отправки в БД
            studentInfo[1] = firstNameTextBox.Text;
            studentInfo[2] = lastNameTextBox.Text;
            studentInfo[3] = middleNameTextBox.Text;
            studentInfo[4] = birthDateDateTimePicker.Value;
            studentInfo[5] = genderComboBox.Text;
            studentInfo[6] = foundationComboBox.Text;
            studentInfo[7] = debtsTextBox.Text;
            studentInfo[8] = noteTextBox.Text;

            DBController.UpdateStudent(studentInfo);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
