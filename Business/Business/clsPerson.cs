using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Business
{
  public class clsPerson
  {
    public enum enMode { AddNew = 0, Update = 1 }
    public enMode Mode = enMode.AddNew;
    public int PersonID { set; get; }
    public string NationalID { set; get; }
    public string FirstName { set; get; }
    public string SecondName { set; get; }
    public string LastName { set; get; }
    public DateTime DateOfBirth { set; get; }
    public byte Gendor { set; get; }
    public string PhoneNumber { set; get; }
    public string Email { set; get; }
    public string ImagePath { set; get; }
    public int NationalityCountryID { set; get; }

    public clsPerson()
    {
      this.PersonID = -1;
      this.NationalID = "";
      this.FirstName = "";
      this.SecondName = "";
      this.LastName = "";
      this.DateOfBirth = DateTime.Now;
      this.Gendor = 0;
      this.PhoneNumber = "";
      this.Email = "";
      this.ImagePath = "";
      this.NationalityCountryID = 0;
      Mode = enMode.AddNew;
    }

    private clsPerson(int PersonID, string NationalID, string FirstName, string SecondName, string LastName,
      DateTime DateOfBirth, byte Gendor, string PhoneNumber, string Email, string ImagePath, int NationalityCountryID)
    {
      this.PersonID = PersonID;
      this.NationalID = NationalID;
      this.FirstName = FirstName;
      this.SecondName = SecondName;
      this.LastName = LastName;
      this.DateOfBirth = DateOfBirth;
      this.Gendor = Gendor;
      this.PhoneNumber = PhoneNumber;
      this.Email = Email;
      this.ImagePath = ImagePath;
      this.NationalityCountryID = NationalityCountryID;
      Mode = enMode.Update;
    }

    // AddNewPerson
    private bool _AddNewPerson()
    {
      int PersonID = clsPersonData.AddNewPerson(this.NationalID,this.FirstName,this.SecondName,this.LastName,
            this.DateOfBirth,this.Gendor,this.PhoneNumber,this.Email,this.ImagePath,this.NationalityCountryID);

      return (PersonID != -1);
    }

    // Update PersonInfo
    private bool _UpdatePersonInfo() 
    {
      return clsPersonData.UpdatePersonInfo(this.PersonID,this.NationalID, this.FirstName, this.SecondName, 
                 this.LastName,this.DateOfBirth, this.Gendor, this.PhoneNumber, this.Email, this.ImagePath,
                 this.NationalityCountryID);
    }

    // Find Person By ID
    public static clsPerson Find(int PersonID)
    {
      string NationalID = "", FirstName = "", SecondName = "", LastName = "", PhoneNumber = "",
        Email = "", ImagePath = "";
      byte Gendor = 0;
      int NationalityCountryID = 0;
      DateTime DateOfBirth = DateTime.Now;

      bool IsFound = clsPersonData.GetPersonByID(PersonID, ref NationalID, ref FirstName, ref SecondName, ref LastName
        ,ref DateOfBirth, ref Gendor, ref PhoneNumber, ref Email, ref ImagePath,ref NationalityCountryID);

      if (IsFound)
      {
        return new clsPerson(PersonID, NationalID, FirstName, SecondName, LastName
        , DateOfBirth, Gendor, PhoneNumber, Email, ImagePath, NationalityCountryID);

      }
      else
      {
        return null;
      }
    }

    // Find Person By NationalID
    public static clsPerson Find(string NationalID)
    {
      int PersonID = -1;
      string FirstName = "", SecondName = "", LastName = "", PhoneNumber = "",
        Email = "", ImagePath = "";
      byte Gendor = 0;
      int NationalityCountryID = 0;
      DateTime DateOfBirth = DateTime.Now;

      bool IsFound = clsPersonData.GetPersonByNationalID(ref PersonID, ref FirstName, ref SecondName, ref LastName
        , ref DateOfBirth, ref Gendor, ref PhoneNumber, ref Email, ref ImagePath, ref NationalityCountryID);

      if (IsFound)
      {
        return new clsPerson(PersonID, NationalID, FirstName, SecondName, LastName
        , DateOfBirth, Gendor, PhoneNumber, Email, ImagePath, NationalityCountryID);

      }
      else
      {
        return null;
      }
    }

    // Find Person By PhoneNumber
    public static clsPerson FindByPhone(string PhoneNumber)
    {
      int PersonID = -1;
      string NationalID = "", FirstName = "", SecondName = "", LastName = "",
        Email = "", ImagePath = "";
      byte Gendor = 0;
      int NationalityCountryID = 0;
      DateTime DateOfBirth = DateTime.Now;

      bool IsFound = clsPersonData.GetPersonByID(PersonID, ref NationalID, ref FirstName, ref SecondName, ref LastName
        , ref DateOfBirth, ref Gendor, ref PhoneNumber, ref Email, ref ImagePath, ref NationalityCountryID);

      if (IsFound)
      {
        return new clsPerson(PersonID, NationalID, FirstName, SecondName, LastName
        , DateOfBirth, Gendor, PhoneNumber, Email, ImagePath, NationalityCountryID);

      }
      else
      {
        return null;
      }
    }

    // Callin Save insted of calling add and update functions
    public bool Save()
    {
      switch (Mode)
      {
        case enMode.AddNew:
          if (_AddNewPerson())
          {
            Mode = enMode.Update;
            return true;
          }
          else
          {
            return false;
          }
        case enMode.Update:
          return _UpdatePersonInfo();
      }
      return false;
    }

    // Get All People
    public static DataTable GetAllPeople() => clsPersonData.GetAllPeople();

    // Delete Person
    public static bool DeletePerson(int PersonID) => clsPersonData.DeletePerson(PersonID);

    // Is PersonID Exist
    public static bool IsExist(int PersonID) => clsPersonData.IsPersonExist(PersonID);

    // Is NationalID Exist
    public static bool IsExist(string NationalNo) => clsPersonData.IsPersonExist(NationalNo);
  }
}
