using System;
using System.Collections.Generic;
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
      {
        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Specialization", Specialization);

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

      using(SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
      {
        connection.Open();
        using(SqlCommand command = new SqlCommand(Query, connection))
        {
          command.Parameters.AddWithValue("@PersonID",);
        }
      }

      return (EffectedRow > 0);
    }
  }
}
