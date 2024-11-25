using System;
using Syncfusion.Schedule;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_App.Global_Classes
{
  internal class clsCustomArrayListDataProvider: ArrayListDataProvider
  {
    public override IScheduleAppointment NewScheduleAppointment()
    {
      return new clsDentalScheduleAppointmnet();
    }
  }
}
