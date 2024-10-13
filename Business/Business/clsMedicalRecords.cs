using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  internal class clsMedicalRecords
  {
    public enum enMode { AddNew = 0, Update = 1 }
    public enMode Mode = enMode.AddNew;

    public int MedicalRecordID { set; get; }
    public string VisitDescription { set; get; }
    public string Diagnosis { set; get; }
    public string AdditionalNotes { set; get; }

    public clsMedicalRecords()
    {
      this.MedicalRecordID = -1;
      this.VisitDescription = "";
      this.Diagnosis = "";
      this.AdditionalNotes = "";

      Mode = enMode.AddNew;
    }

    private clsMedicalRecords(int MedicalRecordID, string VisitDescription, string Diagnosis,
        string AdditionalNotes)
    {
      this.MedicalRecordID = MedicalRecordID;
      this.VisitDescription = VisitDescription;
      this.Diagnosis = Diagnosis;
      this.AdditionalNotes = AdditionalNotes;

      Mode = enMode.Update;
    }

    // AddNew MedicalRecord
    private bool _AddNew()
    {
      this.MedicalRecordID = clsMedicalRecordsData.AddNewMedicalRecord(this.VisitDescription, this.Diagnosis,
        this.AdditionalNotes);

      return (this.MedicalRecordID != -1);
    }

    // Update MedicalRecord
    private bool _Update()
    {
      return clsMedicalRecordsData.UpdateMedicalRecord(this.MedicalRecordID, this.VisitDescription,
             this.Diagnosis, this.AdditionalNotes);
    }

    // Delete MedicalRecord
    public static bool Delete(int MedicalRecordID) => clsMedicalRecordsData.Delete(MedicalRecordID);

    // Find MedicalRecord by ID
    public static clsMedicalRecords Find(int MedicalRecordID)
    {
      string VisitDescription = "", Diagnosis = "", AdditionalNotes = "";
      bool IsFound = clsMedicalRecordsData.GetMedicalRecordByID(MedicalRecordID,
           ref VisitDescription, ref Diagnosis, ref AdditionalNotes);

      if (IsFound)
        return new clsMedicalRecords(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes);
      else
        return null;
    }

    // GetAllMedicalRecords
    public static DataTable GetAllMedicalRecords() => clsMedicalRecordsData.GetAllMedicalRecords();

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
