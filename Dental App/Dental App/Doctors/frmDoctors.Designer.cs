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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblDoctorNumbers = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tpcDoctors = new System.Windows.Forms.TabControl();
      this.tpbListDoctors = new System.Windows.Forms.TabPage();
      this.dgvDoctors = new System.Windows.Forms.DataGridView();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtFilterValue = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.btnAddNew = new Dental_App.ExpertsBtn();
      this.panel1.SuspendLayout();
      this.tpcDoctors.SuspendLayout();
      this.tpbListDoctors.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel1.Controls.Add(this.lblDoctorNumbers);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 493);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(872, 56);
      this.panel1.TabIndex = 3;
      // 
      // lblDoctorNumbers
      // 
      this.lblDoctorNumbers.AutoSize = true;
      this.lblDoctorNumbers.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDoctorNumbers.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblDoctorNumbers.Location = new System.Drawing.Point(87, 17);
      this.lblDoctorNumbers.Name = "lblDoctorNumbers";
      this.lblDoctorNumbers.Size = new System.Drawing.Size(37, 21);
      this.lblDoctorNumbers.TabIndex = 2;
      this.lblDoctorNumbers.Text = "???";
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
      // tpcDoctors
      // 
      this.tpcDoctors.Controls.Add(this.tpbListDoctors);
      this.tpcDoctors.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tpcDoctors.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tpcDoctors.Location = new System.Drawing.Point(0, 52);
      this.tpcDoctors.Name = "tpcDoctors";
      this.tpcDoctors.SelectedIndex = 0;
      this.tpcDoctors.Size = new System.Drawing.Size(872, 441);
      this.tpcDoctors.TabIndex = 4;
      // 
      // tpbListDoctors
      // 
      this.tpbListDoctors.BackColor = System.Drawing.Color.Gainsboro;
      this.tpbListDoctors.Controls.Add(this.dgvDoctors);
      this.tpbListDoctors.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tpbListDoctors.Location = new System.Drawing.Point(4, 29);
      this.tpbListDoctors.Name = "tpbListDoctors";
      this.tpbListDoctors.Padding = new System.Windows.Forms.Padding(3);
      this.tpbListDoctors.Size = new System.Drawing.Size(864, 408);
      this.tpbListDoctors.TabIndex = 0;
      this.tpbListDoctors.Text = "List Doctors";
      // 
      // dgvDoctors
      // 
      this.dgvDoctors.AllowUserToAddRows = false;
      this.dgvDoctors.AllowUserToDeleteRows = false;
      this.dgvDoctors.AllowUserToOrderColumns = true;
      this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvDoctors.Location = new System.Drawing.Point(3, 3);
      this.dgvDoctors.Name = "dgvDoctors";
      this.dgvDoctors.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      this.dgvDoctors.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvDoctors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvDoctors.Size = new System.Drawing.Size(858, 402);
      this.dgvDoctors.TabIndex = 4;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Controls.Add(this.iconButton1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, -117);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(872, 115);
      this.panel3.TabIndex = 6;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel2.Controls.Add(this.btnAddNew);
      this.panel2.Controls.Add(this.txtFilterValue);
      this.panel2.Controls.Add(this.cbFilter);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, -2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(872, 54);
      this.panel2.TabIndex = 7;
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
            "Doctor ID",
            "National ID",
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
      // iconButton1
      // 
      this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserMd;
      this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 55;
      this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.iconButton1.Location = new System.Drawing.Point(360, 13);
      this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.iconButton1.Size = new System.Drawing.Size(131, 86);
      this.iconButton1.TabIndex = 1;
      this.iconButton1.Text = "Doctors";
      this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.iconButton1.UseVisualStyleBackColor = true;
      // 
      // btnAddNew
      // 
      this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddNew.BackColor = System.Drawing.Color.DarkSlateBlue;
      this.btnAddNew.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
      this.btnAddNew.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnAddNew.BorderRadius = 5;
      this.btnAddNew.BorderSize = 0;
      this.btnAddNew.FlatAppearance.BorderSize = 0;
      this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddNew.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
      this.btnAddNew.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.btnAddNew.Location = new System.Drawing.Point(724, 4);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(137, 48);
      this.btnAddNew.TabIndex = 61;
      this.btnAddNew.Text = "Add New";
      this.btnAddNew.TextColor = System.Drawing.Color.WhiteSmoke;
      this.btnAddNew.UseVisualStyleBackColor = false;
      // 
      // frmDoctors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.ClientSize = new System.Drawing.Size(872, 549);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.tpcDoctors);
      this.Controls.Add(this.panel1);
      this.Name = "frmDoctors";
      this.Text = "frmDoctors";
      this.Load += new System.EventHandler(this.frmDoctors_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tpcDoctors.ResumeLayout(false);
      this.tpbListDoctors.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblDoctorNumbers;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tpcDoctors;
    private System.Windows.Forms.TabPage tpbListDoctors;
    private System.Windows.Forms.Panel panel3;
    private FontAwesome.Sharp.IconButton iconButton1;
    private System.Windows.Forms.DataGridView dgvDoctors;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtFilterValue;
    private System.Windows.Forms.ComboBox cbFilter;
    private System.Windows.Forms.Label label2;
    private ExpertsBtn btnAddNew;
  }
}