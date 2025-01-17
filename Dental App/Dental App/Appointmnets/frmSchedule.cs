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
using Dental_App.Doctors;

namespace Dental_App.Appointmnets
{
  public partial class frmSchedule : Form
  {
    private DateTime SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }

    CustomScheduleDataProvider dataProvider = new CustomScheduleDataProvider();
    SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();
    public frmSchedule()
    {
      InitializeComponent();
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.ShowingAppointmentForm += ScheduleControl1_ShowingAppointmentForm; ;
      this.scheduleControl1.ScheduleAppointmentClick += ScheduleAppointmentClick;
      
      FillList(); 
    }

 

    private void ScheduleAppointmentClick(object sender, ScheduleAppointmentClickEventArgs e)
    {
      SelectedAppointmentDate = e.ClickDateTime.Date;
      _AppointmnetTime = e.ClickDateTime.ToShortTimeString();
      

    }

    private void ScheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
    {
      e.Cancel = true;
      
      
      //frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(this.scheduleControl1, SelectedAppointmentDate, _AppointmnetTime);
      //frm.ShowDialog();
      frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(this.scheduleControl1, SelectedAppointmentDate, _AppointmnetTime);
      frm.ShowDialog();
    }

    private void frmAppointments_Load(object sender, EventArgs e)
    {
      
      
    }



    private void FillList()
    {
      DataTable dt = clsAppointments.GetAllAppointments();


      foreach (DataRow row in dt.Rows)
      {
        clsAppointments item = new clsAppointments();
        item.UniqueID = (int)row["UniqueID"];
        item.StartTime = (DateTime)row["StartTime"];
        item.EndTime = (DateTime)row["EndTime"];
        item.Subject = (string)row["_Subject"];
        item.Content = (string)row["Content"];
        item.LabelValue = 1;
        item.LocationValue = (string)row["LocationValue"];
        item.ReminderValue = (int)row["ReminderValue"];
        item.Reminder = false;
        item.AllDay = false;
        item.Dirty = false;
        item.Owner = 1; // (int)row["Own"];
        item.MarkerValue = 1;//(int)row["MarkerValue"];
        
        list.Add(item);
        

      }

      dataProvider.MasterList = list;
      scheduleControl1.DataSource = dataProvider;
      // Refreshing
      // scheduleControl1.Refresh();
    }




  }
}
