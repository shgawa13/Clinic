using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_App.Test
{
  public partial class frmTestCardWithFilter : Form
  {
    private int _PatientID { get; set; }

    public frmTestCardWithFilter()
    {
      InitializeComponent();

      ctrlPatientCardWithFilter1.OnPatientSelected += CtrlPatientCardWithFilter1_OnPatientSelected;
    }

    private void CtrlPatientCardWithFilter1_OnPatientSelected(object sender, Patients.controls.ctrlPatientCardWithFilter.PatientCardEventArgs e)
    {
      
        //_PatientID = ctrlPatientCardWithFilter1.PatientID;
        MessageBox.Show($"button has been clicked {e.PatientID}");

      
      
    }

    private void frmTestCardWithFilter_Load(object sender, EventArgs e)
    {
      

    }
  }
}
