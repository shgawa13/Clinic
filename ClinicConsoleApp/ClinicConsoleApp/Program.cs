using Business;
using System;
using System.Data;
using System.Reflection;
using Syncfusion.Schedule;
using System.Diagnostics.Eventing.Reader;
using Syncfusion.Windows.Forms.Schedule;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClinicConsoleApp
{

  public  class TemprtureEventAgrs : EventArgs
  {
    public double NewTemprture { set; get; }
    public double OldTemprture { set; get; }
    public double Diffrence { set; get; }

    public TemprtureEventAgrs(double NewTemprture, double OldTemprture ) 
    {
      this.NewTemprture = NewTemprture;
      this.OldTemprture = OldTemprture;
      this.Diffrence = NewTemprture - OldTemprture;
    }
  
  }


  public class Thermostat 
  {

    public event EventHandler<TemprtureEventAgrs> TemprtureChanged;

    private double CurrentTmep;
    private double OldTemp;


    public void SetNewTempreture(double NewTemp)
    {

      if (NewTemp != CurrentTmep)
      {
        OldTemp = CurrentTmep;
        CurrentTmep = NewTemp;
        OnTempretureChanged(CurrentTmep, OldTemp);

      }
    }

    public void OnTempretureChanged(double CurrentTemp, double OldTemp)
    {
      OnTempretureChanged(new TemprtureEventAgrs(CurrentTmep, OldTemp));
    }

    protected virtual void OnTempretureChanged(TemprtureEventAgrs e)
    {
      TemprtureChanged?.Invoke(this, e);
    }

  }
  
  
  public class Display
  {
    public void Subscribe(Thermostat thermostat)
    {
      thermostat.TemprtureChanged += HandleTempretureChanged;
    }

    private void HandleTempretureChanged(object sender, TemprtureEventAgrs e)
    {
      Console.WriteLine("\n\n Tempreture has been Changed:");
      Console.WriteLine($"New Temp: {e.NewTemprture}");
      Console.WriteLine($"Old Temp: {e.OldTemprture}");
      Console.WriteLine($"Diffrences: {e.Diffrence}");
      
    }
  }

  // ----------------- Order Event Args -----------------

  public class OrderEvent :EventArgs
  {
    public string OrderID { set; get; }
    public string Product { set; get; }
    public double Price { set; get; }

    public OrderEvent(string OrderID, string Product, double Price)
    {
      this.OrderID = OrderID;
      this.Product = Product;
      this.Price = Price;
    }
  }


  public class Order
  {

    public event EventHandler<OrderEvent> OnOrderCreated;

    public void CreateOrder(string OrderID, string Product, double Price)
    {
      if(OnOrderCreated != null)
      {
        OnOrderCreated(this, new OrderEvent(OrderID, Product, Price));
      }
    }

  }


  public class Shipper
  {
    

    public void Subscribe(Order s)
    {
      s.OnOrderCreated += S_OnOrderCreated;
    }

    private void S_OnOrderCreated(object sender, OrderEvent e)
    {
      Console.WriteLine($"-------------------------------------\n");
      Console.WriteLine($"New Order has been Created");
      Console.WriteLine($"OrderID: ${e.OrderID}");
      Console.WriteLine($"Product: ${e.Product}");
      Console.WriteLine($"Price: ${e.Price}");
      Console.WriteLine($"-------------------------------------\n");
    }
  }


    public class Plan
  {
    public string ItemName { set; get; }
    public short ItemPrice { set; get; }

    public Plan() 
    {
      this.ItemName = "";
      this.ItemPrice = 0;
    }

    private Plan(string itemName, short itemPrice)
    {
      this.ItemName = itemName;
      this.ItemPrice = itemPrice;
    }
  }

  internal class Program
  {
    
    public static clsPerson AddingNewPerson()
    {

      clsPerson person = new clsPerson();
      person.NationalID = "7846346387";
      person.FirstName = "Alexander";
      person.SecondName = "Hamilton";
      person.LastName = "Tech";
      person.DateOfBirth = new DateTime(1990,2,13);
      person.Gendor = 0;
      person.PhoneNumber = "0568889993";
      person.Email = "Alexender@gmail.com";
      person.ImagePath = " ";
      person.NationalityCountryID = 11;

      
      if (person.Save())
      {
        Console.WriteLine("New Doctor has been Added Successfully");
        Console.WriteLine($"{person.PersonID}");
       
      }
      else
      {
        Console.WriteLine("Error");
      }

      return person;
    }

    public static void PrintInfo (clsPerson person)
    {
      

      if (person != null)
      {
        Console.WriteLine($"DoctorID: ");
        Console.WriteLine($"PersonID: ");
        Console.WriteLine($"Specilization: ");
      }
    }

    public static DataTable GetAll()
    {
      return clsSpecialities.GetAllSpecialities();
    }

    public static void PrintAll()
    {
      DataTable dt = GetAll();

      if(dt != null)
      {
        foreach(DataRow row in dt.Rows)
        {
          Console.WriteLine($"ID : {row["ID"]}");
          Console.WriteLine($"Title : {row["Title"]}");
          Console.WriteLine($"Description : {row["Description"]}");
        }
      }
    }

    public static void GetSpecialityByID( string Title)
    {
      clsSpecialities sp = clsSpecialities.Find(Title); //Geriatric

      if (sp != null)
      {
        Console.WriteLine($"ID : {sp.ID}");
        Console.WriteLine($"Title : {sp.Title}");
        Console.WriteLine($"Description : {sp.Description}");
      }
      else
      {
        Console.WriteLine("Error something went worng");
      }
    }

    public static void ShowScheduleInfo()
    {

      Type appointmentType = typeof(ScheduleAppointment);

      Console.WriteLine("Properties:"); 
      PropertyInfo[] properties = appointmentType.GetProperties();

      foreach (PropertyInfo property in properties) 
      {
        Console.WriteLine($"{property.ToString()}");
      }
    }


    public static string[] arr = new string[20];

    


    public static void FillArrayWithTime()
    {
      int Year = DateTime.Today.Year;
      int Month = DateTime.Today.Month;
      int ToDay = DateTime.Today.Day;

      DateTime date = new DateTime(Year, Month, ToDay, 8, 0, 0);

      for(int i =0; i< 20; i++)
      {

        Console.WriteLine($"{date.ToShortTimeString()}");
        date = date.AddMinutes(30);

      }

    }

    public static void AddNewAppointment()
    {
      int Year = DateTime.Today.Year;
      int Month = DateTime.Today.Month;
      int ToDay = DateTime.Today.Day;

      DateTime date = new DateTime(Year, Month, ToDay, 8, 0, 0);

      clsAppointments Appt = new clsAppointments();
      Appt.PatientID = 6;
      Appt.DoctorID = 3;
      Appt.AppointmentStatus = clsAppointments.enAppointmentSataus.Pending;
      Appt.MedicalRecordID = 1;
      Appt.PaymentID = 1;
      Appt.StartTime = new DateTime(Year, Month, 20, 8, 0, 0);
      Appt.EndTime = new DateTime(Year, Month, 20, 9, 0, 0);
      Appt.Subject = "Appointment Test";
      Appt.Content = "Dr.Something";
      Appt.LabelValue = 2;
      Appt.LocationValue = "Room B";
      Appt.Reminder = false;
      Appt.AllDay = false;
      Appt.MarkerValue = 2;

      if (Appt.Save())
        Console.WriteLine($" {Appt.AppointmentID} Appointment has been made successfully");
      else
        Console.WriteLine($" Something went wrong  ");


      //this.AppointmentID = AppointmentID;
      //this.PatientID = PatientID;
      //this.DoctorID = DoctorID;
      //this.AppointmentStatus = AppointmentStatus;
      //this.MedicalRecordID = MedicalRecordID;
      //this.PaymentID = PaymentID;
      //this.LastStatusDate = DateTime.Now;
      //this.StartTime = StartTime;
      //this.EndTime = EndTime;
      //this.LocationValue = Location;
      //this.Subject = clsPatient.Find(PatientID).FullName;
      //this.LabelValue = LabelValue;
      //this.MarkerValue = MarkerValue;
      //this.Notes = Note;

    }


    public static void GetAllAppt()
    {
      DataTable dt = clsAppointments.GetAllAppointments();

      foreach(DataRow row in dt.Rows)
      {
        Console.WriteLine($"{row["StartTime"]}");
        Console.WriteLine($"{row["EndTime"]}");
        Console.WriteLine($"{row["_Subject"]}");
        Console.WriteLine($"{row["Content"]}");
        Console.WriteLine($"{row["LabelValue"]}");
        Console.WriteLine($"{row["LocationValue"]}");
        Console.WriteLine($"{row["ReminderValue"]}");
        Console.WriteLine($"{row["Reminder"]}");
        Console.WriteLine($"{row["AllDay"]}");
        Console.WriteLine($"{row["MarkerValue"]}");
        Console.WriteLine($"{row["Dirty"]}");
      }


    }


    



    public static List<Plan> Testitem = new List<Plan>();

    public static void PushToList(ref List<Plan> Testitem)
    {
      Plan one = new Plan();
      one.ItemName = "A";
      one.ItemPrice = 10;
      Testitem.Add(one);

      Plan two = new Plan();
      two.ItemName= "B";
      two.ItemPrice = 10;
      Testitem.Add(two);
      
      Plan three = new Plan();
      three.ItemName= "B";
      three.ItemPrice = 10;
      Testitem.Add(three);
    }

    public static void PrintPlanList(ref List<Plan> list)
    {
      foreach (Plan p in list)
      {
        Console.WriteLine($"Item Name: {p.ItemName} , Item Price: {p.ItemPrice}");
      }
    }

    static void Main(string[] args)
    {
      //Display Screen = new Display();
      //Thermostat thermostat = new Thermostat();

      //Screen.Subscribe(thermostat);

      //thermostat.SetNewTempreture(25);
      //thermostat.SetNewTempreture(25);
      //thermostat.SetNewTempreture(25);
      //thermostat.SetNewTempreture(26);


      //var order = new Order();

      //Shipper Aramx = new Shipper();
      //Aramx.Subscribe(order);

      //order.CreateOrder("2fd6522-454df45-454d54f", "PC", 6000);
      //order.CreateOrder("2fd6522-454df45-454d54f", "PC", 6000);

      AddNewAppointment();

      Console.ReadKey();
    }
  }
}
