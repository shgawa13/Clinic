using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsPatientData
  {
    // Add new Patient
    public static int AddNewPatient(int PersonID)
    {
      int PatientID = -1;

      string query = @"Insert Into Patients(PersonID)
                    Values(@PersonID);
                    Select SCOPE_IDENTITY();";
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
            command.Parameters.AddWithValue("@PersonID", PersonID);
            
            // resiving object from DB
            object result = command.ExecuteNonQuery();
            // Convert object to Int 
            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PatientID = ID;
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
        //Console.WriteLine($"Person ID is: {PersonID}");
      }

      return PatientID;
    }

    public static bool DeletePatient(int PatientID)
    {

      int IsDeleted = -1;
      string query = @"Delete From Patients where PatientID=@PatientID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PatientID", PatientID);

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
