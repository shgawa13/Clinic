using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsAppointments
  {
    public enum enMode { AddNew = 0, Update = 1 }
    public enMode Mode = enMode.AddNew;

    public enum enAppointmentSataus
    { Pending = 1, Confirmed = 2, Completed = 3, Canceled = 4, Rescheduled = 5, NotShow = 6 }

    public int AppointmentID { set; get; }
    public int PatientID { set; get; }
    public int DoctorID { set; get; }
    public DateTime AppointmentDateTime { set; get; }
    public enAppointmentSataus AppointmentStatus { set; get; }
    public int MedicalRecordID { set; get; }
    public int PaymentID { set; get; }
    public DateTime LastStatusDate { set; get; }

    public clsAppointments()
    {
      this.AppointmentID = -1;
      this.PatientID = -1;
      this.DoctorID = -1;
      this.AppointmentDateTime = DateTime.Now;
      this.AppointmentStatus = enAppointmentSataus.Pending;
      this.MedicalRecordID = -1;
      this.PaymentID = -1;
      this.LastStatusDate = DateTime.Now;

      Mode = enMode.AddNew;
    }

    private clsAppointments(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime,
      enAppointmentSataus AppointmentStatus, int MedicalRecordID, int PaymentID, DateTime LastStatusDate)
    {
      this.AppointmentID = AppointmentID;
      this.PatientID = PatientID;
      this.DoctorID = DoctorID;
      this.AppointmentDateTime = AppointmentDateTime;
      this.AppointmentStatus = AppointmentStatus;
      this.MedicalRecordID = MedicalRecordID;
      this.PaymentID = PaymentID;
      this.LastStatusDate = LastStatusDate;

      Mode = enMode.Update;
    }

    // Add new Appointment
    private bool _AddNewAppointment() 
    {
      this.AppointmentID = clsAppointmentsData.AddNewAppointment(this.PatientID, this.DoctorID,
        this.AppointmentDateTime, (byte)this.AppointmentStatus, this.MedicalRecordID, this.PaymentID, this.LastStatusDate);
      return (this.AppointmentID != -1);
    }

    // Update Appointment
    private bool _UpdateAppointment()
    {
      return clsAppointmentsData.UpdateAppointment(this.AppointmentID, this.PatientID, this.DoctorID,
        this.AppointmentDateTime, (byte)this.AppointmentStatus, this.MedicalRecordID, this.PaymentID, this.LastStatusDate);
    }

    // Delete Appointment
    public static bool DeleteAppointment(int AppointmentID)
    {
      return clsAppointmentsData.DeleteAppointment(AppointmentID);
    }

    // Find Appointment 
    public static clsAppointments Find(int AppointmentID)
    {
      int PatientID = -1, DoctorID = -1, MedicalRecordID = -1, PaymentID = -1;
      byte AppointmentStatus = 1;
      DateTime AppointmentDateTime = DateTime.Now, LastStatusDate = DateTime.Now;

      // pass by ref
      bool IsFound = clsAppointmentsData.GetAppointmentByID(AppointmentID, ref PatientID, ref DoctorID,
        ref AppointmentDateTime, ref AppointmentStatus, ref MedicalRecordID, ref PaymentID, ref LastStatusDate);

      if (IsFound)
        return new clsAppointments(AppointmentID, PatientID, DoctorID, AppointmentDateTime,
          (enAppointmentSataus)AppointmentStatus, MedicalRecordID, PaymentID, LastStatusDate);
      else
        return null;

    }

    // Get All Appointments
    public static DataTable GetAllAppointments() => clsAppointmentsData.GetAllAppointments();

    // IsExist
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

  }
}
