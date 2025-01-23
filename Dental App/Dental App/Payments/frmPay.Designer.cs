namespace Dental_App.Payments
{
  partial class frmPay
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
      this.lblTitle = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.iconButton6 = new FontAwesome.Sharp.IconButton();
      this.iconStartTime = new FontAwesome.Sharp.IconButton();
      this.label9 = new System.Windows.Forms.Label();
      this.tbNote = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.iconNote = new FontAwesome.Sharp.IconButton();
      this.lblAmount = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.payicon = new FontAwesome.Sharp.IconButton();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.iconID = new FontAwesome.Sharp.IconButton();
      this.lblID = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.btnSteps = new Dental_App.ExpertsBtn();
      this.expertsBtn2 = new Dental_App.ExpertsBtn();
      ((System.ComponentModel.ISupportInitialize)(this.tbNote)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.SystemColors.WindowText;
      this.lblTitle.Location = new System.Drawing.Point(170, 6);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(177, 25);
      this.lblTitle.TabIndex = 152;
      this.lblTitle.Text = "Add New Payment";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(93, 167);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 25);
      this.label1.TabIndex = 153;
      this.label1.Text = "Date :";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.Location = new System.Drawing.Point(167, 167);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(36, 25);
      this.lblDate.TabIndex = 154;
      this.lblDate.Text = "???";
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
      this.iconButton6.Location = new System.Drawing.Point(9, 163);
      this.iconButton6.Name = "iconButton6";
      this.iconButton6.Size = new System.Drawing.Size(34, 32);
      this.iconButton6.TabIndex = 156;
      this.iconButton6.UseVisualStyleBackColor = true;
      // 
      // iconStartTime
      // 
      this.iconStartTime.FlatAppearance.BorderSize = 0;
      this.iconStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconStartTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconStartTime.IconChar = FontAwesome.Sharp.IconChar.CircleDollarToSlot;
      this.iconStartTime.IconColor = System.Drawing.Color.SteelBlue;
      this.iconStartTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconStartTime.IconSize = 31;
      this.iconStartTime.Location = new System.Drawing.Point(9, 205);
      this.iconStartTime.Name = "iconStartTime";
      this.iconStartTime.Size = new System.Drawing.Size(34, 32);
      this.iconStartTime.TabIndex = 155;
      this.iconStartTime.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.label9.Location = new System.Drawing.Point(44, 307);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(52, 21);
      this.label9.TabIndex = 159;
      this.label9.Text = "Note:";
      // 
      // tbNote
      // 
      this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(156)))));
      this.tbNote.BeforeTouchSize = new System.Drawing.Size(408, 111);
      this.tbNote.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
      this.tbNote.Location = new System.Drawing.Point(97, 305);
      this.tbNote.Multiline = true;
      this.tbNote.Name = "tbNote";
      this.tbNote.Size = new System.Drawing.Size(408, 111);
      this.tbNote.TabIndex = 158;
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
      this.iconNote.Location = new System.Drawing.Point(12, 305);
      this.iconNote.Name = "iconNote";
      this.iconNote.Size = new System.Drawing.Size(29, 27);
      this.iconNote.TabIndex = 157;
      this.iconNote.UseVisualStyleBackColor = true;
      // 
      // lblAmount
      // 
      this.lblAmount.AutoSize = true;
      this.lblAmount.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAmount.Location = new System.Drawing.Point(167, 209);
      this.lblAmount.Name = "lblAmount";
      this.lblAmount.Size = new System.Drawing.Size(36, 25);
      this.lblAmount.TabIndex = 163;
      this.lblAmount.Text = "???";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(61, 209);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(95, 25);
      this.label4.TabIndex = 162;
      this.label4.Text = "Amount :";
      // 
      // payicon
      // 
      this.payicon.FlatAppearance.BorderSize = 0;
      this.payicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.payicon.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.payicon.IconChar = FontAwesome.Sharp.IconChar.Cog;
      this.payicon.IconColor = System.Drawing.Color.SteelBlue;
      this.payicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.payicon.IconSize = 31;
      this.payicon.Location = new System.Drawing.Point(9, 254);
      this.payicon.Name = "payicon";
      this.payicon.Size = new System.Drawing.Size(34, 32);
      this.payicon.TabIndex = 164;
      this.payicon.UseVisualStyleBackColor = true;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Dental_App.Properties.Resources.dollars;
      this.pictureBox1.Location = new System.Drawing.Point(183, 40);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(150, 69);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 166;
      this.pictureBox1.TabStop = false;
      // 
      // cbPaymentMethod
      // 
      this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPaymentMethod.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbPaymentMethod.FormattingEnabled = true;
      this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
      this.cbPaymentMethod.Location = new System.Drawing.Point(172, 258);
      this.cbPaymentMethod.Name = "cbPaymentMethod";
      this.cbPaymentMethod.Size = new System.Drawing.Size(193, 28);
      this.cbPaymentMethod.TabIndex = 167;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(44, 258);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 25);
      this.label2.TabIndex = 168;
      this.label2.Text = "P-Method :";
      // 
      // iconID
      // 
      this.iconID.FlatAppearance.BorderSize = 0;
      this.iconID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.iconID.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
      this.iconID.IconColor = System.Drawing.Color.SteelBlue;
      this.iconID.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconID.IconSize = 31;
      this.iconID.Location = new System.Drawing.Point(9, 123);
      this.iconID.Name = "iconID";
      this.iconID.Size = new System.Drawing.Size(34, 32);
      this.iconID.TabIndex = 169;
      this.iconID.UseVisualStyleBackColor = true;
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblID.Location = new System.Drawing.Point(166, 127);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(36, 25);
      this.lblID.TabIndex = 171;
      this.lblID.Text = "???";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(114, 127);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(42, 25);
      this.label5.TabIndex = 170;
      this.label5.Text = "ID :";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::Dental_App.Properties.Resources.dollars;
      this.pictureBox2.Location = new System.Drawing.Point(183, 40);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(150, 69);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 166;
      this.pictureBox2.TabStop = false;
      // 
      // btnSteps
      // 
      this.btnSteps.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.btnSteps.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
      this.btnSteps.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnSteps.BorderRadius = 5;
      this.btnSteps.BorderSize = 0;
      this.btnSteps.Enabled = false;
      this.btnSteps.FlatAppearance.BorderSize = 0;
      this.btnSteps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSteps.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSteps.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.btnSteps.Location = new System.Drawing.Point(240, 434);
      this.btnSteps.Name = "btnSteps";
      this.btnSteps.Size = new System.Drawing.Size(137, 45);
      this.btnSteps.TabIndex = 160;
      this.btnSteps.Text = "Save";
      this.btnSteps.TextColor = System.Drawing.Color.WhiteSmoke;
      this.btnSteps.UseVisualStyleBackColor = false;
      this.btnSteps.Click += new System.EventHandler(this.btnSteps_Click);
      // 
      // expertsBtn2
      // 
      this.expertsBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
      this.expertsBtn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
      this.expertsBtn2.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.expertsBtn2.BorderRadius = 5;
      this.expertsBtn2.BorderSize = 0;
      this.expertsBtn2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.expertsBtn2.FlatAppearance.BorderSize = 0;
      this.expertsBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.expertsBtn2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expertsBtn2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.expertsBtn2.Location = new System.Drawing.Point(383, 434);
      this.expertsBtn2.Name = "expertsBtn2";
      this.expertsBtn2.Size = new System.Drawing.Size(137, 45);
      this.expertsBtn2.TabIndex = 161;
      this.expertsBtn2.Text = "Close";
      this.expertsBtn2.TextColor = System.Drawing.Color.WhiteSmoke;
      this.expertsBtn2.UseVisualStyleBackColor = false;
      // 
      // frmPay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(532, 486);
      this.Controls.Add(this.lblID);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.iconID);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbPaymentMethod);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.payicon);
      this.Controls.Add(this.lblAmount);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnSteps);
      this.Controls.Add(this.expertsBtn2);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.tbNote);
      this.Controls.Add(this.iconNote);
      this.Controls.Add(this.iconButton6);
      this.Controls.Add(this.iconStartTime);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblTitle);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmPay";
      this.Text = "Payment ";
      this.Load += new System.EventHandler(this.frmPay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tbNote)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblDate;
    private FontAwesome.Sharp.IconButton iconButton6;
    private FontAwesome.Sharp.IconButton iconStartTime;
    private System.Windows.Forms.Label label9;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbNote;
    private FontAwesome.Sharp.IconButton iconNote;
    private ExpertsBtn btnSteps;
    private ExpertsBtn expertsBtn2;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.Label label4;
    private FontAwesome.Sharp.IconButton payicon;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ComboBox cbPaymentMethod;
    private System.Windows.Forms.Label label2;
    private FontAwesome.Sharp.IconButton iconID;
    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}