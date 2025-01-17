using System;
using System.Data;
using Syncfusion.Schedule;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataLayer;

namespace Business
{
  public class clsAppointments: IScheduleAppointment
  {

    private bool allDay;

    private string content = string.Empty;

    private bool dirty;

    private DateTime end = DateTime.Now.AddMinutes(30.0);

    private int id = -1;

    private bool ignoreChanges;

    private int labelValue;

    private string locationValue = string.Empty;

    private ScheduleAppointmentToolTip m_eAppointmentToolTip;

    private bool m_bAllowClickable = true;

    private bool m_bAllowDrag = true;

    private bool m_bAllowResize = true;

    private bool m_bBlocked;

    private Color m_colorBackColor = Color.Empty;

    private Color m_colorTimeSpanColor = Color.Empty;

    private bool m_bNotifyOnOveride;

    private bool m_bRecurringOnOverride;

    private int m_nPriority;

    private string m_sCustomToolTip = string.Empty;

    private string _Notes = string.Empty;

    private int markerValue;

    private int owner;

    private bool reminder;

    private int reminderValue;

    private string reminderText = "None";

    private DateTime start = DateTime.Now;

    private string subject = string.Empty;

    private object tag;

    private int version;

    // AppointmnetID
    private int _AppintmnetID;
    public int AppintmnetID
    {
      get { return _AppintmnetID; }
      set { AppintmnetID = value; }
    }

    // PatientID
    private int _PatientID;
    public int PatientID
    {
      get { return _PatientID; }
      set { _PatientID = value; }
    }

    // DoctorID
    private int _DoctorID;
    public int DoctorID
    {
      get { return _DoctorID; }
      set { _DoctorID = value; }
    }

    // AppointmentStatus
    //private int _AppointmentStatus;
    //public int AppointmentStatus
    //{
    //  get { return _AppointmentStatus; }
    //  set { _AppointmentStatus = value; }
    //}

    // MedicalRecordID
    private int _MedicalRecordID;
    public int MedicalRecordID
    {
      get { return _MedicalRecordID; }
      set { _MedicalRecordID = value; }
    }

    // PaymentID
    private int _PaymentID;
    public int PaymentID
    {
      get { return _PaymentID; }
      set { _PaymentID = value; }
    }

    // LastStatusDate
    private DateTime _LastStatusDate;
    public DateTime LastStatusDate
    {
      get { return _LastStatusDate; }
      set { _LastStatusDate = value; }
    }


    //
    // Summary:
    //     Holds the default fore color of appointment panel.
    private Color m_colorForeColor = Color.Black;

    //
    // Summary:
    //     Gets or sets fore color of the appointment panel.
    //
    // Remarks:
    //     The default value of ForeColor property is Color.Black.
    [Browsable(true)]
    [DefaultValue(typeof(Color), "Black")]
    [Bindable(true)]
    [Description("Specifies the fore color of an appointment panel.")]
    public Color ForeColor
    {
      get
      {
        return m_colorForeColor;
      }
      set
      {
        if (!IgnoreChanges && m_colorForeColor != value)
        {
          Dirty = true;
        }

        if (value != Color.Empty)
        {
          m_colorForeColor = value;
        }
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether this appointment is an all-day appointment.
    [Browsable(true)]
    [Description("Gets or sets whether this appointment is an all-day appointment.")]
    [DefaultValue(false)]
    [Bindable(true)]
    public virtual bool AllDay
    {
      get
      {
        return allDay;
      }
      set
      {
        if (!IgnoreChanges && allDay != value)
        {
          Dirty = true;
        }

        allDay = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not blocked appointment is allowed
    //     to click.
    [Description("Specifies whether or not blocked appointment is allowed to click.")]
    [DefaultValue(true)]
    [Bindable(true)]
    [Browsable(true)]
    public bool AllowClickable
    {
      get
      {
        return m_bAllowClickable;
      }
      set
      {
        if (!IgnoreChanges && value != m_bAllowClickable)
        {
          Dirty = true;
        }

        m_bAllowClickable = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not an appointment is allowed to be
    //     dragged.The total hours doesn't gets changed by dragging an appointment.
    //
    // Value:
    //     Default is true.
    //
    // Remarks:
    //     Setting this property to true enables moving an appointment by clicking on a
    //     appointment and moving it to a new place. The total duration of an Appointment
    //     is not altered by dragging.
    [Description("Specifies whether or not an appointment is allowed to drag.")]
    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue(true)]
    public bool AllowDrag
    {
      get
      {
        return m_bAllowDrag;
      }
      set
      {
        if (!IgnoreChanges && value != m_bAllowDrag)
        {
          Dirty = true;
        }

        m_bAllowDrag = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not an appointment is allowed to resize
    //     and modify its duration.
    [Browsable(true)]
    [Bindable(true)]
    [Description("Specifies whether or not an appointment is allowed to resize.")]
    [DefaultValue(true)]
    public bool AllowResize
    {
      get
      {
        return m_bAllowResize;
      }
      set
      {
        if (!IgnoreChanges && value != m_bAllowResize)
        {
          Dirty = true;
        }

        m_bAllowResize = value;
      }
    }

    //
    // Summary:
    //     Gets or sets back color of the appointment panel
    [Browsable(true)]
    [Bindable(true)]
    [Description("Specifies the back color of the appointment panel.")]
    [DefaultValue(typeof(Color), "")]
    public Color BackColor
    {
      get
      {
        return m_colorBackColor;
      }
      set
      {
        if (!IgnoreChanges && value != m_colorBackColor)
        {
          Dirty = true;
        }

        if (value != Color.Empty)
        {
          m_colorBackColor = value;
        }
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether the block appointment is blocked.
    [Browsable(true)]
    [Bindable(true)]
    [Description("Specifies whether the block appointment is blocked.")]
    [DefaultValue(false)]
    public virtual bool Blocked
    {
      get
      {
        return m_bBlocked;
      }
      set
      {
        if (!IgnoreChanges && value != m_bBlocked)
        {
          Dirty = true;
        }

        m_bBlocked = value;
      }
    }

    //
    // Summary:
    //     Gets or sets the custom tooltip text to be displayed for the item.
    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue("")]
    [Description("Gets or sets the custom tooltip text to be displayed for the appointment.")]
    public string CustomToolTip
    {
      get
      {
        return m_sCustomToolTip;
      }
      set
      {
        if (!IgnoreChanges && value != m_sCustomToolTip)
        {
          Dirty = true;
        }

        m_sCustomToolTip = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a text string holding the details or comments for this appointment
    //     item.
    [DefaultValue("")]
    [Description("Gets or sets a text string holding the details or comments for this appointment item.")]
    [Bindable(true)]
    [Browsable(true)]
    public virtual string Content
    {
      get
      {
        return content;
      }
      set
      {
        if (!IgnoreChanges && content != value)
        {
          Dirty = true;
        }

        content = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether this item has been modified.
    [XmlIgnore]
    [Bindable(false)]
    [Description("Gets or sets an arbitrary object associated with this item.")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DefaultValue(false)]
    public virtual bool Dirty
    {
      get
      {
        return dirty;
      }
      set
      {
        dirty = value;
      }
    }

    //
    // Summary:
    //     Gets or sets the end time for this item.
    [Description("Gets or sets the end time for this item.")]
    [Bindable(true)]
    [Browsable(true)]
    public virtual DateTime EndTime
    {
      get
      {
        return end;
      }
      set
      {
        if (!IgnoreChanges && end != value)
        {
          Dirty = true;
        }

        end = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether changes to this item affect the Dirty
    //     property.
    [Browsable(false)]
    [XmlIgnore]
    [Description("Gets or sets whether changes to this item affect the Dirty property.")]
    [DefaultValue(false)]
    public virtual bool IgnoreChanges
    {
      get
      {
        return ignoreChanges;
      }
      set
      {
        dirty = ignoreChanges;
      }
    }

    //
    // Summary:
    //     Gets or sets a integer categorizer value for this item.
    [Description("Gets or sets a integer categorizer value for this item.")]
    [DefaultValue(0)]
    [Browsable(true)]
    [Bindable(true)]
    public virtual int LabelValue
    {
      get
      {
        return labelValue;
      }
      set
      {
        if (!IgnoreChanges && labelValue != value)
        {
          Dirty = true;
        }

        labelValue = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a string associated with this item.
    [Browsable(true)]
    [Description("Gets or sets a string associated with this item.")]
    [DefaultValue("")]
    [Bindable(true)]
    public virtual string LocationValue
    {
      get
      {
        return locationValue;
      }
      set
      {
        if (!IgnoreChanges && locationValue != value)
        {
          Dirty = true;
        }

        locationValue = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a integer categorizer value for this item.
    [Browsable(true)]
    [Bindable(true)]
    [Description("Gets or sets a integer categorizer value for this item.")]
    [DefaultValue(0)]
    public virtual int MarkerValue
    {
      get
      {
        return markerValue;
      }
      set
      {
        if (!IgnoreChanges && markerValue != value)
        {
          Dirty = true;
        }

        markerValue = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether the block appointment is notify on overide.
    [DefaultValue(true)]
    [Browsable(true)]
    [Bindable(true)]
    [Description("Specifies whether the block appointment is notify on overide.")]
    public bool NotifyOnOveride
    {
      get
      {
        return m_bNotifyOnOveride;
      }
      set
      {
        if (!IgnoreChanges && value != m_bNotifyOnOveride)
        {
          Dirty = true;
        }

        m_bNotifyOnOveride = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether the block appointment is notify on overide.
    [Bindable(true)]
    [Browsable(true)]
    [Description("Specifies whether the block appointment recurring date need override.")]
    [DefaultValue(false)]
    public bool RecurringOnOverride
    {
      get
      {
        return m_bRecurringOnOverride;
      }
      set
      {
        if (!IgnoreChanges && value != m_bRecurringOnOverride)
        {
          Dirty = true;
        }

        m_bRecurringOnOverride = value;
      }
    }

    //
    // Summary:
    //     Gets or sets an integer that can be used to identify the owner (if any) of this
    //     item.
    [DefaultValue(0)]
    [Browsable(true)]
    [Bindable(true)]
    [Description("Gets or sets an integer that can be used to identify the owner (if any)  of this item.")]
    public virtual int Owner
    {
      get
      {
        return owner;
      }
      set
      {
        if (!IgnoreChanges && value != owner)
        {
          Dirty = true;
        }

        owner = value;
      }
    }

    //
    // Summary:
    //     Gets or sets priority of the block appointment.
    [DefaultValue(0)]
    [Description("Gets or sets priority of the block appointment.")]
    [Browsable(true)]
    [Bindable(true)]
    public int Priority
    {
      get
      {
        return m_nPriority;
      }
      set
      {
        if (!IgnoreChanges && value != m_nPriority)
        {
          Dirty = true;
        }

        m_nPriority = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a value indicating whether you want a reminder event raised when
    //     the StartTime of this item gets close.
    [Browsable(true)]
    [Bindable(true)]
    [DefaultValue(false)]
    [Description("Gets or sets whether you want a reminder event raised when the StartTime of this item gets close.")]
    public virtual bool Reminder
    {
      get
      {
        return reminder;
      }
      set
      {
        if (!IgnoreChanges && reminder != value)
        {
          Dirty = true;
        }

        reminder = value;
      }
    }

    //
    // Summary:
    //     Gets or sets the type of reminder event raised when the StartTime of this item
    //     gets close.
    [Browsable(true)]
    [DefaultValue(0)]
    [Bindable(true)]
    [Description("Gets or sets the type of reminder event raised when the StartTime of this item gets close.")]
    public virtual int ReminderValue
    {
      get
      {
        return reminderValue;
      }
      set
      {
        if (!IgnoreChanges && reminderValue != value)
        {
          Dirty = true;
        }

        reminderValue = value;
      }
    }

    //
    // Summary:
    //     Gets or sets the type of reminder event raised when the StartTime of this item
    //     gets close.
    [Browsable(true)]
    [DefaultValue("None")]
    [Description("Gets or sets the type of reminder event raised when the StartTime of this item gets close.")]
    [Bindable(true)]
    public virtual string ReminderText
    {
      get
      {
        return reminderText;
      }
      set
      {
        if (!IgnoreChanges && reminderText != value)
        {
          Dirty = true;
        }

        reminderText = value;
      }
    }

    //
    // Summary:
    //     Gets or sets the start time for this item.
    [Browsable(true)]
    [Bindable(true)]
    [Description("Gets or sets the start time for this item.")]
    public virtual DateTime StartTime
    {
      get
      {
        return start;
      }
      set
      {
        if (!IgnoreChanges && start != value)
        {
          Dirty = true;
        }

        start = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a text string identifying the topic of this item.
    [DefaultValue("")]
    [Description("Gets or sets a text string identifying the topic of this item.")]
    [Browsable(true)]
    [Bindable(true)]
    public virtual string Subject
    {
      get
      {
        return subject;
      }
      set
      {
        if (!IgnoreChanges && subject != value)
        {
          Dirty = true;
        }

        subject = value;
      }
    }


    //
    // Summary:
    //     Gets or sets a text string as Notes of this item.
    [DefaultValue("")]
    [Description("Gets or sets a text string as Notes of this item.")]
    [Browsable(true)]
    [Bindable(true)]

    public string Notes
    {
      get
      {
        return _Notes;
      }
      set
      {
        if(!IgnoreChanges && _Notes != value)
        {
          Dirty = true;
        }
        _Notes = value;
      }
    }
    //
    // Summary:
    //     Gets or sets an arbitrary object associated with this item.
    [XmlIgnore]
    [Description("Gets or sets an arbitrary object associated with this item.")]
    [Browsable(false)]
    [Bindable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual object Tag
    {
      get
      {
        return tag;
      }
      set
      {
        if (!IgnoreChanges && tag != value)
        {
          Dirty = true;
        }

        tag = value;
      }
    }

    //
    // Summary:
    //     Gets or sets color of appointment time span element.
    [Browsable(true)]
    [Bindable(true)]
    [Description("Specifies the color of appointment time span element.")]
    [DefaultValue(typeof(Color), "")]
    public Color TimeSpanColor
    {
      get
      {
        return m_colorTimeSpanColor;
      }
      set
      {
        if (!IgnoreChanges && value != m_colorTimeSpanColor)
        {
          Dirty = true;
        }

        if (value != Color.Empty)
        {
          m_colorTimeSpanColor = value;
        }
      }
    }

    //
    // Summary:
    //     Gets or sets the tooltip text to be displayed for the item.
    [Description("Gets or sets the tooltip text to be displayed for the item.")]
    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue(ScheduleAppointmentToolTip.All)]
    public ScheduleAppointmentToolTip ToolTip
    {
      get
      {
        return m_eAppointmentToolTip;
      }
      set
      {
        if (!IgnoreChanges && value != m_eAppointmentToolTip)
        {
          Dirty = true;
        }

        m_eAppointmentToolTip = value;
      }
    }

    //
    // Summary:
    //     Gets or sets a unique integer associated with this item.
    [Description("Gets or sets a unique integer associated with this item.")]
    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue(0)]
    public virtual int UniqueID
    {
      get
      {
        return id;
      }
      set
      {
        if (!IgnoreChanges && value != id)
        {
          Dirty = true;
        }

        id = value;
      }
    }

    //
    // Summary:
    //     Gets an integer format version number.
    //
    // Remarks:
    //     If you modify this class in a manner that changes its serialization, you should
    //     change the version number so there is a unique number that can be used to identify
    //     the serialization format.
    [Browsable(false)]
    [Bindable(false)]
    [Description("Gets in integer format version number.")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DefaultValue(0)]
    public virtual int Version => version;

    //
    // Summary:
    //     Initializes a new instance of the Syncfusion.Schedule.ScheduleAppointment class.
    //public clsAppt()
    //{
    //  this.DoctorID = -1;

    //}



    //
    // Summary:
    //     Creates a copy of this item; using MemberwiseClone.
    //
    // Returns:
    //     A new instance of this item.
    public object Clone()
    {
      return MemberwiseClone();
    }

    //
    // Summary:
    //     Implemented to check UniqueID property for equality.
    //
    // Parameters:
    //   obj:
    //     The object to compare this instance to.
    //
    // Returns:
    //     Zero if the objects have the same UniqueID. Nonzero otherwise.
    public int CompareTo(object obj)
    {
      if (obj is ScheduleAppointment scheduleAppointment)
      {
        if (!UniqueID.Equals(scheduleAppointment.UniqueID))
        {
          return GetHashCode().CompareTo(scheduleAppointment.GetHashCode());
        }

        return 0;
      }

      return 1;
    }

    //
    // Summary:
    //     Determines whether the item has conflict with other item.
    //
    // Parameters:
    //   appVal:
    //     A IScheduleAppointment
    //
    // Returns:
    //     True, it the item is in conflict; Fasle, otherwise.
    public virtual bool IsConflict(IScheduleAppointment appVal)
    {
      return IsConflict(appVal.StartTime, appVal.EndTime);
    }

    //
    // Summary:
    //     Determines whether the item has conflict with other item.
    //
    // Parameters:
    //   dtStart:
    //     Item start time.
    //
    //   dtEnd:
    //     Item end time.
    //
    // Returns:
    //     True, if the item is in conflict; False, otherwise.
    public virtual bool IsConflict(DateTime dtStart, DateTime dtEnd)
    {
      return MaxDate(dtStart, StartTime) < MinDate(dtEnd, EndTime);
    }

    //
    // Summary:
    //     Gets the maximum date between specified dates.
    //
    // Parameters:
    //   dtDateTime1:
    //     The date value to compare.
    //
    //   dtDateTime2:
    //     The date value to compare.
    //
    // Returns:
    //     The maximum date.
    private static DateTime MaxDate(DateTime dtDateTime1, DateTime dtDateTime2)
    {
      return (dtDateTime1 > dtDateTime2) ? dtDateTime1 : dtDateTime2;
    }

    //
    // Summary:
    //     Gets the minimum date between specified dates.
    //
    // Parameters:
    //   dtDateTime1:
    //     The date value to compare.
    //
    //   dtDateTime2:
    //     The date value to compare.
    //
    // Returns:
    //     The minimum date.
    private static DateTime MinDate(DateTime dtDateTime1, DateTime dtDateTime2)
    {
      return (dtDateTime1 < dtDateTime2) ? dtDateTime1 : dtDateTime2;
    }

    //
    // Summary:
    //     An Overridden method that returns a text representation of the appointment.
    //
    // Returns:
    //     A string holding the schedule appointment data.
    public override string ToString()
    {
      if (AllDay)
      {
        return $"subject:{Subject}";
      }

      return $"[{StartTime}  {EndTime}] subject:{Subject}";
    }

    public enum enMode { AddNew=0,Update=1}
    public enMode Mode = enMode.AddNew;
    public enum enAppointmentSataus
    { Pending = 1, Confirmed = 2, Completed = 3, Canceled = 4, Rescheduled = 5, NotShow = 6 }
    public int AppointmentID { set; get; }
    public enAppointmentSataus AppointmentStatus { set; get; } 

    public clsAppointments()
    {
      this.AppointmentID = -1;
      this.PatientID = -1;
      this.DoctorID = -1;
      this.StartTime = DateTime.Now;
      this.EndTime = DateTime.Now;
      this.AppointmentStatus = enAppointmentSataus.Pending;
      this.MedicalRecordID = -1;
      this.PaymentID = -1;
      this.LastStatusDate = DateTime.Now;
      this._Notes = string.Empty;

      Mode = enMode.AddNew;
    }

    private clsAppointments(int AppointmentID, int PatientID, int DoctorID, enAppointmentSataus AppointmentStatus,
      int MedicalRecordID, int PaymentID, DateTime LastStatusDate, DateTime StartTime, DateTime EndTime,
       string Location, string Title,byte LabelValue,byte MarkerValue, string Note)
    {
      this.AppointmentID = AppointmentID;
      this.PatientID = PatientID;
      this.DoctorID = DoctorID;
      this.AppointmentStatus = AppointmentStatus;
      this.MedicalRecordID = MedicalRecordID;
      this.PaymentID = PaymentID;
      this.LastStatusDate = DateTime.Now;
      this.StartTime = StartTime;
      this.EndTime = EndTime;
      this.LocationValue = Location;
      this.Subject = clsPatient.Find(PatientID).FullName;
      this.LabelValue = LabelValue;
      this.MarkerValue = MarkerValue;
      this.Notes = Note;
      
      Mode = enMode.Update;
    }

    /// Add new Appointment
    private bool _AddNewAppointment()
    {
      this.AppointmentID = clsAppointmentsData.AddNewAppointment(this.PatientID, this.DoctorID,
         (byte)this.AppointmentStatus, this.MedicalRecordID, this.PaymentID, this.LastStatusDate,
         this.StartTime, this.EndTime, this.LocationValue,(byte)this.LabelValue, (byte)this.MarkerValue,this.Notes);
      return (this.AppointmentID != -1);
    }

    // Update Appointment
    private bool _UpdateAppointment()
    {
      return clsAppointmentsData.UpdateAppointment(this.AppointmentID,this.PatientID, this.DoctorID,
         (byte)this.AppointmentStatus, this.MedicalRecordID, this.PaymentID, this.LastStatusDate,
         this.StartTime, this.EndTime, this.LocationValue, (byte)this.LabelValue, (byte)this.MarkerValue, this.content);
    }

    /// <summary>
    /// Delete Appointment:
    ///   it takes AppointmenID, then it will delete Appointment. 
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <returns></returns>
    public static bool DeleteAppointment(int AppointmentID)
    {
      return clsAppointmentsData.DeleteAppointment(AppointmentID);
    }

    /// <summary>
    /// Find Appointment 
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <returns></returns>
    public static clsAppointments Find(int AppointmentID)
    {
      int PatientID = -1, DoctorID = -1, MedicalRecordID = -1, PaymentID = -1;
      byte AppointmentStatus = 1, LabelValue = 0, MarkerValue = 0;
      DateTime LastStatusDate = DateTime.Now, StartTime = DateTime.Now,EndTime = DateTime.Now;
      string Location = "", Note = "",Subject="";

      // pass by ref
      bool IsFound = clsAppointmentsData.GetAppointmentByID(AppointmentID, ref PatientID, ref DoctorID,
        ref AppointmentStatus, ref MedicalRecordID, ref PaymentID, ref LastStatusDate, ref StartTime, ref EndTime,
        ref Location, ref LabelValue,ref MarkerValue,ref Note);

      if (IsFound)
        return new clsAppointments(AppointmentID,PatientID,DoctorID,(enAppointmentSataus)AppointmentStatus,
         MedicalRecordID,PaymentID,LastStatusDate,StartTime,EndTime,Location,Subject,LabelValue,MarkerValue,Note);
      else
        return null;

    }

    /// <summary>
    /// Get All Appointments
    /// </summary>
    /// <returns></returns>
    public static DataTable GetAllAppointments() => clsTestApptData.GetAllAppointmnets();

    /// <summary>
    /// IsExist
    /// </summary>
    /// <param name="AppointmentID"></param>
    /// <returns></returns>
    public static bool IsExist(int AppointmentID) => clsAppointmentsData.IsAppointmentExist(AppointmentID);

    // Handle AppointmentStatus
    public bool SetConfirmed() => clsAppointmentsData.UpdateStatus(AppointmentID, 2);

    public bool SetCompleted() => clsAppointmentsData.UpdateStatus(AppointmentID, 3);

    public bool Cancele() => clsAppointmentsData.UpdateStatus(AppointmentID, 4);

    public bool Rescheduled() => clsAppointmentsData.UpdateStatus(AppointmentID, 5);

    public bool SetNotShowed() => clsAppointmentsData.UpdateStatus(AppointmentID, 6);


    // Handle Add and Update calls
    public bool Save()
    {

      switch (Mode)
      {
        case enMode.AddNew:
          if (_AddNewAppointment())
          {
            Mode = enMode.AddNew;
            return true;
          }
          else
          {
            return false;
          }

        case enMode.Update:
          return _UpdateAppointment();
      }

      return false;
    }

    bool IScheduleAppointment.IsConflict(IScheduleAppointment item)
    {
      throw new NotImplementedException();
    }

    bool IScheduleAppointment.IsConflict(DateTime dtStart, DateTime dtEnd)
    {
      throw new NotImplementedException();
    }

    int IComparable.CompareTo(object obj)
    {
      throw new NotImplementedException();
    }

    object ICloneable.Clone()
    {
      throw new NotImplementedException();
    }
  }
}
