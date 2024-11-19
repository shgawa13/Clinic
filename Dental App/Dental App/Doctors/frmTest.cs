using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;
using GridScheduleSample;
using Dental_App.Global_Classes;
using Dental_App.Appointmnets;

namespace Dental_App.Doctors
{
  public partial class frmTest : Form
  {
   

    private SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
    private AppointmentForm customAppointmentForm;
    //Hook the event for showing the appointment form.
      ScheduleControl scheduleControl1 = new ScheduleControl();
    
    public frmTest()
    {
      
      InitializeComponent();
      data.MasterList = new SimpleScheduleAppointmentList();
      data.FileName = "default.schedule";
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.DataSource = data;

      scheduleControl1.Location = new Point(82, 12);
      scheduleControl1.Size = new Size(350, 360);
      this.Controls.Add(scheduleControl1);
      scheduleControl1.ShowingAppointmentForm += scheduleControl1_ShowingAppointmentForm;
    }

    private void scheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
    {
      e.Cancel = true;

      customAppointmentForm = new AppointmentForm(); 
      //customAppointmentForm.ShowDialog();
    }

    public static string[] DisplayStrings = new string[]
    {
       "Subject:",        // 0                       
       "Location:",       // 1                       
       "Show time as:",   // 2                       
       "Reminder:",       // 3                       
       "All Day Event",    // 4                       
       "End Time:",       // 5                       
       "Start Time:",     // 6                       
       "Label:",          // 7                       
       "subject",          // 8                       
       "Cancel",           // 9                       
       "Save and Close",   // 10                       
       "Enter Appointment", // 11                       
       "Delete this appointment that spans more than one day?", // 12
       "Delete a Span",    // 13                       
       "Delete Span",      // 14                       
       "Edit Recurring",   // 15                       
       "Make Recurring"    // 16                       
    };

   

    private void expertsBtn1_Click(object sender, EventArgs e)
    {
      AppointmentTest frm = new AppointmentTest(scheduleControl1);

      frm.ShowDialog();
      
      
    }

    private void frmTest_Load(object sender, EventArgs e)
    {
      
    }
  }
}
