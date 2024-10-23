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
    private int _PatientID;
    private clsPatient _Patient;

    public int PatientID
    {
      get { return _PatientID; }
    }

    public ctrlPatientCard()
    {
      InitializeComponent();
    }

    public void LoadPatientInfo(int PateintID)
    {
      _Patient = clsPatient.FindPatientByID(PatientID);
      if(_Patient == null)
      {
        ResetPersonInfo();
        MessageBox.Show("No Patient with ID. = " + _PatientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      _FillPersonInfo();
    }
   
    private void _FillPersonInfo()
    {
      lblPatientID.Text = _Patient.PatientID.ToString();
      lblFullName.Text = _Patient.FullName;
      lblNationalID.Text = _Patient.NationalID;
      lblDateOfBirth.Text = _Patient.DateOfBirth.ToString();
      lblGendor.Text = (_Patient.Gendor==0) ? "Male":"Female";
      lblPhone.Text = _Patient.PhoneNumber;
      lblCountry.Text = clsCountries.Find(_Patient.NationalityCountryID).CountryName;
      lblEmail.Text = _Patient.Email;
      // _LoadPersonImage();
    }

    // Handle Patient Image
    private void _LoadPersonImage()
    {
      if (_Patient.Gendor == 0)
        pbAvatar.Image = Resources.Male_avatar;
      else
        pbAvatar.Image = Resources.Female_avatar;

      string ImagePath = _Patient.ImagePath;
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
  }
}
