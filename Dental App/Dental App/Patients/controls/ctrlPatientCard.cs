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
using System.IO;
using Dental_App.Properties;

namespace Dental_App.Patients.controls
{
  public partial class ctrlPatientCard : UserControl
  {

    public ctrlPatientCard()
    {
      InitializeComponent();
    }

   

    private int _PatientID;
    public int PatientID
    {
      get { return _PatientID; }
    }

    private clsPatient _Patient;
    public clsPatient SelectedPatient
    {
      get { return _Patient; }

      set { _Patient = value; }
     
    }


    public bool LoadPatientInfo(int pateintID)
    {
      _PatientID = pateintID;
      
      _Patient = clsPatient.FindPatientByID(_PatientID);
      if(_Patient == null)
      {
        ResetPersonInfo();
        MessageBox.Show("No Patient with ID. = " + _PatientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      SelectedPatient = _Patient;
      _FillPersonInfo();
      return true;
    }

    public bool LoadPatientInfo(string NationalID)
    {
      _Patient = clsPatient.FindPatientByNationalID(NationalID);
      if(_Patient == null)
      {
        ResetPersonInfo();
        MessageBox.Show("No Patient with NationalID. = " + NationalID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      SelectedPatient = _Patient;


      _FillPersonInfo();
      return true;
    }


    private void _FillPersonInfo()
    {
      lblPatientID.Text = _Patient.PatientID.ToString();
      lblFullName.Text = _Patient.PatientInfo.FullName;
      lblNationalID.Text = _Patient.PatientInfo.NationalID;
      lblDateOfBirth.Text = _Patient.PatientInfo.DateOfBirth.ToShortDateString();
      lblGendor.Text = (_Patient.PatientInfo.Gendor==0) ? "Male":"Female";
      lblPhone.Text = _Patient.PatientInfo.PhoneNumber;
      lblCountry.Text = clsCountries.Find(_Patient.PatientInfo.NationalityCountryID).CountryName;
      lblEmail.Text = _Patient.PatientInfo.Email;
       _LoadPersonImage();
    }

    // Handle Patient Image
    private void _LoadPersonImage()
    {
      if (_Patient.PatientInfo.Gendor == 0)
        pbAvatar.Image = Resources.Male_avatar;
      else
        pbAvatar.Image = Resources.Female_avatar;

      string ImagePath = _Patient.PatientInfo.ImagePath;
      if(ImagePath != "")
      {
        if (File.Exists(ImagePath))
          pbAvatar.ImageLocation = ImagePath;
        else
          MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Reset Value
    public void ResetPersonInfo()
    {
      lblPatientID.Text = "???";
      lblFullName.Text = "???";
      lblNationalID.Text = "???";
      lblDateOfBirth.Text = "???";
      lblGendor.Text = "???";
      lblPhone.Text = "???";
      lblCountry.Text = "???";
      lblEmail.Text = "???";

      pbAvatar.Image = Resources.Male_avatar;
    }

    private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Form frm = new frmAddUpdatePatient(_Patient.PatientID);
      frm.ShowDialog();
      // refreching
      LoadPatientInfo(_PatientID);
    }

 
  }

}
