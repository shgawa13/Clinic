using GridScheduleSample;
using Syncfusion.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace Dental_App.Global_Classes
{
  public class CustomScheduleDataProvider : SimpleScheduleDataProvider
  {
    public override IScheduleAppointment NewScheduleAppointment()
    {
      return new clsAppointments();
    }
  }

}
