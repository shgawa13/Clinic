using GridScheduleSample;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.IO;
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
using System.Threading;
using System.Security.Cryptography;
using Dental_App.Properties;

namespace Dental_App.Appointmnets
{
  public partial class frmSchedule : Form
  {
    private DateTime SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }

    public CustomScheduleDataProvider dataProvider = new CustomScheduleDataProvider();
    public SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();
    public ScheduleControl ScheduleControl { set; get; }

    public frmSchedule()
    {
      InitializeComponent();
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.ShowingAppointmentForm += ScheduleControl1_ShowingAppointmentForm; ;
      this.scheduleControl1.ScheduleAppointmentClick += ScheduleAppointmentClick;
      this.scheduleControl1.SetupContextMenu += ScheduleControl1_SetupContextMenu; 

    }

    private void ScheduleControl1_SetupContextMenu(object sender, CancelEventArgs e)
    {
      // Create a new ContextMenuStrip
      ContextMenuStrip menu = new ContextMenuStrip();

      // Add a custom menu item
      menu.Items.Add("Add Appointmnet",Resources.AddAppointment_32,HandleAddNew);
      menu.Items.Add("Edit",Resources.edit_32,HandleEdit);
      menu.Items.Add("Delete",Resources.cross_32);
     


      // Assign the custom menu to the ScheduleControl
      scheduleControl1.ContextMenuStrip = menu;

      // Cancel the default context menu
      e.Cancel = true;
    }

    private void HandleAddNew(object sender, EventArgs e)
    {
      MessageBox.Show("Add new appointmnet here");
    }


    private void HandleEdit(object sender, EventArgs e)
    {
      MessageBox.Show("Edit appointmnet here");

    }

    private void HandleDelete(object sender, EventArgs e)
    {
      MessageBox.Show("Delete appointmnet here");

    }

    private void ScheduleAppointmentClick(object sender, ScheduleAppointmentClickEventArgs e)
    {
      SelectedAppointmentDate = e.ClickDateTime.Date;
      _AppointmnetTime = e.ClickDateTime.ToShortTimeString();

    }

    void scheduleControl1_SetupContextMenu(object sender, CancelEventArgs e)
    {
      // Create a new ContextMenuStrip
      ContextMenuStrip menu = new ContextMenuStrip();

      // Add a custom menu item
      menu.Items.Add("Hello");

      // Assign the custom menu to the ScheduleControl
      scheduleControl1.ContextMenuStrip = menu;

      // Cancel the default context menu
      e.Cancel = true;
    }


    private void ScheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
    {
      e.Cancel = true;

      //frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(this.scheduleControl1, SelectedAppointmentDate, _AppointmnetTime);
      //frm.ShowDialog();
      frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(this.scheduleControl1, SelectedAppointmentDate, _AppointmnetTime);
      frm.ShowDialog();
    }

    public ScheduleControl GetScheduleControl()
    {
      return scheduleControl1;
    }

    private void frmAppointments_Load(object sender, EventArgs e)
    {
      //FillList();
      Thread t1 = new Thread(() => FillList());
      t1.Start();
      t1.Join();


    }



    private void FillList()
    {
      DataTable dt = clsAppointments.GetAllAppointments();


      foreach (DataRow row in dt.Rows)
      {
        clsAppointments item = new clsAppointments();
        item.UniqueID = (int)row["AppointmentID"];
        item.PatientID = (int)row["PatientID"];
        item.DoctorID = (int)row["DoctorID"];
        item.Subject = (string)row["PatientName"];
        item.Content = (string)row["DoctorName"];
        item.AppointmentStatus = (clsAppointments.enAppointmentSataus)row["AppointmentStatus"];
        item.LastStatusDate = (DateTime)row["LastStatusDate"];
        item.StartTime = (DateTime)row["StartTime"];
        item.EndTime = (DateTime)row["EndTime"];
        item.LocationValue = (string)row["Location"];
        item.LabelValue = (short)row["LabelValue"];
        item.MarkerValue = (short)row["MarkerValue"];
        item.Reminder = false;
        item.AllDay = false;
        item.Dirty = false;
        item.Owner = 1; // (int)row["Own"];
        item.MarkerValue = 1;//(int)row["MarkerValue"];
        item.Notes = (string)row["Notes"];
        
        list.Add(item);
        
        
      }

      dataProvider.MasterList = list;
      scheduleControl1.DataSource = dataProvider;
      // Refreshing
      // scheduleControl1.Refresh();
    }




  }
}
