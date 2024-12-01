namespace Dental_App.Doctors
{
  partial class frmAddUpdateAppointmnet
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
      this.SuspendLayout();
      // 
      // ShowRecurDialog
      // 
      this.ShowRecurDialog.Location = new System.Drawing.Point(568, 139);
      this.ShowRecurDialog.Click += new System.EventHandler(this.ShowRecurDialog_Click);
      // 
      // frmAddUpdateAppointmnet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1210, 522);
      this.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.Name = "frmAddUpdateAppointmnet";
      this.Text = "Add New Appointmnet";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
  }
}