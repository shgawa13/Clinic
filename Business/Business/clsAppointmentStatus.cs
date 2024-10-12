using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsAppointmentStatus
  {
    public short AppointmentStatusID { get; set; }
    public string StatusName { get; set; }
    public string StatusDiscription { get; set; }

    public clsAppointmentStatus()
    {
      this.AppointmentStatusID = -1;
      this.StatusName = "";
      this.StatusDiscription = "";
    }

    private clsAppointmentStatus(short AppointmentStatusID, string StatusName, string StatusDiscription)
    {
      AppointmentStatusID = AppointmentStatusID;
      StatusName = StatusName;
      StatusDiscription = StatusDiscription;
    }

    // Add new AppointmentStatus
    private bool _AddNewAppointmentStatus()
    {
      this.AppointmentStatusID = clsAppointmentStatusData.AddNewAppointmentStatus(this.StatusName, this.StatusDiscription);
      return (AppointmentStatusID != -1);
    }

    // Update AppointmentStatus
    private bool _UpdateAppointmentStatus() 
    {
      return clsAppointmentStatusData.UpdateAppointmentStatus(this.AppointmentStatusID, StatusName,StatusDiscription);
    } 

    // Delete
    public static bool DeleteAppointmentStatus(short AppointmentStatusID)
    {
      return clsAppointmentStatusData.DeleteAppointmentStatus(AppointmentStatusID);
    }

    // Find 
    public static clsAppointmentStatus Find(short AppointmentStautsID)
    {
      string StatusName = "", StatusDiscription = "";
      bool IsFound = clsAppointmentStatusData.FindAppointmentStatusByID(AppointmentStautsID, ref StatusName,
        ref StatusDiscription);

      if (IsFound)
        return new clsAppointmentStatus(AppointmentStautsID, StatusName, StatusDiscription);
      else
       return null;
    }

    // Get all AppointmentStatus
    public static DataTable GetAllAppointmentStatus() => clsAppointmentStatusData.GetAllAppointmentStatus();

    // Delete AppointmentStatus
    public static bool Delete(short AppointmentStautsID)
    {
      return clsAppointmentStatusData.DeleteAppointmentStatus(AppointmentStautsID);
    }

  }
}
