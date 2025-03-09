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

    public CustomScheduleDataProvider dataProvider = new CustomScheduleDataProvider();
    public SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();
    public ScheduleControl ScheduleControl { set; get; }

    public frmSchedule()
    {
      InitializeComponent();
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.ShowingAppointmentForm += ScheduleControl1_ShowingAppointmentForm; ;
      this.scheduleControl1.ScheduleAppointmentClick += ScheduleAppointmentClick;
      

    }



    //public ContextMenuStrip MetroContextMenu()
    //{
    //  ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[9], ScheduleGrid.GetBitmap("AddNew.png"), newItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[10], null, newAllDayItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripSeparator());
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[11], ScheduleGrid.GetBitmap("Edit.png"), editItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[12], ScheduleGrid.GetBitmap("Delete.png"), deleteItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripSeparator());
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[13], ScheduleGrid.GetBitmap("Day.png"), dayItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[14], ScheduleGrid.GetBitmap("Workweek.png"), workWeekItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[15], ScheduleGrid.GetBitmap("Week.png"), weekItemClick));
    //  contextMenuStrip.Items.Add(new ToolStripMenuItem(ScheduleGrid.DisplayStrings[16], ScheduleGrid.GetBitmap("Month.png"), monthItemClick));
    //  contextMenuStrip.ShowImageMargin = true;
    //  contextMenuStrip.DropShadowEnabled = false;
    //  contextMenuStrip.Renderer = new ContextMenuRenderer();
    //  contextMenuStrip.BackColor = Color.White;
    //  return contextMenuStrip;
    //}

 

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
