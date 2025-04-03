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
using Dental_App.Appointmnets;
using Dental_App.Global_Classes;

namespace Dental_App.Patients
{
  public partial class frmListPatients : Form
  {
    private clsPatient _Patient;

    private static DataTable _dtAllPatients = clsPatient.GetAllPatients() ?? new DataTable();

    private DataTable _dtPatients = _dtAllPatients.Clone(); // Create structure copy

    //// show only colums in the Table
    //private DataTable _dtPatients = _dtAllPatients.DefaultView.ToTable(false,
    //  "PatientID", "NationalID", "FirstName", "SecondName", "LastName", "DateOfBirth", "Gendor",
    //  "PhoneNumber", "Email");

    public frmListPatients()
    {
      InitializeComponent();
      cbFilter.SelectedIndex = 0;

    }


    // here we will refresh the list 
    private void _RefreshPatientsList()
    {
      // Get data or empty table if null
      _dtAllPatients = clsPatient.GetAllPatients() ?? new DataTable();

      // we check if the table is empty or not
      cbFilter.Enabled = _HandleEmptyTable();
      lbPatientsDataTable.Visible = !cbFilter.Enabled;

      dgvPatients.DataSource = _dtPatients;
      lblPatientsNumbers.Text = dgvPatients.RowCount.ToString();

    }


    private void frmListPatients_Load(object sender, EventArgs e)
    {
      _RefreshPatientsList();

      // here we style the width of columns 
      if (cbFilter.Enabled)
      {
        dgvPatients.Columns[0].HeaderText = "PatientID";
        dgvPatients.Columns[0].Width = 65;

        dgvPatients.Columns[6].HeaderText = "Gendor";
        dgvPatients.Columns[6].Width = 60;
      }
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {

      txtFilterValue.Visible = (cbFilter.Text != "None") ;
     
      if (cbFilter.Visible)
      {
        txtFilterValue.Text = string.Empty;
        txtFilterValue.Focus();
      }

    }

    private bool _HandleEmptyTable()
    {
      if (_dtAllPatients.Rows.Count >0)
      {
        _dtPatients = _dtAllPatients.DefaultView.ToTable(false,
            "PatientID", "NationalID", "FirstName", "SecondName", "LastName",
            "DateOfBirth", "Gendor", "PhoneNumber", "Email");
        return true;
      }
      else
      {
        // Clear the table but maintain structure
        _dtPatients.Clear();
        return false;
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



    private void tlsmAddAppointment_Click(object sender, EventArgs e)
    {
      frmAddUpdateAppointmnet frm = new frmAddUpdateAppointmnet((int)dgvPatients.CurrentRow.Cells[0].Value);
      frm.ShowDialog();
    }

    private void tlsmUpdateAppointment_Click(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void tlsmShowPatientInfo_Click(object sender, EventArgs e)
    {
      int PateintID = (int)dgvPatients.CurrentRow.Cells[0].Value;
      frmPatientInfo frm = new frmPatientInfo(PateintID);
      frm.ShowDialog();

      // refreshing
      //  _RefreshPatientsList();

    }

    private void tlsmEdit_Click(object sender, EventArgs e)
    {
      frmAddUpdatePatient frm = new frmAddUpdatePatient((int)dgvPatients.CurrentRow.Cells[0].Value);
      frm.ShowDialog();

    }

    private void tlsmDeletePatient_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Are you sure to delete this patient", "Worinig", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      int PateintID = (int)dgvPatients.CurrentRow.Cells[0].Value;
      _Patient.DeletePatient(PateintID);

    }
  }
}
