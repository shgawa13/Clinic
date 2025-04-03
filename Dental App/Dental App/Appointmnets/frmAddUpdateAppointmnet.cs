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


    public enum enLabelValue { }


    private clsAppointments _Appointment;
    private clsPayments _Payment;
    private clsMedicalRecords _MedicalRecord;
    private ScheduleControl _ScheduleGrid;
    private clsPatient _Patient;
    private clsProcedures _Procedure;

    private ListObjectList _LabelList;
    protected ListObjectList LabelList
    {
      get { return _LabelList; }
      set { LabelList = value; }
    }

    private int _PatientID;
    private int _PaymentID;
    private int _ApptID;
    private DateTime _SelectedAppointmentDate { get; set; }
    private string _AppointmnetTime { get; set; }
    private string _Diagnosis { get; set; }
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
    //public frmAddUpdateAppointmnet(int ApptID, ScheduleControl control, DateTime AppointmentDate, string AppointmentTime)
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
      if (_Mode == enMode.Update)
        _LoadData();

      ctrlPatientCardWithFilter2.OnPatientSelected += CtrlPatientCardWithFilter1_OnPatientSelected1;
      
    }

    private void CtrlPatientCardWithFilter1_OnPatientSelected1(object sender, Patients.controls.ctrlPatientCardWithFilter.PatientCardEventArgs e)
    {
      
      _FindPatinet(e.Patient.PatientID);
    }



    // Reset Defualt values
    private void _ResetDefualtValues()
    {
      // Filling ComboBox with Data
      _FillComboBoxWithTime();
      _FillDoctorsComboBox();
      _FillingMarkComboBox();
      _FillingLabelComboBox();

      if (_Mode == enMode.AddNew)
      {
        //frmAddUpdateAppointmnet.Text = "Add new Appointment";
        _Appointment = new clsAppointments();
        _Procedure = new clsProcedures();

      }
      else
      {
        //frmAddUpdateAppointmnet.Text = "Update Appointment";
      }
      // Reset DateTime
      dtAppointmentDate.MinDateTime = DateTime.Today;

      // we check for the value incase add appointmnet from patient list
      if (_SelectedAppointmentDate != null)
        dtAppointmentDate.Value = _SelectedAppointmentDate;
      else
        dtAppointmentDate.Value = DateTime.Now;

      dtAppointmentDate.MaxDateTime = DateTime.Today.AddMonths(6);

      // ResetComboBox
      _ResetComboBox();

      // Disable steps button
       btnSteps.Enabled = false;
       btnSteps.Text = "Next";
    
    }

    private void _ResetComboBox()
    {
      cbStartTime.SelectedIndex = 0;
      cbDoctor.SelectedIndex = 0;
      cbEndTime.SelectedIndex = 0;
     // cbLable.SelectedIndex = 0;
      cbEndTime.SelectedIndex = 0;
      cbLocation.SelectedIndex = 0;
      cbMark.SelectedIndex = 0;

    }

    // Filling Mark comboBox
    private void _FillingMarkComboBox()
    {
      cbMark.Items.Add(new CustomList(0, "Diagnosis"));
      cbMark.Items.Add(new CustomList(1, "Extraction"));
      cbMark.Items.Add(new CustomList(2, "Restoration"));
      cbMark.Items.Add(new CustomList(3, "Whitening"));
      cbMark.Items.Add(new CustomList(4, "Orthopedic"));
      cbMark.Items.Add(new CustomList(5, "Implantation"));
      
     
    }

    // Filing Label comboBox
    private void _FillingLabelComboBox()
    {

      cbLable.Items.Add(new CustomList(0, "None"));
      cbLable.Items.Add(new CustomList(1, "Important"));
      cbLable.Items.Add(new CustomList(2, "Business"));
      cbLable.Items.Add(new CustomList(3, "Personal"));
      cbLable.Items.Add(new CustomList(4, "Vacation"));
      cbLable.Items.Add(new CustomList(5, "Must Attend"));
      cbLable.Items.Add(new CustomList(6, "Travel Required"));
      cbLable.Items.Add(new CustomList(7, "Needs Preparation"));
      cbLable.Items.Add(new CustomList(8, "Birthday"));
      cbLable.Items.Add(new CustomList(9, "Anniversary"));
      cbLable.Items.Add(new CustomList(10, "Phone Call"));
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

      if(Doctors.Rows.Count == 0)
        cbDoctor.Items.Add(new CustomList(0, "- Select Doctor -"));


      foreach (DataRow row in Doctors.Rows)
      {
        cbDoctor.Items.Add(new CustomList((int)row["DoctorID"],(string)row["FullName"]));
      }
      cbDoctor.SelectedIndex = 0;
      
    }

    // Find patient
    private void _FindPatinet(int PatientID)
    {
      _Patient = clsPatient.FindPatientByID(PatientID);

      if (_Patient == null)
      {
        MessageBox.Show($"Patient with ID: {_PatientID}???");
        return;
      }
      // here we fill patient card

      tbNote.Focus();

      btnSteps.Enabled = true;
    }

    // Load Procedure Info
    private async Task  _FindProcedure(int ProcedureID)
    {
      _Procedure = await Task.Run(()=> clsProcedures.Find(ProcedureID));

      if (_Procedure == null) 
      {
        MessageBox.Show($"Error: Couldn't Find procedure with ID: {ProcedureID}");
        return;
      };

      _LoadProcedureInfo();
    }

    // _Load procedure Data
    private  void  _LoadProcedureInfo()
    {
      // Map database fields to checkboxes using a dictionary
        var checkboxMapping = new Dictionary<CheckBoxAdv, int?>
        {
          { chbPeroxide25, _Procedure.Peroxide25 },
          { chbPeroxide40, _Procedure.Peroxide40 },
          { chbCompositeFilling, _Procedure.CompositeFilling },
          { chbPorcelainFilling, _Procedure.PorcelainFilling },
          { chbAmalgamFilling, _Procedure.AmalgamFilling },
          { chbSingleImplant, _Procedure.SingleImplant },
          { chbDoubleImplant, _Procedure.DoubleImplant },
          { chbFullMouthImplants, _Procedure.FullMouthImplant },
          { chbCleaning, _Procedure.Cleaning },
          { chbDiagnosis, _Procedure.Diagnosis },
          { chbSimpleExtraction, _Procedure.SimpleExtraction },
          { chbComplicatedExtrcation, _Procedure.ComplicatedExtrcation },
          { chbComplexExtraction, _Procedure.ComplexExtraction }
        };

      // Set checkbox states
      foreach (var mapping in checkboxMapping)
      {
        mapping.Key.Checked = mapping.Value == 1;
      }

    }
    
    // Load Appointment Data:
    private void _LoadData()
    {
      _Appointment = clsAppointments.Find(_ApptID);

      if(_Appointment == null)
      {
        MessageBox.Show("Error: Appointment Couldn't found");
        return;
      }

      ctrlPatientCardWithFilter1.LoadPatientInfo(_Appointment.PatientID);
     // _FindProcedure(_Appointment.ProcedureID);
      dtAppointmentDate.Value = _Appointment.StartTime.Date;
      cbStartTime.SelectedIndex = cbStartTime.FindString(_Appointment.StartTime.ToShortTimeString());
      cbEndTime.SelectedIndex = cbStartTime.FindString(_Appointment.EndTime.ToShortTimeString());
      cbDoctor.SelectedIndex = cbDoctor.FindString(_Appointment.DoctorID.ToString());
      cbLocation.SelectedIndex = cbLocation.FindString(_Appointment.LocationValue);


    }


    // if User Select StartTime it will add 30 min to EndTime 
    private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbStartTime.SelectedIndex != 19)
        cbEndTime.SelectedIndex = cbStartTime.SelectedIndex + 1;
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

        if (tcAppointment.SelectedIndex != 2)
            tcAppointment.SelectedTab = tcAppointment.TabPages[tcAppointment.SelectedIndex + 1];

        if (tcAppointment.SelectedIndex == 2 && btnSteps.Enabled)
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

      _Appointment.PatientID = (int)_Patient.PatientID;
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
      _Appointment.MarkerValue = cbMark.SelectedIndex;
      _Appointment.PaymentID = _PaymentID;
      _Appointment.MedicalRecordID = _GetMedicalRecordID();
      _Appointment.ProcedureID = GetProcedureID();
      _SelectedAppointmentDate = (DateTime)dtAppointmentDate.Value;
      _AppointmnetTime = GetSelectedTime(cbStartTime).ToString();
    }

    // Fill Procedure object 
    private void _FillProcedure()
    {

      _Procedure.Peroxide25 = (byte)((chbPeroxide25.Checked) ? 1 : 0);
      _Procedure.Peroxide40 = (byte)((chbPeroxide40.Checked) ? 1 : 0);
      _Procedure.CompositeFilling = (byte)((chbCompositeFilling.Checked) ? 1 : 0);
      _Procedure.PorcelainFilling = (byte)((chbPorcelainFilling.Checked) ? 1 : 0);
      _Procedure.AmalgamFilling = (byte)((chbAmalgamFilling.Checked) ? 1 : 0);
      _Procedure.SingleImplant = (byte)((chbSingleImplant.Checked) ? 1 : 0);
      _Procedure.DoubleImplant = (byte)((chbDoubleImplant.Checked) ? 1 : 0);
      _Procedure.FullMouthImplant = (byte)((chbFullMouthImplants.Checked) ? 1 : 0);
      _Procedure.Cleaning = (byte)((chbCleaning.Checked) ? 1 : 0);
      _Procedure.Diagnosis = (byte)((chbDiagnosis.Checked) ? 1 : 0);
      _Procedure.SimpleExtraction = (byte)((chbSimpleExtraction.Checked) ? 1 : 0);
      _Procedure.ComplicatedExtrcation = (byte)((chbComplicatedExtrcation.Checked) ? 1 : 0);
      _Procedure.ComplexExtraction = (byte)((chbComplexExtraction.Checked) ? 1 : 0);

    }


    private int GetProcedureID()
    {
      if (_Procedure.Save())
      {
        MessageBox.Show($"procedure has been added successfully");
        return _Procedure.ProceduerID;
      }
      return -1;
    }


    // OnClick on these buttons will show spicific plan panel
    private void DiagnosisBtn_Click(object sender, EventArgs e)
    {
       _Plan = enPlan.Diagnosis;
       HandlePlans();
    }

    private void ExtractionBtn_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Extraction;
      HandlePlans();
    }

    private void RestorationBtn_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Restoration;
      HandlePlans();
    }

    private void WhiteningBtn_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Whitening;
      HandlePlans();
    }

    private void ImplantationBtn_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Implantation;
      HandlePlans();
    }

    private void OrthopedicBtn_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Orthopedic;
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

    private void PayBillBtn_Click(object sender, EventArgs e)
    {
      frmPay frm = new frmPay(TotalCost);
      frm.DataBack += GetPaymentID;
      frm.ShowDialog();
    }
    

    private void PrintBillBtn_Click(object sender, EventArgs e)
    {
      frmPDFBills frm = new frmPDFBills();
      frm.ShowDialog();
    }
   
    // here we assing PaymentID 
    private void GetPaymentID(object sender, int PaymentID)
    {
      if(PaymentID != -1)
      {
        _PaymentID = PaymentID;
        btnSteps.Enabled = true;
        btnPrintBill.Enabled = true;

        _FillProcedure();
        _UpdateBillInfo();
      }
      else
      {
        MessageBox.Show("Error Couldn't Save Appointment because payment fild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        btnSteps.Enabled = false;
      }
    }

    // here we update Bill info
    private void _UpdateBillInfo()
    {
      lblBillsDate.Text = dtAppointmentDate.DateTimeText;
      lblTime.Text = cbStartTime.SelectedText;
      lblPatientName.Text = _Patient.PatientInfo.FullName;
      lblLocation.Text = cbLocation.SelectedItem.ToString();
      lblDoctorName.Text = cbDoctor.SelectedItem.ToString();
      lblSummay.Text = lbSummary.Text;
      lblCost.Text = $"${CalcPlanCost()}";
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

    private void tbpAddAppointment_Click(object sender, EventArgs e)
    {
      
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
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

