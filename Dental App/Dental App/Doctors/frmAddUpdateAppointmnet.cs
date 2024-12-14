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

     public static string[] DisplayStrings = new string[19]
     {
    "Sub&ject:", "&Location:", "Sho&w time as:", "&Reminder:", "All Day Event", "En&d Time:", "Start Time&:", "La&bel:", "subject", "Cancel",
    "Save and Close", "Enter Appointment", "Delete this appointment that spans more than one day?", "Delete a Span", "Delete Span", "Edit Recurring", "Make Recurring", "minutes", "hours"
    };

    public frmAddUpdateAppointmnet(ScheduleControl control)
    {
      InitializeComponent();
      _ScheduleGrid = control;

    }

    private void frmAddUpdateAppointmnet_Load(object sender, EventArgs e)
    {
      dtAppointmentDate.Value = DateTime.Today;
      

    }

    private int DateTimeToIndex(DateTime dt)
    {
      return 1; // dt.Hour * (60 / minimumTimeSlot) + dt.Minute / minimumTimeSlot;
    }

    private void PopulateTimeListBoxes(int minimumTimeSlot, string format)
    {
      int num = 1440 / minimumTimeSlot;
      object[] array = new object[num];
      DateTime date = DateTime.Now.Date;
      for (int i = 0; i < num; i++)
      {
        array[i] = date.AddMinutes(i * minimumTimeSlot).ToString(format);
      }

      endListBox.Items.AddRange(array);
      startListBox.Items.AddRange(array);
    }

    private void comboBoxStartTime()
    {
      DateTime dt = DateTime.Now.Date;

    }
   


  }
    

}
