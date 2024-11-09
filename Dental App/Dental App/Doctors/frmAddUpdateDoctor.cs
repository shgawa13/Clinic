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

namespace Dental_App.Doctors
{
  public partial class frmAddUpdateDoctor : Form
  {
    public enum enMode { AddNew =0, Update }

    private int _DoctorID = -1;
    private enMode _Mode = enMode.AddNew;

    public frmAddUpdateDoctor()
    {
      InitializeComponent();
      _Mode = enMode.AddNew;
    }

    public frmAddUpdateDoctor(int ID)
    {
      InitializeComponent();

      _DoctorID = ID;
      _Mode = enMode.Update;
    }

    private void _FillSpecialityCombobox()
    {
      DataTable dtSpecialities = clsSpecialities.GetAllSpecialities();

      foreach(DataRow row in dtSpecialities.Rows)
      {
        cmbSpeciality.Items.Add(row["Title"]);
      }
    }

    private void frmAddUpdateDoctor_Load(object sender, EventArgs e)
    {
      _FillSpecialityCombobox();
    }
  }
}
