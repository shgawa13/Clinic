using System;
using System.Collections.Generic;
using System.Data;
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
            object result = command.ExecuteScalar();
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

    // Update Patient
    public static bool UpdatePatient(int PatientID,int PersonID)
    {
      int EffectedRow = 0;

      string query = @"update Patients set PersonID=@PersonID  where PatientID=@PatientID";
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
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            // rows effected  
            EffectedRow = command.ExecuteNonQuery();

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

      return (EffectedRow > 0);
    }

    // Find by PatientID
    public static bool FindPatientByID(int PatientID,ref int PersonID)
    {
      bool IsFound = false;
      string query = @"Select * from Patients where PatientID=@PatientID;";

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
            command.Parameters.AddWithValue("@PatientID", PatientID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                PersonID = (int)reader["PersonID"];
                
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

    // Find by PersonID
    public static bool FindPatientByPersonID(int PersonID, ref int PatientID)
    {
      bool IsFound = false;
      string query = @"Select * from Patients where PersonID=@PersonID;";

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
            command.Parameters.AddWithValue("@PersonID", PersonID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                PatientID = (int)reader["PatientID"];

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

    // Get All Patients
    public static DataTable GetAllPatients()
    {
      DataTable dtAllPatients = new DataTable();

      string query = @"select * from PatientsView;";

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
                dtAllPatients.Load(reader);
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


      return dtAllPatients;
    }

    // Delete Patient
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
