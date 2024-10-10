using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsDoctorsData
  {
    // AddNewDoctors
    public static int AddNewDoctor(int PersonID, string Specialization)
    {
      int DoctorID = -1;
      string Query = @"Insert into Doctors(PersonID,Specialization) Values(@PersonID,@Specialization);
                     Select SCOPE_IDENTITY();";

      try
      { // Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Specialization", Specialization);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              DoctorID = ID;
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

        return DoctorID;
    }

    // Update Doctors
    public static bool UpdateDoctors(int DoctorID, int PersonID, string Specialization)
    {
      int EffectedRow = 0;
      string Query = @"Update Doctors
      set PersonID=@PersonID,
      Specialization=@Specialization
      where DoctorID=@DoctorID";

      try
      { // Create Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        { // Open Connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Specialization", Specialization);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);

            EffectedRow = command.ExecuteNonQuery();
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

      return (EffectedRow > 0);
    }

    // Find Doctor By ID
    public static bool GetDoctorByID(int DoctorID,ref int PersonID,ref string Specialization)
    {
      bool IsFound = false;

      string query = @"Select * from Doctors where DoctorID=@DoctorID;";

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
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                PersonID = (int)reader["PersonID"];
                Specialization = (string)reader["Specialization"];
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
        Console.WriteLine($"Person ID is: {PersonID}");
      }

      return IsFound;
    }


    // Get All Doctors
    public static DataTable GetAllDoctors()
    {
      DataTable dtAllDoctors = new DataTable();
      string query = @"select * from Doctors;";

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
                dtAllDoctors.Load(reader);
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

      return dtAllDoctors;
    }

    // Delete Doctors
    public static bool DeleteDoctor(int DoctorID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Doctors where DoctorsID=@DoctorsID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@DoctorID", DoctorID);

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


    // IsExist DoctorID
    public static bool IsPersonExist(int DoctorID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from Doctors where DoctorID=@DoctorID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@DoctorID", DoctorID);

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
