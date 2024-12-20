using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using Syncfusion.WinForms;
using Syncfusion.Windows.Forms;
using Syncfusion.Schedule;
using GridScheduleSample;
using Syncfusion.Windows.Forms.Schedule;
using Business;

namespace Dental_App.Doctors
{
  public partial class frmAddUpdateAppointmnet : MetroForm
  {
    public enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;

    private ScheduleControl _ScheduleGrid;
    private clsPatient _Patient;
    private int _PatientID;
    private DateTime _SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }

    // AppointmentForm Can be opened from two places
    // From Schedule
    public frmAddUpdateAppointmnet(ScheduleControl control, DateTime AppointmentDate, string AppointmentTime)
    {
      InitializeComponent();
      _ScheduleGrid = control;
      _SelectedAppointmentDate = AppointmentDate;
      _AppointmnetTime = AppointmentTime;
    }

    public frmAddUpdateAppointmnet(ScheduleControl control, int PatientID)
    {
      InitializeComponent();
      _ScheduleGrid = control;
      _PatientID = PatientID;
    }

    private void frmAddUpdateAppointmnet_Load(object sender, EventArgs e)
    {
      dtAppointmentDate.MinDateTime = DateTime.Today;
      dtAppointmentDate.Value = _SelectedAppointmentDate;
      dtAppointmentDate.MaxDateTime = DateTime.Today.AddMonths(6);


      _ResetDefualtValues();
    }

    // Reset Defualt values
    private void _ResetDefualtValues()
    {
      
      // ResetLables
      lblPatinetID.Text = "???";
      lblFullName.Text = "???";
      lblNationalNo.Text = "???";
      lblPhone.Text = "???";
      lblEmail.Text = "???";
      tbSearch.Text = string.Empty;

      _FillComboBoxWithTime();
      _FillDoctorsComboBox();

    }

    private int DateTimeToIndex(DateTime dt)
    {
      return 1; // dt.Hour * (60 / minimumTimeSlot) + dt.Minute / minimumTimeSlot;
    }

    // Filling ComboBox with time it start with 8:00 AM.
    private void _FillComboBoxWithTime()
    {
     
      int Year = DateTime.Today.Year;
      int Month = DateTime.Today.Month;
      int ToDay = DateTime.Today.Day;

      DateTime date = new DateTime(Year, Month, ToDay, 8, 0, 0);

      for (int i = 0; i < 20; i++)
      {
        cbStartTime.Items.Add(date.ToShortTimeString());
        date = date.AddMinutes(30);
        cbEndTime.Items.Add(date.ToShortTimeString());
      }
      
      // If there is no Time selected
      if (_AppointmnetTime == "")
        cbStartTime.SelectedIndex = 0;
      cbStartTime.SelectedIndex = cbStartTime.FindString(_AppointmnetTime);
      
      cbEndTime.SelectedIndex = 0;
    }

    private void _FillDoctorsComboBox()
    {
      DataTable Doctors = clsDoctors.GetAllDoctors();

      foreach(DataRow row in Doctors.Rows)
      {
        cbDoctor.Items.Add(row["FullName"]);
      }

    }

    // Find patient
    private void _FindPatinet(int PatientID)
    {
      _Patient = clsPatient.FindPatientByID(PatientID);

      if (_Patient == null) 
      {
        MessageBox.Show($"Patient with ID: {_Patient} was not  found");
        return;  
      }

      lblFullName.Text = _Patient.PatientInfo.FullName;
      lblPatinetID.Text = PatientID.ToString();
      lblNationalNo.Text = _Patient.PatientInfo.NationalID;
      lblEmail.Text = _Patient.PatientInfo.Email;
      lblPhone.Text = _Patient.PatientInfo.PhoneNumber;

      
    }


    private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
    {

      cbEndTime.SelectedIndex = cbStartTime.SelectedIndex + 1;
    }

    private void iconSearch_Click(object sender, EventArgs e)
    {
      _PatientID = int.Parse(tbSearch.Text);
      _FindPatinet(_PatientID);
    }

   
  }   
}
