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
    // Delegate function will return PaymentID
    public delegate void DataBackEventHandler(object sender, int PaymentID);
    public event DataBackEventHandler DataBack;

    public enum enMode { AddNew=0, Update=1}
    public enMode Mode = enMode.AddNew;

    public enum enPaymentMethod { Cash=0, Card=1}

    private decimal _Amount;
    private int _PaymentID =-1;
    public int PaymentID
    {
      get { return _PaymentID; }
      set {  _PaymentID = value; }
    }

    private clsPayments _Payment;

    // this will handle add new
    public frmPay(decimal TotalBill)
    {
      InitializeComponent();
      _Amount = TotalBill;

      Mode = enMode.AddNew;
    }

    // this will handle update
    public frmPay(int ID, decimal TotalBill)
    {
      InitializeComponent();
      _PaymentID = ID;
      _Amount = TotalBill;

      Mode = enMode.Update;
    }


    private void _ResetDefualtValues()
    {
      if(Mode == enMode.AddNew)
      {
        lblTitle.Text = "Add New Payment";
        _Payment = new clsPayments();
      }
      else
      {
        lblTitle.Text = "Update Payment";
      }

      lblID.Text = "????";
      lblDate.Text = DateTime.Now.ToShortDateString();
      tbAmount.Text = _Amount.ToString();
      tbAmount.Focus();
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

      lblID.Text = _Payment.PaymentID.ToString();
      lblDate.Text = _Payment.PaymentDate.ToShortDateString();
      tbAmount.Text = _Payment.PaidAmount.ToString();

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

    private void btnSteps_Click(object sender, EventArgs e)
    {
      // Saving Payment

      _Payment.PaymentDate = DateTime.Now;
      _Payment.PaidAmount = _Amount;
      _Payment.PaymentMethod = (byte)cbPaymentMethod.SelectedIndex;

      if(tbNote.Text.Trim() != null)
      {

        _Payment.Notes = tbNote.Text.Trim();
      }
      else
      {
        _Payment.Notes = "";
      }


      if (_Payment.Save())
      {

        lblTitle.Text = "Update Payment";
        MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Mode = enMode.Update;

        DataBack?.Invoke(this, _PaymentID);

      }
      else
      {
        MessageBox.Show("Error Couldn't Save Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
    }

    // if input is not digit 
    private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      // handle numbers input
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    // handle txtBox Amount is not empty.
    private void tbAmount_Validating(object sender, CancelEventArgs e)
    {
      if (String.IsNullOrEmpty(tbAmount.Text.Trim()))
      {
        e.Cancel = true;
        errorProvider1.SetError(tbAmount, "You must enter PatientID");
        return;
      }
      else
      {
        errorProvider1.SetError(tbAmount, null);
      }
    }

    // this will handle if Paid amount less than totalCost  
    private void tbAmount_Leave(object sender, EventArgs e)
    {
      if (Convert.ToDecimal(tbAmount.Text.Trim()) != _Amount)
      {
        // tbNote.Text = 
      }
    }

  }
}
