namespace Dental_App.Doctors
{
  partial class frmAddUpdateDoctor
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
      this.label13 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.linkChoseImage = new System.Windows.Forms.LinkLabel();
      this.linkReomve = new System.Windows.Forms.LinkLabel();
      this.cmbCountry = new System.Windows.Forms.ComboBox();
      this.rbFemal = new System.Windows.Forms.RadioButton();
      this.rbMale = new System.Windows.Forms.RadioButton();
      this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
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
      this.lblDoctorID = new System.Windows.Forms.Label();
      this.txtbSecondName = new System.Windows.Forms.TextBox();
      this.txtbFirstName = new System.Windows.Forms.TextBox();
      this.iconLogo = new FontAwesome.Sharp.IconButton();
      this.pbAvatar = new System.Windows.Forms.PictureBox();
      this.cmbSpeciality = new System.Windows.Forms.ComboBox();
      this.iconButton5 = new FontAwesome.Sharp.IconButton();
      this.iconButton6 = new FontAwesome.Sharp.IconButton();
      this.iconButton7 = new FontAwesome.Sharp.IconButton();
      this.iconButton8 = new FontAwesome.Sharp.IconButton();
      this.iconButton3 = new FontAwesome.Sharp.IconButton();
      this.iconButton4 = new FontAwesome.Sharp.IconButton();
      this.iconButton2 = new FontAwesome.Sharp.IconButton();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.iconSpeciality = new FontAwesome.Sharp.IconButton();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.btnClose = new Dental_App.ExpertsBtn();
      this.btnSave = new Dental_App.ExpertsBtn();
      ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
      this.SuspendLayout();
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label13.Location = new System.Drawing.Point(357, 280);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(86, 21);
      this.label13.TabIndex = 129;
      this.label13.Text = "Speciality";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
      this.lblTitle.Location = new System.Drawing.Point(381, 19);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(194, 30);
      this.lblTitle.TabIndex = 128;
      this.lblTitle.Text = "Add New Doctor";
      // 
      // linkChoseImage
      // 
      this.linkChoseImage.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
      this.linkChoseImage.AutoSize = true;
      this.linkChoseImage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkChoseImage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.linkChoseImage.LinkColor = System.Drawing.Color.White;
      this.linkChoseImage.Location = new System.Drawing.Point(621, 317);
      this.linkChoseImage.Name = "linkChoseImage";
      this.linkChoseImage.Size = new System.Drawing.Size(109, 21);
      this.linkChoseImage.TabIndex = 111;
      this.linkChoseImage.TabStop = true;
      this.linkChoseImage.Text = "Chose Image";
      this.linkChoseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.linkChoseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChoseImage_LinkClicked);
      // 
      // linkReomve
      // 
      this.linkReomve.AutoSize = true;
      this.linkReomve.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkReomve.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.linkReomve.LinkColor = System.Drawing.Color.DarkSalmon;
      this.linkReomve.Location = new System.Drawing.Point(744, 317);
      this.linkReomve.Name = "linkReomve";
      this.linkReomve.Size = new System.Drawing.Size(124, 21);
      this.linkReomve.TabIndex = 126;
      this.linkReomve.TabStop = true;
      this.linkReomve.Text = "Remove Image";
      this.linkReomve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.linkReomve.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReomve_LinkClicked);
      // 
      // cmbCountry
      // 
      this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCountry.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbCountry.FormattingEnabled = true;
      this.cmbCountry.Location = new System.Drawing.Point(157, 325);
      this.cmbCountry.Name = "cmbCountry";
      this.cmbCountry.Size = new System.Drawing.Size(163, 29);
      this.cmbCountry.TabIndex = 108;
      // 
      // rbFemal
      // 
      this.rbFemal.AutoSize = true;
      this.rbFemal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.rbFemal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbFemal.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.rbFemal.Location = new System.Drawing.Point(240, 231);
      this.rbFemal.Name = "rbFemal";
      this.rbFemal.Size = new System.Drawing.Size(85, 25);
      this.rbFemal.TabIndex = 106;
      this.rbFemal.Text = "Female";
      this.rbFemal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.rbFemal.UseVisualStyleBackColor = true;
      this.rbFemal.CheckedChanged += new System.EventHandler(this.rbFemal_CheckedChanged);
      // 
      // rbMale
      // 
      this.rbMale.AutoSize = true;
      this.rbMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.rbMale.Checked = true;
      this.rbMale.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbMale.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.rbMale.Location = new System.Drawing.Point(157, 231);
      this.rbMale.Name = "rbMale";
      this.rbMale.Size = new System.Drawing.Size(66, 25);
      this.rbMale.TabIndex = 105;
      this.rbMale.TabStop = true;
      this.rbMale.Text = "Male";
      this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.rbMale.UseVisualStyleBackColor = true;
      this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
      // 
      // dtpDateOfBirth
      // 
      this.dtpDateOfBirth.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDateOfBirth.Location = new System.Drawing.Point(157, 183);
      this.dtpDateOfBirth.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
      this.dtpDateOfBirth.Name = "dtpDateOfBirth";
      this.dtpDateOfBirth.Size = new System.Drawing.Size(164, 26);
      this.dtpDateOfBirth.TabIndex = 104;
      this.dtpDateOfBirth.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label3.Location = new System.Drawing.Point(56, 377);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 21);
      this.label3.TabIndex = 124;
      this.label3.Text = "Email";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label6.Location = new System.Drawing.Point(56, 329);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 21);
      this.label6.TabIndex = 123;
      this.label6.Text = "Country";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label7.Location = new System.Drawing.Point(56, 281);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(59, 21);
      this.label7.TabIndex = 122;
      this.label7.Text = "Phone";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label8.Location = new System.Drawing.Point(56, 233);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(65, 21);
      this.label8.TabIndex = 121;
      this.label8.Text = "Gendor";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label4.Location = new System.Drawing.Point(56, 186);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(43, 21);
      this.label4.TabIndex = 120;
      this.label4.Text = "DOB";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label9.Location = new System.Drawing.Point(56, 137);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(88, 21);
      this.label9.TabIndex = 119;
      this.label9.Text = "Natinal ID";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label10.Location = new System.Drawing.Point(56, 89);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(94, 21);
      this.label10.TabIndex = 118;
      this.label10.Text = "First Name";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label11.Location = new System.Drawing.Point(56, 42);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(75, 21);
      this.label11.TabIndex = 117;
      this.label11.Text = "DoctorID";
      // 
      // txtbEmail
      // 
      this.txtbEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbEmail.Location = new System.Drawing.Point(157, 374);
      this.txtbEmail.Name = "txtbEmail";
      this.txtbEmail.Size = new System.Drawing.Size(164, 26);
      this.txtbEmail.TabIndex = 109;
      // 
      // txtbPhone
      // 
      this.txtbPhone.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbPhone.Location = new System.Drawing.Point(157, 278);
      this.txtbPhone.Name = "txtbPhone";
      this.txtbPhone.Size = new System.Drawing.Size(164, 26);
      this.txtbPhone.TabIndex = 107;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label5.Location = new System.Drawing.Point(326, 89);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(113, 21);
      this.label5.TabIndex = 116;
      this.label5.Text = "Middle Name";
      // 
      // txtbNationalID
      // 
      this.txtbNationalID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbNationalID.Location = new System.Drawing.Point(157, 134);
      this.txtbNationalID.Name = "txtbNationalID";
      this.txtbNationalID.Size = new System.Drawing.Size(164, 26);
      this.txtbNationalID.TabIndex = 103;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label12.Location = new System.Drawing.Point(606, 89);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(93, 21);
      this.label12.TabIndex = 115;
      this.label12.Text = "Last Name";
      // 
      // txtbLastName
      // 
      this.txtbLastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbLastName.Location = new System.Drawing.Point(700, 86);
      this.txtbLastName.Name = "txtbLastName";
      this.txtbLastName.Size = new System.Drawing.Size(164, 26);
      this.txtbLastName.TabIndex = 102;
      // 
      // lblDoctorID
      // 
      this.lblDoctorID.AutoSize = true;
      this.lblDoctorID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDoctorID.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblDoctorID.Location = new System.Drawing.Point(153, 42);
      this.lblDoctorID.Name = "lblDoctorID";
      this.lblDoctorID.Size = new System.Drawing.Size(37, 21);
      this.lblDoctorID.TabIndex = 114;
      this.lblDoctorID.Text = "???";
      // 
      // txtbSecondName
      // 
      this.txtbSecondName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbSecondName.Location = new System.Drawing.Point(439, 86);
      this.txtbSecondName.Name = "txtbSecondName";
      this.txtbSecondName.Size = new System.Drawing.Size(164, 26);
      this.txtbSecondName.TabIndex = 101;
      // 
      // txtbFirstName
      // 
      this.txtbFirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbFirstName.Location = new System.Drawing.Point(157, 86);
      this.txtbFirstName.Name = "txtbFirstName";
      this.txtbFirstName.Size = new System.Drawing.Size(164, 26);
      this.txtbFirstName.TabIndex = 100;
      // 
      // iconLogo
      // 
      this.iconLogo.FlatAppearance.BorderSize = 0;
      this.iconLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.UserMd;
      this.iconLogo.IconColor = System.Drawing.Color.White;
      this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconLogo.IconSize = 80;
      this.iconLogo.Location = new System.Drawing.Point(482, 170);
      this.iconLogo.Name = "iconLogo";
      this.iconLogo.Size = new System.Drawing.Size(79, 76);
      this.iconLogo.TabIndex = 127;
      this.iconLogo.UseVisualStyleBackColor = true;
      // 
      // pbAvatar
      // 
      this.pbAvatar.Image = global::Dental_App.Properties.Resources.Female_avatar;
      this.pbAvatar.Location = new System.Drawing.Point(659, 125);
      this.pbAvatar.Name = "pbAvatar";
      this.pbAvatar.Size = new System.Drawing.Size(173, 174);
      this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbAvatar.TabIndex = 125;
      this.pbAvatar.TabStop = false;
      // 
      // cmbSpeciality
      // 
      this.cmbSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSpeciality.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbSpeciality.FormattingEnabled = true;
      this.cmbSpeciality.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.cmbSpeciality.Location = new System.Drawing.Point(440, 276);
      this.cmbSpeciality.Name = "cmbSpeciality";
      this.cmbSpeciality.Size = new System.Drawing.Size(163, 29);
      this.cmbSpeciality.TabIndex = 130;
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
      this.iconButton5.Location = new System.Drawing.Point(12, 372);
      this.iconButton5.Name = "iconButton5";
      this.iconButton5.Size = new System.Drawing.Size(34, 32);
      this.iconButton5.TabIndex = 138;
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
      this.iconButton6.Location = new System.Drawing.Point(12, 324);
      this.iconButton6.Name = "iconButton6";
      this.iconButton6.Size = new System.Drawing.Size(34, 32);
      this.iconButton6.TabIndex = 137;
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
      this.iconButton7.Location = new System.Drawing.Point(12, 276);
      this.iconButton7.Name = "iconButton7";
      this.iconButton7.Size = new System.Drawing.Size(34, 32);
      this.iconButton7.TabIndex = 136;
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
      this.iconButton8.Location = new System.Drawing.Point(12, 228);
      this.iconButton8.Name = "iconButton8";
      this.iconButton8.Size = new System.Drawing.Size(34, 32);
      this.iconButton8.TabIndex = 135;
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
      this.iconButton3.Location = new System.Drawing.Point(12, 181);
      this.iconButton3.Name = "iconButton3";
      this.iconButton3.Size = new System.Drawing.Size(34, 32);
      this.iconButton3.TabIndex = 134;
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
      this.iconButton4.Location = new System.Drawing.Point(12, 132);
      this.iconButton4.Name = "iconButton4";
      this.iconButton4.Size = new System.Drawing.Size(34, 32);
      this.iconButton4.TabIndex = 133;
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
      this.iconButton2.Location = new System.Drawing.Point(12, 84);
      this.iconButton2.Name = "iconButton2";
      this.iconButton2.Size = new System.Drawing.Size(34, 32);
      this.iconButton2.TabIndex = 132;
      this.iconButton2.UseVisualStyleBackColor = true;
      // 
      // iconButton1
      // 
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
      this.iconButton1.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 31;
      this.iconButton1.Location = new System.Drawing.Point(12, 37);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Size = new System.Drawing.Size(34, 32);
      this.iconButton1.TabIndex = 131;
      this.iconButton1.UseVisualStyleBackColor = true;
      // 
      // iconSpeciality
      // 
      this.iconSpeciality.FlatAppearance.BorderSize = 0;
      this.iconSpeciality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconSpeciality.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconSpeciality.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
      this.iconSpeciality.IconColor = System.Drawing.Color.SteelBlue;
      this.iconSpeciality.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconSpeciality.IconSize = 31;
      this.iconSpeciality.Location = new System.Drawing.Point(326, 274);
      this.iconSpeciality.Name = "iconSpeciality";
      this.iconSpeciality.Size = new System.Drawing.Size(34, 32);
      this.iconSpeciality.TabIndex = 139;
      this.iconSpeciality.UseVisualStyleBackColor = true;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
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
      this.btnClose.Location = new System.Drawing.Point(753, 371);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(137, 37);
      this.btnClose.TabIndex = 113;
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
      this.btnSave.Location = new System.Drawing.Point(593, 371);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(137, 37);
      this.btnSave.TabIndex = 112;
      this.btnSave.Text = "Save";
      this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // frmAddUpdateDoctor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
      this.ClientSize = new System.Drawing.Size(901, 432);
      this.Controls.Add(this.iconSpeciality);
      this.Controls.Add(this.iconButton5);
      this.Controls.Add(this.iconButton6);
      this.Controls.Add(this.iconButton7);
      this.Controls.Add(this.iconButton8);
      this.Controls.Add(this.iconButton3);
      this.Controls.Add(this.iconButton4);
      this.Controls.Add(this.iconButton2);
      this.Controls.Add(this.iconButton1);
      this.Controls.Add(this.cmbSpeciality);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.iconLogo);
      this.Controls.Add(this.linkChoseImage);
      this.Controls.Add(this.linkReomve);
      this.Controls.Add(this.pbAvatar);
      this.Controls.Add(this.cmbCountry);
      this.Controls.Add(this.rbFemal);
      this.Controls.Add(this.rbMale);
      this.Controls.Add(this.dtpDateOfBirth);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtbEmail);
      this.Controls.Add(this.txtbPhone);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtbNationalID);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.txtbLastName);
      this.Controls.Add(this.lblDoctorID);
      this.Controls.Add(this.txtbSecondName);
      this.Controls.Add(this.txtbFirstName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmAddUpdateDoctor";
      this.Text = "Add new Doctor";
      this.Load += new System.EventHandler(this.frmAddUpdateDoctor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label13;
    private ExpertsBtn btnClose;
    private ExpertsBtn btnSave;
    private System.Windows.Forms.Label lblTitle;
    private FontAwesome.Sharp.IconButton iconLogo;
    private System.Windows.Forms.LinkLabel linkChoseImage;
    private System.Windows.Forms.LinkLabel linkReomve;
    private System.Windows.Forms.PictureBox pbAvatar;
    private System.Windows.Forms.ComboBox cmbCountry;
    private System.Windows.Forms.RadioButton rbFemal;
    private System.Windows.Forms.RadioButton rbMale;
    private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
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
    private System.Windows.Forms.Label lblDoctorID;
    private System.Windows.Forms.TextBox txtbSecondName;
    private System.Windows.Forms.TextBox txtbFirstName;
    private System.Windows.Forms.ComboBox cmbSpeciality;
    private FontAwesome.Sharp.IconButton iconButton5;
    private FontAwesome.Sharp.IconButton iconButton6;
    private FontAwesome.Sharp.IconButton iconButton7;
    private FontAwesome.Sharp.IconButton iconButton8;
    private FontAwesome.Sharp.IconButton iconButton3;
    private FontAwesome.Sharp.IconButton iconButton4;
    private FontAwesome.Sharp.IconButton iconButton2;
    private FontAwesome.Sharp.IconButton iconButton1;
    private FontAwesome.Sharp.IconButton iconSpeciality;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}