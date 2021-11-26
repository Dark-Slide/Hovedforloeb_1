using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Football
{
    internal class SQL
    {
        string sql = @"Data Source=.\SQLExpress3;Initial Catalog=Football";
        string queryString = "SELECT TeamName FROM Team;";
        SqlConnection cnn;
        using (SqlConnection connectrion = new SqlConnection(sql)) {
            SqlCommand command = new SqlCommand(queryString, connection);
            try 
            {
                while (true)
            	{
                    
            	}
            }
        }
    }
}
