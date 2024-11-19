using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Schedule;
//using System.Windows.Media;


namespace Dental_App.Global_Classes
{
  internal class clsDentalScheduleAppointment : IScheduleAppointment, IComparable, ICloneable
  {
    

    //
    // Summary:
    //     Gets or sets a value indicating whether all day appointment or not.
    public bool AllDay { get; set; }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not blocked appointment is allowed
    //     to click.
    public bool AllowClickable { get; set; }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not an appointment is allowed to drag.
    public bool AllowDrag { get; set; }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not an appointment is allowed to resize
    //     and modify its duration.
    public bool AllowResize { get; set; }

    //
    // Summary:
    //     Gets or sets the appointment html element background color.
    public Color BackColor { get; set; }

    //
    // Summary:
    //     Gets or sets fore color of the appointment panel.
    public Color ForeColor { get; set; }

    //
    // Summary:
    //     Gets or sets a text displayed as the main content of this schedule item.
    public string Content { get; set; }

    //
    // Summary:
    //     Gets or sets associates ToolTip text with the appointment.
    public string CustomToolTip { get; set; }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not this items has been modified.
    public bool Dirty { get; set; }

    //
    // Summary:
    //     Gets or sets end time for this item.
    public DateTime EndTime { get; set; }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not changes to this item should be
    //     ignored.
    public bool IgnoreChanges { get; set; }

    //
    // Summary:
    //     Gets or sets a categorizer value for this item.
    public int LabelValue { get; set; }

    //
    // Summary:
    //     Gets or sets some item dependent string-like the location of a meeting.
    public string LocationValue { get; set; }

    //
    // Summary:
    //     Gets or sets some item dependent string-like the location of a meeting.
    public bool RecurringOnOverride { get; set; }

    //
    // Summary:
    //     Gets or sets categorizer value for this item.
    public int MarkerValue { get; set; }

    //
    // Summary:
    //     Gets or sets owner of this schedule item.
    public int Owner { get; set; }

    //
    // Summary:
    //     Gets or sets a value indicating whether or not some reminder action should be
    //     taken as this item becomes current.
    public bool Reminder { get; set; }

    //
    // Summary:
    //     Gets or sets a remind value of this item.
    public int ReminderValue { get; set; }

    //
    // Summary:
    //     Gets or sets a remind text of this item.
    public string ReminderText { get; set; }

    //
    // Summary:
    //     Gets or sets a start time of this item.
    public DateTime StartTime { get; set; }

    //
    // Summary:
    //     Gets or sets the subject or topic title for this schedule item.
    public string Subject { get; set; }

    //
    // Summary:
    //     Gets or sets an arbitrary object associated with this item.
    public object Tag { get; set; }

    //
    // Summary:
    //     Gets or sets a color of appointment time span element.
    public Color TimeSpanColor { get; set; }


  
    //
    // Summary:
    //     Gets or sets ToolTip text with the appointment.
    public ScheduleAppointmentToolTip ToolTip { get; set; }

    //
    // Summary:
    //     Gets or sets a unique identifier for this schedule item.
    public int UniqueID { get; set; }

    //
    // Summary:
    //     A read-only property that gets a version associated with the data schema for
    //     this item.
    public int Version { get; }

    //
    // Summary:
    //     Determine whether item has conflict with other item.
    //
    // Parameters:
    //   item:
    //     A IScheduleAppointment
    //
    // Returns:
    //     True if the item is in conflict.
    public bool IsConflict(IScheduleAppointment item) => false;

    //
    // Summary:
    //     Determine whether item has conflict with other item.
    //
    // Parameters:
    //   dtStart:
    //     start time
    //
    //   dtEnd:
    //     end time
    //
    // Returns:
    //     True if the item is in conflict.
    public bool IsConflict(DateTime dtStart, DateTime dtEnd) => false;


    public int CompareTo(object obj)
    {
      throw new NotImplementedException();
    }

    object ICloneable.Clone()
    {
      throw new NotImplementedException();
    }

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
    private int _AppointmentStatus;
    public int AppointmentStatus
    {
      get { return _AppointmentStatus; }
      set { _AppointmentStatus = value; }
    }

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


  }
}
