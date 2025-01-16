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

    private string fileName;

    public string FileName
    {
      get { return fileName; }
      set { fileName = value; }
    }

    private SimpleScheduleAppointmentList masterList;

    /// <summary>
    /// Get or sets an IScheduleAppointmentList collection that holds the IScheduleAppointments. 
    /// </summary>
    public SimpleScheduleAppointmentList MasterList
    {
      get { return masterList; }
      set { masterList = value; }
    }


    public override IScheduleAppointment NewScheduleAppointment()
    {
      return new clsAppointments();
    }

    public override void AddItem(IScheduleAppointment item)
    {
      this.MasterList.Add(item);
    }

    public override void RemoveItem(IScheduleAppointment item)
    {
      this.MarkerList.Remove(item);
    }

    public override void SaveModifiedItem(IScheduleAppointment appModifiedItem, IScheduleAppointment appOriginalItem)
    {
      base.SaveModifiedItem(appModifiedItem, appOriginalItem);
    }

    public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate)
    {
      ScheduleAppointmentList list = new ScheduleAppointmentList();
      DateTime start = startDate.Date;
      DateTime end = endDate.Date;
      foreach (clsAppointments item in this.MasterList)
      {
        //item.EndTime.AddMinutes(-1) is to make sure an item that ends at 
        //midnight is not shown on the next days calendar

        if ((item.StartTime.Date >= start && item.StartTime.Date <= end)
          || (item.EndTime.AddMinutes(-1).Date > start && item.EndTime.Date <= end))
        {
          list.Add(item);
        }
      }
      list.SortStartTime();
      //DisplayList(string.Format("************dates between {0} and {1}", startDate, endDate), list);
      return list;
    }

    public override IScheduleAppointmentList GetScheduleForDay(DateTime day)
    {
      ScheduleAppointmentList list = new ScheduleAppointmentList();
      day = day.Date;
      foreach (clsAppointments item in this.MasterList)
      {
        //do not want anything that ends at 12AM on the day
        if (item.StartTime.Date == day || (item.EndTime.Date == day && item.EndTime > day))
        {
          list.Add(item);
        }
      }

      //DisplayList(string.Format("*************day {0}", day), list);
      return list;
    }
  }

}
