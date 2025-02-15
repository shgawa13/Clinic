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
using Syncfusion.Windows.Forms.Tools;
using Dental_App.Payments;

namespace Dental_App.Appointmnets
{
  public partial class frmAddUpdateAppointmnet : MetroForm
  {
    // private PdfViewerControl pdfViewerControl;
    public enum enPlan { Diagnosis = 0, Extraction = 1, Restoration = 2, Whitening = 3, Orthopedic = 4, Implantation = 5 }
    private enPlan _Plan = enPlan.Diagnosis;

    public enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;
   
    private clsAppointments _Appointment;
    private clsPayments _Payment;
    private clsMedicalRecords _MedicalRecord;
    private ScheduleControl _ScheduleGrid;
    private clsPatient _Patient;
    private int _PatientID;
    private int _DoctrorID;
    private int _PaymentID;
    private DateTime _SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }
    private string _Diagnosis { set; get; }
    private decimal TotalCost = 0;
    // AppointmentForm Can be opened from two places
    // From Schedule to create new Appointmnet
    public frmAddUpdateAppointmnet(ScheduleControl control, DateTime AppointmentDate, string AppointmentTime)
    {
      InitializeComponent();
      _ScheduleGrid = control;
      _SelectedAppointmentDate = AppointmentDate;
      _AppointmnetTime = AppointmentTime;
      _Mode = enMode.AddNew;
      // ------------
      CheckBoxEvent();
    }

    //// From Schedule to Update an Existing appointment
    //public frmAddUpdateAppointmnet(int ApptID,ScheduleControl control, DateTime AppointmentDate, string AppointmentTime)
    //{
    //  InitializeComponent();
    //  _ScheduleGrid = control;
    //  _SelectedAppointmentDate = AppointmentDate;
    //  _AppointmnetTime = AppointmentTime;
    //  _Mode = enMode.Update;
    //  // ------------
    //  CheckBoxEvent();
    //}

    // From patient list 
    public frmAddUpdateAppointmnet(int PatientID)
    {
      InitializeComponent();
      _PatientID = PatientID;
      _Mode = enMode.Update;
      // ------------
      CheckBoxEvent();
      
    }

    private void CheckBoxEvent()
    {
      chbCleaning.CheckStateChanged += CheckBox_CheckStateChanged;
      chbXray.CheckStateChanged += CheckBox_CheckStateChanged;
      chbDiagnosis.CheckStateChanged += CheckBox_CheckStateChanged;
      chbPeroxide25.CheckStateChanged += CheckBox_CheckStateChanged;
      chbPeroxide40.CheckStateChanged += CheckBox_CheckStateChanged;
      chbCompositeFilling.CheckStateChanged += CheckBox_CheckStateChanged;
      chbPorcelainFilling.CheckStateChanged += CheckBox_CheckStateChanged;
      chbAmalgamFilling.CheckStateChanged += CheckBox_CheckStateChanged;
      chbSingleImplant.CheckStateChanged += CheckBox_CheckStateChanged;
      chbDoubleImplant.CheckStateChanged += CheckBox_CheckStateChanged;
      chbFullMouthImplants.CheckStateChanged += CheckBox_CheckStateChanged;
      chbSimpleExtraction.CheckStateChanged += CheckBox_CheckStateChanged;
      chbComplicatedExtrcation.CheckStateChanged += CheckBox_CheckStateChanged;
      chbComplexExtraction.CheckStateChanged += CheckBox_CheckStateChanged;
      chbWisdomExtarction.CheckStateChanged += CheckBox_CheckStateChanged;

    }

    private void CheckBox_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }
    

    private void frmAddUpdateAppointmnet_Load(object sender, EventArgs e)
    {
      _ResetDefualtValues();
     // if (_Mode == enMode.Update)
     //   _LoadData();
    }

    // Reset Defualt values
    private void _ResetDefualtValues()
    {

      if(_Mode == enMode.AddNew)
      {
        lblTitle.Text = "Add new Appointment";
        _Appointment = new clsAppointments();
      }
      else
      {
        lblTitle.Text = "Update Appointment";
      }
      // Reset DateTime
      dtAppointmentDate.MinDateTime = DateTime.Today;

      // we check for the value incase add appointmnet from patient list
      if (_SelectedAppointmentDate != null)
        dtAppointmentDate.Value = _SelectedAppointmentDate;
      else
        dtAppointmentDate.Value = DateTime.Now;

      dtAppointmentDate.MaxDateTime = DateTime.Today.AddMonths(6);

      // ResetLables
      lblPatinetID.Text = "???";
      lblFullName.Text = "???";
      lblNationalNo.Text = "???";
      lblPhone.Text = "???";
      lblEmail.Text = "???";
      tbSearch.Text = string.Empty;

      // Disable steps button
      btnSteps.Enabled = false;
      btnSteps.Text = "Next";
    
      cbMark.Items.Add(new CustomList(0, "None"));
      cbMark.Items.Add(new CustomList(1, "Important"));
      cbMark.Items.Add(new CustomList(2, "Business"));
      cbMark.Items.Add(new CustomList(3, "Personal"));
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



    private DateTime GetSelectedTime(ComboBox comboBox)
    {
      if (comboBox.SelectedItem != null) 
      {
        string selectedTime = comboBox.SelectedItem.ToString();
        DateTime selectedDate = DateTime.Parse(selectedTime); 
        return selectedDate;
      } 
      return DateTime.MinValue;
    }

    // Filling ComboBox with Doctors names.
    private void _FillDoctorsComboBox()
    {
      DataTable Doctors = clsDoctors.GetAllDoctors();

      foreach (DataRow row in Doctors.Rows)
      {
        cbDoctor.Items.Add(new CustomList((int)row["DoctorID"],(string)row["FullName"]));
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

      btnSteps.Enabled = true;
    }

    // if appointment open from patient list we load patient info
    private void _LoadPatientInfo(int PatientID)
    {
      _FindPatinet(PatientID);
      tbSearch.Enabled = false;
      iconSearch.Enabled = false;
    }

    // if User Select StartTime it will add 30 min to EndTime 
    private void cbStartTime_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      if (cbStartTime.SelectedIndex != 19)
      {
        cbEndTime.SelectedIndex = cbStartTime.SelectedIndex + 1;
      }
    }

    
    private void iconSearch_Click(object sender, EventArgs e)
    {
      if (tbSearch.Text.Trim() != string.Empty)
      {
        _PatientID = int.Parse(tbSearch.Text.Trim());
        _FindPatinet(_PatientID);

      }
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


    //-------------------------------------[ Procedures Tap ] --------------------------------------------//

    private void CalcTotalCost()
    {
      TotalCost = CalcPlanCost();
      lbCost.Text = $"${TotalCost}";
    }

    private short CalcPlanCost()
    {
      var checkBoxes = GetCheckBoxes();
      var checkedCheckBoxes = checkBoxes
          .Where(cb => cb.Checked)
          .ToList();

      int cost = checkedCheckBoxes.Sum(cb => int.Parse(cb.Tag.ToString()));
      _Diagnosis = checkedCheckBoxes.FirstOrDefault()?.Text; // Update diagnosis (first checked checkbox)

      // Build the summary string
      StringBuilder summary = new StringBuilder();
      foreach (var cb in checkedCheckBoxes)
      {
        summary.Append($"{cb.Text}  ${cb.Tag}.\n");
      }

      // Update the summary label
      lbSummary.Text = summary.ToString();

      // Return the cost as a short 
      return Convert.ToInt16(cost);
    }

    // Get all checkboxes
    private IEnumerable<CheckBoxAdv> GetCheckBoxes()
    {
      return new List<CheckBoxAdv>
      {
        chbCleaning, chbXray, chbDiagnosis, chbSimpleExtraction,
        chbComplicatedExtrcation, chbComplexExtraction, chbWisdomExtarction, chbAmalgamFilling,
        chbPorcelainFilling, chbCompositeFilling, chbSingleImplant, chbDoubleImplant,
        chbFullMouthImplants, chbPeroxide25, chbPeroxide40
      };
    }
    
    // Hide all Panles
    private IEnumerable<Panel> HideAllPanelss()
    {
      return new List<Panel>
      {
        pnlDiagnosis,
        pnlExtaction,
        pnlRestoration,
        pnlImplantaion,
        pnlWhitening,
        pnlOrthopedic
      };
    }

    private void HandlePlans()
    {
      HideAllPanels();

      switch (_Plan)
      {
        case enPlan.Diagnosis:
          pnlDiagnosis.Visible = true;
          break;

        case enPlan.Extraction:
          pnlExtaction.Visible = true;
          break;

        case enPlan.Restoration:
          pnlRestoration.Visible = true;
          break;

        case enPlan.Implantation:
          pnlImplantaion.Visible = true;
          break;

        case enPlan.Whitening:
          pnlWhitening.Visible = true;
          break;

        case enPlan.Orthopedic:
          pnlOrthopedic.Dock = DockStyle.Left;
          pnlOrthopedic.Visible = true;

          break;
      }
    }

   
    private void btnSteps_Click(object sender, EventArgs e)
    {

      if(tcAppointment.SelectedIndex !=2)
        tcAppointment.SelectedTab = tcAppointment.TabPages[tcAppointment.SelectedIndex + 1];

      if(tcAppointment.SelectedIndex == 2 && btnSteps.Enabled)
      {
         _SaveAppointment();
        if (_Appointment.Save())
          MessageBox.Show("Appointment Has been Added Successully");
        else
          MessageBox.Show("Erorr: Something went wrong couldn't add an appointment");

      }

    }


    private void tcAppointment_SelectedIndexChanged(object sender, EventArgs e)
    {
      
      // if tab insex is 1 we change the text to save
      if(tcAppointment.SelectedIndex == 2)
      {
        btnSteps.Enabled = false;
        btnSteps.Text = "Save";
      }
      else
      {
        btnSteps.Text = "Next";
      }
    }
    
    private void _SaveAppointment()
    {
      // Getting doctorID 
      CustomList selectedDoctor = (CustomList)cbDoctor.SelectedItem;
      CustomList selectedLable = (CustomList)cbLable.SelectedItem;
      _Appointment.PatientID = (int)_PatientID;
      _Appointment.DoctorID = selectedDoctor.ID;
      _Appointment.Subject = _Patient.PatientInfo.FullName;
      _Appointment.Content = selectedDoctor.DisplayMember;
      _Appointment.LastStatusDate = DateTime.Now;
      _Appointment.StartTime = GetSelectedTime(cbStartTime);
      _Appointment.EndTime = GetSelectedTime(cbEndTime);
      _Appointment.LocationValue = cbLocation.Text;
      _Appointment.AllDay = false;
      _Appointment.Dirty = false;
      _Appointment.LabelValue = 1;
      _Appointment.Reminder = false;
      _Appointment.Owner = 1;
      _Appointment.MarkerValue = 1;
      _Appointment.PaymentID = _PaymentID;
      _Appointment.MedicalRecordID = _GetMedicalRecordID();

      _SelectedAppointmentDate = (DateTime)dtAppointmentDate.Value;
      _AppointmnetTime = GetSelectedTime(cbStartTime).ToString();
    }



    // OnClick on these buttons will show spicific plan panel
    private void btnDiagnosis_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Diagnosis;
      HandlePlans();
    }

    private void btnExtraction_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Extraction;
      HandlePlans();
    }

    private void btnRestoration_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Restoration;
      HandlePlans();
    }

    private void btnWhitening_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Whitening;
      HandlePlans();
    }

    private void Orthopedic_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Orthopedic;
      HandlePlans();
    }

    private void btnImplantation_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Implantation;
      HandlePlans();
    }

    // Hiding all Panels
    private void HideAllPanels()
    {
      pnlDiagnosis.Visible = false;
      pnlExtaction.Visible = false;
      pnlRestoration.Visible = false;
      pnlImplantaion.Visible = false;
      pnlWhitening.Visible = false;
      pnlOrthopedic.Visible = false;
    }

    //------------------------------------- [ Bills Tap ] --------------------------------------------//

    private void btnPrintBill_Click(object sender, EventArgs e)
    {
      frmPDFBills frm = new frmPDFBills();
      frm.ShowDialog();
    }

    private void btnPayBill_Click(object sender, EventArgs e)
    {
      frmPay frm = new frmPay(TotalCost);
      frm.DataBack += GetPaymentID;
      frm.ShowDialog();
    }

    // here we assing PaymentID 
    private void GetPaymentID(object sender, int PaymentID)
    {
      if(PaymentID != -1)
      {
        _PaymentID = PaymentID;
        btnSteps.Enabled = true;
      }
      else
      {
        MessageBox.Show("Error Couldn't Save Appointment because payment fild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        btnSteps.Enabled = false;
      }
    }

    // here we handle MedicalRecred
    private int _GetMedicalRecordID()
    {
      _MedicalRecord = new clsMedicalRecords();
      _MedicalRecord.VisitDescription = lbSummary.Text.Trim();
      _MedicalRecord.Diagnosis = _Diagnosis;
      _MedicalRecord.AdditionalNotes = null;

      if (_MedicalRecord.Save())
        MessageBox.Show("MedicalRecord has been save Successfully");
      else
        MessageBox.Show("Error: Fild to create MedicalRecord");

      return _MedicalRecord.MedicalRecordID;
    }


  }

  /// <summary>
  /// Custom list that hold
  /// int ID
  /// string displayName 
  /// </summary>
 public class CustomList 
  {
    private int id;
    private string display;

    //
    // Summary:
    //     Gets or sets string that is used when this object is displayed.
    public  string DisplayMember
    {
      get
      {
        return display;
      }
      set
      {
        display = value;
      }
    }

    //
    // Summary:
    //     Gets or sets an integer that is stored in the data objects to represent this
    //     object.
    public  int ID
    {
      get
      {
        return id;
      }
      set
      {
        id = value;
      }
    }

   
    // Parameters:
    //   valueMember:
    //     The valueMember that is stored in the data objects.
    //
    //   displayMember:
    //     The displayMember that is used for display.
   
    public CustomList(int valueMember, string displayMember)
    {
      id = valueMember;
      display = displayMember;
    }


   
    // Returns:
    /// <returns>The DisplayMember as string</returns>
   
    public override string ToString()
    {
      return display;
    }
  }

 
}

