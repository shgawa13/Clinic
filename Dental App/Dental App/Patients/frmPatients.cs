using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Dental_App.Patients
{
  public partial class frmListPatients : Form
  {
    private static DataTable _dtAllPatients = clsPatient.GetAllPatients();

    // show only colums in the Table
    private DataTable _dtPatients = _dtAllPatients.DefaultView.ToTable(false,
      "PatientID", "NationalID", "FirstName", "SecondName", "LastName", "DateOfBirth", "Gendor",
      "PhoneNumber", "Email", "ImagePath", "NationalityCountryID");

    // here we will refresh the list 
    private void _RefreshPatientsList()
    {
      _dtAllPatients = clsPatient.GetAllPatients();
      _dtPatients = _dtAllPatients.DefaultView.ToTable(false,
      "PatientID", "NationalID", "FirstName", "SecondName", "LastName", "DateOfBirth", "Gendor","PhoneNumber",
      "Email", "ImagePath", "NationalityCountryID");

      dgvPatients.DataSource = _dtPatients;
      lblPatientsNumbers.Text = dgvPatients.RowCount.ToString();

    }

      public frmListPatients()
    {
      InitializeComponent();
    }


    private void frmListPatients_Load(object sender, EventArgs e)
    {
      dgvPatients.DataSource = _dtPatients;


      lblPatientsNumbers.Text = dgvPatients.RowCount.ToString();
    }
  }
}
