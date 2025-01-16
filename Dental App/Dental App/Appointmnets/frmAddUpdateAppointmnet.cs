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
namespace Dental_App.Appointmnets
{
  public partial class frmAddUpdateAppointmnet : MetroForm
  {
    // private PdfViewerControl pdfViewerControl;
    public enum enPlan { Diagnosis = 0, Extraction = 1, Restoration = 2, Whitening = 3, Orthopedic = 4, Implantation = 5 }
    private enPlan _Plan = enPlan.Diagnosis;

    public enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;

    private ScheduleControl _ScheduleGrid;
    private clsPatient _Patient;
    private int _PatientID;
    private DateTime _SelectedAppointmentDate { set; get; }
    private string _AppointmnetTime { set; get; }
    private List<string> PlanList = new List<string>();
    private int TotalCost = 0;
    private List<DentalPlan> PlanItem = new List<DentalPlan>();
    // AppointmentForm Can be opened from two places
    // From Schedule
    public frmAddUpdateAppointmnet(ScheduleControl control, DateTime AppointmentDate, string AppointmentTime)
    {
      InitializeComponent();
      _ScheduleGrid = control;
      _SelectedAppointmentDate = AppointmentDate;
      _AppointmnetTime = AppointmentTime;

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

      // Disable steps button
      btnSteps.Enabled = false;
      btnSteps.Text = "Next";

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

      foreach (DataRow row in Doctors.Rows)
      {
        cbDoctor.Items.Add(row["FullName"]);
      }

    }

    // Filling ComboBoxt with Lables
    private void _FillLabelComboBox()
    {
      //labelList = new ListObjectList();
      //labelList.Add(new ListObject(0, "None", Color.White));
      //labelList.Add(new ListObject(1, "Important", Color.FromArgb(255, 128, 64)));
      //labelList.Add(new ListObject(2, "Business", Color.FromArgb(86, 152, 233)));
      //labelList.Add(new ListObject(3, "Personal", Color.FromArgb(57, 210, 53)));
      //labelList.Add(new ListObject(4, "Vacation", Color.FromArgb(199, 198, 182)));
      //labelList.Add(new ListObject(5, "Must Attend", Color.FromArgb(255, 128, 0)));
      //labelList.Add(new ListObject(6, "Travel Required", Color.FromArgb(0, 255, 255)));
      //labelList.Add(new ListObject(7, "Needs Preparation", Color.FromArgb(171, 171, 88)));
      //labelList.Add(new ListObject(8, "Birthday", Color.FromArgb(186, 117, 255)));
      //labelList.Add(new ListObject(9, "Anniversary", Color.FromArgb(255, 128, 64)));
      //labelList.Add(new ListObject(10, "Phone Call", Color.FromArgb(255, 128, 64)));
      
     // cbLabels.DataSource =
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


    // Handle CheckBoxes and Plan Cost
    private short CalcPlanCost()
    {
      int Cost = 0;

      foreach (var checkBox in GetCheckBoxes())
      {
        if (checkBox.Checked)
        {
          Cost += int.Parse(checkBox.Tag.ToString());
        }
      }

      _UpdateSummary();
      return Convert.ToInt16(Cost);
    }



    // Update Summary 
    private void _UpdateSummary()
    {

      string Summarylable = "";

      foreach (var checkBox in GetCheckBoxes())
      {
        if (checkBox.Checked)
        {
          Summarylable += $"{checkBox.Text}  ${checkBox.Tag}.\n";
        }
      }

      lbSummary.Text = Summarylable;


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
    
    }

    
    private void tcAppointment_SelectedIndexChanged(object sender, EventArgs e)
    {
      // if tab index is 2 we hide the button
      btnSteps.Visible = (tcAppointment.SelectedIndex != 2);
      // if tab insex is 1 we change the text to save
      btnSteps.Text = (tcAppointment.SelectedIndex == 1) ? "Save": "Next";
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

  }

  public class DentalPlan
  {
    public string Name { set; get; }
    public short Price { set; get; }

    public DentalPlan(string planName, short planPrice)
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

