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
      cbFilter.SelectedIndex = 0;

    }


    private void frmListPatients_Load(object sender, EventArgs e)
    {
      dgvPatients.DataSource = _dtPatients;

      lblPatientsNumbers.Text = dgvPatients.RowCount.ToString();
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtFilterValue.Visible = (cbFilter.Text != "None");
     
      if (txtFilterValue.Visible)
      {
        cbFilter.Text = "";
        cbFilter.Focus();
      }

    }

    private void txtFilterValue_TextChanged(object sender, EventArgs e)
    {
      // we can save case in FilterColumn string 
      string FilterColumn = "";
      //Map Selected Filter to real Column name 
      switch (cbFilter.Text)
      {
        case "Patient ID":
          FilterColumn = "PatientID";
          break;

        case "National ID":
          FilterColumn = "NationalID";
          break;

        case "Last Name":
          FilterColumn = "LastName";
          break;

        case "Phone Number":
          FilterColumn = "PhoneNumber";
          break;

        case "Email":
          FilterColumn = "Email";
          break;

        default:
          FilterColumn = "None";
          break;

      }

      //Reset the filters in case nothing selected or filter value conains nothing.
      if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
      {
        _dtPatients.DefaultView.RowFilter = "";
        lblPatientsNumbers.Text = _dtPatients.Rows.Count.ToString();
        return;
      }

      if (FilterColumn == "PatientID")
        // this will filter Numbers [PatientID]
        _dtPatients.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
      else
        // this will filter Strings [NationalID,Email,PhoneNumber,LastName]
        _dtPatients.DefaultView.RowFilter = string.Format("[{0}] LIKE'{1}%'", FilterColumn, txtFilterValue.Text.Trim());

      // here it will handle both string and Numbers
      lblPatientsNumbers.Text = _dtPatients.Rows.Count.ToString();
    }

    private void btnAddNewPatient_Click(object sender, EventArgs e)
    {
      frmAddUpdatePatient frm = new frmAddUpdatePatient();
      frm.DataBack += CallRefresh;
      frm.ShowDialog();
      
    }

    private void CallRefresh(object sender, int PatientID)
    {
      // refreshing
      _RefreshPatientsList();
    }

    private void tlsmShowInfo_Click(object sender, EventArgs e)
    {
      int PateintID = (int)dgvPatients.CurrentRow.Cells[0].Value;
      frmPatientInfo frm = new frmPatientInfo(PateintID);
      frm.ShowDialog();
      
      // refreshing
     //  _RefreshPatientsList();
    }

    private void tlsmEdit_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"ID: {(int)dgvPatients.CurrentRow.Cells[0].Value}");
    }

    
  }
}
