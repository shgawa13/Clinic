namespace Dental_App.Patients
{
  partial class frmPatientInfo
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
      this.ctrlPatientCard1.BackColor = System.Drawing.Color.Gainsboro;
      this.ctrlPatientCard1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlPatientCard1.Location = new System.Drawing.Point(0, 0);
      this.ctrlPatientCard1.Name = "ctrlPatientCard1";
      this.ctrlPatientCard1.Size = new System.Drawing.Size(621, 317);
      this.ctrlPatientCard1.TabIndex = 0;
      // 
      // frmPatientInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(621, 317);
      this.Controls.Add(this.ctrlPatientCard1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmPatientInfo";
      this.Text = "Patient ";
      this.ResumeLayout(false);

    }

    #endregion

    private controls.ctrlPatientCard ctrlPatientCard1;
  }
}