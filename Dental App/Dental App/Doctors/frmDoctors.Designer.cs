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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblDoctorNumbers = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tpcDoctors = new System.Windows.Forms.TabControl();
      this.tpbListDoctors = new System.Windows.Forms.TabPage();
      this.dgvDoctors = new System.Windows.Forms.DataGridView();
      this.tpbAddDoctor = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnClose = new Dental_App.ExpertsBtn();
      this.btnSave = new Dental_App.ExpertsBtn();
      this.lblTitle = new System.Windows.Forms.Label();
      this.iconButton9 = new FontAwesome.Sharp.IconButton();
      this.linkChoseImage = new System.Windows.Forms.LinkLabel();
      this.linkReomve = new System.Windows.Forms.LinkLabel();
      this.pbAvatar = new System.Windows.Forms.PictureBox();
      this.cmbCountry = new System.Windows.Forms.ComboBox();
      this.rbFemal = new System.Windows.Forms.RadioButton();
      this.rbMale = new System.Windows.Forms.RadioButton();
      this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
      this.iconButton5 = new FontAwesome.Sharp.IconButton();
      this.iconButton6 = new FontAwesome.Sharp.IconButton();
      this.iconButton7 = new FontAwesome.Sharp.IconButton();
      this.iconButton8 = new FontAwesome.Sharp.IconButton();
      this.iconButton3 = new FontAwesome.Sharp.IconButton();
      this.iconButton4 = new FontAwesome.Sharp.IconButton();
      this.iconButton2 = new FontAwesome.Sharp.IconButton();
      this.iconButton10 = new FontAwesome.Sharp.IconButton();
      this.label3 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.txtbEmail = new System.Windows.Forms.TextBox();
      this.txtbPhone = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtbNationalID = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.txtbLastName = new System.Windows.Forms.TextBox();
      this.lblPatientID = new System.Windows.Forms.Label();
      this.txtbSecondName = new System.Windows.Forms.TextBox();
      this.txtbFirstName = new System.Windows.Forms.TextBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtFilterValue = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.tpcDoctors.SuspendLayout();
      this.tpbListDoctors.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
      this.tpbAddDoctor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
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
      this.tpcDoctors.Controls.Add(this.tpbAddDoctor);
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
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
      this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaption;
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle10;
      this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvDoctors.Location = new System.Drawing.Point(3, 3);
      this.dgvDoctors.Name = "dgvDoctors";
      this.dgvDoctors.ReadOnly = true;
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
      dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
      this.dgvDoctors.RowsDefaultCellStyle = dataGridViewCellStyle12;
      this.dgvDoctors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvDoctors.Size = new System.Drawing.Size(858, 402);
      this.dgvDoctors.TabIndex = 4;
      // 
      // tpbAddDoctor
      // 
      this.tpbAddDoctor.BackColor = System.Drawing.Color.DimGray;
      this.tpbAddDoctor.Controls.Add(this.label13);
      this.tpbAddDoctor.Controls.Add(this.textBox1);
      this.tpbAddDoctor.Controls.Add(this.btnClose);
      this.tpbAddDoctor.Controls.Add(this.btnSave);
      this.tpbAddDoctor.Controls.Add(this.lblTitle);
      this.tpbAddDoctor.Controls.Add(this.iconButton9);
      this.tpbAddDoctor.Controls.Add(this.linkChoseImage);
      this.tpbAddDoctor.Controls.Add(this.linkReomve);
      this.tpbAddDoctor.Controls.Add(this.pbAvatar);
      this.tpbAddDoctor.Controls.Add(this.cmbCountry);
      this.tpbAddDoctor.Controls.Add(this.rbFemal);
      this.tpbAddDoctor.Controls.Add(this.rbMale);
      this.tpbAddDoctor.Controls.Add(this.dtpDateOfBirth);
      this.tpbAddDoctor.Controls.Add(this.iconButton5);
      this.tpbAddDoctor.Controls.Add(this.iconButton6);
      this.tpbAddDoctor.Controls.Add(this.iconButton7);
      this.tpbAddDoctor.Controls.Add(this.iconButton8);
      this.tpbAddDoctor.Controls.Add(this.iconButton3);
      this.tpbAddDoctor.Controls.Add(this.iconButton4);
      this.tpbAddDoctor.Controls.Add(this.iconButton2);
      this.tpbAddDoctor.Controls.Add(this.iconButton10);
      this.tpbAddDoctor.Controls.Add(this.label3);
      this.tpbAddDoctor.Controls.Add(this.label6);
      this.tpbAddDoctor.Controls.Add(this.label7);
      this.tpbAddDoctor.Controls.Add(this.label8);
      this.tpbAddDoctor.Controls.Add(this.label4);
      this.tpbAddDoctor.Controls.Add(this.label9);
      this.tpbAddDoctor.Controls.Add(this.label10);
      this.tpbAddDoctor.Controls.Add(this.label11);
      this.tpbAddDoctor.Controls.Add(this.txtbEmail);
      this.tpbAddDoctor.Controls.Add(this.txtbPhone);
      this.tpbAddDoctor.Controls.Add(this.label5);
      this.tpbAddDoctor.Controls.Add(this.txtbNationalID);
      this.tpbAddDoctor.Controls.Add(this.label12);
      this.tpbAddDoctor.Controls.Add(this.txtbLastName);
      this.tpbAddDoctor.Controls.Add(this.lblPatientID);
      this.tpbAddDoctor.Controls.Add(this.txtbSecondName);
      this.tpbAddDoctor.Controls.Add(this.txtbFirstName);
      this.tpbAddDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
      this.tpbAddDoctor.Location = new System.Drawing.Point(4, 29);
      this.tpbAddDoctor.Name = "tpbAddDoctor";
      this.tpbAddDoctor.Padding = new System.Windows.Forms.Padding(3);
      this.tpbAddDoctor.Size = new System.Drawing.Size(864, 408);
      this.tpbAddDoctor.TabIndex = 1;
      this.tpbAddDoctor.Text = "Add Doctors";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(351, 273);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(170, 88);
      this.textBox1.TabIndex = 98;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
      this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
      this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnClose.BorderRadius = 5;
      this.btnClose.BorderSize = 0;
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
      this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.btnClose.Location = new System.Drawing.Point(698, 355);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(137, 37);
      this.btnClose.TabIndex = 97;
      this.btnClose.Text = "Close";
      this.btnClose.TextColor = System.Drawing.Color.WhiteSmoke;
      this.btnClose.UseVisualStyleBackColor = false;
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
      this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnSave.BorderRadius = 5;
      this.btnSave.BorderSize = 0;
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
      this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.btnSave.Location = new System.Drawing.Point(538, 355);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(137, 37);
      this.btnSave.TabIndex = 96;
      this.btnSave.Text = "Save";
      this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
      this.lblTitle.Location = new System.Drawing.Point(339, 3);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(194, 30);
      this.lblTitle.TabIndex = 95;
      this.lblTitle.Text = "Add New Doctor";
      // 
      // iconButton9
      // 
      this.iconButton9.FlatAppearance.BorderSize = 0;
      this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Tooth;
      this.iconButton9.IconColor = System.Drawing.Color.White;
      this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton9.IconSize = 75;
      this.iconButton9.Location = new System.Drawing.Point(405, 140);
      this.iconButton9.Name = "iconButton9";
      this.iconButton9.Size = new System.Drawing.Size(63, 76);
      this.iconButton9.TabIndex = 94;
      this.iconButton9.UseVisualStyleBackColor = true;
      // 
      // linkChoseImage
      // 
      this.linkChoseImage.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
      this.linkChoseImage.AutoSize = true;
      this.linkChoseImage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkChoseImage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.linkChoseImage.LinkColor = System.Drawing.Color.White;
      this.linkChoseImage.Location = new System.Drawing.Point(579, 301);
      this.linkChoseImage.Name = "linkChoseImage";
      this.linkChoseImage.Size = new System.Drawing.Size(109, 21);
      this.linkChoseImage.TabIndex = 93;
      this.linkChoseImage.TabStop = true;
      this.linkChoseImage.Text = "Chose Image";
      this.linkChoseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // linkReomve
      // 
      this.linkReomve.AutoSize = true;
      this.linkReomve.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkReomve.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.linkReomve.LinkColor = System.Drawing.SystemColors.ScrollBar;
      this.linkReomve.Location = new System.Drawing.Point(702, 301);
      this.linkReomve.Name = "linkReomve";
      this.linkReomve.Size = new System.Drawing.Size(124, 21);
      this.linkReomve.TabIndex = 92;
      this.linkReomve.TabStop = true;
      this.linkReomve.Text = "Remove Image";
      this.linkReomve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pbAvatar
      // 
      this.pbAvatar.Image = global::Dental_App.Properties.Resources.Female_avatar;
      this.pbAvatar.Location = new System.Drawing.Point(617, 109);
      this.pbAvatar.Name = "pbAvatar";
      this.pbAvatar.Size = new System.Drawing.Size(173, 174);
      this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbAvatar.TabIndex = 91;
      this.pbAvatar.TabStop = false;
      // 
      // cmbCountry
      // 
      this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCountry.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbCountry.FormattingEnabled = true;
      this.cmbCountry.Location = new System.Drawing.Point(115, 309);
      this.cmbCountry.Name = "cmbCountry";
      this.cmbCountry.Size = new System.Drawing.Size(163, 29);
      this.cmbCountry.TabIndex = 90;
      // 
      // rbFemal
      // 
      this.rbFemal.AutoSize = true;
      this.rbFemal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.rbFemal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbFemal.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.rbFemal.Location = new System.Drawing.Point(198, 215);
      this.rbFemal.Name = "rbFemal";
      this.rbFemal.Size = new System.Drawing.Size(85, 25);
      this.rbFemal.TabIndex = 89;
      this.rbFemal.Text = "Female";
      this.rbFemal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.rbFemal.UseVisualStyleBackColor = true;
      // 
      // rbMale
      // 
      this.rbMale.AutoSize = true;
      this.rbMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.rbMale.Checked = true;
      this.rbMale.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbMale.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.rbMale.Location = new System.Drawing.Point(115, 215);
      this.rbMale.Name = "rbMale";
      this.rbMale.Size = new System.Drawing.Size(66, 25);
      this.rbMale.TabIndex = 88;
      this.rbMale.TabStop = true;
      this.rbMale.Text = "Male";
      this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.rbMale.UseVisualStyleBackColor = true;
      // 
      // dtpDateOfBirth
      // 
      this.dtpDateOfBirth.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDateOfBirth.Location = new System.Drawing.Point(115, 167);
      this.dtpDateOfBirth.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
      this.dtpDateOfBirth.Name = "dtpDateOfBirth";
      this.dtpDateOfBirth.Size = new System.Drawing.Size(164, 26);
      this.dtpDateOfBirth.TabIndex = 87;
      this.dtpDateOfBirth.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
      // 
      // iconButton5
      // 
      this.iconButton5.FlatAppearance.BorderSize = 0;
      this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
      this.iconButton5.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton5.IconSize = 31;
      this.iconButton5.Location = new System.Drawing.Point(-42, 355);
      this.iconButton5.Name = "iconButton5";
      this.iconButton5.Size = new System.Drawing.Size(34, 32);
      this.iconButton5.TabIndex = 86;
      this.iconButton5.UseVisualStyleBackColor = true;
      // 
      // iconButton6
      // 
      this.iconButton6.FlatAppearance.BorderSize = 0;
      this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Globe;
      this.iconButton6.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton6.IconSize = 31;
      this.iconButton6.Location = new System.Drawing.Point(-42, 307);
      this.iconButton6.Name = "iconButton6";
      this.iconButton6.Size = new System.Drawing.Size(34, 32);
      this.iconButton6.TabIndex = 85;
      this.iconButton6.UseVisualStyleBackColor = true;
      // 
      // iconButton7
      // 
      this.iconButton7.FlatAppearance.BorderSize = 0;
      this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Phone;
      this.iconButton7.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton7.IconSize = 31;
      this.iconButton7.Location = new System.Drawing.Point(-42, 259);
      this.iconButton7.Name = "iconButton7";
      this.iconButton7.Size = new System.Drawing.Size(34, 32);
      this.iconButton7.TabIndex = 84;
      this.iconButton7.UseVisualStyleBackColor = true;
      // 
      // iconButton8
      // 
      this.iconButton8.FlatAppearance.BorderSize = 0;
      this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.User;
      this.iconButton8.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton8.IconSize = 31;
      this.iconButton8.Location = new System.Drawing.Point(-42, 211);
      this.iconButton8.Name = "iconButton8";
      this.iconButton8.Size = new System.Drawing.Size(34, 32);
      this.iconButton8.TabIndex = 83;
      this.iconButton8.UseVisualStyleBackColor = true;
      // 
      // iconButton3
      // 
      this.iconButton3.FlatAppearance.BorderSize = 0;
      this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Calendar;
      this.iconButton3.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton3.IconSize = 31;
      this.iconButton3.Location = new System.Drawing.Point(-42, 164);
      this.iconButton3.Name = "iconButton3";
      this.iconButton3.Size = new System.Drawing.Size(34, 32);
      this.iconButton3.TabIndex = 82;
      this.iconButton3.UseVisualStyleBackColor = true;
      // 
      // iconButton4
      // 
      this.iconButton4.FlatAppearance.BorderSize = 0;
      this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ideal;
      this.iconButton4.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton4.IconSize = 31;
      this.iconButton4.Location = new System.Drawing.Point(-42, 115);
      this.iconButton4.Name = "iconButton4";
      this.iconButton4.Size = new System.Drawing.Size(34, 32);
      this.iconButton4.TabIndex = 81;
      this.iconButton4.UseVisualStyleBackColor = true;
      // 
      // iconButton2
      // 
      this.iconButton2.FlatAppearance.BorderSize = 0;
      this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
      this.iconButton2.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton2.IconSize = 31;
      this.iconButton2.Location = new System.Drawing.Point(-42, 67);
      this.iconButton2.Name = "iconButton2";
      this.iconButton2.Size = new System.Drawing.Size(34, 32);
      this.iconButton2.TabIndex = 80;
      this.iconButton2.UseVisualStyleBackColor = true;
      // 
      // iconButton10
      // 
      this.iconButton10.FlatAppearance.BorderSize = 0;
      this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
      this.iconButton10.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton10.IconSize = 31;
      this.iconButton10.Location = new System.Drawing.Point(-42, 20);
      this.iconButton10.Name = "iconButton10";
      this.iconButton10.Size = new System.Drawing.Size(34, 32);
      this.iconButton10.TabIndex = 79;
      this.iconButton10.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label3.Location = new System.Drawing.Point(14, 361);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 21);
      this.label3.TabIndex = 78;
      this.label3.Text = "Email";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label6.Location = new System.Drawing.Point(14, 313);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 21);
      this.label6.TabIndex = 77;
      this.label6.Text = "Country";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label7.Location = new System.Drawing.Point(14, 265);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(59, 21);
      this.label7.TabIndex = 76;
      this.label7.Text = "Phone";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label8.Location = new System.Drawing.Point(14, 217);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(65, 21);
      this.label8.TabIndex = 75;
      this.label8.Text = "Gendor";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label4.Location = new System.Drawing.Point(14, 170);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(43, 21);
      this.label4.TabIndex = 74;
      this.label4.Text = "DOB";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label9.Location = new System.Drawing.Point(14, 121);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(88, 21);
      this.label9.TabIndex = 73;
      this.label9.Text = "Natinal ID";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label10.Location = new System.Drawing.Point(14, 73);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(89, 21);
      this.label10.TabIndex = 72;
      this.label10.Text = "FirstName";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label11.Location = new System.Drawing.Point(14, 26);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(75, 21);
      this.label11.TabIndex = 71;
      this.label11.Text = "DoctorID";
      // 
      // txtbEmail
      // 
      this.txtbEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbEmail.Location = new System.Drawing.Point(115, 358);
      this.txtbEmail.Name = "txtbEmail";
      this.txtbEmail.Size = new System.Drawing.Size(164, 26);
      this.txtbEmail.TabIndex = 70;
      // 
      // txtbPhone
      // 
      this.txtbPhone.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbPhone.Location = new System.Drawing.Point(115, 262);
      this.txtbPhone.Name = "txtbPhone";
      this.txtbPhone.Size = new System.Drawing.Size(164, 26);
      this.txtbPhone.TabIndex = 69;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label5.Location = new System.Drawing.Point(284, 73);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(111, 21);
      this.label5.TabIndex = 68;
      this.label5.Text = "SecondName";
      // 
      // txtbNationalID
      // 
      this.txtbNationalID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbNationalID.Location = new System.Drawing.Point(115, 118);
      this.txtbNationalID.Name = "txtbNationalID";
      this.txtbNationalID.Size = new System.Drawing.Size(164, 26);
      this.txtbNationalID.TabIndex = 67;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label12.Location = new System.Drawing.Point(564, 73);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(88, 21);
      this.label12.TabIndex = 66;
      this.label12.Text = "LastName";
      // 
      // txtbLastName
      // 
      this.txtbLastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbLastName.Location = new System.Drawing.Point(658, 70);
      this.txtbLastName.Name = "txtbLastName";
      this.txtbLastName.Size = new System.Drawing.Size(164, 26);
      this.txtbLastName.TabIndex = 65;
      // 
      // lblPatientID
      // 
      this.lblPatientID.AutoSize = true;
      this.lblPatientID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPatientID.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblPatientID.Location = new System.Drawing.Point(111, 26);
      this.lblPatientID.Name = "lblPatientID";
      this.lblPatientID.Size = new System.Drawing.Size(37, 21);
      this.lblPatientID.TabIndex = 64;
      this.lblPatientID.Text = "???";
      // 
      // txtbSecondName
      // 
      this.txtbSecondName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbSecondName.Location = new System.Drawing.Point(397, 70);
      this.txtbSecondName.Name = "txtbSecondName";
      this.txtbSecondName.Size = new System.Drawing.Size(164, 26);
      this.txtbSecondName.TabIndex = 63;
      // 
      // txtbFirstName
      // 
      this.txtbFirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbFirstName.Location = new System.Drawing.Point(115, 70);
      this.txtbFirstName.Name = "txtbFirstName";
      this.txtbFirstName.Size = new System.Drawing.Size(164, 26);
      this.txtbFirstName.TabIndex = 62;
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
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
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
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label13.Location = new System.Drawing.Point(393, 232);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(86, 21);
      this.label13.TabIndex = 99;
      this.label13.Text = "Speciality";
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
      this.tpbAddDoctor.ResumeLayout(false);
      this.tpbAddDoctor.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
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
    private System.Windows.Forms.TabPage tpbAddDoctor;
    private System.Windows.Forms.Panel panel3;
    private FontAwesome.Sharp.IconButton iconButton1;
    private System.Windows.Forms.DataGridView dgvDoctors;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtFilterValue;
    private System.Windows.Forms.ComboBox cbFilter;
    private System.Windows.Forms.Label label2;
    private ExpertsBtn btnClose;
    private ExpertsBtn btnSave;
    private System.Windows.Forms.Label lblTitle;
    private FontAwesome.Sharp.IconButton iconButton9;
    private System.Windows.Forms.LinkLabel linkChoseImage;
    private System.Windows.Forms.LinkLabel linkReomve;
    private System.Windows.Forms.PictureBox pbAvatar;
    private System.Windows.Forms.ComboBox cmbCountry;
    private System.Windows.Forms.RadioButton rbFemal;
    private System.Windows.Forms.RadioButton rbMale;
    private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    private FontAwesome.Sharp.IconButton iconButton5;
    private FontAwesome.Sharp.IconButton iconButton6;
    private FontAwesome.Sharp.IconButton iconButton7;
    private FontAwesome.Sharp.IconButton iconButton8;
    private FontAwesome.Sharp.IconButton iconButton3;
    private FontAwesome.Sharp.IconButton iconButton4;
    private FontAwesome.Sharp.IconButton iconButton2;
    private FontAwesome.Sharp.IconButton iconButton10;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtbEmail;
    private System.Windows.Forms.TextBox txtbPhone;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtbNationalID;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox txtbLastName;
    private System.Windows.Forms.Label lblPatientID;
    private System.Windows.Forms.TextBox txtbSecondName;
    private System.Windows.Forms.TextBox txtbFirstName;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label13;
  }
}