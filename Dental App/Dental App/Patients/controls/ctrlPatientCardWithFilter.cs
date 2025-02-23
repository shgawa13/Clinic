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
    public event Action<int> OnPatientSelected;

    protected virtual void PatientSelected(int PatientID)
    {
      Action<int> handler = OnPatientSelected;

      if(handler != null)
      {
        handler(PatientID);
      }
    }

    public class PatientCardWithFilterEvent : EventArgs
    {
      public int ID { get; }
      
      public PatientCardWithFilterEvent(int id)
      {
        this.ID = id;
      }

    }

    public event EventHandler<PatientCardWithFilterEvent> OnPatientSelecte;

    public void RaisePatientSelected(int ID)
    {
      RaisePatientSelected(new PatientCardWithFilterEvent(ID));
    }

    protected virtual void RaisePatientSelected(PatientCardWithFilterEvent e)
    {
      OnPatientSelecte?.Invoke(this, e);
    }

    public ctrlPatientCardWithFilter()
    {
      InitializeComponent();
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

    public void LoadPatientInfo(int PatientID)
    {
      cbFilterBy.SelectedIndex = 0;
      txtFilterValue.Text = PatientID.ToString();
      FindNow();
    }

    public void LoadPatientInfo(string NationalID)
    {
      cbFilterBy.SelectedIndex = 1;
      txtFilterValue.Text = NationalID;
      FindNow();
    }

    public void FindNow()
    {
      switch (cbFilterBy.Text) 
      {
        case "Patient ID":
          ctrlPatientCard1.LoadPatientInfo(int.Parse(txtFilterValue.Text));
          break;

        case "National ID":
          ctrlPatientCard1.LoadPatientInfo(txtFilterValue.Text);
          break;
      }

      if (OnPatientSelected != null && FilterEnable)
      {
        OnPatientSelected(ctrlPatientCard1.PatientID);
      }

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

    
  }
}
