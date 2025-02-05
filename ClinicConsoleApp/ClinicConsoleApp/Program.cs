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

  public class TempEventArgs : EventArgs
  {
    public double NewTemp { set; get; }
    public double OldTemp { set; get; }
    public double Diff { set; get; }

    public TempEventArgs(double NewTemp, double OldTemp)
    {
      this.NewTemp = NewTemp;
      this.OldTemp = OldTemp;
      this.Diff = NewTemp - OldTemp;
    }
  }


  public class Theromstat
  {
    public event EventHandler<TempEventArgs> TempChanged;
    public double CurrentTemp;
    public double OldTemp;

    public void SetTemp(double NewTemp)
    {
      if (CurrentTemp != NewTemp)
      {
        OldTemp = CurrentTemp;
        CurrentTemp = NewTemp;

        OnTempChanged(CurrentTemp, OldTemp);
      }
    }

    public void OnTempChanged(double Current, double OldTemp)
    {
      OnTempChanged(new TempEventArgs(Current, OldTemp));
    }

    protected virtual void OnTempChanged(TempEventArgs e)
    {
      TempChanged?.Invoke(this, e);
    }

  }

  public class Display
  {

    public void Subscribe(Theromstat theromstat)
    {
      theromstat.TempChanged += HandleTempChanged;
    }

    private void HandleTempChanged(object sender, TempEventArgs e)
    {
      Console.WriteLine($"\n--------- [ Temp Has Changed ] ---------");
      Console.WriteLine($"--------- [ NewTemp: {e.NewTemp}] ---------");
      Console.WriteLine($"--------- [ OldTemp: {e.OldTemp}] ---------");
      Console.WriteLine($"--------- [ Diff: {e.Diff}] ---------");
      Console.WriteLine($"------------------------------------------");
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


    }


    public static void GetAllAppt()
    {
      DataTable dt = clsAppointments.GetAllAppointments();

      foreach(DataRow row in dt.Rows)
      {
        Console.WriteLine($"{row["AppointmentID"]}");
        Console.WriteLine($"{clsPatient.Find((int)row["PatientID"])}");
        Console.WriteLine($"{clsDoctors.Find((int)row["DoctorID"]).FullName}");
        Console.WriteLine($"{row["AppointmentStatus"]}");
        Console.WriteLine($"{row["MedicalRecordID"]}");
        Console.WriteLine($"{row["PaymentID"]}");
        Console.WriteLine($"{row["LastStatusDate"]}");
        Console.WriteLine($"{row["StartTime"]}");
        Console.WriteLine($"{row["EndTime"]}");
        Console.WriteLine($"{row["Location"]}");
        Console.WriteLine($"{row["LabelValue"]}");
        Console.WriteLine($"{row["MarkerValue"]}");
        Console.WriteLine($"{row["Notes"]}");
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

  

    static void Main(string[] args)
    {
      Display Screen = new Display();
      Theromstat Therom = new Theromstat();

      Screen.Subscribe(Therom);

      Therom.SetTemp(10);
      Therom.SetTemp(12);

      //var order = new Order();

      //Shipper Aramx = new Shipper();
      //Aramx.Subscribe(order);

      //order.CreateOrder("2fd6522-454df45-454d54f", "PC", 6000);
      //order.CreateOrder("2fd6522-454df45-454d54f", "PC", 6000);

      GetAllAppt();

      Console.ReadKey();
    }
  }
}
