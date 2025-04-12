using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Dental_App.Appointmnets;
using Dental_App.Doctors;
using Dental_App.Patients;
using Dental_App.Test;

namespace Dental_App
{
  public partial class MainForm : Form
  {
    //Fields
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;

    public MainForm()
    {
      InitializeComponent();
      leftBorderBtn = new Panel();
      leftBorderBtn.Size = new Size(7, 50);
      panelMenu.Controls.Add(leftBorderBtn);

      //Form
      this.Text = string.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }
    //Structs
    private struct RGBColors
    {
      public static readonly Color color1 = Color.FromArgb(172, 126, 241);
      public static readonly Color color2 = Color.FromArgb(249, 118, 176);
      public static readonly Color color3 = Color.FromArgb(253, 138, 114);
      public static readonly Color color4 = Color.FromArgb(95, 77, 221);
      public static readonly Color color5 = Color.FromArgb(249, 88, 155);
      public static readonly Color color6 = Color.FromArgb(217, 3, 104);
    }
    //Methods
    private void ActivateButton(object senderBtn, Color color)
    {
      if (senderBtn != null)
      {
        DisableButton();
        //Button
        currentBtn = (IconButton)senderBtn;
        currentBtn.BackColor = Color.FromArgb(37, 36, 81);
        currentBtn.ForeColor = color;
        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        currentBtn.IconColor = color;
        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        //Left border button
        leftBorderBtn.BackColor = color;
        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        leftBorderBtn.Visible = true;
        leftBorderBtn.BringToFront();
        //Current Child Form Icon
        iconCurrentChild.IconChar = currentBtn.IconChar;
        iconCurrentChild.IconColor = color;
      }
    }
    private void DisableButton()
    {
      if (currentBtn != null)
      {
        currentBtn.BackColor = Color.FromArgb(31, 30, 68);
        currentBtn.ForeColor = Color.Gainsboro;
        currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        currentBtn.IconColor = Color.Gainsboro;
        currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
      }
    }
    private void OpenChildForm(Form childForm)
    {
      //open only form
      if (currentChildForm != null)
      {
        currentChildForm.Close();
        currentChildForm.Dispose();
      }
      currentChildForm = childForm;
      //End
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      panelDesktop.Controls.Add(childForm);
      childForm.Size = panelDesktop.Size;
      panelDesktop.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
      lblTitleChild.Text = childForm.Text;
    }
    
    //Events
    //Reset
    private void btnHome_Click(object sender, EventArgs e)
    {
      if (currentChildForm != null)
      {
        currentChildForm?.Close();
        currentChildForm?.Dispose();
      }
      Reset();

    }

    //Menu Button_Clicks

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color1);
     // OpenChildForm(new frmTester());
      
    }


    private void iconButton2_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color2);
      OpenChildForm(new frmSchedule());
    }

    private void iconButton3_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color3);
      OpenChildForm(new frmListPatients());
    }

    private void iconButton4_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color4);
      OpenChildForm(new frmListDoctors());
    }

    private void iconButton5_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color5);
    }

    private void iconButton6_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color6);
    }

    private void iconButton7_Click(object sender, EventArgs e)
    {
      // MessageBox.Show("Testing");
       OpenChildForm(new frmTestCardWithFilter());
    }

    private void homeBtn_Click(object sender, EventArgs e)
    {
      currentChildForm.Close();
      Reset();
    }

    private void Reset()
    {
      DisableButton();
      leftBorderBtn.Visible = false;
      iconCurrentChild.IconChar = IconChar.Home;
      iconCurrentChild.IconColor = Color.MediumPurple;
      lblTitleChild.Text = "Home";
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void iconClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void iconMaxmize_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
        WindowState = FormWindowState.Maximized;
      else
        WindowState = FormWindowState.Normal;
    }

    private void iconMinimize_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

   
  }
}
