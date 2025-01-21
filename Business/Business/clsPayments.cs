using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsPayments
  {
    public enum enMode { AddNew = 0 , Update=1}
    public enMode Mode = enMode.AddNew;

    public int PaymentID { set; get; }
    public DateTime PaymentDate { set; get; }
    public string PaymentMethod { set; get; }
    public decimal PaidAmount { set; get; }
    public string Notes { set; get; }

    public clsPayments()
    {
      this.PaymentID = -1;
      this.PaymentDate = DateTime.Now;
      this.PaymentMethod = "";
      this.PaidAmount = 0;
      this.Notes = "";

      Mode = enMode.AddNew;
    }

    private clsPayments(int PaymentID, DateTime PaymentDate, string PaymentMethod, decimal PaidAmount,string Notes)
    {
      this.PaymentID = PaymentID;
      this.PaymentDate = PaymentDate;
      this.PaymentMethod = PaymentMethod;
      this.PaidAmount = PaidAmount;
      this.Notes = Notes;

      Mode = enMode.Update;
    }

    // AddNew Payment
    private bool _AddNew()
    {
      this.PaymentID = clsPaymentsData.AddNewPayment(this.PaymentDate, this.PaymentMethod,
        this.PaidAmount, this.Notes);

      return (this.PaymentID != -1);
    }

    // Update Payment
    private bool _Update()
    {
      return clsPaymentsData.UpdatePayments(this.PaymentID, this.PaymentDate, this.PaymentMethod, this.PaidAmount, this.Notes);
    }

    // Delete Payment
    public static bool Delete(int PaymentID) => clsPaymentsData.Delete(PaymentID);

    // Find Payment by ID
    public static clsPayments Find(int PaymentID)
    {
      DateTime PaymentDate = DateTime.Now;
      string PaymentMethod = "";
      decimal PaidAmount = 0;
      string Notes = "";
      bool IsFound = clsPaymentsData.GetPaymentByID(PaymentID, ref PaymentDate,ref PaymentMethod,ref PaidAmount,ref Notes);

      if (IsFound)
        return new clsPayments(PaymentID,PaymentDate,PaymentMethod,PaidAmount,Notes);
      else
        return null;
    }

    // GetAllPayments
    public static DataTable GetAllPayments() =>clsPaymentsData.GetAllPayments();

    // IsExist
    public static bool IsExist(int PaymentID) => clsPaymentsData.IsPaymentIDExist(PaymentID);

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
