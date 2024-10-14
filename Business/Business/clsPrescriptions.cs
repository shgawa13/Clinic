using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsPrescriptions
  {
    public enum enMode { AddNew=0, Update=1}
    public enMode Mode = enMode.AddNew;

    public int PerscriptionID { set; get; }
    public int MedicalRecordID { set; get; }
    public string MedicationName { set; get; }

    public clsPrescriptions()
    {
      this.PerscriptionID = -1;
      this.MedicalRecordID = -1;
      this.MedicationName = "";

      Mode = enMode.AddNew;
    }

    private clsPrescriptions(int PerscriptionID,int MedicalRecordID,string MedicationName)
    {
      this.PerscriptionID = PerscriptionID;
      this.MedicalRecordID = MedicalRecordID;
      this.MedicationName = MedicationName;

      Mode = enMode.Update;
    }



  }
}
