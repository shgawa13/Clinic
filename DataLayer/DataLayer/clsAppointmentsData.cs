using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class clsAppointmentsData
  {
    // Add new Appointment
    public static int AddNewAppointment(int PatientID,int DoctorID, DateTime AppointmentDateTime,
                  byte AppointmentStatus, int MedicalRecordID, int PaymentID, DateTime LastStatusDate)
    {
      int AppointmentID = -1;
      string query = @"Inert into Appointments(PatientID,DoctorID,AppointmentDateTime,AppointmentStatus,
       MedicalRecordID,PaymentID,LastStatusDate)
       Values(@PatientID,@DoctorID,@AppointmentDateTime,@AppointmentStatus,@MedicalRecordID,@PaymentID,
       @LastStatusDate);
       Select SCOPE_IDENTITY();";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // open connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            // adding Parameters
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              AppointmentID = ID;
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

      return AppointmentID;
    }

    // Update Appointmnet
    public static bool UpdateAppointment(int AppointmentID,int PatientID, int DoctorID, DateTime AppointmentDateTime,
                  byte AppointmentStatus, int MedicalRecordID, int PaymentID,DateTime LastStatusDate)
    {
      int EffectedRow = 0;
      string Query = @"Update Appointments
      set PatientID=@PatientID,
      DoctorID=@DoctorID,
      AppointmentDateTime=@AppointmentDateTime,
      AppointmentStatus=@AppointmentStatus,
      MedicalRecordID=@MedicalRecordID
      PaymentID=@PaymentID,
      LastStatusDate=@LastStatusDate
      where AppointmentID=@AppointmentID";

      try
      { // Create Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        { // Open Connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

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

      }

      return (EffectedRow > 0);
    }

    // Find Appointment By ID
    public static bool GetAppointmentByID(int AppointmentID,ref int PatientID,ref int DoctorID,
      ref DateTime AppointmentDateTime,ref byte AppointmentStatus, ref int MedicalRecordID,
      ref int PaymentID,ref DateTime LastStatusDate)
    {
      bool IsFound = false;

      string query = @"Select * from Appointment where AppointmentID=@AppointmentID;";

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
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                PatientID = (int)reader["PatientID"];
                DoctorID = (int)reader["DoctorID"];
                AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                AppointmentStatus = (byte)reader["AppointmentStatus"];
                MedicalRecordID = (int)reader["MedicalRecordID"];
                PaymentID = (int)reader["PaymentID"];
                LastStatusDate = (DateTime)reader["LastStatusDate"];
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
       // Console.WriteLine($"Person ID is: {PersonID}");
      }

      return IsFound;
    }

    // Get All Appointments
    public static DataTable GetAllAppointments()
    {
      DataTable dtAllAppointments = new DataTable();
      string query = @"select * from Appointments;";

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
                dtAllAppointments.Load(reader);
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

      return dtAllAppointments;
    }

    // Delete Appointment
    public static bool DeleteAppointment(int AppointmentID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Appointments where AppointmentID=@AppointmentID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

    // IsExist Appointment
    public static bool IsAppointmentExist(int AppointmentID)
    {
      bool IsExist = false;
      string query = @"Select Found=1 from Appointments where AppointmentID=@AppointmentID;";

      try
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

    // Update AppointmentStatus
    public static bool UpdateStatus(int AppointmentID, short NewStatus)
    {
      int EffectedRow = 0;
      string Query = @"Update Appointments
      set AppointmentStatus=@NewStatus
      LastStatusDate=@LastStatusDate
      where AppointmentID=@AppointmentID,";

      try
      { // Create Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        { // Open Connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@AppointmentStatus", NewStatus);;
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

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

      }

      return (EffectedRow > 0);
    }
  }
}
