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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string role = DBController.AuthorizationUser(login, password);
            if (role != "guest")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароль или логин введены неверно!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            string login = regLoginTextBox.Text;
            string password = regPasswordTextBox.Text;
            if (regPasswordTextBox.Text.CompareTo(regRepeatPaswordTextBox.Text) != 0)
            {
                MessageBox.Show("Пароли должны совпадать!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
