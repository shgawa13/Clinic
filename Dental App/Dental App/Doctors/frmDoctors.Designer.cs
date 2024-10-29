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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tpListDoctors = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.panel3 = new System.Windows.Forms.Panel();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.dgvDoctors = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tpListDoctors.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel1.Controls.Add(this.lblDoctorNumbers);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 474);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 56);
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
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tpListDoctors);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabControl1.Location = new System.Drawing.Point(0, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(800, 472);
      this.tabControl1.TabIndex = 4;
      // 
      // tpListDoctors
      // 
      this.tpListDoctors.BackColor = System.Drawing.Color.Gainsboro;
      this.tpListDoctors.Controls.Add(this.dgvDoctors);
      this.tpListDoctors.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tpListDoctors.Location = new System.Drawing.Point(4, 29);
      this.tpListDoctors.Name = "tpListDoctors";
      this.tpListDoctors.Padding = new System.Windows.Forms.Padding(3);
      this.tpListDoctors.Size = new System.Drawing.Size(792, 439);
      this.tpListDoctors.TabIndex = 0;
      this.tpListDoctors.Text = "List Doctors";
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
      this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 439);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Add Doctors";
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Controls.Add(this.iconButton1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, -93);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(800, 95);
      this.panel3.TabIndex = 6;
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
      this.iconButton1.Location = new System.Drawing.Point(324, 3);
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
      // dgvDoctors
      // 
      this.dgvDoctors.AllowUserToAddRows = false;
      this.dgvDoctors.AllowUserToDeleteRows = false;
      this.dgvDoctors.AllowUserToOrderColumns = true;
      this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      this.dgvDoctors.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvDoctors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvDoctors.Size = new System.Drawing.Size(786, 433);
      this.dgvDoctors.TabIndex = 4;
      // 
      // frmDoctors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
      this.ClientSize = new System.Drawing.Size(800, 530);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "frmDoctors";
      this.Text = "frmDoctors";
      this.Load += new System.EventHandler(this.frmDoctors_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tpListDoctors.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblDoctorNumbers;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpListDoctors;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Panel panel3;
    private FontAwesome.Sharp.IconButton iconButton1;
    private System.Windows.Forms.DataGridView dgvDoctors;
  }
}