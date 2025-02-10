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
    public static int AddNewDoctor(int PersonID, byte SpecialityID)
    {
      int DoctorID = -1;
      string Query = @"Insert into Doctors(PersonID,SpecialityID) Values(@PersonID,@SpecialityID);
                     Select SCOPE_IDENTITY();";

      try
      { // Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SpecialityID", SpecialityID);
            // SpecialityID

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
    public static bool UpdateDoctors(int DoctorID, int PersonID, byte SpecialityID)
    {
      int EffectedRow = 0;
      string Query = @"Update Doctors
      set PersonID=@PersonID,
      SpecialityID=@SpecialityID
      where DoctorID=@DoctorID";

      try
      { // Create Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        { // Open Connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SpecialityID", SpecialityID);
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
    public static bool GetDoctorByID(int DoctorID,ref int PersonID,ref byte SpecialityID)
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
                SpecialityID = (byte)reader["SpecialityID"];
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

    // Find Doctor By ID
    public static bool GetDoctorByFullName(string FullName,ref int DoctorID ,ref int PersonID,ref string NationalID, 
      ref byte SpecialityID,ref DateTime DateOfBirth, ref byte Gendor, ref string PhoneNumber, ref string Email, 
      ref int NationalityCountryID,ref string ImagePath)
    {
      bool IsFound = false;

      string query = @"Select * from DoctorsView where FullName like '%@FullName';";

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
            command.Parameters.AddWithValue("@FullName", FullName);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                DoctorID = (int)reader["DoctorID"];
                PersonID = (int)reader["PersonID"];
                NationalID = (string)reader["NationalID"];
                SpecialityID = (byte)reader["SpecialityID"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (byte)reader["Gendor"];
                PhoneNumber = (string)reader["PhoneNumber"];
                // handle Email
                if (reader["Email"] == System.DBNull.Value)
                  Email = "";
                else
                  Email = (string)reader["Email"];

                NationalityCountryID = (int)reader["NationalityCountryID"];

                // handle ImagePath
                if (reader["ImagePath"] == System.DBNull.Value)
                  ImagePath = "";
                else
                  ImagePath = (string)reader["ImagePath"];

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
        Console.WriteLine($"FullName is: {FullName}");
      }

      return IsFound;
    }

    // Get All Doctors
    public static DataTable GetAllDoctors()
    {
      DataTable dtAllDoctors = new DataTable();
      string query = @"Select * from DoctorsView;";

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
