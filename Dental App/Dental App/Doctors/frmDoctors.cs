using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dental_App.Doctors
{
  public partial class frmDoctors : Form
  {
    private static DataTable _dtAllDoctors = clsDoctors.GetAllDoctors();

    private DataTable _dtDoctors = _dtAllDoctors.DefaultView.ToTable(false, "DoctorID", "NationalID",
      "FullName", "Specialization", "DateOfBirth", "Gendor","PhoneNumber", "Email", "ImagePath",
      "NationalityCountryID");

    // here we will refresh the list 
    private void _RefreshDoctorList()
    {
      _dtAllDoctors = clsDoctors.GetAllDoctors();
      _dtDoctors = _dtAllDoctors.DefaultView.ToTable(false, "DoctorID", "NationalID",
      "FullName", "Specialization", "DateOfBirth", "Gendor", "PhoneNumber", "Email");

      dgvDoctors.DataSource = _dtDoctors;
      lblDoctorNumbers.Text = dgvDoctors.RowCount.ToString();
    }
    // DoctorID,NatioanlID,FullName,Spec,DateOfBirth,Gendor,PhoneNumber,Email
    public frmDoctors()
    {
      InitializeComponent();
    }

    private void frmDoctors_Load(object sender, EventArgs e)
    {
      _RefreshDoctorList();

      // here we style the width of columns
      dgvDoctors.Columns[0].HeaderText = "DoctorID";
      dgvDoctors.Columns[0].Width =80;

      dgvDoctors.Columns[1].HeaderText = "NationalID";
      dgvDoctors.Columns[1].Width = 120;

      dgvDoctors.Columns[2].HeaderText = "FullName";
      dgvDoctors.Columns[2].Width = 180;

      dgvDoctors.Columns[3].HeaderText = "Specialization";
      dgvDoctors.Columns[3].Width = 110;

      dgvDoctors.Columns[5].HeaderText ="Gendor";
      dgvDoctors.Columns[5].Width =60;

      cbFilter.SelectedIndex = 0;

    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
      // None
      // Doctor ID
      // National ID
      // Last Name
      // Phone Number
      // Email

      txtFilterValue.Visible = (cbFilter.Text !="None");

      if (cbFilter.Visible)
      {
        txtFilterValue.Text = string.Empty;
        txtFilterValue.Focus();
      }

    }

    private void txtFilterValue_TextChanged(object sender, EventArgs e)
    {
      // we can save case in FilterColumn string 
      string FilterColumn = "";
      //Map Selected Filter to real Column name
      switch (cbFilter.Text)
      {
        case "Doctor ID":
          FilterColumn = "DoctorID";
          break;

        case "National ID":
          FilterColumn = "NationalID";
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

      //Reset the filters in case nothing selected or filter value contains nothing.
      if(txtFilterValue.Text.Trim()=="" || FilterColumn == "None")
      {
        _dtDoctors.DefaultView.RowFilter = "";
        lblDoctorNumbers.Text = _dtDoctors.Rows.Count.ToString();
        return;
      }

      // Here we decide if we are searching for text or Numbers
      if(FilterColumn == "DoctorID")
        // this will filter Numbers [PatientID]
        _dtDoctors.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
      else
        _dtDoctors.DefaultView.RowFilter = string.Format("[{0}] LIKE'{1}%'", FilterColumn, txtFilterValue.Text.Trim());

      // Numbers will handle  both cases
      lblDoctorNumbers.Text = _dtDoctors.Rows.Count.ToString();

    }

    //| --------------------------------------------------------- |
    //| -------------------- Add New Doctor --------------------- |
    //| --------------------------------------------------------- |

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      frmAddUpdateDoctor frm = new frmAddUpdateDoctor();
      frm.DataBack += Frm_RefreshDoctors;
      frm.ShowDialog();
    }

    private void Frm_RefreshDoctors(object sender, int DoctorID)
    {
      _RefreshDoctorList();
    }
  }
}
