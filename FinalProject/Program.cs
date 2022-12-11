using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Изначально запускается диалог для входа или регистрации
            LoginForm lf = new LoginForm();
            // Если все данные введены верно, то запускается основное окно
            if (lf.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm(lf.Role));
        }
    }
}
