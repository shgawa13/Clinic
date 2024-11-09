using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace Business
{
  public class clsDoctors
  {
    public enum enMode { AddNew = 0, Update = 1 }
    public enMode Mode = enMode.AddNew;

    public int DoctorID { set; get; }
    public int PersonID { set; get; }
    public clsPerson DoctorInfo {  set; get; }
    public byte SpecialityID { set; get; }
    public clsSpecialities SpecilityInfo;


    public clsDoctors()
    {
      this.DoctorID = -1;
      this.PersonID = -1;
      this.SpecialityID = 0;

      Mode = enMode.AddNew; 
    }

    private clsDoctors(int DoctorID, int PersonID, byte SpecialityID)
    {
      this.DoctorID = DoctorID;
      this.PersonID = PersonID;
      this.DoctorInfo = clsPerson.Find(PersonID);
      this.SpecialityID = SpecialityID;
      this.SpecilityInfo = clsSpecialities.Find(SpecialityID);

      Mode = enMode.Update;
    }

    // Add new Doctor
    private bool _AddNewDoctor()
    {
      int DoctorID = clsDoctorsData.AddNewDoctor(this.PersonID, this.SpecialityID);

      return (this.DoctorID != 0);
    }

    // Update Doctor
    private bool _UpdateDoctor()
    {
      return clsDoctorsData.UpdateDoctors(this.DoctorID, this.PersonID, this.SpecialityID);
    }

    // Find Doctor
    public static clsDoctors Find(int DoctorID)
    {
      int PersonID = -1;
      byte SpecialityID = 0;
      bool IsFound = clsDoctorsData.GetDoctorByID(DoctorID,ref PersonID,ref SpecialityID);

      if (IsFound)
        return new clsDoctors(DoctorID, PersonID, SpecialityID);
      else
        return null;
    }

    // Get All Doctors
    public static DataTable GetAllDoctors()
    {
      DataTable dtAllDoctors = clsDoctorsData.GetAllDoctors();
      return dtAllDoctors;
    }

    // Delete Doctors
    public static bool DeleteDoctor(int DoctorID) => clsDoctorsData.DeleteDoctor(DoctorID);


    // handle Add and Update calls
    public bool Save()
    {
      switch (Mode)
      {
        case enMode.AddNew:

          if (_AddNewDoctor())
          {
            Mode = enMode.Update;
            return true;
          }
          else
          {
            return false;
          }

        case enMode.Update:
          return _UpdateDoctor();
      }
      return false;
    }

  }
}
