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
      this.label1 = new System.Windows.Forms.Label();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.panel2 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.label1.Location = new System.Drawing.Point(353, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 26);
      this.label1.TabIndex = 0;
      this.label1.Text = "Patients";
      // 
      // iconButton1
      // 
      this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
      this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 70;
      this.iconButton1.Location = new System.Drawing.Point(335, 15);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Size = new System.Drawing.Size(131, 48);
      this.iconButton1.TabIndex = 1;
      this.iconButton1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 394);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 56);
      this.panel1.TabIndex = 2;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
      this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataGridView1.Location = new System.Drawing.Point(0, 151);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dataGridView1.Size = new System.Drawing.Size(800, 243);
      this.dataGridView1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 95);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 56);
      this.panel2.TabIndex = 4;
      // 
      // frmListPatients
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.iconButton1);
      this.Controls.Add(this.label1);
      this.Name = "frmListPatients";
      this.Text = "frmPatients";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private FontAwesome.Sharp.IconButton iconButton1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel2;
  }
}