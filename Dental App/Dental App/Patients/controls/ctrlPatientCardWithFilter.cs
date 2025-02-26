using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_App.Patients.controls
{
  public partial class ctrlPatientCardWithFilter : UserControl
  {
    //public event Action<int> OnPatientSelected;

    //protected virtual void PatientSelected(int PatientID)
    //{
    //  Action<int> handler = OnPatientSelected;

    //  if(handler != null)
    //  {
    //    handler(PatientID);
    //  }
    //}


    public ctrlPatientCardWithFilter()
    {
      InitializeComponent();
    }

    public class PatientCardEventArgs : EventArgs
    {
      public int PatientID { get; }
      public clsPatient Patient { get; }

      public PatientCardEventArgs(int PatientID, clsPatient Patient)
      {
        this.PatientID = PatientID;
        this.Patient = Patient;
      }
    }



    private bool _FilterEnable = true;
    public bool FilterEnable
    {
      get { return _FilterEnable; }

      set
      {
        _FilterEnable = value;
        grbFilter.Enabled = _FilterEnable;
      }
    }

    private int _PatientID = -1;
    public int PatientID
    {
      get { return ctrlPatientCard1.PatientID; }
    }

    public clsPatient SelectedPatient
    {
      get { return ctrlPatientCard1.SelectedPatient; }
    }

    public event EventHandler<PatientCardEventArgs> OnPatientSelected;
    // funcation that will rais on PatientSelected
    public void RaisPatientSelected(int PatientID, clsPatient Patient)
    {

      OnPatientSelected?.Invoke(this, new PatientCardEventArgs(PatientID, Patient));
    }

    

    public bool LoadPatientInfo(int PatientID)
    {
      cbFilterBy.SelectedIndex = 0;
      txtFilterValue.Text = PatientID.ToString();
     return FindNow();
    }

    public bool LoadPatientInfo(string NationalID)
    {
      cbFilterBy.SelectedIndex = 1;
      txtFilterValue.Text = NationalID;
     return FindNow();
    }

    public bool FindNow()
    {
      bool IsFound = false;

      switch (cbFilterBy.Text) 
      {
        case "Patient ID":
         IsFound = ctrlPatientCard1.LoadPatientInfo(int.Parse(txtFilterValue.Text));
          break;

        case "National ID":
          IsFound = ctrlPatientCard1.LoadPatientInfo(txtFilterValue.Text);
          break;
      }


     
      if (OnPatientSelected != null && FilterEnable)
      {
        //// sending PatientID and Patient object as EventArgs
        OnPatientSelected(this,new PatientCardEventArgs(ctrlPatientCard1.PatientID, ctrlPatientCard1.SelectedPatient));
      }
      return IsFound;
    }

   

    // Validat inputs in Search box.

    private void txtFilterValue_Validating(object sender, CancelEventArgs e)
    {
      if (String.IsNullOrEmpty(txtFilterValue.Text.Trim()))
      {
        e.Cancel = true;
        errorProvider1.SetError(txtFilterValue, "You must enter PatientID");
        return;
      }
      else
      {
        errorProvider1.SetError(txtFilterValue, null);
      }
    }

    private void iconSearch_Click(object sender, EventArgs e)
    {
      FindNow();
    }

    private void ctrlPatientCard1_Load(object sender, EventArgs e)
    {

    }
  }
  
}
