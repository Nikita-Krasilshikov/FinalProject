using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private List<object> studentInfo;
        private string role;

        public string Role { get => role; }

        public MainForm(string role)
        {
            InitializeComponent();
            studentInfo = new List<object>();
            this.role = role;
            studentsCountLabel.Text = $"Количество записей: {DBController.StudentsCount()}";
            genderComboBox.SelectedIndex = 0;
            foundationComboBox.SelectedIndex = 0;
            this.Text += " " + role.ToUpper();
            // В зависимости от роли пользователя, скрываются или отображаются определённые компоненты
            if (role == "admin")
            {
                usersButton.Visible = true;
            }
            if (role == "admin" || role == "user")
            {
                addStudentButton.Visible = true;
            }
            if (role == "guest")
            {
                fieldGroupBox.Visible = false;
                this.Height = 141;
            }
        }

        private void showGroupListButton_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Owner = this;
            studentsForm.ShowDialog();
        }

        private void workingButton_Click(object sender, EventArgs e)
        {
            PaidForm paidForm = new PaidForm();
            paidForm.ShowDialog();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
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
            if (DBController.HasStudent(studentID))
            {
                MessageBox.Show("Студент с таким ID уже существует!", "Ошибка уникальности", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (debtsTextBox.Text.Trim().Length != 0)
                try
                {
                    debts = int.Parse(debtsTextBox.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Поле Кол-во долгов должно быть числом!", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

            studentInfo.Add(studentID);
            studentInfo.Add(firstName);
            studentInfo.Add(lastName);
            studentInfo.Add(middleNameTextBox.Text);
            studentInfo.Add(birthDateDateTimePicker.Value);
            studentInfo.Add(genderComboBox.Text);
            studentInfo.Add(foundationComboBox.Text);
            studentInfo.Add(debts);
            studentInfo.Add(noteTextBox.Text);

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            genderComboBox.Text = "";
            studentsIDTextBox.Text = "";
            foundationComboBox.Text = "";
            debtsTextBox.Text = "";
            noteTextBox.Text = "";

            DBController.AddStudent(studentInfo);

            studentsCountLabel.Text = $"Количество записей: {DBController.StudentsCount()}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }
    }
}
