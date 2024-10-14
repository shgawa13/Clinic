using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsPrescriptionsData
  {
    // Add new Prescription
    public static int AddNewPrescription(int MedicalRecordID,string MedicationName)
    {
      int PerscriptionID = -1;

      string query = @"Insert Into Prescriptions(MedicalRecordID,MedicationName)
      Values(@MedicalRecordID,@MedicationName);
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
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@MedicationName", MedicationName);

            // resiving object from DB
            object result = command.ExecuteScalar();
            // Convert object to Int 
            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PerscriptionID = ID;
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


      return PerscriptionID;
    }

    // Update Perscription
    public static bool UpdatePerscription(int PerscriptionID, int MedicalRecordID, string MedicationName)
    {
      int EffectedRow = 0;

      string query = @"update Perscriptions
          set MedicalRecordID=@MedicalRecordID,
          MedicationName=@MedicationName,
          where PerscriptionID=@PerscriptionID";
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
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@MedicationName", MedicationName);
            
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
        //Console.WriteLine($"");
      }

      return (EffectedRow > 0);
    }

    // Find Perscription By ID
    public static bool GetPerscriptionByID(int PerscriptionID, ref int MedicalRecordID,
      ref string MedicationName)
    {
      bool IsFound = false;

      string query = @"Select * from Payments where PerscriptionID=@PerscriptionID;";

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
            command.Parameters.AddWithValue("@PerscriptionID", PerscriptionID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                MedicalRecordID = (int)reader["MedicalRecordID"];
                MedicationName = (string)reader["MedicationName"];

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
        // Console.WriteLine($"");
      }

      return IsFound;
    }



    // Get All Payments
    public static DataTable GetAllPerscriptions()
    {
      DataTable dtAllPerscriptions = new DataTable();
      string query = @"select * from Perscriptions;";

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
                dtAllPerscriptions.Load(reader);
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

      return dtAllPerscriptions;
    }

    // Delete Payment
    public static bool Delete(int PerscriptionID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Perscriptions where PerscriptionID=@PerscriptionID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PerscriptionID", PerscriptionID);

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


    // IsExist PerscriptionID
    public static bool IsPerscriptionIDExist(int PerscriptionID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from Perscriptions where PerscriptionID=@PerscriptionID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PerscriptionID", PerscriptionID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
              IsExist = reader.HasRows;
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

      return IsExist;
    }

  }
}
