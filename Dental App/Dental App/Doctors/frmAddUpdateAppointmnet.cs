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
using Syncfusion.WinForms.ListView;

namespace Dental_App.Doctors
{
  public partial class frmAddUpdateAppointmnet : MetroForm
  {

    public enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;
    private short res = 0;
    private ScheduleControl _ScheduleGrid;
    private clsPatient _Patient;
    private int _PatientID;
    private DateTime _SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }
    private List<string> PlanList = new List<string>();
    
    private List<DentalPlan> PlanItem = new List<DentalPlan>();
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
       List<DentalPlan> PlanItem = new List<DentalPlan>();
      _ResetDefualtValues();
      CalcTotalCost();
      
      PlanItem.Add(new DentalPlan("Cleaning", 10));
      PlanItem.Add(new DentalPlan("X-ray", 10));
      PlanItem.Add(new DentalPlan("Diagnosis", 10));

      
    }

    

    // Reset Defualt values
    private void _ResetDefualtValues()
    {
      // Reset DateTime
      dtAppointmentDate.MinDateTime = DateTime.Today;
      dtAppointmentDate.Value = _SelectedAppointmentDate;
      dtAppointmentDate.MaxDateTime = DateTime.Today.AddMonths(6);

      // ResetLables
      lblPatinetID.Text = "???";
      lblFullName.Text = "???";
      lblNationalNo.Text = "???";
      lblPhone.Text = "???";
      lblEmail.Text = "???";
      tbSearch.Text = string.Empty;

      // Filling ComboBox with Data
      _FillComboBoxWithTime();
      _FillDoctorsComboBox();
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

    // Filling ComboBox with Doctors names.
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
      tbNote.Focus();
    }


    private void btnSave_Click(object sender, EventArgs e)
    {

    }

    private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
    {
      cbEndTime.SelectedIndex = cbStartTime.SelectedIndex + 1;
    }

    private void iconSearch_Click(object sender, EventArgs e)
    {
      _PatientID = int.Parse(tbSearch.Text.Trim());
      _FindPatinet(_PatientID);
    }

    private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
    {
      // handle numbers input
       e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
    }

    // Validat inputs in Search box.
    private void tbSearch_Validating(object sender, CancelEventArgs e)
    {
      if (String.IsNullOrEmpty(tbSearch.Text.Trim()))
      {
        e.Cancel = true;
        errorProvider1.SetError(tbSearch, "You must enter PatientID");
        return;
      }
      else
      {
        errorProvider1.SetError(tbSearch, null);
      }
    }

    private void CalcTotalCost()
    {
      lbCost.Text = $"${CalcDiagnosis()}";
    }

   

    private short CalcDiagnosis()
    {
      int res = 0;
     
      res += (chbCleaning.Checked == true) ? int.Parse(chbCleaning.Tag.ToString()) : 0;
      res += (chbXray.Checked == true) ? int.Parse(chbXray.Tag.ToString()) : 0;
      res += (chbDiagnosis.Checked == true) ? int.Parse(chbDiagnosis.Tag.ToString()) : 0;

      return Convert.ToInt16(res);
    }

    
    // new
    private void chbCleaning_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }
  }

  public class DentalPlan
  {
    public string Name { set; get; }
    public short Price { set; get; }

    public DentalPlan(string planName,short planPrice)
    {
      Name = planName;
      Price = planPrice;
    }

    public override string ToString()
    {
      return Name;
    }
  }
}
