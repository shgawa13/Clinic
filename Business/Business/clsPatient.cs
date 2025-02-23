using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsPatient:clsPerson
  {
    public enum enMode { AddNew = 0, Update = 1 }
    public enMode Mode = enMode.AddNew;
    public int PatientID { set; get; }
    public int PersonID { set; get; }
    public clsPerson PatientInfo;
    
    public clsPatient()
    {
      this.PatientID = -1;
      this.PersonID = base.PersonID;
      
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

    /// <summary>
    ///  Find Patient By PatientID.
    /// </summary>
    /// <param name="PatientID"></param>
    /// <returns>Patient object</returns>
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

    /// <summary>
    /// Find Patient By PersonID.
    /// </summary>
    /// <param name="PersonID"></param>
    /// <returns>Patient object</returns>
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

    /// <summary>
    /// Find Patient by NationalID.
    /// </summary>
    /// <param name="NationalID"></param>
    /// <returns>Patient object</returns>
    public static clsPatient FindPatientByNationalID(string NationalID)
    {
      bool IsFound = false;
      int PatientID = -1,PersonID =-1;

      IsFound = clsPatientData.FindPatientByNationalID(NationalID, ref PatientID, ref PersonID);
      if (IsFound)
        return new clsPatient(PatientID, PersonID);
      else
        return null;
    }

    /// <summary>
    /// This will save Data After add or Updating PatientInfo. 
    /// </summary>
    /// <returns></returns>
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
