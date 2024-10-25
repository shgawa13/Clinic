namespace Dental_App.Doctors
{
  partial class frmDoctors
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
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtFilterValue = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.btnAddNewPatient = new FontAwesome.Sharp.IconButton();
      this.label2 = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(354, 162);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 26);
      this.label1.TabIndex = 0;
      this.label1.Text = "Doctors";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel2.Controls.Add(this.txtFilterValue);
      this.panel2.Controls.Add(this.cbFilter);
      this.panel2.Controls.Add(this.btnAddNewPatient);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(0, 197);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 56);
      this.panel2.TabIndex = 5;
      // 
      // txtFilterValue
      // 
      this.txtFilterValue.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.txtFilterValue.Location = new System.Drawing.Point(252, 14);
      this.txtFilterValue.Name = "txtFilterValue";
      this.txtFilterValue.Size = new System.Drawing.Size(160, 26);
      this.txtFilterValue.TabIndex = 3;
      // 
      // cbFilter
      // 
      this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFilter.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.cbFilter.FormattingEnabled = true;
      this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Patient ID",
            "Natinal ID",
            "Last Name",
            "Phone Number",
            "Email"});
      this.cbFilter.Location = new System.Drawing.Point(86, 13);
      this.cbFilter.Name = "cbFilter";
      this.cbFilter.Size = new System.Drawing.Size(153, 29);
      this.cbFilter.TabIndex = 2;
      // 
      // btnAddNewPatient
      // 
      this.btnAddNewPatient.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnAddNewPatient.BackColor = System.Drawing.Color.Snow;
      this.btnAddNewPatient.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAddNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddNewPatient.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddNewPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.btnAddNewPatient.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
      this.btnAddNewPatient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(134)))), ((int)(((byte)(223)))));
      this.btnAddNewPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btnAddNewPatient.IconSize = 36;
      this.btnAddNewPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnAddNewPatient.Location = new System.Drawing.Point(673, 3);
      this.btnAddNewPatient.Name = "btnAddNewPatient";
      this.btnAddNewPatient.Size = new System.Drawing.Size(112, 50);
      this.btnAddNewPatient.TabIndex = 1;
      this.btnAddNewPatient.Text = "AddNew";
      this.btnAddNewPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAddNewPatient.UseVisualStyleBackColor = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label2.Location = new System.Drawing.Point(12, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 21);
      this.label2.TabIndex = 0;
      this.label2.Text = "Find by:";
      // 
      // frmDoctors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.label1);
      this.Name = "frmDoctors";
      this.Text = "frmDoctors";
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtFilterValue;
    private System.Windows.Forms.ComboBox cbFilter;
    private FontAwesome.Sharp.IconButton btnAddNewPatient;
    private System.Windows.Forms.Label label2;
  }
}