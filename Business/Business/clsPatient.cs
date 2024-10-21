using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsPatient: clsPerson
  {
    public enum enMode { AddNew = 0, Update = 1 }
    public enMode Mode = enMode.AddNew;
    public int PatientID { set; get; }
    public int PersonID { set; get; }
    public clsPerson PatientInfo;
    
    public clsPatient()
    {
      this.PatientID = -1;
      this.PersonID = -1;

      Mode = enMode.AddNew;
    }

    private clsPatient(int PatientID,int PersonID)
    {
      this.PatientID = PatientID;
      this.PersonID = PersonID;
      this.PatientInfo = clsPerson.Find(PersonID);

      Mode = enMode.Update;
    }

    private bool _AddNewPatient()
    {


      this.PatientID = clsPatientData.AddNewPatient(this.PersonID);
      return (this.PatientID != 0);
    }

    private bool _UpdatePatient()
    {
      return clsPatientData.UpdatePatient(this.PatientID,this.PersonID);
    }

    public bool DeletePatient(int PatientID) => clsPatientData.DeletePatient(PatientID);

    public static clsPatient FindPatientByID(int PatientID)
    {
      bool IsFound = false;
      int PersonID = -1;

      IsFound = clsPatientData.FindPatientByID(PatientID, ref PersonID);
      if (IsFound)
        return new clsPatient(PatientID, PersonID);
      else
        return null;
    }

    public static clsPatient FindPateintByPersonID(int PersonID)
    {
      bool IsFound = false;
      int PatientID = -1;

      IsFound = clsPatientData.FindPatientByID(PersonID,ref PatientID);
      if (IsFound)
        return new clsPatient(PatientID, PersonID);
      else
        return null;
    }

    // handle add and update call
    public bool Save()
    {       
      switch (Mode)
      {
        case enMode.AddNew:

          if (_AddNewPatient())
          {
            Mode = enMode.Update;
            return true;
          }
          else
          {
            return false;
          }

        case enMode.Update:
          return _UpdatePatient();
      }
      return false;
    }

    public static DataTable GetAllPatients() => clsPatientData.GetAllPatients();

  }
}
