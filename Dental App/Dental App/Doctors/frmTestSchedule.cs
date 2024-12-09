using GridScheduleSample;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_App.Doctors
{
  public partial class frmTestSchedule : Form
  {
    public frmTestSchedule()
    {
      InitializeComponent();
    
      this.scheduleControl1.ShowingAppointmentForm += ScheduleControl1_ShowingAppointmentForm;
    }

    private void ScheduleControl1_ShowingAppointmentForm(object sender, Syncfusion.Windows.Forms.Schedule.ShowingAppointFormEventArgs e)
    {
      e.Cancel = true;
     

    }

    private void frmTestSchedule_Load(object sender, EventArgs e)
    {
      SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
      data.MasterList = new SimpleScheduleAppointmentList();
      data.FileName = "default.schedule";
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.DataSource = data;
    }
  }
}
