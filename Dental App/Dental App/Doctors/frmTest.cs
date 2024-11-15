﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using GridScheduleSample;

namespace Dental_App.Doctors
{
  public partial class frmTest : Form
  {
    public frmTest()
    {
      InitializeComponent();
    }

    private void frmTest_Load(object sender, EventArgs e)
    {
      SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
      data.MasterList = new SimpleScheduleAppointmentList();
      data.FileName = "default.schedule";
      this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
      this.scheduleControl1.DataSource = data;
    }
  }
}
