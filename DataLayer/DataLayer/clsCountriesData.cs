using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataLayer
{
  public class clsCountriesData
  {
    public static bool GetCountryByID(int ID, ref string CountryName)
    {
      bool IsFound = false;
      string Query = "Select * from Countries where CountryID=@ID;";
      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          connection.Open();
          using(SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@ID", ID);

            using(SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;
                CountryName = (string)reader["CountryName"];
              }
            }
          }
      
        }
    
      }
      catch (Exception)
      {
        IsFound = false;
      }
      finally
      {
        
      }
      return IsFound;
    }

    public static bool GetCountryByName(string CountryName, ref int ID)
    {
      bool IsFound = false;
      string Query = "select * from Countries where CountryName =@CountryName;";
      try
      {

        using(SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          connection.Open();
          using(SqlCommand command = new SqlCommand(Query,connection))
          {
            command.Parameters.AddWithValue("@CountryName", CountryName);

            using(SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;
                ID = Convert.ToInt32(reader["CountryID"]);
              }
            }
          }
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex}");
      }
      finally
      {

      }

      return IsFound;
    }

    public static DataTable GetAllCountries()
    {
      DataTable Dt = new DataTable();
      string Query = "Select * from Countries;";
      try
      {
        using(SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          connection.Open();
          using(SqlCommand command = new SqlCommand(Query, connection))
          {
            using(SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.HasRows)
              {
                Dt.Load(reader);
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

      return Dt;
    }
  }
}
