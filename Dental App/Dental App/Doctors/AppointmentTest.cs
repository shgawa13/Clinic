using System;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridScheduleSample;
using Dental_App.Global_Classes;
namespace Dental_App.Doctors
{
  public partial class AppointmentTest : MetroForm
  {
    private ScheduleControl schedulegrid;

    public AppointmentTest(ScheduleControl control)
    {
      InitializeComponent();
      schedulegrid = control;
    }

    private SimpleScheduleDataProvider dataProvider;
    public SimpleScheduleDataProvider DataProvider
    {
      get
      {
        return dataProvider;
      }
      set
      {
        dataProvider = value;
      }
    }

    List<String> colorOptions;

    private void AppointmentTest_Load(object sender, EventArgs e)
    {
      colorOptions = new List<string>();
      colorOptions.Add("None");
      colorOptions.Add("Important");
      colorOptions.Add("Business");
      colorOptions.Add("Personal");
      colorOptions.Add("Vacation");
      colorOptions.Add("Must Attend");
      colorOptions.Add("Travel Required");
      colorOptions.Add("Needs Preparation");
      colorOptions.Add("Birthday");
      colorOptions.Add("Anniversary");
      colorOptions.Add("Phone Call");
      this.comboBox1.DataSource = colorOptions;
      this.comboBox1.SelectedIndex = 0;
    }

    ArrayListDataProvider provider = new ArrayListDataProvider();

  
    private void ok_Click(object sender, EventArgs e)
    {
      //Create a new schedule appointment
      clsDentalScheduleAppointment item = (clsDentalScheduleAppointment)provider.NewScheduleAppointment();
      if (item != null)
      {

        item.DoctorID = 1;
        item.AllDay = true;

        item.StartTime = this.StartDateDateTimePickerAdv.Value;

        item.EndTime = this.EndDateDateTimePickerAdv.Value;

        item.Subject = this.SubjectTextBoxExt.Text;
        item.LabelValue = this.comboBox1.SelectedIndex;
        //Appointment can be added in ScheduleDataProvider
        provider.AddItem(item);
      }
      this.schedulegrid.DataSource = provider;
      this.schedulegrid.GetScheduleHost().SetDataToDayPanels();
      this.Close();
    }


    private void TestAppointmnet()
    {

      
     


    }


  }
}
