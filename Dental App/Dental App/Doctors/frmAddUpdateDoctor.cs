using Business;
using Dental_App.Global_Classes;
using Dental_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_App.Doctors
{
  public partial class frmAddUpdateDoctor : Form
  {
    // adding delegate
    public delegate void DataBackEventHandler(object sender, int DoctorID);
    public event DataBackEventHandler DataBack;

    public enum enMode { AddNew =0, Update }
    public enum enGendor { Male=0, Female=1}

    private int _DoctorID = -1;
    private enMode _Mode = enMode.AddNew;
    private clsPerson _Person;
    private clsDoctors _Doctor;

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
    // Filling ComboBox for Speciality and Countries.
    private void _FillSpecialitiesInComoboBox()
    {
      DataTable dtSpecialities = clsSpecialities.GetAllSpecialities();

      foreach(DataRow row in dtSpecialities.Rows)
      {
        cmbSpeciality.Items.Add(row["Title"]);
      }
    }

    private void _FillCountriesInComoboBox()
    {
      DataTable dataCountries = clsCountries.GetAllCountries();

      foreach (DataRow row in dataCountries.Rows)
      {
        cmbCountry.Items.Add(row["CountryName"]);
      }

    }

    private void _ResetDefualtValues()
    {
      _FillCountriesInComoboBox();
      _FillSpecialitiesInComoboBox();
      // Checking Mode
      if(_Mode == enMode.AddNew)
      {
        lblTitle.Text = "Add New Doctor";
        _Person = new clsPerson();
        _Doctor = new clsDoctors();
      }
      else
      {
        lblTitle.Text = "Update Doctor";

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
      _Doctor = clsDoctors.Find(_DoctorID);

      if (_Doctor == null)
      {
        MessageBox.Show($"there is no Doctor with {_DoctorID}", "Doctor Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.Close();
        return;
      }

      // now we load PersonInfo
      _Person = clsPerson.Find(_Doctor.PersonID);


      // here we fill info form the object
      lblDoctorID.Text = _Doctor.DoctorID.ToString();
      txtbFirstName.Text = _Person.FirstName;
      txtbSecondName.Text = _Person.SecondName;
      txtbLastName.Text = _Person.LastName;
      txtbNationalID.Text = _Person.NationalID;
      txtbPhone.Text = _Person.PhoneNumber;
      txtbEmail.Text = _Person.Email;

      // handle Gander
      if (_Person.Gendor == 0)
        rbMale.Checked = true;
      else
        rbFemal.Checked = true;
      //cmbCountry.SelectedIndex = cmbCountry.FindString(_Patient.CountryInfo.CountryName);
      cmbCountry.SelectedIndex = cmbCountry.FindString(_Person.CountryInfo.CountryName);
      cmbSpeciality.SelectedIndex = cmbSpeciality.FindString(_Doctor.SpecilityInfo.Title);
      if (_Person.ImagePath != "")
      {
        pbAvatar.ImageLocation = _Person.ImagePath;
      }

      linkReomve.Visible = (_Person.ImagePath != "");

    }


    // handle image Function is devided into  two parts:
    // (1) Delete old image incase was changed
    // (2) copy image from origanl Folder into project folder

    private bool _HandleImage()
    {
      // First we handle Delete Image 
      // we check if new image is not equle to image in picturebox
      if (_Person.ImagePath != pbAvatar.ImageLocation)
      {
        // now we make sure the image path is not empty so we don't get error
        if (_Person.ImagePath != "")
        {
          try
          {
            // now we can delete image
            File.Delete(_Person.ImagePath);

          }
          catch (IOException iox)
          {
            MessageBox.Show($"Something went worng we couldn't delete image: {iox.Message}", "Can't Delete Image",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        // copy image into project folder
        if (pbAvatar.ImageLocation != null)
        {
          string SourceImageFile = pbAvatar.ImageLocation.ToString();

          if (clsUtilities.CopyImageToProjectImages(ref SourceImageFile))
          {
            pbAvatar.ImageLocation = SourceImageFile;
            return true;
          }
          else
          {
            return false;
          }
        }

      }
      // we can return true in case image was only deleted
      return true;
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
      // we call handle image
      if (!_HandleImage())
        return;

      int NationalCountryID = clsCountries.Find(cmbCountry.Text).ID;
      byte SpecialityID = clsSpecialities.Find(cmbSpeciality.Text).ID;

      _Person.FirstName = txtbFirstName.Text.Trim();
      _Person.SecondName = txtbSecondName.Text.Trim();
      _Person.LastName = txtbLastName.Text.Trim();
      _Person.NationalID = txtbNationalID.Text.Trim();
      _Person.Email = txtbEmail.Text.Trim();
      _Person.DateOfBirth = dtpDateOfBirth.Value;
      _Person.PhoneNumber = txtbPhone.Text.Trim();

      if (rbMale.Checked)
        _Person.Gendor = (byte)enGendor.Male;
      else
        _Person.Gendor = (byte)enGendor.Female;

      _Person.NationalityCountryID = NationalCountryID;

      if (pbAvatar.ImageLocation != null)
        _Person.ImagePath = pbAvatar.ImageLocation;
      else
        _Person.ImagePath = "";

      if (_Person.Save())
      {
        _Doctor.PersonID = _Person.PersonID;
        _Doctor.SpecialityID = SpecialityID;

        if (_Doctor.Save())
        {
          _DoctorID = _Doctor.DoctorID;
          MessageBox.Show($"DoctorID: {_DoctorID}");
          lblDoctorID.Text = _DoctorID.ToString();
          //change form mode to update.
          _Mode = enMode.Update;
          lblTitle.Text = "Update Doctor";

          MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

          DataBack?.Invoke(this, _DoctorID);
        }
        //}
        else
        {
          MessageBox.Show("Error Couldn't Save Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

      }
    }

    private void frmAddUpdateDoctor_Load(object sender, EventArgs e)
    {
      _ResetDefualtValues();
      if (_Mode == enMode.Update)
        _LoadData();
    }

    private void linkReomve_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      // First we clear the Picture box 
      pbAvatar.ImageLocation = null;

      // now we handle the defualt avatar
      if (rbMale.Checked)
        pbAvatar.Image = Resources.Male_avatar;
      else
        pbAvatar.Image = Resources.Female_avatar;

      // we hide remove image link
      linkReomve.Visible = false;
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

    private void linkChoseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
      openFileDialog1.FilterIndex = 1;
      openFileDialog1.RestoreDirectory = true;

      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        // Process the selected file
        string selectedFilePath = openFileDialog1.FileName;
        pbAvatar.Load(selectedFilePath);
        linkReomve.Visible = true;
      }
    }
  }
}
