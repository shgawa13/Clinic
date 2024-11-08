using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
  public class clsSpecialitiesData
  {

    public static bool GetSpecialtyByID(byte ID, ref string Title,ref string Description)
    {
      bool IsFound = false;
      string Query = $"Select * from Specialities where ID = @ID";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // open connection 
          connection.Open();
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // Adding Parameters
            command.Parameters.AddWithValue("@ID", ID);
            using (SqlDataReader reader = command.ExecuteReader()) 
            {
              if (reader.Read())
              {
                IsFound = true;
                Title = (string)reader["Title"];
                Description = (string)reader["Description"];
              }
              else
              {
                IsFound = false;
              }
            }
          }
        }
      }catch( Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        //
      }
      return IsFound;
    }

    // GetSpecialty By Title

    public static bool GetSpecialtyByTitle(string Title,ref byte ID,ref string Description)
    {
      bool IsFound = false;
      string Query = $"Select * from Specialities where Title = @Title";

      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // adding Parameters
            command.Parameters.AddWithValue("@Title", Title);

            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                ID = (byte)reader["ID"];
                Description = (string)reader["Description"];
              }
              else
              {
                IsFound = false;
              }
            }
          }
        }
      }catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        //
      }
      return IsFound;
    }

    public static DataTable GetAllSpecialities()
    {
      DataTable dtSpecialities = new DataTable();

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Query
          string Query = $"Select * from Specialities";

          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // Reading Data from table and load it in DataTable;
            using (SqlDataReader reader = command.ExecuteReader())
            {
              // if reader is read mean it has data then we load data

              if (reader.HasRows)
              {
                dtSpecialities.Load(reader);
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
        //
      }

       return dtSpecialities;
    }
  }
}
