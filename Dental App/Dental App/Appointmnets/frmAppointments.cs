using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using GridScheduleSample;

namespace Dental_App.Appointmnets
{
  public partial class frmAppointments : Form
  {
    SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
    //ScheduleAppointment appointment = new 
    public frmAppointments()
    {
      InitializeComponent();
    }

    private void frmAppointments_Load(object sender, EventArgs e)
    {
      data.MasterList = new SimpleScheduleAppointmentList();
      data.FileName = "default.schedule";
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.DataSource = data;
      // scheduleControl1.BackColor = Color.SteelBlue;
      
      
    }
    public Button ShowRecurDialog;


    public void AddAppointmnet()
    {

      

    }


    

    }
}
