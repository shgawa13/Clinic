using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsPaymentsData
  {
    // Add new Payment
    public static int AddNewPayment(DateTime PaymentDate, byte PaymentMethod, decimal AmountPaid,string Notes,decimal Total)
    {
      int PaymentID = -1;

      string query = @"Insert Into Payments(PaymentDate,PaymentMethod,AmountPaid,AdditionalNotes,Total)
      Values(@PaymentDate,@PaymentMethod,@AmountPaid,@AdditionalNotes,Total);
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
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            command.Parameters.AddWithValue("@AdditionalNotes", Notes);
            command.Parameters.AddWithValue("@Total", Total); 
            // resiving object from DB
            object result = command.ExecuteScalar();
            // Convert object to Int 
            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PaymentID = ID;
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


      return PaymentID;
    }

    // Update Payment
    public static bool UpdatePayments(int PaymentID, DateTime PaymentDate, byte PaymentMethod, decimal AmountPaid,
      string Notes,decimal Total)
    {
      int EffectedRow = 0;

      string query = @"update Payments
          set PaymentDate=@PaymentDate,
          PaymentMethod=@PaymentMethod,
          AmountPaid=@AmountPaid,
          AdditionalNotes=@Notes,
          Total=@Total
          where PaymentID=@PaymentID";
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
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@AdditionalNotes", Notes);
            command.Parameters.AddWithValue("@Total", Total);
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

    // Find Payment By ID
    public static bool GetPaymentByID(int PaymentID, ref DateTime PaymentDate, ref byte PaymentMethod,
      ref decimal AmountPaid,ref string Notes, ref decimal Total)
    {
      bool IsFound = false;

      string query = @"Select * from Payments where PaymentID=@PaymentID;";

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
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                PaymentDate = (DateTime)reader["PaymentDate"];
                PaymentMethod = (byte)reader["PaymentMethod"];
                AmountPaid = (decimal)reader["AmountPaid"];
                Notes = (string)reader["AdditionalNotes"];
                Total = (decimal)reader["Total"];
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
    public static DataTable GetAllPayments()
    {
      DataTable dtAllPayments = new DataTable();
      string query = @"select * from Payments;";

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
                dtAllPayments.Load(reader);
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

      return dtAllPayments;
    }

    // Delete Payment
    public static bool Delete(int PaymentID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Payments where PaymentID=@PaymentID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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


    // IsExist PaymentID
    public static bool IsPaymentIDExist(int PaymentID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from Payments where PaymentID=@PaymentID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
