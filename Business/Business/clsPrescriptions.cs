using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsPrescriptions
  {
    public enum enMode { AddNew=0, Update=1}
    public enMode Mode = enMode.AddNew;

    public int PrescriptionID { set; get; }
    public int MedicalRecordID { set; get; }
    public string MedicationName { set; get; }

    public clsPrescriptions()
    {
      this.PrescriptionID = -1;
      this.MedicalRecordID = -1;
      this.MedicationName = "";

      Mode = enMode.AddNew;
    }

    private clsPrescriptions(int PerscriptionID,int MedicalRecordID,string MedicationName)
    {
      this.PrescriptionID = PerscriptionID;
      this.MedicalRecordID = MedicalRecordID;
      this.MedicationName = MedicationName;

      Mode = enMode.Update;
    }


    // AddNew Prescription
    private bool _AddNew()
    {
      this.PrescriptionID = clsPrescriptionsData.AddNewPrescription(this.MedicalRecordID,this.MedicationName);

      return (this.PrescriptionID != -1);
    }

    // Update Prescription
    private bool _Update()
    {
      return clsPrescriptionsData.UpdatePerscription(this.PrescriptionID,this.MedicalRecordID,this.MedicationName);
    }

    // Delete Prescription
    public static bool Delete(int PrescriptionID) => clsPrescriptionsData.Delete(PrescriptionID);

    // Find Prescription by ID
    public static clsPrescriptions Find(int PrescriptionID)
    {
      int MedicalRecordID = -1;
      string MedicationName = "";
      bool IsFound = clsPrescriptionsData.GetPerscriptionByID(PrescriptionID,
        ref MedicalRecordID,ref MedicationName);

      if (IsFound)
        return new clsPrescriptions(PrescriptionID,MedicalRecordID,MedicationName);
      else
        return null;
    }

    // GetAllPrescriptions
    public static DataTable GetAllPrescriptions() => clsPrescriptionsData.GetAllPerscriptions();

    // IsExist
    public static bool IsExist(int PrescriptionID) => clsPrescriptionsData.IsPerscriptionIDExist(PrescriptionID);

    // Handle Add and Update calls
    public bool Save()
    {

      switch (Mode)
      {
        case enMode.AddNew:
          if (_AddNew())
          {
            Mode = enMode.Update;
            return true;
          }
          else
          {
            return false;
          }

        case enMode.Update:
          return _Update();
      }
      return false;
    }

  }
}
