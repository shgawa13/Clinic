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
    public string Specialization { set; get; }

    public clsDoctors()
    {
      this.DoctorID = -1;
      this.PersonID = -1;
      this.Specialization = "";
      Mode = enMode.AddNew; 
    }

    private clsDoctors(int DoctorID, int PersonID, string Specialization)
    {
      this.DoctorID = DoctorID;
      this.PersonID = PersonID;
      this.DoctorInfo = clsPerson.Find(PersonID);
      this.Specialization = Specialization;
      Mode = enMode.Update;
    }

    // Add new Doctor
    private bool _AddNewDoctor()
    {
      int DoctorID = clsDoctorsData.AddNewDoctor(this.PersonID, this.Specialization);

      return (DoctorID > 0);
    }

    // Update Doctor
    private bool _UpdateDoctor()
    {
      return clsDoctorsData.UpdateDoctors(this.DoctorID, this.PersonID, this.Specialization);
    }

    // Find Doctor
    public clsDoctors Find(int DoctorID)
    {
      int PersonID = -1;
      string Specialization = "";
      bool IsFound = clsDoctorsData.GetDoctorByID(DoctorID,ref PersonID,ref Specialization);

      if (IsFound)
        return new clsDoctors(DoctorID, PersonID, Specialization);
      else
        return null;
    }

    // Get All Doctors
    public DataTable GetAllDoctors()
    {
      DataTable dtAllDoctors = clsDoctorsData.GetAllDoctors();
      return dtAllDoctors;
    }

    // Delete Doctors
    public static bool _DeleteDoctor(int DoctorID) => clsDoctorsData.DeleteDoctor(DoctorID);


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
