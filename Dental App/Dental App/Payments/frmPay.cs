using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_App.Payments
{
  public partial class frmPay : Form
  {
    public enum enMode { AddNew=0, Update=1}
    public enMode Mode = enMode.AddNew;

    public enum enPaymentMethod { Cash=0, Card=1}
    
    private int _PaymentID =-1;
    public int PaymentID
    {
      get { return _PaymentID; }
      set {  _PaymentID = value; }
    }

    private clsPayments _Payment;

    // this will handle add new
    public frmPay()
    {
      InitializeComponent();
      Mode = enMode.AddNew;
    }

    // this will handle update
    public frmPay(int ID)
    {
      InitializeComponent();
      _PaymentID = ID;
      Mode = enMode.AddNew;
    }


    private void _ResetDefualtValues()
    {
      lblTitle.Text = "Add New Payment";
      lblID.Text = "????";
      lblDate.Text = DateTime.Now.ToShortDateString();
      tbNote.Clear();
    }

    private void _LoadData()
    {
      // if it's null then we return 
      _Payment = clsPayments.Find(_PaymentID);

      if (_Payment == null)
      {
        MessageBox.Show($"there is no Payment with {_PaymentID}",
          "Payment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.Close();
        return;
      }

      lblTitle.Text = "Update Payment";
      lblID.Text = _Payment.PaymentID.ToString();
      lblDate.Text = _Payment.PaymentDate.ToShortDateString();
      lblAmount.Text = _Payment.PaidAmount.ToString();

      cbPaymentMethod.SelectedIndex = _Payment.PaymentMethod;
      if (_Payment.Notes == null)
        tbNote.Text = "";
      else
        tbNote.Text = _Payment.Notes;


    }


    private void frmPay_Load(object sender, EventArgs e)
    {
      _ResetDefualtValues();
      if (Mode == enMode.Update)
        _LoadData();
    }

    
  }
}
