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
      this.panelSearch = new System.Windows.Forms.Panel();
      this.iconSearch = new FontAwesome.Sharp.IconButton();
      this.tbSearch = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.ctrlPatientCard1 = new Dental_App.Patients.controls.ctrlPatientCard();
      this.panelSearch.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelSearch
      // 
      this.panelSearch.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panelSearch.Controls.Add(this.iconSearch);
      this.panelSearch.Controls.Add(this.tbSearch);
      this.panelSearch.Controls.Add(this.label11);
      this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelSearch.Location = new System.Drawing.Point(0, 0);
      this.panelSearch.Name = "panelSearch";
      this.panelSearch.Size = new System.Drawing.Size(619, 41);
      this.panelSearch.TabIndex = 151;
      // 
      // iconSearch
      // 
      this.iconSearch.BackColor = System.Drawing.Color.Gainsboro;
      this.iconSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
      this.iconSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
      this.iconSearch.IconColor = System.Drawing.Color.SteelBlue;
      this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconSearch.IconSize = 25;
      this.iconSearch.Location = new System.Drawing.Point(336, 6);
      this.iconSearch.Name = "iconSearch";
      this.iconSearch.Size = new System.Drawing.Size(42, 28);
      this.iconSearch.TabIndex = 151;
      this.iconSearch.UseVisualStyleBackColor = false;
      // 
      // tbSearch
      // 
      this.tbSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.tbSearch.Location = new System.Drawing.Point(170, 7);
      this.tbSearch.Name = "tbSearch";
      this.tbSearch.Size = new System.Drawing.Size(142, 26);
      this.tbSearch.TabIndex = 152;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.Black;
      this.label11.Location = new System.Drawing.Point(9, 10);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(155, 21);
      this.label11.TabIndex = 150;
      this.label11.Text = "Find Patient by ID:";
      // 
      // ctrlPatientCard1
      // 
      this.ctrlPatientCard1.BackColor = System.Drawing.Color.Gainsboro;
      this.ctrlPatientCard1.Location = new System.Drawing.Point(0, 40);
      this.ctrlPatientCard1.Name = "ctrlPatientCard1";
      this.ctrlPatientCard1.Size = new System.Drawing.Size(626, 317);
      this.ctrlPatientCard1.TabIndex = 152;
      // 
      // ctrlPatientCardWithFilter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ctrlPatientCard1);
      this.Controls.Add(this.panelSearch);
      this.Name = "ctrlPatientCardWithFilter";
      this.Size = new System.Drawing.Size(619, 357);
      this.panelSearch.ResumeLayout(false);
      this.panelSearch.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelSearch;
    private FontAwesome.Sharp.IconButton iconSearch;
    private System.Windows.Forms.TextBox tbSearch;
    private System.Windows.Forms.Label label11;
    private ctrlPatientCard ctrlPatientCard1;
  }
}
