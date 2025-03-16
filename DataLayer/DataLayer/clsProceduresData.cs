using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
 public class clsProceduresData
  {
    // Add new Procedure
    public static int AddNewProcedure(byte Peroxide25, byte Peroxide40, byte CompositeFilling, byte PorcelainFilling,
      byte AmalgamFilling, byte SingleImplant, byte DoubleImplant, byte FullMouthImplant, byte Cleaning, byte Xray,
      byte Diagnosis, byte SimpleExtraction, byte ComplicatedExtraction, byte ComplexExtraction, byte WisdomExtraction)
    {
      int ProcedureID = -1;

      string query = @"Insert Into Procedures
      (Peroxide25,Peroxide40,CompositeFilling,PorcelainFilling,AmalgamFilling,SingleImplant,DoubleImplant,FullMouthImplant
      Cleaning,Xray,Diagnosis,SimpleExtraction,ComplicatedExtraction,ComplexExtraction,WisdomExtraction)
      Values(@Peroxide25,@Peroxide40,@CompositeFilling,@PorcelainFilling,@AmalgamFilling,@SingleImplant,@DoubleImplant,
      @FullMouthImplant,@Cleaning,@Xray,@Diagnosis,@SimpleExtraction,@ComplicatedExtraction,@ComplexExtraction,@WisdomExtraction);
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
            command.Parameters.AddWithValue("@Peroxide25", Peroxide25);
            command.Parameters.AddWithValue("@Peroxide40", Peroxide40);
            command.Parameters.AddWithValue("@CompositeFilling", CompositeFilling);
            command.Parameters.AddWithValue("@PorcelainFilling", PorcelainFilling);
            command.Parameters.AddWithValue("@AmalgamFilling", AmalgamFilling);
            command.Parameters.AddWithValue("@SingleImplant", SingleImplant);
            command.Parameters.AddWithValue("@DoubleImplant", DoubleImplant);
            command.Parameters.AddWithValue("@FullMouthImplant", FullMouthImplant);
            command.Parameters.AddWithValue("@Cleaning", Cleaning);
            command.Parameters.AddWithValue("@Xray", Xray);
            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            command.Parameters.AddWithValue("@SimpleExtraction", SimpleExtraction);
            command.Parameters.AddWithValue("@ComplicatedExtraction", ComplicatedExtraction);
            command.Parameters.AddWithValue("@ComplexExtraction", ComplexExtraction);
            command.Parameters.AddWithValue("@WisdomExtraction", WisdomExtraction);
;

            // resiving object from DB
            object result = command.ExecuteScalar();
            // Convert object to Int 
            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              ProcedureID = ID;
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
        //Console.WriteLine($"Procedure ID is: {ProcedureID}");
      }


      return ProcedureID;
    }

    // Update Procedure
    public static bool UpdateProcedure(int ProcedureID, byte Peroxide25, byte Peroxide40, byte CompositeFilling, byte PorcelainFilling,
      byte AmalgamFilling, byte SingleImplant, byte DoubleImplant, byte FullMouthImplant, byte Cleaning, byte Xray,
      byte Diagnosis, byte SimpleExtraction, byte ComplicatedExtraction, byte ComplexExtraction, byte WisdomExtraction)
    {
      int EffectedRow = 0;

      string query = @"update Procedures
          set Peroxide25=@Peroxide25,
          Peroxide40=@Peroxide40,
          CompositeFilling=@CompositeFilling,
          PorcelainFilling=@PorcelainFilling,
          AmalgamFilling=@AmalgamFilling,
          SingleImplant=@SingleImplant,
          DoubleImplant=@DoubleImplant,
          FullMouthImplant=@FullMouthImplant,
          Cleaning=@Cleaning,
          Diagnosis=@Diagnosis,
          SimpleExtraction=@SimpleExtraction,
          ComplicatedExtraction=@ComplicatedExtraction,
          ComplexExtraction=@ComplexExtraction,
          WisdomExtraction=@WisdomExtraction
          where ProcedureID=@ProcedureID";
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
            command.Parameters.AddWithValue("@ProcedureID", ProcedureID);
            command.Parameters.AddWithValue("@Peroxide25", Peroxide25);
            command.Parameters.AddWithValue("@Peroxide40", Peroxide40);
            command.Parameters.AddWithValue("@CompositeFilling", CompositeFilling);
            command.Parameters.AddWithValue("@PorcelainFilling", PorcelainFilling);
            command.Parameters.AddWithValue("@AmalgamFilling", AmalgamFilling);
            command.Parameters.AddWithValue("@SingleImplant", SingleImplant);
            command.Parameters.AddWithValue("@DoubleImplant", DoubleImplant);
            command.Parameters.AddWithValue("@FullMouthImplant", FullMouthImplant);
            command.Parameters.AddWithValue("@Cleaning", Cleaning);
            command.Parameters.AddWithValue("@Xray", Xray);
            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            command.Parameters.AddWithValue("@SimpleExtraction", SimpleExtraction);
            command.Parameters.AddWithValue("@ComplicatedExtraction", ComplicatedExtraction);
            command.Parameters.AddWithValue("@ComplexExtraction", ComplexExtraction);
            command.Parameters.AddWithValue("@WisdomExtraction", WisdomExtraction);


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
        //Console.WriteLine($"Procedure ID is: {ProcedureID}");
      }

      return (EffectedRow > 0);
    }

    // Find Procedure By ID
    public static bool GetProcedureByID(int ProcedureID,ref byte Peroxide25, ref byte Peroxide40, ref byte CompositeFilling,
      ref byte PorcelainFilling,ref byte AmalgamFilling, ref byte SingleImplant, ref byte DoubleImplant, ref byte FullMouthImplant,
      ref byte Cleaning, ref byte Xray,ref byte Diagnosis, ref byte SimpleExtraction, ref byte ComplicatedExtraction, 
      ref byte ComplexExtraction, ref byte WisdomExtraction)
    {
      bool IsFound = false;

      string query = @"Select * from Procedures where ProcedureID=@ProcedureID;";

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
            command.Parameters.AddWithValue("@ProcedureID", ProcedureID);
            // Create Reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                Peroxide25 = (byte)reader["Peroxide25"];
                Peroxide40 = (byte)reader["Peroxide40"];
                CompositeFilling = (byte)reader["CompositeFilling"];
                PorcelainFilling = (byte)reader["PorcelainFilling"];
                AmalgamFilling = (byte)reader["AmalgamFilling"];
                SingleImplant = (byte)reader["SingleImplant"];
                DoubleImplant = (byte)reader["DoubleImplant"];
                FullMouthImplant = (byte)reader["FullMouthImplant"];
                Cleaning = (byte)reader["Cleaning"];
                Diagnosis = (byte)reader["Diagnosis"];
                SimpleExtraction = (byte)reader["SimpleExtraction"];
                ComplicatedExtraction = (byte)reader["ComplicatedExtraction"];
                ComplexExtraction = (byte)reader["ComplexExtraction"];
                WisdomExtraction = (byte)reader["WisdomExtraction"];
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
        Console.WriteLine($"Procedure ID is: {ProcedureID}");
      }

      return IsFound;
    }

    /// <summary>
    /// Delete Procedure:
    /// </summary>
    /// <param name="ProcedureID"></param>
    /// <returns> boolen value if deleted return true otherwise false </returns>
    public static bool DeleteProcedure(int ProcedureID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Procedures where ProcedureID=@ProcedureID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(clsAccessSetting.ConnectingString))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@ProcedureID", ProcedureID);

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
        //Console.WriteLine($"Procedure ID is: {ProcedureID}");
      }

      return (IsDeleted > 0);
    }

  }
}
