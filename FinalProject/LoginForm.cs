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
    public partial class LoginForm : Form
    {
        private string role;

        public string Role { get => role; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            role = DBController.AuthorizationUser(login, password);
            if (Role != "guest")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Пароль или логин введены неверно!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            string login = regLoginTextBox.Text;
            string password = regPasswordTextBox.Text;
            if (regPasswordTextBox.Text.CompareTo(regRepeatPaswordTextBox.Text) != 0)
                MessageBox.Show("Пароли должны совпадать!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                try
                {
                    DBController.AddNewUser(login, password);
                    regLoginTextBox.Text = "";
                    regPasswordTextBox.Text = "";
                    regRepeatPaswordTextBox.Text = "";
                    tabControl1.SelectedTab = tabPage1;
                }
                catch (AlreadyExistUserException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            role = "guest";
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
