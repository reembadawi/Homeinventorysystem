using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp8.Entities;

namespace WindowsFormsApp8.DataAccessLayer
{
    public static class UsersDAL
    {
       private static string connectionString = "Data Source=.; " +
            "Initial Catalog = PersonalShopping; Integrated Security = True";

        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void CreateUser(User user)
        {
            string commandText = $"Insert into SystemUsers values('{user.FirstName}','{user.LastName}','{user.UserName}','{user.Password}')";
            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();
            connection.Close();
            command.ExecuteNonQuery();
        }

        public static void UpdateUser(User user) 
        {
            string commandText = $"Update SystemUsers Set " +
               $"FirstName='{user.FirstName}'" +
               $"LastName='{user.LastName}'" +
               $"UserName='{user.UserName}'" +
               $"Password='{user.Password}'";

            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();
            connection.Close();
            command.ExecuteNonQuery();

        }
         public static void DeleteUser(User user) 
        {
            string commandText = $"Delet from SystemUsers where UserId ={user.UserId}";

            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();
            connection.Close();
            command.ExecuteNonQuery();
        }
        public static DataTable GetAllUsers()
        {
            string commandText = $"Select * from SystemUsers";
            SqlCommand command = new SqlCommand(commandText, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static User GetUserById(int userId)
        {
            User user = new User();

            string commandText = $"Select * from SystemUsers Where UserId={userId}";
            SqlCommand command = new SqlCommand(commandText, connection);
            SqlDataReader userReader=command.ExecuteReader();
            if (userReader.HasRows)
            {
                while (userReader.Read())
                {
                    user.UserId = userReader.GetInt32(0);
                    user.FirstName = userReader.GetString(1);
                    user.LastName = userReader.GetString(2);
                    user.UserName = userReader.GetString(3);
                    user.Password = userReader.GetString(4);
                }
            }
            return user;
            
        }
    }
}
