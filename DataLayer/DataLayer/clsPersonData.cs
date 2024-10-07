using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom;
using System.Collections;
using System.Data;

namespace DataLayer
{
  public class clsPersonData
  {
    // Add new Person
    public static int AddNewPerson(int NationalID, string FirstName, string SecondName, string LastName,
      DateTime DateOfBirth, byte Gendor, string PhoneNumber, string Email, string ImagePath, short CountryID)
    {
      int PersonID = -1;

      string query = @"Insert Into People
     (NationalID,FirstName,SecondName,LastName,DateOfBirth,Gendor,PhoneNumber,Email,ImagePath,CountryID)
     Values(@NationalID,@FirstName,@SecondName,@LastName,@DateOfBirth,@Gendor,@PhoneNumber,@Email,@ImagePath,@CountryID);
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
            command.Parameters.AddWithValue("@NationalID", NationalID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            if (Email != "" && Email != null)
              command.Parameters.AddWithValue("@Email", Email);
            else
              command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "" && ImagePath != null)
              command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
              command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            // resiving object from DB
            object result = command.ExecuteNonQuery();
            // Convert object to Int 
            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PersonID = ID;
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


      return PersonID;
    }

    // Update PersonInfo
    public static bool UpdatePersonInfo(int PersonID, int NationalID, string FirstName, string SecondName, string LastName,
      DateTime DateOfBirth, byte Gendor, string PhoneNumber, string Email, string ImagePath, short CountryID)
    {
      int EffectedRow = 0;

      string query = @"update People
          set NationalID=@NationalID,
          FirstName=@FirstName,
          SecondName=@SecondName,
          LastName=@LastName,
          DateOfBirth=@DateOfBirth,
          Gendor=@Gendor,
          PhoneNumber=@PhoneNumber,
          Email=@Email,
          ImagePath=@ImagePath,
          CountryID=@CountryID
          where PersonID=@PersonID";
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
            command.Parameters.AddWithValue("@NationalID", NationalID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            if (Email != "" && Email != null)
              command.Parameters.AddWithValue("@Email", Email);
            else
              command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "" && ImagePath != null)
              command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
              command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);


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
        Console.WriteLine($"Person ID is: {PersonID}");
      }

      return (EffectedRow > 0);
    }

    // Find Person By ID
    public static bool GetPersonByID(int PersonID, ref int NationalID, ref string FirstName, ref string SecondName,
      ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string PhoneNumber, ref string Email,
      ref string ImagePath, short CountryID)
    {
      bool IsFound = false;

      string query = @"Select * from People where PersonID=@PersonID;";

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
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                NationalID = (int)reader["NationalID"];
                FirstName = (string)reader["FirstName"];
                SecondName = (string)reader["SecondName"];
                LastName = (string)reader["LastName"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (byte)reader["Gendor"];
                PhoneNumber = (string)reader["PhoneNumber"];
                Email = (string)reader["Email"] ?? "";
                ImagePath = (string)reader["ImagePath"] ?? "";
                CountryID = (short)reader["CountryID"];
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

    // Find Person By NationalID
    public static bool GetPersonByNationalID(ref int PersonID, ref string FirstName, ref string SecondName,
      ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string PhoneNumber, ref string Email,
      ref string ImagePath, short CountryID)
    {
      bool IsFound = false;
      string query = @"Select * from People where PersonID=@PersonID;";

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
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                PersonID = (int)reader["PersonID"];
                FirstName = (string)reader["FirstName"];
                SecondName = (string)reader["SecondName"];
                LastName = (string)reader["LastName"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (byte)reader["Gendor"];
                PhoneNumber = (string)reader["PhoneNumber"];
                Email = (string)reader["Email"] ?? "";
                ImagePath = (string)reader["ImagePath"] ?? "";
                CountryID = (short)reader["CountryID"];
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

    // Find Person By PhoneNumber
    public static bool GetPersonByPhoneNumber(string PhoneNumber, ref int PersonID, ref int NationalID,
      ref string FirstName, ref string SecondName, ref string LastName, ref DateTime DateOfBirth,
      ref byte Gendor, ref string Email, ref string ImagePath, short CountryID)
    {
      bool IsFound = false;
      string query = @"Select * from People where PhoneNumber=@PhoneNumber;";

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
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                PersonID = (int)reader["PersonID"];
                NationalID = (int)reader["NationalID"];
                FirstName = (string)reader["FirstName"];
                SecondName = (string)reader["SecondName"];
                LastName = (string)reader["LastName"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (byte)reader["Gendor"];
                Email = (string)reader["Email"] ?? "";
                ImagePath = (string)reader["ImagePath"] ?? "";
                CountryID = (short)reader["CountryID"];
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
        //Console.WriteLine($"Person ID is: {PersonID}");
      }

      return IsFound;
    }

    // Get All People
    public static DataTable GetAllPeople()
    {
      DataTable dtAllPeople = new DataTable();
      string query = @"select * from People;";

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
                dtAllPeople.Load(reader);
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

      return dtAllPeople;
    }

    // Delete Person
    public static bool DeletePerson(int PersonID)
    {
      int IsDeleted = -1;
      string query = @"Delete From People where PersonID=@PersonID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);

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


    // IsExist PersonID
    public static bool IsPersonExist(int PersonID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from People where PersonID=@PersonID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
              IsExist = reader.HasRows;
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

      return IsExist;
    }

    // Is NationalID Exist
    public static bool IsPersonExist(string NationalID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from People where NationalID=@NationalID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@NationalID", NationalID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
              IsExist = reader.HasRows;
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

      return IsExist;
    }
  }
}
