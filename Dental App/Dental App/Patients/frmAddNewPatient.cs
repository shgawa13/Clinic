using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_App.Patients
{
  public partial class frmAddUpdatePatient : Form
  {
    private int _PatientID =-1;

    public frmAddUpdatePatient()
    {
      InitializeComponent();
    }

    public frmAddUpdatePatient(int PatientID)
    {
      InitializeComponent();
      _PatientID = PatientID;

    }
  }
}
