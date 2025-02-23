namespace Dental_App.Patients.controls
{
  partial class ctrlPatientCardWithFilter
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.grbFilter = new System.Windows.Forms.Panel();
      this.cbFilterBy = new System.Windows.Forms.ComboBox();
      this.iconSearch = new FontAwesome.Sharp.IconButton();
      this.txtFilterValue = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.ctrlPatientCard1 = new Dental_App.Patients.controls.ctrlPatientCard();
      this.grbFilter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // grbFilter
      // 
      this.grbFilter.BackColor = System.Drawing.Color.Gainsboro;
      this.grbFilter.Controls.Add(this.cbFilterBy);
      this.grbFilter.Controls.Add(this.iconSearch);
      this.grbFilter.Controls.Add(this.txtFilterValue);
      this.grbFilter.Controls.Add(this.label11);
      this.grbFilter.Dock = System.Windows.Forms.DockStyle.Top;
      this.grbFilter.Location = new System.Drawing.Point(0, 0);
      this.grbFilter.Name = "grbFilter";
      this.grbFilter.Size = new System.Drawing.Size(619, 41);
      this.grbFilter.TabIndex = 151;
      // 
      // cbFilterBy
      // 
      this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFilterBy.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.cbFilterBy.FormattingEnabled = true;
      this.cbFilterBy.Items.AddRange(new object[] {
            "Patient ID",
            "National ID"});
      this.cbFilterBy.Location = new System.Drawing.Point(129, 6);
      this.cbFilterBy.Name = "cbFilterBy";
      this.cbFilterBy.Size = new System.Drawing.Size(142, 29);
      this.cbFilterBy.TabIndex = 153;
      // 
      // iconSearch
      // 
      this.iconSearch.BackColor = System.Drawing.Color.SlateBlue;
      this.iconSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
      this.iconSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
      this.iconSearch.IconColor = System.Drawing.Color.WhiteSmoke;
      this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconSearch.IconSize = 25;
      this.iconSearch.Location = new System.Drawing.Point(441, 4);
      this.iconSearch.Name = "iconSearch";
      this.iconSearch.Size = new System.Drawing.Size(49, 32);
      this.iconSearch.TabIndex = 151;
      this.iconSearch.UseVisualStyleBackColor = false;
      this.iconSearch.Click += new System.EventHandler(this.iconSearch_Click);
      // 
      // txtFilterValue
      // 
      this.txtFilterValue.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.txtFilterValue.Location = new System.Drawing.Point(290, 7);
      this.txtFilterValue.Name = "txtFilterValue";
      this.txtFilterValue.Size = new System.Drawing.Size(142, 26);
      this.txtFilterValue.TabIndex = 152;
      this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.Black;
      this.label11.Location = new System.Drawing.Point(9, 10);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(111, 21);
      this.label11.TabIndex = 150;
      this.label11.Text = "Find Patient:";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // ctrlPatientCard1
      // 
      this.ctrlPatientCard1.BackColor = System.Drawing.Color.Gainsboro;
      this.ctrlPatientCard1.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctrlPatientCard1.Location = new System.Drawing.Point(0, 41);
      this.ctrlPatientCard1.Name = "ctrlPatientCard1";
      this.ctrlPatientCard1.Size = new System.Drawing.Size(619, 317);
      this.ctrlPatientCard1.TabIndex = 152;
      this.ctrlPatientCard1.Load += new System.EventHandler(this.ctrlPatientCard1_Load);
      // 
      // ctrlPatientCardWithFilter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ctrlPatientCard1);
      this.Controls.Add(this.grbFilter);
      this.Name = "ctrlPatientCardWithFilter";
      this.Size = new System.Drawing.Size(619, 357);
      this.grbFilter.ResumeLayout(false);
      this.grbFilter.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel grbFilter;
    private FontAwesome.Sharp.IconButton iconSearch;
    private System.Windows.Forms.TextBox txtFilterValue;
    private System.Windows.Forms.Label label11;
    private ctrlPatientCard ctrlPatientCard1;
    private System.Windows.Forms.ComboBox cbFilterBy;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}
