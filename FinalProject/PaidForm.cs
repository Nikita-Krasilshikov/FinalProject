using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PaidForm : Form
    {
        public PaidForm()
        {
            InitializeComponent();
            // Фильтрация и соритровка данных
            studentBindingSource.Filter = "foundation LIKE 'Платная%'";
            studentBindingSource.Sort = "id DESC";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaidForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных из датасета в таблицу
            this.paidStudentTableAdapter.Fill(this.students_dbDataSet.student);
        }
    }
}
