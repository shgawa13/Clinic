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
      "FullName", "Specialization", "DateOfBirth", "Gendor", "PhoneNumber", "Email", "ImagePath",
      "NationalityCountryID");

      dgvDoctors.DataSource = _dtDoctors;
      lblDoctorNumbers.Text = dgvDoctors.RowCount.ToString();
    }

    public frmDoctors()
    {
      InitializeComponent();
    }

    private void frmDoctors_Load(object sender, EventArgs e)
    {
      _RefreshDoctorList();
    }

   
  }
}
