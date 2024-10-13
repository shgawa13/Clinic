using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsMedicalRecordsData
  {
    // Add new MedicalRecord
    public static int AddNewMedicalRecord(string VisitDescription, string Diagnosis, string AdditionalNotes)
    {
      int MedicalRecordID = -1;

      string query = @"Insert Into MedicalRecords
     (VisitDescription,Diagnosis,AdditionalNotes)
     Values(@VisitDescription,@Diagnosis,@AdditionalNotes);
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
            command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);

            if (AdditionalNotes != "" && AdditionalNotes != null)
              command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
              command.Parameters.AddWithValue("@AdditionalNotes", System.DBNull.Value);


            // resiving object from DB
            object result = command.ExecuteScalar();
            // Convert object to Int 
            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              MedicalRecordID = ID;
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
        //Console.WriteLine($"MedicalRecordID is: {MedicalRecordID}");
      }


      return MedicalRecordID;
    }

    // Update MedicalRecord
    public static bool UpdateMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes)
    {
      int EffectedRow = 0;

      string query = @"update MedicalRecords
          set VisitDescription=@VisitDescription,
          Diagnosis=@Diagnosis,
          AdditionalNotes=@AdditionalNotes,
          where MedicalRecordID=@MedicalRecordID";
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
            command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
           
            if (AdditionalNotes != "" && AdditionalNotes != null)
              command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
              command.Parameters.AddWithValue("@AdditionalNotes", System.DBNull.Value);

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

    // Find MedicalRecord By ID
    public static bool GetMedicalRecordByID(int MedicalRecordID, ref string VisitDescription, ref string Diagnosis,
      ref string AdditionalNotes)
    {
      bool IsFound = false;

      string query = @"Select * from MedicalRecords where MedicalRecordID=@MedicalRecordID;";

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
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                VisitDescription = (string)reader["VisitDescription"];
                Diagnosis = (string)reader["Diagnosis"];

                // handle AdditionalNotes
                if (reader["AdditionalNotes"] == System.DBNull.Value)
                  AdditionalNotes = "";
                else
                  AdditionalNotes = (string)reader["AdditionalNotes"];

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

    

    // Get All MedicalRecords
    public static DataTable GetAllMedicalRecords()
    {
      DataTable dtAllMedicalRecords = new DataTable();
      string query = @"select * from MedicalRecords;";

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
                dtAllMedicalRecords.Load(reader);
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

      return dtAllMedicalRecords;
    }

    // Delete MedicalRecord
    public static bool Delete(int MedicalRecordID)
    {
      int IsDeleted = -1;
      string query = @"Delete From MedicalRecords where MedicalRecordID=@MedicalRecordID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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


    // IsExist MedicalRecordID
    public static bool IsExist(int MedicalRecordID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from MedicalRecords where MedicalRecordID=@MedicalRecordID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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
