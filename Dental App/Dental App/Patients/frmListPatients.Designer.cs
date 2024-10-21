namespace Dental_App.Patients
{
  partial class frmListPatients
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblPatientsNumbers = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvPatients = new System.Windows.Forms.DataGridView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtFilterValue = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.btnAddNewPatient = new FontAwesome.Sharp.IconButton();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel1.Controls.Add(this.lblPatientsNumbers);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 474);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 56);
      this.panel1.TabIndex = 2;
      // 
      // lblPatientsNumbers
      // 
      this.lblPatientsNumbers.AutoSize = true;
      this.lblPatientsNumbers.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPatientsNumbers.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblPatientsNumbers.Location = new System.Drawing.Point(87, 16);
      this.lblPatientsNumbers.Name = "lblPatientsNumbers";
      this.lblPatientsNumbers.Size = new System.Drawing.Size(37, 21);
      this.lblPatientsNumbers.TabIndex = 2;
      this.lblPatientsNumbers.Text = "???";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label1.Location = new System.Drawing.Point(3, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "# Record: ";
      // 
      // dgvPatients
      // 
      this.dgvPatients.AllowUserToAddRows = false;
      this.dgvPatients.AllowUserToDeleteRows = false;
      this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dgvPatients.Location = new System.Drawing.Point(0, 56);
      this.dgvPatients.Name = "dgvPatients";
      this.dgvPatients.ReadOnly = true;
      this.dgvPatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvPatients.Size = new System.Drawing.Size(800, 418);
      this.dgvPatients.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel2.Controls.Add(this.txtFilterValue);
      this.panel2.Controls.Add(this.cbFilter);
      this.panel2.Controls.Add(this.btnAddNewPatient);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 56);
      this.panel2.TabIndex = 4;
      // 
      // txtFilterValue
      // 
      this.txtFilterValue.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.txtFilterValue.Location = new System.Drawing.Point(252, 14);
      this.txtFilterValue.Name = "txtFilterValue";
      this.txtFilterValue.Size = new System.Drawing.Size(160, 26);
      this.txtFilterValue.TabIndex = 3;
      this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
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
      this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
      // panel3
      // 
      this.panel3.Controls.Add(this.iconButton1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, -95);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(800, 95);
      this.panel3.TabIndex = 5;
      // 
      // iconButton1
      // 
      this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
      this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 70;
      this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.iconButton1.Location = new System.Drawing.Point(325, 9);
      this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.iconButton1.Size = new System.Drawing.Size(131, 77);
      this.iconButton1.TabIndex = 1;
      this.iconButton1.Text = "Patients";
      this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.iconButton1.UseVisualStyleBackColor = true;
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
      this.btnAddNewPatient.Click += new System.EventHandler(this.btnAddNewPatient_Click);
      // 
      // frmListPatients
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 530);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.dgvPatients);
      this.Controls.Add(this.panel1);
      this.Name = "frmListPatients";
      this.Text = "Patients List ";
      this.Load += new System.EventHandler(this.frmListPatients_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private FontAwesome.Sharp.IconButton iconButton1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dgvPatients;
    private System.Windows.Forms.Panel panel2;
    private FontAwesome.Sharp.IconButton btnAddNewPatient;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbFilter;
    private System.Windows.Forms.Label lblPatientsNumbers;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox txtFilterValue;
  }
}