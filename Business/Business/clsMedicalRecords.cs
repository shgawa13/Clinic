using System;
using System.Collections.Generic;
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
  }
}
