using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using ParameterizedQueryDemo.Models;

namespace ParameterizedQueryDemo.DAL
{
    public class CityGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["CityInfoConnectionString"].ConnectionString;

        public int Insert(City city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO City (Name, About, Country)VALUES(@name,@about,@country)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = city.Name;
            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = city.About;
            command.Parameters.Add("country", SqlDbType.VarChar);
            command.Parameters["country"].Value = city.Country;
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}