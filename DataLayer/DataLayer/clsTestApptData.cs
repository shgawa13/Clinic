using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataLayer
{
  public class clsTestApptData
  {

    public static DataTable GetAllAppointmnets()
    {
      DataTable dtAllAppointments = new DataTable();
      string Query = $"Select * from Appointmnets";

      try
      {
        using(SqlConnection connection = new SqlConnection(clsAccessSetting.TestConnString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using(SqlCommand command = new SqlCommand(Query, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.HasRows)
              {
                dtAllAppointments.Load(reader);
              }

            }
          }
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {

      }

      return dtAllAppointments;
    }



  }
}
