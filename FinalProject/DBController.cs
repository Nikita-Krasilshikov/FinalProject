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
    }
}
