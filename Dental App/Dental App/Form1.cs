using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Dental_App
{
  public partial class Form1 : Form
  {
    // Declear proprties
    private IconButton currentBtn;
    private Panel LeftBorderBtn;

    public Form1()
    {
      InitializeComponent();
      LeftBorderBtn = new Panel();
      LeftBorderBtn.Size = new Size(7, 50);
      panelMenu.Controls.Add(LeftBorderBtn);
    }

    // Structs
    private struct RGBColors
    {
     public static Color color1 = Color.FromArgb(114,137,218);
     public static Color color2 = Color.FromArgb(66,69,73);
     public static Color color3 = Color.FromArgb(54,57,62);
     public static Color color4 = Color.FromArgb(40,43,48);
     public static Color color5 = Color.FromArgb(30,33,36);
    }                                                     

    // Methods
    private void ActiveButton(object senderBtn,Color color)
    {
      if(senderBtn != null)
      {
        DisableButton();
        // Button
        currentBtn = (IconButton)senderBtn;
        currentBtn.BackColor = Color.FromArgb(114, 137, 218);
        currentBtn.ForeColor = color;
        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        currentBtn.IconColor = color;
        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        // left
        LeftBorderBtn.BackColor = color;
        LeftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        LeftBorderBtn.Visible = true;
        LeftBorderBtn.BringToFront();
      }
    }

    private void DisableButton()
    {
      if(currentBtn != null)
      {
        currentBtn.BackColor = Color.FromArgb(66, 69, 73);
        currentBtn.ForeColor = Color.Gainsboro;
        currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        currentBtn.IconColor = Color.Gainsboro;
        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
      }
    }
  }
}
