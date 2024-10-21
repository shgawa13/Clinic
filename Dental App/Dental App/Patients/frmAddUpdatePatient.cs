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
    // Delegate function will return PatientID
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

    private void _LoadData()
    {
      _Patient = clsPatient.FindPatientByID(_PatientID);

      if(_Patient == null)
      {
        MessageBox.Show($"there is no Patient with {_PatientID}", "Patient Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.Close();
        return;
      }

      // here we fill info form the object
      lblPatientID.Text = _Patient.PatientID.ToString();
      txtbFirstName.Text = _Patient.PatientInfo.FirstName;
      txtbSecondName.Text = _Patient.PatientInfo.SecondName;
      txtbLastName.Text = _Patient.PatientInfo.LastName;
      txtbNationalID.Text = _Patient.PatientInfo.NationalID;
      txtbPhone.Text = _Patient.PatientInfo.PhoneNumber;
      txtbEmail.Text = _Patient.PatientInfo.Email;

      // handle Gander
      if (_Patient.PatientInfo.Gendor == 0)
        rbMale.Checked = true;
      else
        rbFemal.Checked = true;
      //cmbCountry.SelectedIndex = cmbCountry.FindString(_Patient.CountryInfo.CountryName);
      cmbCountry.SelectedIndex = cmbCountry.FindString(_Patient.PatientInfo.CountryInfo.CountryName);
      if (_Patient.PatientInfo.ImagePath != "")
      {
        pbAvatar.ImageLocation = _Patient.PatientInfo.ImagePath;
      }

      linkReomve.Visible = (_Patient.PatientInfo.ImagePath != "");

    }

    private void frmAddUpdatePatient_Load(object sender, EventArgs e)
    {
      _ResetDefualtValues();
      if (_Mode == enMode.Update)
        _LoadData();
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
