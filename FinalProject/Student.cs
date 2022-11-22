namespace FinalProject
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private int birthDay;
        private int birthMonth;
        private int birthYear;
        private string gender;
        private int studentID;
        private string foundation;
        private int debts;
        private string note;
        public Student()
        {

        }
        public Student(string firstName, string lastName, string middleName, int birthDay,
            int birthMonth, int birthYear, string gender, int studentID, string foundation, int debts, string note)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.BirthDay = birthDay;
            this.BirthMonth = birthMonth;
            this.BirthYear = birthYear;
            this.Gender = gender;
            this.StudentID = studentID;
            this.Foundation = foundation;
            this.Debts = debts;
            this.Note = note;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public int BirthDay { get => birthDay; set => birthDay = value; }
        public int BirthMonth { get => birthMonth; set => birthMonth = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public string Gender { get => gender; set => gender = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public string Foundation { get => foundation; set => foundation = value; }
        public int Debts { get => debts; set => debts = value; }
        public string Note { get => note; set => note = value; }
        public string FullName { get => $"{firstName} {lastName} {middleName}"; }
        public string BirthDate { get => $"{birthDay}.{birthMonth}.{birthYear}"; }
    }
}
