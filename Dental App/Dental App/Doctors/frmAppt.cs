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
using Syncfusion.Windows.Forms.Schedule;


namespace Dental_App.Doctors
{
  public partial class frmAppt : MetroAppointmentForm
  {
    
    public frmAppt()
    {
      InitializeComponent();
      this.AllowRoundedCorners = true;
      this.CaptionBarColor = Color.FromArgb(46, 41, 90);

      

    }

    
  }
}
