namespace Dental_App.Doctors
{
  partial class frmTest
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
      this.expertsBtn1 = new Dental_App.ExpertsBtn();
      this.SuspendLayout();
      // 
      // expertsBtn1
      // 
      this.expertsBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.expertsBtn1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
      this.expertsBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.expertsBtn1.BorderRadius = 20;
      this.expertsBtn1.BorderSize = 0;
      this.expertsBtn1.FlatAppearance.BorderSize = 0;
      this.expertsBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.expertsBtn1.ForeColor = System.Drawing.Color.White;
      this.expertsBtn1.Location = new System.Drawing.Point(323, 186);
      this.expertsBtn1.Name = "expertsBtn1";
      this.expertsBtn1.Size = new System.Drawing.Size(137, 49);
      this.expertsBtn1.TabIndex = 0;
      this.expertsBtn1.Text = "expertsBtn1";
      this.expertsBtn1.TextColor = System.Drawing.Color.White;
      this.expertsBtn1.UseVisualStyleBackColor = false;
      this.expertsBtn1.Click += new System.EventHandler(this.expertsBtn1_Click);
      // 
      // frmTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.expertsBtn1);
      this.Name = "frmTest";
      this.Text = "frmTest";
      this.Load += new System.EventHandler(this.frmTest_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private ExpertsBtn expertsBtn1;
  }
}