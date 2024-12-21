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
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblTitle = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.tbNote = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.iconNote = new FontAwesome.Sharp.IconButton();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label13 = new System.Windows.Forms.Label();
      this.cbLocation = new System.Windows.Forms.ComboBox();
      this.cbDoctor = new System.Windows.Forms.ComboBox();
      this.cbEndTime = new System.Windows.Forms.ComboBox();
      this.cbStartTime = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.iconLogo = new FontAwesome.Sharp.IconButton();
      this.iconButton3 = new FontAwesome.Sharp.IconButton();
      this.iconButton6 = new FontAwesome.Sharp.IconButton();
      this.iconStartTime = new FontAwesome.Sharp.IconButton();
      this.dtAppointmentDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
      this.label8 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.lblFullName = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblPhone = new System.Windows.Forms.Label();
      this.lblNationalNo = new System.Windows.Forms.Label();
      this.panelSearch = new System.Windows.Forms.Panel();
      this.iconSearch = new FontAwesome.Sharp.IconButton();
      this.tbSearch = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblPatinetID = new System.Windows.Forms.Label();
      this.iconButton4 = new FontAwesome.Sharp.IconButton();
      this.iconButton5 = new FontAwesome.Sharp.IconButton();
      this.iconButton2 = new FontAwesome.Sharp.IconButton();
      this.iconButton7 = new FontAwesome.Sharp.IconButton();
      this.label19 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.iconButton8 = new FontAwesome.Sharp.IconButton();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.label17 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnClose = new Dental_App.ExpertsBtn();
      this.btnSave = new Dental_App.ExpertsBtn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbNote)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panelSearch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.groupBox1.Controls.Add(this.lblTitle);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.tbNote);
      this.groupBox1.Controls.Add(this.iconNote);
      this.groupBox1.Controls.Add(this.splitContainer1);
      this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(0, 13);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(733, 465);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Appointmnet Info";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(278, 19);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(176, 25);
      this.lblTitle.TabIndex = 151;
      this.lblTitle.Text = "New Appointment";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label9.Location = new System.Drawing.Point(49, 343);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(52, 21);
      this.label9.TabIndex = 150;
      this.label9.Text = "Note:";
      // 
      // tbNote
      // 
      this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(156)))));
      this.tbNote.BeforeTouchSize = new System.Drawing.Size(604, 64);
      this.tbNote.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.tbNote.Location = new System.Drawing.Point(117, 343);
      this.tbNote.Multiline = true;
      this.tbNote.Name = "tbNote";
      this.tbNote.Size = new System.Drawing.Size(604, 64);
      this.tbNote.TabIndex = 149;
      // 
      // iconNote
      // 
      this.iconNote.FlatAppearance.BorderSize = 0;
      this.iconNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconNote.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconNote.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
      this.iconNote.IconColor = System.Drawing.Color.SteelBlue;
      this.iconNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconNote.IconSize = 31;
      this.iconNote.Location = new System.Drawing.Point(21, 343);
      this.iconNote.Name = "iconNote";
      this.iconNote.Size = new System.Drawing.Size(34, 27);
      this.iconNote.TabIndex = 148;
      this.iconNote.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(14, 53);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
      this.splitContainer1.Panel1.Controls.Add(this.label13);
      this.splitContainer1.Panel1.Controls.Add(this.cbLocation);
      this.splitContainer1.Panel1.Controls.Add(this.cbDoctor);
      this.splitContainer1.Panel1.Controls.Add(this.cbEndTime);
      this.splitContainer1.Panel1.Controls.Add(this.cbStartTime);
      this.splitContainer1.Panel1.Controls.Add(this.label5);
      this.splitContainer1.Panel1.Controls.Add(this.iconLogo);
      this.splitContainer1.Panel1.Controls.Add(this.iconButton3);
      this.splitContainer1.Panel1.Controls.Add(this.iconButton6);
      this.splitContainer1.Panel1.Controls.Add(this.iconStartTime);
      this.splitContainer1.Panel1.Controls.Add(this.dtAppointmentDate);
      this.splitContainer1.Panel1.Controls.Add(this.label8);
      this.splitContainer1.Panel1.Controls.Add(this.label12);
      this.splitContainer1.Panel1.Controls.Add(this.label16);
      this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
      this.splitContainer1.Panel2.Controls.Add(this.lblFullName);
      this.splitContainer1.Panel2.Controls.Add(this.lblEmail);
      this.splitContainer1.Panel2.Controls.Add(this.lblPhone);
      this.splitContainer1.Panel2.Controls.Add(this.lblNationalNo);
      this.splitContainer1.Panel2.Controls.Add(this.panelSearch);
      this.splitContainer1.Panel2.Controls.Add(this.label10);
      this.splitContainer1.Panel2.Controls.Add(this.label7);
      this.splitContainer1.Panel2.Controls.Add(this.label3);
      this.splitContainer1.Panel2.Controls.Add(this.lblPatinetID);
      this.splitContainer1.Panel2.Controls.Add(this.iconButton4);
      this.splitContainer1.Panel2.Controls.Add(this.iconButton5);
      this.splitContainer1.Panel2.Controls.Add(this.iconButton2);
      this.splitContainer1.Panel2.Controls.Add(this.iconButton7);
      this.splitContainer1.Panel2.Controls.Add(this.label19);
      this.splitContainer1.Panel2.Controls.Add(this.label18);
      this.splitContainer1.Panel2.Controls.Add(this.iconButton8);
      this.splitContainer1.Panel2.Controls.Add(this.iconButton1);
      this.splitContainer1.Panel2.Controls.Add(this.label17);
      this.splitContainer1.Size = new System.Drawing.Size(707, 281);
      this.splitContainer1.SplitterDistance = 136;
      this.splitContainer1.TabIndex = 19;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label13.Location = new System.Drawing.Point(363, 92);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(80, 21);
      this.label13.TabIndex = 150;
      this.label13.Text = "Location:";
      // 
      // cbLocation
      // 
      this.cbLocation.AllowDrop = true;
      this.cbLocation.DropDownHeight = 80;
      this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbLocation.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbLocation.FormattingEnabled = true;
      this.cbLocation.IntegralHeight = false;
      this.cbLocation.Items.AddRange(new object[] {
            "Room A1",
            "Room B1",
            "Room B2",
            "Room C1",
            "Room C2"});
      this.cbLocation.Location = new System.Drawing.Point(454, 88);
      this.cbLocation.Name = "cbLocation";
      this.cbLocation.Size = new System.Drawing.Size(176, 29);
      this.cbLocation.TabIndex = 149;
      // 
      // cbDoctor
      // 
      this.cbDoctor.AllowDrop = true;
      this.cbDoctor.DropDownHeight = 80;
      this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbDoctor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbDoctor.FormattingEnabled = true;
      this.cbDoctor.IntegralHeight = false;
      this.cbDoctor.Location = new System.Drawing.Point(117, 88);
      this.cbDoctor.Name = "cbDoctor";
      this.cbDoctor.Size = new System.Drawing.Size(209, 29);
      this.cbDoctor.TabIndex = 148;
      // 
      // cbEndTime
      // 
      this.cbEndTime.AllowDrop = true;
      this.cbEndTime.DropDownHeight = 80;
      this.cbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEndTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEndTime.FormattingEnabled = true;
      this.cbEndTime.IntegralHeight = false;
      this.cbEndTime.Location = new System.Drawing.Point(472, 50);
      this.cbEndTime.Name = "cbEndTime";
      this.cbEndTime.Size = new System.Drawing.Size(140, 29);
      this.cbEndTime.TabIndex = 147;
      // 
      // cbStartTime
      // 
      this.cbStartTime.AllowDrop = true;
      this.cbStartTime.DropDownHeight = 80;
      this.cbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbStartTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbStartTime.FormattingEnabled = true;
      this.cbStartTime.IntegralHeight = false;
      this.cbStartTime.Location = new System.Drawing.Point(135, 50);
      this.cbStartTime.Name = "cbStartTime";
      this.cbStartTime.Size = new System.Drawing.Size(142, 29);
      this.cbStartTime.TabIndex = 146;
      this.cbStartTime.SelectedIndexChanged += new System.EventHandler(this.cbStartTime_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(42, 54);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(92, 21);
      this.label5.TabIndex = 145;
      this.label5.Text = "Start Time:";
      // 
      // iconLogo
      // 
      this.iconLogo.FlatAppearance.BorderSize = 0;
      this.iconLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.UserMd;
      this.iconLogo.IconColor = System.Drawing.Color.SteelBlue;
      this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconLogo.IconSize = 31;
      this.iconLogo.Location = new System.Drawing.Point(8, 83);
      this.iconLogo.Name = "iconLogo";
      this.iconLogo.Size = new System.Drawing.Size(35, 35);
      this.iconLogo.TabIndex = 128;
      this.iconLogo.UseVisualStyleBackColor = true;
      // 
      // iconButton3
      // 
      this.iconButton3.FlatAppearance.BorderSize = 0;
      this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
      this.iconButton3.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton3.IconSize = 31;
      this.iconButton3.Location = new System.Drawing.Point(326, 48);
      this.iconButton3.Name = "iconButton3";
      this.iconButton3.Size = new System.Drawing.Size(34, 32);
      this.iconButton3.TabIndex = 144;
      this.iconButton3.UseVisualStyleBackColor = true;
      // 
      // iconButton6
      // 
      this.iconButton6.FlatAppearance.BorderSize = 0;
      this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Calendar;
      this.iconButton6.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton6.IconSize = 31;
      this.iconButton6.Location = new System.Drawing.Point(7, 7);
      this.iconButton6.Name = "iconButton6";
      this.iconButton6.Size = new System.Drawing.Size(34, 32);
      this.iconButton6.TabIndex = 143;
      this.iconButton6.UseVisualStyleBackColor = true;
      // 
      // iconStartTime
      // 
      this.iconStartTime.FlatAppearance.BorderSize = 0;
      this.iconStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconStartTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconStartTime.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
      this.iconStartTime.IconColor = System.Drawing.Color.SteelBlue;
      this.iconStartTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconStartTime.IconSize = 31;
      this.iconStartTime.Location = new System.Drawing.Point(8, 48);
      this.iconStartTime.Name = "iconStartTime";
      this.iconStartTime.Size = new System.Drawing.Size(34, 32);
      this.iconStartTime.TabIndex = 142;
      this.iconStartTime.UseVisualStyleBackColor = true;
      // 
      // dtAppointmentDate
      // 
      this.dtAppointmentDate.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.dtAppointmentDate.DateTimeIcon = null;
      this.dtAppointmentDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.dtAppointmentDate.Location = new System.Drawing.Point(112, 11);
      this.dtAppointmentDate.Name = "dtAppointmentDate";
      this.dtAppointmentDate.Size = new System.Drawing.Size(194, 29);
      this.dtAppointmentDate.TabIndex = 18;
      this.dtAppointmentDate.ToolTipText = "";
      this.dtAppointmentDate.Value = new System.DateTime(2024, 12, 12, 0, 0, 0, 0);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(45, 11);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(50, 21);
      this.label8.TabIndex = 4;
      this.label8.Text = "Date:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label12.Location = new System.Drawing.Point(45, 90);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(66, 21);
      this.label12.TabIndex = 12;
      this.label12.Text = "Doctor:";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label16.Location = new System.Drawing.Point(361, 54);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(85, 21);
      this.label16.TabIndex = 8;
      this.label16.Text = "End Time:";
      // 
      // lblFullName
      // 
      this.lblFullName.AutoSize = true;
      this.lblFullName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.lblFullName.Location = new System.Drawing.Point(341, 58);
      this.lblFullName.Name = "lblFullName";
      this.lblFullName.Size = new System.Drawing.Size(31, 21);
      this.lblFullName.TabIndex = 144;
      this.lblFullName.Text = "???";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.lblEmail.Location = new System.Drawing.Point(527, 111);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(31, 21);
      this.lblEmail.TabIndex = 146;
      this.lblEmail.Text = "???";
      // 
      // lblPhone
      // 
      this.lblPhone.AutoSize = true;
      this.lblPhone.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.lblPhone.Location = new System.Drawing.Point(331, 111);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(31, 21);
      this.lblPhone.TabIndex = 145;
      this.lblPhone.Text = "???";
      // 
      // lblNationalNo
      // 
      this.lblNationalNo.AutoSize = true;
      this.lblNationalNo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.lblNationalNo.Location = new System.Drawing.Point(135, 111);
      this.lblNationalNo.Name = "lblNationalNo";
      this.lblNationalNo.Size = new System.Drawing.Size(31, 21);
      this.lblNationalNo.TabIndex = 147;
      this.lblNationalNo.Text = "???";
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
      this.panelSearch.Size = new System.Drawing.Size(707, 41);
      this.panelSearch.TabIndex = 150;
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
      this.iconSearch.Location = new System.Drawing.Point(299, 6);
      this.iconSearch.Name = "iconSearch";
      this.iconSearch.Size = new System.Drawing.Size(42, 28);
      this.iconSearch.TabIndex = 151;
      this.iconSearch.UseVisualStyleBackColor = false;
      this.iconSearch.Click += new System.EventHandler(this.iconSearch_Click);
      // 
      // tbSearch
      // 
      this.tbSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
      this.tbSearch.Location = new System.Drawing.Point(159, 7);
      this.tbSearch.Name = "tbSearch";
      this.tbSearch.Size = new System.Drawing.Size(116, 26);
      this.tbSearch.TabIndex = 152;
      this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
      this.tbSearch.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearch_Validating);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.Black;
      this.label11.Location = new System.Drawing.Point(9, 10);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(150, 21);
      this.label11.TabIndex = 150;
      this.label11.Text = "Find by PatientID:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label10.Location = new System.Drawing.Point(29, 58);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(90, 21);
      this.label10.TabIndex = 149;
      this.label10.Text = "Patient ID:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(28, 61);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(90, 21);
      this.label7.TabIndex = 149;
      this.label7.Text = "Patient ID:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(245, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(92, 21);
      this.label3.TabIndex = 148;
      this.label3.Text = "Full Name:";
      // 
      // lblPatinetID
      // 
      this.lblPatinetID.AutoSize = true;
      this.lblPatinetID.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.lblPatinetID.Location = new System.Drawing.Point(125, 58);
      this.lblPatinetID.Name = "lblPatinetID";
      this.lblPatinetID.Size = new System.Drawing.Size(31, 21);
      this.lblPatinetID.TabIndex = 143;
      this.lblPatinetID.Text = "???";
      // 
      // iconButton4
      // 
      this.iconButton4.FlatAppearance.BorderSize = 0;
      this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ideal;
      this.iconButton4.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton4.IconSize = 25;
      this.iconButton4.Location = new System.Drawing.Point(7, 111);
      this.iconButton4.Name = "iconButton4";
      this.iconButton4.Size = new System.Drawing.Size(20, 21);
      this.iconButton4.TabIndex = 140;
      this.iconButton4.UseVisualStyleBackColor = true;
      // 
      // iconButton5
      // 
      this.iconButton5.FlatAppearance.BorderSize = 0;
      this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
      this.iconButton5.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton5.IconSize = 25;
      this.iconButton5.Location = new System.Drawing.Point(454, 109);
      this.iconButton5.Name = "iconButton5";
      this.iconButton5.Size = new System.Drawing.Size(19, 24);
      this.iconButton5.TabIndex = 142;
      this.iconButton5.UseVisualStyleBackColor = true;
      // 
      // iconButton2
      // 
      this.iconButton2.FlatAppearance.BorderSize = 0;
      this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
      this.iconButton2.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton2.IconSize = 25;
      this.iconButton2.Location = new System.Drawing.Point(215, 55);
      this.iconButton2.Name = "iconButton2";
      this.iconButton2.Size = new System.Drawing.Size(24, 27);
      this.iconButton2.TabIndex = 133;
      this.iconButton2.UseVisualStyleBackColor = true;
      // 
      // iconButton7
      // 
      this.iconButton7.FlatAppearance.BorderSize = 0;
      this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Phone;
      this.iconButton7.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton7.IconSize = 25;
      this.iconButton7.Location = new System.Drawing.Point(247, 105);
      this.iconButton7.Name = "iconButton7";
      this.iconButton7.Size = new System.Drawing.Size(20, 32);
      this.iconButton7.TabIndex = 141;
      this.iconButton7.UseVisualStyleBackColor = true;
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label19.Location = new System.Drawing.Point(28, 111);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(108, 21);
      this.label19.TabIndex = 5;
      this.label19.Text = "National No:";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label18.Location = new System.Drawing.Point(471, 111);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(57, 21);
      this.label18.TabIndex = 4;
      this.label18.Text = "Email:";
      // 
      // iconButton8
      // 
      this.iconButton8.FlatAppearance.BorderSize = 0;
      this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
      this.iconButton8.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton8.IconSize = 25;
      this.iconButton8.Location = new System.Drawing.Point(8, 55);
      this.iconButton8.Name = "iconButton8";
      this.iconButton8.Size = new System.Drawing.Size(18, 27);
      this.iconButton8.TabIndex = 139;
      this.iconButton8.UseVisualStyleBackColor = true;
      // 
      // iconButton1
      // 
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
      this.iconButton1.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 25;
      this.iconButton1.Location = new System.Drawing.Point(7, 55);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Size = new System.Drawing.Size(18, 27);
      this.iconButton1.TabIndex = 139;
      this.iconButton1.UseVisualStyleBackColor = true;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label17.Location = new System.Drawing.Point(272, 111);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(63, 21);
      this.label17.TabIndex = 3;
      this.label17.Text = "Phone:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(59, 316);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 21);
      this.label2.TabIndex = 148;
      this.label2.Text = "Note:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(45, 52);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(92, 21);
      this.label6.TabIndex = 6;
      this.label6.Text = "Start Time:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(55, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = "Patinet ID:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(54, 56);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(92, 21);
      this.label4.TabIndex = 2;
      this.label4.Text = "Full Name:";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
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
      this.btnClose.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.btnClose.Location = new System.Drawing.Point(589, 486);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(137, 37);
      this.btnClose.TabIndex = 115;
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
      this.btnSave.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.btnSave.Location = new System.Drawing.Point(429, 487);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(137, 37);
      this.btnSave.TabIndex = 114;
      this.btnSave.Text = "Save";
      this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // frmAddUpdateAppointmnet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
      this.ClientSize = new System.Drawing.Size(733, 526);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmAddUpdateAppointmnet";
      this.Text = "Appointmnet";
      this.Load += new System.EventHandler(this.frmAddUpdateAppointmnet_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbNote)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panelSearch.ResumeLayout(false);
      this.panelSearch.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label19;
    private Syncfusion.WinForms.Input.SfDateTimeEdit dtAppointmentDate;
    private FontAwesome.Sharp.IconButton iconButton2;
    private FontAwesome.Sharp.IconButton iconButton4;
    private FontAwesome.Sharp.IconButton iconButton7;
    private FontAwesome.Sharp.IconButton iconButton1;
    private FontAwesome.Sharp.IconButton iconStartTime;
    private FontAwesome.Sharp.IconButton iconButton6;
    private FontAwesome.Sharp.IconButton iconButton3;
    private FontAwesome.Sharp.IconButton iconLogo;
    private System.Windows.Forms.Label lblNationalNo;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Label lblFullName;
    private System.Windows.Forms.Label lblPatinetID;
    private FontAwesome.Sharp.IconButton iconNote;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbNote;
    private System.Windows.Forms.Label label2;
    private ExpertsBtn btnClose;
    private ExpertsBtn btnSave;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbEndTime;
    private System.Windows.Forms.ComboBox cbStartTime;
    private System.Windows.Forms.Panel panelSearch;
    private System.Windows.Forms.TextBox tbSearch;
    private System.Windows.Forms.Label label11;
    private FontAwesome.Sharp.IconButton iconSearch;
    private FontAwesome.Sharp.IconButton iconButton5;
    private System.Windows.Forms.Label label10;
    private FontAwesome.Sharp.IconButton iconButton8;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.ComboBox cbLocation;
    private System.Windows.Forms.ComboBox cbDoctor;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}