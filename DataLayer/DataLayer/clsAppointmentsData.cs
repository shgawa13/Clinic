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
    /// <summary>
    /// Add new Appointment:
    ///   will Add New Appointment and return AppointmentID.
    /// </summary>
    /// <param name="PatientID"></param>
    /// <param name="DoctorID"></param>
    /// <param name="AppointmentStatus"></param>
    /// <param name="MedicalRecordID"></param>
    /// <param name="PaymentID"></param>
    /// <param name="LastStatusDate"></param>
    /// <param name="StartTime"></param>
    /// <param name="EndTime"></param>
    /// <param name="Location"></param>
    /// <param name="LabelValue"></param>
    /// <param name="MarkerValue"></param>
    /// <param name="Notes"></param>
    /// <returns></returns>
    public static int AddNewAppointment( int PatientID, int DoctorID, byte AppointmentStatus,
       DateTime LastStatusDate, DateTime StartTime, DateTime EndTime,
       string Location, byte LabelValue, byte MarkerValue, string Notes, int PaymentID, int MedicalRecordID)
    {
      int AppointmentID = -1;
      string query = @"Insert into Appointments(PatientID,DoctorID,AppointmentStatus,
       LastStatusDate,StartTime,EndTime,Location,LabelValue,MarkerValue,Notes,PaymentID,MedicalRecordID)
       Values(@PatientID,@DoctorID,@AppointmentStatus,@LastStatusDate,@StartTime,@EndTime,@Location,@LabelValue,
       @MarkerValue,@Notes,@PaymentID,@MedicalRecordID);
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
            command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@StartTime", StartTime);
            command.Parameters.AddWithValue("@EndTime", EndTime);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@LabelValue", LabelValue);
            command.Parameters.AddWithValue("@MarkerValue", MarkerValue);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

    /// <summary>
    /// Update Appointmnet:
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <param name="PatientID"></param>
    /// <param name="DoctorID"></param>
    /// <param name="AppointmentStatus"></param>
    /// <param name="MedicalRecordID"></param>
    /// <param name="PaymentID"></param>
    /// <param name="LastStatusDate"></param>
    /// <param name="StartTime"></param>
    /// <param name="EndTime"></param>
    /// <param name="Location"></param>
    /// <param name="LabelValue"></param>
    /// <param name="MarkerValue"></param>
    /// <param name="Notes"></param>
    /// <returns></returns>
    public static bool UpdateAppointment(int AppointmentID, int PatientID, int DoctorID, byte AppointmentStatus,
        DateTime LastStatusDate, DateTime StartTime, DateTime EndTime,string Location, byte LabelValue, byte MarkerValue,
        string Notes, int PaymentID, int MedicalRecordID)
    {
      int EffectedRow = 0;
      string Query = @"Update Appointments
      set PatientID=@PatientID,
      DoctorID=@DoctorID,
      AppointmentStatus=@AppointmentStatus,
      LastStatusDate=@LastStatusDate
      StartTime=@StartTime,
      EndTime=@EndTime,
      Location=@Location,
      LabelValue=@LabelValue,
      MarkerValue=@MarkerValue,
      Notes=@Notes,
      PaymentID=@PaymentID,
      MedicalRecordID=@MedicalRecordID
      where AppointmentID=@AppointmentID";

      try
      { // Create Connection
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        { // Open Connection
          connection.Open();
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // adding Parameters
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@StartTime", StartTime);
            command.Parameters.AddWithValue("@EndTime", EndTime);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@LabelValue", LabelValue);
            command.Parameters.AddWithValue("@MarkerValue", MarkerValue);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

    /// <summary>
    /// Find Appointment By ID:
    ///   Find Appointment by AppointmentID.
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <returns></returns>
    public static bool GetAppointmentByID(int AppointmentID,ref int PatientID,ref int DoctorID,ref byte AppointmentStatus,
      ref int MedicalRecordID, ref int PaymentID,ref DateTime LastStatusDate, ref DateTime StartTime, ref DateTime EndTime,
       ref string Location, ref byte LabelValue, ref byte MarkerValue, ref string Notes)
    {
      bool IsFound = false;

      string query = @"Select * from Appointments where AppointmentID=@AppointmentID;";

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
                AppointmentStatus = (byte)reader["AppointmentStatus"];
                LastStatusDate = (DateTime)reader["LastStatusDate"];
                StartTime = (DateTime)reader["AppointmentStartTime"];
                EndTime = (DateTime)reader["AppointmentEndTime"];
                Location = (string)reader["Location"];
                LabelValue = (byte)reader["LabelValue"];
                MarkerValue = (byte)reader["MarkerValue"];
                Notes = (string)reader["Notes"];
                PaymentID = (int)reader["PaymentID"];
                MedicalRecordID = (int)reader["MedicalRecordID"];
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

    /// <summary>
    /// Get All Appointments:
    ///   Get all Appointments as DataTable.
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Delete Appointment:
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <returns></returns>
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


    /// <summary>
    /// IsExist:
    ///  Check if Appointment already Exist or not;
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Update AppointmentStatus:
    ///  Update Status of Appointment
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <param name="NewStatus"></param>
    /// <returns></returns>
    public static bool UpdateStatus(int AppointmentID, byte NewStatus)
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
