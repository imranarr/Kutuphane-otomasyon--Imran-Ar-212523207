using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibaryProgram
{
    public class UserDal
    {
        public void AddUser(User user)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=Azat; Initial Catalog=DbLibrary; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string connectionString = "Server=Azat; Initial Catalog=DbLibrary; integrated security=true";
            string insertQuery = "INSERT INTO Users (UserName, Password) VALUES (@UserName, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
