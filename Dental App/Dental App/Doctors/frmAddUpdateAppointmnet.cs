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
  
    public enum enPlan { Diagnosis=0, Extraction=1, Restoration=2, Whitening=3, Orthopedic=4, Implantation=5 }
    private enPlan _Plan = enPlan.Diagnosis;

    public enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;

    private short res = 0;
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
    }

    public frmAddUpdateAppointmnet(ScheduleControl control, int PatientID)
    {
      InitializeComponent();
      _ScheduleGrid = control;
      _PatientID = PatientID;
    }

    private void frmAddUpdateAppointmnet_Load(object sender, EventArgs e)
    {
      _ResetDefualtValues();
     // CalcTotalCost();
      
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
      if(tbSearch.Text.Trim() != string.Empty)
      {
        _FindPatinet(_PatientID);
        _PatientID = int.Parse(tbSearch.Text.Trim());

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
      TotalCost = CalcDiagnosis() + CalcExtraction();
      lbCost.Text = $"${TotalCost}";
    }

   
    // Calc Diagnosis Plan
    private short CalcDiagnosis()
    {
      int Cost = 0;
    
      Cost += (chbCleaning.Checked) ? int.Parse(chbCleaning.Tag.ToString()) : 0;
      Cost += (chbXray.Checked) ? int.Parse(chbXray.Tag.ToString()) : 0;
      Cost += (chbDiagnosis.Checked) ? int.Parse(chbDiagnosis.Tag.ToString()) : 0;
     
      _UpdateSummary();
      return Convert.ToInt16(Cost);
    }

    private short CalcExtraction()
    {
      int Cost = 0;
      Cost += (chbSimpleExtraction.Checked) ? int.Parse(chbSimpleExtraction.Tag.ToString()) : 0;
      Cost += (chbComplicatedExtrcation.Checked) ? int.Parse(chbComplicatedExtrcation.Tag.ToString()) : 0;
      Cost += (chbComplexExtraction.Checked) ? int.Parse(chbComplexExtraction.Tag.ToString()) : 0;
      Cost += (chbWisdomExtarction.Checked) ? int.Parse(chbWisdomExtarction.Tag.ToString()) : 0;

      return Convert.ToInt16(Cost);
    }
    
    private short CalcRestoration()
    {
      int Cost = 0;
      Cost += (chbAmalgamFilling.Checked) ? int.Parse(chbAmalgamFilling.Tag.ToString()) : 0;
      Cost += (chbPorcelainFilling.Checked) ? int.Parse(chbPorcelainFilling.Tag.ToString()) : 0;
      Cost += (chbCompositeFilling.Checked) ? int.Parse(chbCompositeFilling.Tag.ToString()) : 0;

      return Convert.ToInt16(Cost);
    }

    private short CalcImplantation()
    {
      int Cost = 0;
      Cost += (chbSingleImplant.Checked) ? int.Parse(chbSingleImplant.Tag.ToString()) : 0;
      Cost += (chbDoubleImplant.Checked) ? int.Parse(chbDoubleImplant.Tag.ToString()) : 0;
      Cost += (chbFullMouthImplants.Checked) ? int.Parse(chbFullMouthImplants.Tag.ToString()) : 0;

      return Convert.ToInt16(Cost);
    }

    private short CalcWhitenig()
    {
      int Cost = 0;

      Cost += (chbPeroxide25.Checked) ? int.Parse(chbPeroxide25.Tag.ToString()) : 0;
      Cost += (chbPeroxide40.Checked) ? int.Parse(chbPeroxide40.Tag.ToString()) : 0;

      return Convert.ToInt16(Cost);
    }

    // checkboxs to handle TotalCost

    private void chbCleaning_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }
    private void chbXray_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbDiagnosis_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }


    private void chbPeroxide25_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbPeroxide40_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbCompositeFilling_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbPorcelainFilling_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbAmalgamFilling_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbSingleImplant_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbDoubleImplant_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbFullMouthImplants_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    
    private void chbSimpleExtraction_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbComplicatedExtrcation_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbComplexExtraction_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }

    private void chbWisdomExtarction_CheckStateChanged(object sender, EventArgs e)
    {
      CalcTotalCost();
    }


    // Update Summary 

    private void _UpdateSummary()
    {
      string Summarylable = "";

      if(chbCleaning.Checked)
      {
        Summarylable += "\tCleaning \t\t$10\n";
      }
      if(chbXray.Checked)
      {
        Summarylable += "\tX-ray \t\t$10\n";
      }
      if(chbDiagnosis.Checked)
      {
        Summarylable += "\tDiagnosis \t\t$15\n";
      }

      lbSummary.Text = Summarylable;
    }

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

    private void btnImplantation_Click(object sender, EventArgs e)
    {
      _Plan = enPlan.Implantation;
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

    private void HideAllPanels()
    {
      pnlDiagnosis.Visible = false;
      pnlExtaction.Visible = false;
      pnlRestoration.Visible = false;
      pnlImplantaion.Visible = false;
      pnlWhitening.Visible = false;
      pnlOrthopedic.Visible = false;
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
