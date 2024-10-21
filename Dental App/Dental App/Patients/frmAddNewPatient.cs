using Business;
using Dental_App.Properties;
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
    public delegate void DataBackEventHandler(object sender, int PatientID);
    public event DataBackEventHandler DataBack;

    public enum enMode { AddNew = 0, Update = 1 };
    public enum enGendor { Male = 0, Female = 1 };

    private enMode _Mode;
    private int _PatientID =-1;
    clsPatient _Patient;
    clsPerson _Person;

    public frmAddUpdatePatient()
    {
      InitializeComponent();
      _Mode = enMode.AddNew;
    }

    public frmAddUpdatePatient(int PatientID)
    {
      InitializeComponent();
      _PatientID = PatientID;
      _Mode = enMode.Update;
    }

    // filling comboBox with countries
    private void _FillCountriesInComoboBox()
    {
      DataTable dataCountries = clsCountries.GetAllCountries();

      foreach (DataRow row in dataCountries.Rows)
      {
        cmbCountry.Items.Add(row["CountryName"]);
      }

    }

    // Reset Value
    private void _ResetDefualtValues()
    {
      _FillCountriesInComoboBox();
      if(_Mode == enMode.AddNew)
      {
        lblTitle.Text = "Add New Patient";
        _Person = new clsPerson();
        _Patient = new clsPatient();
      }
      else
      {
        lblTitle.Text = "Update Patient";
      }

      if (rbMale.Checked)
        pbAvatar.Image = Resources.Male_avatar;
      else
        pbAvatar.Image = Resources.Female_avatar;
      // hide Remove link incase there is no avatar.
      linkReomve.Visible = (pbAvatar.ImageLocation != null);

      txtbFirstName.Text = "";
      txtbSecondName.Text = "";
      txtbLastName.Text = "";
      txtbNationalID.Text = "";
      cmbCountry.SelectedIndex = cmbCountry.FindString("Bahrain");
      rbMale.Checked = true;
      txtbPhone.Text = "";
      txtbEmail.Text = "";


    }

    private void btnSave_Click(object sender, EventArgs e)
    {

    }

    private void linkChoseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }

    private void rbMale_CheckedChanged(object sender, EventArgs e)
    {
      if (pbAvatar.ImageLocation == null)
        pbAvatar.Image = Resources.Male_avatar;
    }

    private void rbFemal_CheckedChanged(object sender, EventArgs e)
    {
      if (pbAvatar.ImageLocation == null)
        pbAvatar.Image = Resources.Female_avatar;
    }
  }
}
