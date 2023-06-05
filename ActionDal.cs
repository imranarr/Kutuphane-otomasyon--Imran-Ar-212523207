using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryProgram
{
    public class ActionDal
    {
        public List<Action> GetAllAction()
         {
          List<Action> actions = new List<Action>();
          SqlConnection sqlConnection = new SqlConnection("Server=Azat; Initial Catalog=DbLibrary; integrated security=true");
            if(sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlcommand = new SqlCommand("Select * From Actions ", sqlConnection);
            SqlDataReader sqlDataReader= sqlcommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                Action action = new Action
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name= sqlDataReader["Name"].ToString(),
                    WriterName = sqlDataReader["WriterName"].ToString(),
                    WriterSurname = sqlDataReader["WriterSurname"].ToString(),
                    NumberOfPages = Convert.ToInt32(sqlDataReader["NumberOfPages"]),
                    Summary= sqlDataReader["Summary"].ToString()
                };
                actions.Add(action);
            }
            return actions;

        }
        public void AddAction(Action action)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=Azat; Initial Catalog=DbLibrary; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Actions (Name, WriterName, WriterSurname, NumberOfPages, Summary) VALUES (@p1,@p2,@p3,@p4,@p5)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", action.Name);
            sqlCommand.Parameters.AddWithValue("@p2", action.WriterName);
            sqlCommand.Parameters.AddWithValue("@p3", action.WriterSurname);
            sqlCommand.Parameters.AddWithValue("@p4", action.NumberOfPages);
            sqlCommand.Parameters.AddWithValue("@p5", action.Summary);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateAction (Action action)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=Azat; Initial Catalog=DbLibrary; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Update Actions set (Nanme, WriterName,WriterSurname,NumberOfPages, Summary,Id)VALUES(@p1,@p2,@p3,@p4,@p5,id)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",action.Name);
            sqlCommand.Parameters.AddWithValue("@p2",action.WriterName);
            sqlCommand.Parameters.AddWithValue("@p3",action.WriterSurname);
            sqlCommand.Parameters.AddWithValue("@p4",action.NumberOfPages);
            sqlCommand.Parameters.AddWithValue("@p5",action.Summary);
            sqlCommand.Parameters.AddWithValue("@Id",action.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void DeleteAction (int id)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=Azat; Initial Catalog=DbLibrary; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Delete From Actions Where Id=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",id);
            sqlCommand.ExecuteNonQuery ();
            sqlConnection.Close();

        }

    }
}
