using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using Syncfusion.WinForms;
using Syncfusion.Windows.Forms;
using Syncfusion.Schedule;
using GridScheduleSample;
using Syncfusion.Windows.Forms.Schedule;

namespace Dental_App.Doctors
{
  public partial class frmAddUpdateAppointmnet : MetroForm
  {
    private ScheduleControl _ScheduleGrid;

    private ListBox startListBox;

    private ListBox endListBox;

    private int minimumTimeSlot;

    private RTLComboBoxBase startComboBoxBase;

    private RTLComboBoxBase endComboBoxBase;

   

    public frmAddUpdateAppointmnet(ScheduleControl control)
    {
      InitializeComponent();
      _ScheduleGrid = control;

    }

    private void frmAddUpdateAppointmnet_Load(object sender, EventArgs e)
    {
      dtAppointmentDate.MinDateTime = DateTime.Today;
      dtAppointmentDate.Value = DateTime.Today;
      dtAppointmentDate.MaxDateTime = DateTime.Today.AddMonths(6);

      FillComboBoxWithTime();
    }

    private int DateTimeToIndex(DateTime dt)
    {
      return 1; // dt.Hour * (60 / minimumTimeSlot) + dt.Minute / minimumTimeSlot;
    }

    // Filling ComboBox with time it start with 8:00 AM.
    private void FillComboBoxWithTime()
    {
     
      int Year = DateTime.Today.Year;
      int Month = DateTime.Today.Month;
      int ToDay = DateTime.Today.Day;

      DateTime date = new DateTime(Year, Month, ToDay, 8, 0, 0);

      for (int i = 0; i < 20; i++)
      {
        cbStartTime.Items.Add(date.ToShortTimeString());
        date = date.AddMinutes(30);
        cbEndTime.Items.Add(date.ToShortTimeString());
      }

      cbStartTime.SelectedIndex = 0;
      cbEndTime.SelectedIndex = 0;
  }

    private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
    {

      cbEndTime.SelectedIndex = cbStartTime.SelectedIndex + 1;
    }

    private void txtFilterValue_TextChanged(object sender, EventArgs e)
    {

    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label10_Click(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {

    }

    private void expertsBtn1_Click(object sender, EventArgs e)
    {

    }
  }   
}
