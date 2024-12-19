using GridScheduleSample;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Syncfusion.Schedule;
using System.Windows.Documents;
using Dental_App.Global_Classes;
using Syncfusion.DataSource.Extensions;
using Syncfusion.Windows.Forms.Grid;

namespace Dental_App.Doctors
{
  public partial class frmTestSchedule : Form
  {
    private DateTime SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }

    CustomScheduleDataProvider dataProvider = new CustomScheduleDataProvider();
    SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();

    public frmTestSchedule()
    {
      InitializeComponent();
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.ShowingAppointmentForm += ScheduleControl1_ShowingAppointmentForm;
      this.scheduleControl1.ScheduleAppointmentClick += ScheduleAppointmentClick; 
     
     // this.scheduleControl1.Schedule += Schedule_ScheduleDoubleTapped;

    }

    private void ScheduleAppointmentClick(object sender, ScheduleAppointmentClickEventArgs e)
    {
      //throw new NotImplementedException();
      SelectedAppointmentDate = e.ClickDateTime.Date;
      _AppointmnetTime = e.ClickDateTime.ToShortTimeString();
      //MessageBox.Show($"{Time}");
    }

    private void ScheduleControl1_ShowingAppointmentForm(object sender, Syncfusion.Windows.Forms.Schedule.ShowingAppointFormEventArgs e)
    {
      e.Cancel = true;

      frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(this.scheduleControl1,SelectedAppointmentDate,_AppointmnetTime);
      frm.ShowDialog();

    }

    private void frmTestSchedule_Load(object sender, EventArgs e)
    {
      FillList();
      // here we call the function
      
      
    }

    private void FillList()
    {
      DataTable dt = clsAppointments.GetAllAppointments();
    

      foreach (DataRow row in dt.Rows)
      {
        clsAppt item = new clsAppt();
        item.UniqueID = (int)row["UniqueID"];
        item.StartTime = (DateTime)row["StartTime"];
        item.EndTime = (DateTime)row["EndTime"];
        item.Subject = (string)row["_Subject"];
        item.Content = (string)row["Content"];
        item.LabelValue = 0;
        item.LocationValue = (string)row["LocationValue"];
        item.ReminderValue = (int)row["ReminderValue"];
        item.Reminder = false;
        item.AllDay = false;
        item.Dirty = false;
        item.Owner = 1; // (int)row["Own"];
        item.MarkerValue = (int)row["MarkerValue"];
        list.Add(item);

      }

      dataProvider.MasterList = list;
      scheduleControl1.DataSource = dataProvider;
      // Refreshing
     // scheduleControl1.Refresh();
    }
  }
}
