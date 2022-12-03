using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DBController
    {
        private static string connectionString = @"Data Source=emiit.ru;Initial Catalog=students_db;Persist Security Info=True;User ID=user-50;Password=9218964503";
        public static string AuthorizationUser(string login, string password)
        {
            string query = "SELECT * FROM \"user\" WHERE login=@Login AND password=@Password";
            string role = "guest";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter loginParameter = new SqlParameter("@Login", login);
                SqlParameter passwordParameter = new SqlParameter("@Password", password);
                cmd.Parameters.Add(loginParameter);
                cmd.Parameters.Add(passwordParameter);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    role = Convert.ToString(reader.GetValue(3));

                return role;
            }
        }

        public static bool IsUserExist(string login)
        {
            string query = "SELECT * FROM \"user\" WHERE login=@Login";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter loginParameter = new SqlParameter("@Login", login);
                cmd.Parameters.Add(loginParameter);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) ;
                return reader.HasRows;
            }
        }

        public static void AddNewUser(string login, string password)
        {
            if (!IsUserExist(login))
            {
                string query = "INSERT INTO \"user\" (login, password, role) VALUES(@Login, @Password, user)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlParameter loginParameter = new SqlParameter("@Login", login);
                    SqlParameter passwordParameter = new SqlParameter("@Password", password);
                    cmd.Parameters.Add(loginParameter);
                    cmd.Parameters.Add(passwordParameter);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                throw new AlreadyExistUserException();
            }
        }

        public static int StudentsCount()
        {
            string query = "SELECT COUNT(*) FROM \"student\"";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
        }

        public static void DeleteStudent(int id)
        {
            string query = "DELETE FROM \"student\" WHERE id=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idParameter = new SqlParameter("@Id", id);
                cmd.Parameters.Add(idParameter);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteUser(int id)
        {
            string query = "DELETE FROM \"user\" WHERE id=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idParameter = new SqlParameter("@Id", id);
                cmd.Parameters.Add(idParameter);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<object> GetStudentInfo(int id)
        {
            List<object> list = new List<object>();
            string query = "SELECT * FROM \"student\" WHERE id=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idParameter = new SqlParameter("@Id", id);
                cmd.Parameters.Add(idParameter);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader.GetValue(i));
                    }
                }
                return list;
            }
        }

        public static bool HasStudent(int id)
        {
            string query = "SELECT * FROM \"student\" WHERE id=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idParameter = new SqlParameter("@Id", id);
                cmd.Parameters.Add(idParameter);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) ;
                return reader.HasRows;
            }
        }

        public static void UpdateStudent(List<object> values)
        {
            string query = "UPDATE student " +
                           "SET firstName=@FirstName, lastName=@LastName, middleName=@MiddleName, " +
                           "birthDate=@BirthDate, gender=@Gender, foundation=@Foundation, debts=@Debts, note=@Note " +
                           "WHERE id=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idParameter = new SqlParameter("@Id", values[0]);
                SqlParameter firstNameParameter = new SqlParameter("@FirstName", values[1]);
                SqlParameter lastNameParameter = new SqlParameter("@LastName", values[2]);
                SqlParameter middleNameParameter = new SqlParameter("@MiddleName", values[3]);
                SqlParameter birthDateParameter = new SqlParameter("@BirthDate", values[4]);
                SqlParameter genderParameter = new SqlParameter("@Gender", values[5]);
                SqlParameter foundationParameter = new SqlParameter("@Foundation", values[6]);
                SqlParameter debtsParameter = new SqlParameter("@Debts", values[7]);
                SqlParameter noteParameter = new SqlParameter("@Note", values[8]);
                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(firstNameParameter);
                cmd.Parameters.Add(lastNameParameter);
                cmd.Parameters.Add(middleNameParameter);
                cmd.Parameters.Add(birthDateParameter);
                cmd.Parameters.Add(genderParameter);
                cmd.Parameters.Add(foundationParameter);
                cmd.Parameters.Add(debtsParameter);
                cmd.Parameters.Add(noteParameter);
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddStudent(List<object> values)
        {
            string query = "INSERT INTO \"student\" (id, firstName, lastName, middleName, birthDate, gender, foundation, debts, note) " +
                           "VALUES (@Id, @FirstName, @LastName, @MiddleName, @BirthDate, @Gender, @Foundation, @Debts, @Note)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idParameter = new SqlParameter("@Id", values[0]);
                SqlParameter firstNameParameter = new SqlParameter("@FirstName", values[1]);
                SqlParameter lastNameParameter = new SqlParameter("@LastName", values[2]);
                SqlParameter middleNameParameter = new SqlParameter("@MiddleName", values[3]);
                SqlParameter birthDateParameter = new SqlParameter("@BirthDate", values[4]);
                SqlParameter genderParameter = new SqlParameter("@Gender", values[5]);
                SqlParameter foundationParameter = new SqlParameter("@Foundation", values[6]);
                SqlParameter debtsParameter = new SqlParameter("@Debts", values[7]);
                SqlParameter noteParameter = new SqlParameter("@Note", values[8]);
                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(firstNameParameter);
                cmd.Parameters.Add(lastNameParameter);
                cmd.Parameters.Add(middleNameParameter);
                cmd.Parameters.Add(birthDateParameter);
                cmd.Parameters.Add(genderParameter);
                cmd.Parameters.Add(foundationParameter);
                cmd.Parameters.Add(debtsParameter);
                cmd.Parameters.Add(noteParameter);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
