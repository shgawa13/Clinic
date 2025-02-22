namespace Dental_App.Patients
{
  partial class testCard
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
      this.ctrlPatientCardWithFilter1 = new Dental_App.Patients.controls.ctrlPatientCardWithFilter();
      this.SuspendLayout();
      // 
      // ctrlPatientCardWithFilter1
      // 
      this.ctrlPatientCardWithFilter1.FilterEnable = true;
      this.ctrlPatientCardWithFilter1.Location = new System.Drawing.Point(2, 2);
      this.ctrlPatientCardWithFilter1.Name = "ctrlPatientCardWithFilter1";
      this.ctrlPatientCardWithFilter1.Size = new System.Drawing.Size(619, 357);
      this.ctrlPatientCardWithFilter1.TabIndex = 0;
      // 
      // testCard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(622, 363);
      this.Controls.Add(this.ctrlPatientCardWithFilter1);
      this.Name = "testCard";
      this.Text = "testCard";
      this.ResumeLayout(false);

    }

    #endregion

    private controls.ctrlPatientCardWithFilter ctrlPatientCardWithFilter1;
  }
}