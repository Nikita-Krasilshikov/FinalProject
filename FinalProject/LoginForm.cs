using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        private string role;

        // Свойство. Создали для обращения к нему из другой формы.
        public string Role { get => role; }

        public LoginForm()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку "Вход"
        private void enterButton_Click(object sender, EventArgs e)
        {
            // Получение данных с формы
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            // Обращение к контроллеру для авторизации ползьователя
            role = DBController.AuthorizationUser(login, password);
            if (Role != "guest")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Пароль или логин введены неверно!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Обработчик нажатия на кнопку "Создать аккаунт"
        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            string login = regLoginTextBox.Text;
            string password = regPasswordTextBox.Text;
            // Проверка введённых данных
            if (regLoginTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Логин не может быть пустым!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (regPasswordTextBox.Text.Trim().Length < 6)
            {
                MessageBox.Show("Пароль не может быть короче 6 символов!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Проверка на правильность повтора пароля
            if (regPasswordTextBox.Text.CompareTo(regRepeatPaswordTextBox.Text) != 0)
            {
                MessageBox.Show("Пароли должны совпадать!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Добавление пользователя в БД
                DBController.AddNewUser(login, password);
                // Очищение полей
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
