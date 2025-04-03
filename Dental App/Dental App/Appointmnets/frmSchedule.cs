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
using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;



namespace Dental_App.Appointmnets
{
  public partial class frmSchedule : Form
  {
    private DateTime SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }
    private int _ApptID { set; get; }

    public CustomScheduleDataProvider dataProvider = new CustomScheduleDataProvider();
    public SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();
    public ScheduleControl ScheduleControl { set; get; }

    public frmSchedule()
    {
      InitializeComponent();
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.ShowingAppointmentForm += ScheduleControl1_ShowingAppointmentForm; ;
      this.scheduleControl1.ScheduleAppointmentClick += ScheduleAppointmentClick;
      //this.scheduleControl1.Re
     // this.scheduleControl1.Item
      // Assign the custom context menu to the ScheduleControl
      this.scheduleControl1.SetupContextMenu += ScheduleControl1_SetupContextMenu;

    }

    //
    // Summary:
    //     Gets a Metro ContextMenu implementing standard set of menu items for metro theme
    //
    //
    // Returns:
    //     A ContextMenu.
    //
    // Remarks:
    //     If you use this default implementation of a ContextMenu, you can dynamically
    //     cancel the execution of a menu selection by subscribing to the ScheduleControl.ScheduleAppointmentClick
    //     event and setting e.Cancel = true when e.ClickType is RightClick.
    public ContextMenuStrip MetroContextMenu()
    {
      ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
      contextMenuStrip.Items.Add(new ToolStripMenuItem("New Appointment", ScheduleGrid.GetBitmap("AddNew.png"), AddNew));
      //contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[10], null, newAllDayItemClick));
      contextMenuStrip.Items.Add(new ToolStripSeparator());
      contextMenuStrip.Items.Add(new ToolStripMenuItem("Edit", ScheduleGrid.GetBitmap("Edit.png"), EditItem));
      contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[12], ScheduleGrid.GetBitmap("Delete.png"), DeleteItem));
      contextMenuStrip.Items.Add(new ToolStripSeparator());
      contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[13], ScheduleGrid.GetBitmap("Day.png"), SwitchToDayView));
      contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[15], ScheduleGrid.GetBitmap("Week.png"), SwitchToWeekView));
      contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[16], ScheduleGrid.GetBitmap("Month.png"), SwitchToMonthView));
      contextMenuStrip.ShowImageMargin = true;
      contextMenuStrip.DropShadowEnabled = false;
      contextMenuStrip.Renderer = new ContextMenuRenderer();
      contextMenuStrip.BackColor = Color.White;
      return contextMenuStrip;
    }

    // Costumize ContextMenu
    private void ScheduleControl1_SetupContextMenu(object sender, CancelEventArgs e)
    {
      e.Cancel = true;
      this.scheduleControl1.ContextMenuStrip = MetroContextMenu();
    }

    // handle all view type
    private void HandleViewType(ScheduleViewType ViewType)
    {
     
      this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ViewType);
    }

    // View Schedule by day
    private void SwitchToDayView(object sender, EventArgs e) => HandleViewType(ScheduleViewType.Day);
    

    // View Schedule by Week 
    private void SwitchToWeekView(object sender, EventArgs e) => HandleViewType(ScheduleViewType.Week);
   

    // View Schedule by Month 
    private void SwitchToMonthView(object sender, EventArgs e) => HandleViewType(ScheduleViewType.Month);
    

    private void AddNew(object sender, EventArgs e)
    {
      MessageBox.Show("Add new item clicked");
      frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(this.scheduleControl1, SelectedAppointmentDate, _AppointmnetTime);
      frm.ShowDialog();
    }

    private void EditItem(object sender, EventArgs e)
    {
      //frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet(_ApptID, this.scheduleControl1, SelectedAppointmentDate, _AppointmnetTime);
      //frm.ShowDialog();

      MessageBox.Show("Edit item clicked");
    }

    private void DeleteItem(object sender, EventArgs e)
    {
      
      MessageBox.Show("Edit item clicked");
     //this.list.
    }

    private void ScheduleAppointmentClick(object sender, ScheduleAppointmentClickEventArgs e)
    {
      if (e.Item != null)
        MessageBox.Show("there is item");
     
      // e.
      SelectedAppointmentDate = e.ClickDateTime.Date;
      _AppointmnetTime = e.ClickDateTime.ToShortTimeString(); 
     
    }


    private void ScheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
    {
      e.Cancel = true;
    }

    // return schedule
    public ScheduleControl GetScheduleControl() => this.scheduleControl1;
   

    private void frmAppointments_Load(object sender, EventArgs e)
    {
      FillList();
      
      //Thread t1 = new Thread(() => FillList());
      //t1.Start();
      //t1.Join();

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
        item.AppointmentStatus = (clsAppointments.enAppointmentSataus)(byte)row["AppointmentStatus"];
        item.LastStatusDate = (DateTime)row["LastStatusDate"];
        item.StartTime = (DateTime)row["StartTime"];
        item.EndTime = (DateTime)row["EndTime"];
        item.LocationValue = (string)row["Location"];
        item.LabelValue = (byte)row["LabelValue"];
        item.MarkerValue = (byte)row["MarkerValue"];
        item.Reminder = false;
        item.AllDay = false;
        item.Dirty = false;
        item.Owner = 1; // (int)row["Own"];
       // item.Notes = (string)row["Notes"];
        
        list.Add(item);
        
        
      }

      dataProvider.MasterList = list;
      scheduleControl1.DataSource = dataProvider;
      // Refreshing
      // scheduleControl1.Refresh();
    }


  }
}
