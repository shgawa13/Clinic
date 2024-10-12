using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsAppointmentStatusData
  {
    // Add new appointment status
    public static short AddNewAppointmentStatus(string StatusName,string StatusDiscription)
    {
      short AppointmentStatusID = 0;
      string query = @"Insert into AppointmentStatus(StatusName,StatusDiscription)
      Vallues(@StatusName,@StatusDiscription);
      SELECT SCOPE_IDENTITY();";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // open connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            // adding Parameters
            command.Parameters.AddWithValue("@StatusName", StatusName);
            command.Parameters.AddWithValue("@StatusDiscription", StatusDiscription);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              AppointmentStatusID = (short)ID;
            }
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {

      }
      return AppointmentStatusID;
    }

    // Update AppointmentStaus
    public static bool UpdateAppointmentStatus(short AppointmentStautsID,string StatusName,
         string StatusDiscription)
    {
      int EffectedRows = 0;
      string query = @"Update AppointmentStatus
      set StatusName=@StatusName,
      StatusDiscription=@StatusDiscription
      where AppointmentStautsID=@AppointmentStautsID;";

      try
      {

        // Create Connection 
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            // Adding Paramters
            command.Parameters.AddWithValue("@AppointmentStautsID", AppointmentStautsID);
            command.Parameters.AddWithValue("@StatusName", StatusName);
            command.Parameters.AddWithValue("@StatusDiscription", StatusDiscription);
            // rows effected  
            EffectedRows = command.ExecuteNonQuery();

          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        // Console.WriteLine($"");
      }

      return (EffectedRows > 0);
    }

    // Find Status by id
    public static bool FindAppointmentStatusByID(short AppointmentStautsID,ref string StatusName,
             ref string StatusDiscription)
    {
      bool IsFound = false;
      string query = @"Select * from AppointmentStatus where AppointmentStautsID=@AppointmentStautsID;";

      try
      {

        // Create Connection 
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@AppointmentStautsID", AppointmentStautsID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                StatusName = (string)reader["StatusName"];
                StatusDiscription = (string)reader["StatusDiscription"];
              }
            }

          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        //Console.WriteLine($"");
      }

      return IsFound;
    }

    // Get All Status
    public static DataTable GetAllAppointmentStatus()
    {
      DataTable dtAllAppointmentStatus = new DataTable();

      string query = @"select * from AppointmentStatus;";

      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.HasRows)
              {
                dtAllAppointmentStatus.Load(reader);
              }

            }
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {

      }


      return dtAllAppointmentStatus;
    }

    // Delete AppointmentStatus
    public static bool DeleteAppointmentStatus(short AppointmentStatusID)
    {

      int IsDeleted = -1;
      string query = @"Delete From AppointmentStatus where AppointmentStatusID=@AppointmentStatusID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@AppointmentStatusID", AppointmentStatusID);

            IsDeleted = command.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        //Console.WriteLine($"Person ID is: {PersonID}");
      }

      return (IsDeleted > 0);
    }
  }
}
