namespace Dental_App.Patients
{
  partial class frmAddNewPatient
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ctrlPatientCard1 = new Dental_App.Patients.controls.ctrlPatientCard();
      this.SuspendLayout();
      // 
      // ctrlPatientCard1
      // 
      this.ctrlPatientCard1.BackColor = System.Drawing.Color.DarkSlateBlue;
      this.ctrlPatientCard1.Location = new System.Drawing.Point(0, 0);
      this.ctrlPatientCard1.Name = "ctrlPatientCard1";
      this.ctrlPatientCard1.Size = new System.Drawing.Size(840, 406);
      this.ctrlPatientCard1.TabIndex = 0;
      // 
      // frmAddNewPatient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(841, 406);
      this.Controls.Add(this.ctrlPatientCard1);
      this.Name = "frmAddNewPatient";
      this.Text = "frmAddNewPatient";
      this.ResumeLayout(false);

    }

    #endregion

    private controls.ctrlPatientCard ctrlPatientCard1;
  }
}