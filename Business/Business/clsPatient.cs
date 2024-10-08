using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsPatient
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

      return (PatientID > 0);
    }

    private bool DeletePatient(int PatientID)
    {
      return false;
    }

  }
}
