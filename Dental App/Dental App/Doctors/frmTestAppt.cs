using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Dental_App.Global_Classes;
using GridScheduleSample;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;

namespace Dental_App.Doctors
{
  public partial class frmTestAppt : Form
  {
    private ScheduleControl _scheduleControl1;
    private CustomScheduleDataProvider dataProvider;

    public frmTestAppt()
    {
      InitializeComponent();
      _scheduleControl1 = this.scheduleControl1;
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      SimpleScheduleDataProvider data1 = new SimpleScheduleDataProvider();
      data1.MasterList = SimpleScheduleDataProvider.InitializeRandomData("2DataSource");
      this.scheduleControl1.DataSource = data1;

      this.scheduleControl1.GetScheduleHost().Schedule.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
      this.scheduleControl1.GetScheduleHost().Schedule.ShowingAppointmentForm += Schedule_ShowingAppointmentForm;

    }

    private void Schedule_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
    {
      //Cancel the default appointment form for schedule control.
      e.Cancel = true;
      //Shows the Custom appointment form.
      MessageBox.Show("the form has been canceld");
      frmAppt frm = new frmAppt();
      frm.ShowDialog();
      //  TextBox textBox1 = new TextBox
      //  {
      //    Location = new Point(28, 35),
      //    Name = "textBox1",
      //    Size = new Size(100, 23), // Adjust size for better visibility
      //    TabIndex = 9,
      //    Text = "Additional Info"
      //  };

      //  ComboBox comboBox1 = new ComboBox
      //  {
      //    Location = new Point(150, 35), // Adjust as needed
      //    Size = new Size(100, 23),
      //    Name = "comboBox1",

      //  };
      //  comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      //  //comboBox1.Items.Add("Option 1");
      //  //comboBox1.Items.Add("Option 2");
      //  //comboBox1.Items.Add("Option 3");
      //  _FillComboBox(comboBox1);


      //  // Add the TextBox to the form's controls
      //  e.MetroAppointmentForm.Controls[1].Controls.Add(textBox1);
      //  e.MetroAppointmentForm.Controls[1].Controls.Add(comboBox1);
      //}


      //private void _FillComboBox(ComboBox comboBox)
      //{
      //  DataTable Doctors = clsDoctors.GetAllDoctors();

      //  foreach(DataRow doctor in Doctors.Rows)
      //  {
      //    comboBox.Items.Add(doctor["FullName"]);
      //  }
      //}
    }
  }


  #region SimpleScheduleDataProvider
  public class SimpleScheduleDataProvider : ScheduleDataProvider
  {
    /// <summary>
    /// Default constructor.
    /// </summary>
    public SimpleScheduleDataProvider()
        : base()
    {
    }

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

    #region random data

    /// <summary>
    /// A static method that provides random data, not really a part of the implementations.
    /// </summary>
    /// <returns>A SimpleScheduleAppointmentList object holding sample data.</returns>
    public static SimpleScheduleAppointmentList InitializeRandomData(string DataSource)
    {
      //int tc = Environment.TickCount;
      //int tc = 26260100;// simple spread 
      int tc = 28882701; // split the appointment across midnight & 3 items at 8am on 2 days ago

      //Console.WriteLine("Random seed: {0}", tc);
      Random r = new Random(tc);
      Random r1 = new Random(tc);

      // set the number of sample items you want in this list.
      //int count = r.Next(20) + 4;
      int count = 400;//1000;//200;//30;

      SimpleScheduleAppointmentList masterList = new SimpleScheduleAppointmentList();
      clsAppt item = masterList.NewScheduleAppointment() as clsAppt;
      item.DoctorID = 3;
      DateTime now = DateTime.Now.Date;
      item.StartTime = DateTime.Now.AddMinutes(-150);
      item.EndTime = DateTime.Now.AddMinutes(-120);
      item.BackColor = Color.Blue;
      item.Subject = "Name Surname Test";
      item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      masterList.Add(item);
      item = new clsAppt();
      item.StartTime = DateTime.Now.AddMinutes(-150);
      item.EndTime = DateTime.Now.AddMinutes(-120);
      item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      item.Subject = "Name";
      masterList.Add(item);
      item = new clsAppt();
      item.StartTime = DateTime.Now.AddMinutes(-150);
      item.EndTime = DateTime.Now.AddMinutes(-120);
      item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      item.Subject = "Name";
      masterList.Add(item);
      //item = new ScheduleAppointment();
      //item.StartTime = DateTime.Now.AddMinutes(-120);
      //item.EndTime = DateTime.Now.AddMinutes(-90);
      //item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      //item.Subject = "Name Surname Test";
      //masterList.Add(item);

      //item = new ScheduleAppointment();
      //item.StartTime = DateTime.Now.AddMinutes(-120);
      //item.EndTime = DateTime.Now.AddMinutes(-90);
      //item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      //item.Subject = "Name Surname Test";
      //masterList.Add(item);

      //item = new ScheduleAppointment();
      //item.StartTime = DateTime.Now.AddMinutes(-120);
      //item.EndTime = DateTime.Now.AddMinutes(-90);
      //item.Subject = "Name Surname Test";
      //masterList.Add(item);
      //item = new ScheduleAppointment();
      //item.StartTime = DateTime.Now.AddMinutes(-120);
      //item.EndTime = DateTime.Now.AddMinutes(-90);
      //item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      //item.Subject = "Name Surname Test";
      //masterList.Add(item);
      //item = new ScheduleAppointment();
      //item.StartTime = DateTime.Now.AddMinutes(-120);
      //item.EndTime = DateTime.Now.AddMinutes(-90);
      //item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      //item.Subject = "Name Surname Test";

      //item = new ScheduleAppointment();
      //item.StartTime = DateTime.Now.AddMinutes(-120); ;
      //item.EndTime = DateTime.Now.AddMinutes(-60);
      //item.LabelValue = 6;
      //item.Subject = "Name Surname Test";
      //masterList.Add(item);
      //for (int i = 0; i < count; ++i)
      //{
      //    ScheduleAppointment item = masterList.NewScheduleAppointment() as ScheduleAppointment;

      //    int dayOffSet = 30 - r.Next(60);

      //    int hourOffSet = 24 - r.Next(48);

      //    int len = 30 * (r.Next(4) + 1);
      //    item.StartTime = now.AddDays((double)dayOffSet).AddHours((double)hourOffSet); ;
      //    item.EndTime = item.StartTime.AddMinutes((double)len);
      //    item.Subject = string.Format(DataSource + "subject{0}", i);
      //    item.Content = string.Format(DataSource + "content{0}", i);
      //    item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
      //    item.LocationValue = string.Format("location{0}", r1.Next(5));

      //    item.ReminderValue = r1.Next(10) < 5 ? 0 : r1.Next(12);
      //    item.Reminder = r1.Next(10) > 1;
      //    item.AllDay = r1.Next(10) < 1;


      //    item.MarkerValue = r1.Next(4);
      //    item.Dirty = false;

      //    masterList.Add(item);

      //}

      ////set explicit values if needed for testing...
      //masterList[142].Reminder = true;
      //masterList[142].ReminderValue = 9;//  hrs; // 7;//3 hrs


      //DisplayList("Before Sort", masterList);
      masterList.SortStartTime();
      //DisplayList("After Sort", masterList);

      return masterList;
    }

    public static SimpleScheduleAppointmentList InitializeRandomDataSource()
    {
      //int tc = Environment.TickCount;
      //int tc = 26260100;// simple spread 
      int tc = 20000000; // split the appointment across midnight & 3 items at 8am on 2 days ago

      //Console.WriteLine("Random seed: {0}", tc);
      Random r = new Random(tc);
      Random r1 = new Random(tc);

      // set the number of sample items you want in this list.
      //int count = r.Next(20) + 4;
      int count = 200;//1000;//200;//30;

      SimpleScheduleAppointmentList masterList = new SimpleScheduleAppointmentList();
      DateTime now = DateTime.Now.Date;

      for (int i = 0; i < count; ++i)
      {
        ScheduleAppointment item = masterList.NewScheduleAppointment() as ScheduleAppointment;

        int dayOffSet = 30 - r.Next(60);

        int hourOffSet = 24 - r.Next(48);

        int len = 30 * (r.Next(4) + 1);
        item.StartTime = now.AddDays((double)dayOffSet).AddHours((double)hourOffSet); ;
        item.EndTime = item.StartTime.AddMinutes((double)len);
        item.Subject = string.Format("subject{0}", i);
        item.Content = string.Format("content{0}", i);
        item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
        item.LocationValue = string.Format("location{0}", r1.Next(5));

        item.ReminderValue = r1.Next(10) < 5 ? 0 : r1.Next(12);
        item.Reminder = r1.Next(10) > 1;
        item.AllDay = r1.Next(10) < 1;


        item.MarkerValue = r1.Next(4);
        item.Dirty = false;
        masterList.Add(item);
      }

      ////set explicit values if needed for testing...
      //masterList[142].Reminder = true;
      //masterList[142].ReminderValue = 9;//  hrs; // 7;//3 hrs


      //DisplayList("Before Sort", masterList);
      masterList.SortStartTime();
      //DisplayList("After Sort", masterList);

      return masterList;
    }
    private static void DisplayList(string title, ScheduleAppointmentList list)
    {
#if console
			Console.WriteLine("*************" + title);
			foreach(ScheduleAppointment item in list)
			{
				Console.WriteLine(item);
			}
#endif
    }
    #endregion

    #region base class overrides

    /// <summary>
    /// Returns a the subset of MasterList between the 2 dates.
    /// </summary>
    /// <param name="startDate">Starting date limit for the returned items.</param>
    /// <param name="endDate">Ending date limit for the returned items.</param>
    /// <returns>Returns a the subset of MasterList.</returns>
    public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate)
    {
      ScheduleAppointmentList list = new ScheduleAppointmentList();
      DateTime start = startDate.Date;
      DateTime end = endDate.Date;
      foreach (clsAppt item in this.MasterList)
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

    /// <summary>
    /// Returns a the subset of MasterList between the 2 dates.
    /// </summary>
    /// <param name="day">Date for the returned items.</param>
    /// <returns>Returns a the subset of MasterList.</returns>
    public override IScheduleAppointmentList GetScheduleForDay(DateTime day)
    {
      ScheduleAppointmentList list = new ScheduleAppointmentList();
      day = day.Date;
      foreach (ScheduleAppointment item in this.MasterList)
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


    /// <summary>
    /// Gets or sets whether the MasterList has been modified.
    /// </summary>
    public override bool IsDirty
    {
      get
      {
        bool val = base.IsDirty;
        if (!val) //if no global setting marked list as dirty, check individual items
        {
          foreach (IScheduleAppointment item in this.MasterList)
          {
            if (item.Dirty)
            {
              val = true;
              break;
            }
          }
        }
        return val;
      }
      set
      {
        base.IsDirty = value;
      }
    }
    /// <summary>
    /// Overridden to return a <see cref="SimpleScheduleAppointment"/>.
    /// </summary>
    /// <returns></returns>
    public override IScheduleAppointment NewScheduleAppointment()
    {
      return new clsAppt();
    }

    /// <summary>
    /// Overridden to add the item to the MasterList.
    /// </summary>
    /// <param name="item">IScheduleAppointment item to be added.</param>
    public override void AddItem(IScheduleAppointment item)
    {
      this.MasterList.Add(item);
    }

    /// <summary>
    /// Overridden to remove the item from the MasterList.
    /// </summary>
    /// <param name="item">IScheduleAppointment item to be removed.</param>
    public override void RemoveItem(IScheduleAppointment item)
    {
      this.MasterList.Remove(item);
    }
    #endregion
  }
  #endregion

  #region ScheduleAppointmentList

  /// <summary>
  /// Derives <see cref="ScheduleAppointmentList"/> to implement IScheduleAppointmentList.
  /// </summary>
  [Serializable]
  public class SimpleScheduleAppointmentList : ScheduleAppointmentList, ISerializable
  {
    #region ISerializable Members

    #region ISerializable Members

    /// <summary>
    /// Used in serialization.
    /// </summary>
    /// <param name="info"> The SerializationInfo.</param>
    /// <param name="context">The StreamingContext.</param>
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      GetObjectData(info, context);
    }

    #endregion


    /// <summary>
    /// Override to control serialization.
    /// </summary>
    /// <param name="info"> The SerializationInfo.</param>
    /// <param name="context">The StreamingContext.</param>
    protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue("List", this.List);
    }


    #endregion

    /// <summary>
    /// Used in serialization.
    /// </summary>
    /// <param name="info"> The SerializationInfo.</param>
    /// <param name="context">The StreamingContext.</param>
    protected SimpleScheduleAppointmentList(SerializationInfo info, StreamingContext context)
    {
      this.List = (ArrayList)info.GetValue("List", typeof(ArrayList));
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    public SimpleScheduleAppointmentList() : base()
    {

    }

    /// <summary>
    /// Overridden to return a <see cref="SimpleScheduleAppointment"/>.
    /// </summary>
    /// <returns>A SimpleScheduleAppointment.</returns>
    public override IScheduleAppointment NewScheduleAppointment()
    {
      return new clsAppt();
    }


  }
  #endregion

  #region ScheduleAppointment

  /// <summary>
  /// Derives <see cref="ScheduleAppointment"/> to implement IScheduleAppointment.
  /// </summary>
  [Serializable]
  public class SimpleScheduleAppointment : ScheduleAppointment, ISerializable
  {
    #region ISerializable Members

    /// <summary>
    /// Default constructor.
    /// </summary>
    public SimpleScheduleAppointment() : base()
    {
    }

    /// <summary>
    /// Overridden to handle serilaization.
    /// </summary>
    /// <param name="info">The SerialazationInfo.</param>
    /// <param name="context">The StreamingContext.</param>
    protected SimpleScheduleAppointment(SerializationInfo info, StreamingContext context)
    {
      this.UniqueID = (int)info.GetValue("UniqueID", typeof(int));
      this.Subject = (string)info.GetValue("Subject", typeof(string));
      this.StartTime = (DateTime)info.GetValue("StartTime", typeof(DateTime));
      this.ReminderValue = (int)info.GetValue("ReminderValue", typeof(int));
      this.Reminder = (bool)info.GetValue("Reminder", typeof(bool));
      this.Owner = (int)info.GetValue("Owner", typeof(int));
      this.MarkerValue = (int)info.GetValue("MarkerValue", typeof(int));
      this.LocationValue = (string)info.GetValue("LocationValue", typeof(string));
      this.LabelValue = (int)info.GetValue("LabelValue", typeof(int));
      this.EndTime = (DateTime)info.GetValue("EndTime", typeof(DateTime));
      this.Content = (string)info.GetValue("Content", typeof(string));
      this.AllDay = (bool)info.GetValue("AllDay", typeof(bool));

      this.Dirty = false;
    }

    /// <summary>
    /// Handle serilaization.
    /// </summary>
    /// <param name="info">The SerialazationInfo.</param>
    /// <param name="context">The StreamingContext.</param>
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue("UniqueID", this.UniqueID);
      info.AddValue("Subject", this.Subject);
      info.AddValue("StartTime", this.StartTime);
      info.AddValue("ReminderValue", this.ReminderValue);
      info.AddValue("Reminder", this.Reminder);
      info.AddValue("Owner", this.Owner);
      info.AddValue("MarkerValue", this.MarkerValue);
      info.AddValue("LocationValue", this.LocationValue);
      info.AddValue("LabelValue", this.LabelValue);
      info.AddValue("EndTime", this.EndTime);
      info.AddValue("Content", this.Content);
      info.AddValue("AllDay", this.AllDay);

      //info.AddValue("Tag", this.Tag); assume Tag not serializable in this implemetation
    }

    #endregion

  }
  #endregion

}
