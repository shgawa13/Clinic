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
using Microsoft.Win32;

namespace ClinicConsoleApp
{
  
  public class Generic<T>
  {
    public T Content { get; set; }
    public T Name { get; set; }
    public Generic(T value) 
    {
      Content = value;
    
    }

    public T GetValue()
    {
      return Content;
    }
  }


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

    public static void ShowStringInfo()
    {
      Type StringTyp = typeof(String);

      Console.WriteLine($"------ [ String Info ] ------");
      Console.WriteLine($" {StringTyp.Name}");
      Console.WriteLine($" {StringTyp.FullName}");
      Console.WriteLine($" {StringTyp.IsClass}");
      Console.WriteLine($"-----------------------------");
    }

    static string GetParameterList(ParameterInfo[] parameters)
    {
      return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
    }

    public static void ShowScheduleInfo()
    {

      Type appointmentType = typeof(ScheduleAppointment);
      // get properties in ScheduleAppointmnet
      Console.WriteLine("\nProperties:"); 
      PropertyInfo[] properties = appointmentType.GetProperties();

      foreach (PropertyInfo property in properties) 
      {
        Console.WriteLine($"\t Name:{property.Name}, PropertyType: {property.PropertyType}");
      }

      MethodInfo[] methods = appointmentType.GetMethods();
      Console.WriteLine($"\nMethods:\n");

      foreach(MethodInfo method in methods)
      {
        Console.WriteLine($"\t{method.ReturnType}, {method.Name}, ({GetParameterList(method.GetParameters())})");
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

    // this is Custom Attribute 
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class RangeAttribute : Attribute
    {
      public int Min { get; }
      public int Max { get; }

      public string ErrorMessage { get; set; }

      public RangeAttribute(int min, int max)
      {
        Min = min;
        Max = max;
      }
    }


    public class Person
    {
      // here we can have the cutom Attribute to handle the validation of age
      [RangeAttribute(18, 40, ErrorMessage = "Error: Person should be between 18 - 40 Years old.")]
      public int Age { set; get; }

      [RangeAttribute(3, 10, ErrorMessage = "Error: Person must have Experince from 3 - 10 Years")]
      public int Experince { get; set; }

      public string Name { get; set; }

      public Person(int Age, int Experince, string name) 
      {
        this.Age = Age;
        this.Experince = Experince;
        this.Name = name;
      }
    }

    public static T Swap<T>(ref T first, ref T second)
    {
      T temp = first;
      first = second;
      second = temp;
      return temp;
    }

    static void Main(string[] args)
    {

      //Person person = new Person(11, 5, "sonethid");


      //if (ValidatePerson(person))
      //  Console.WriteLine("person is Valid");
      //else
      //  Console.WriteLine("Perosn Not Valid");




      //Console.WriteLine("Swap Numbers: ");
      //int a = 5, b = 10;

      //Console.WriteLine($"Before Swap: a={a},b={b}");
      //Swap(ref a, ref b);
      //Console.WriteLine($"After Swap: a={a},b={b}");


      //Console.WriteLine($"------------------------");

      //Generic<int> genericInt = new Generic<int>(5);
      //Console.WriteLine($"the value is:  {genericInt.GetValue()}");

      //Generic<string> genericStr = new Generic<string>("nano");
      //Console.WriteLine($"the value is:{genericStr.GetValue()}");



      // Specify the Registry key and path
      //string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware"; // <- this need permission
     
      string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DentalApp";
      string valueName = "UserName";
      

      try
      {
        string valueData= Registry.GetValue(keyPath, valueName,null) as string;
        Console.WriteLine($"\n valueName: \t{valueName} \n valueData: \t {valueData}");

      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }

      Console.ReadKey();
    }

    static bool ValidatePerson(Person person)
    {
      Type type = typeof(Person);

      foreach(var property in type.GetProperties())
      {
        // Check RangeAttribute on property
        if (Attribute.IsDefined(property, typeof(RangeAttribute)))
        {
          var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
          int value = (int)property.GetValue(person);

          // here we perform Validation
          if(value < rangeAttribute.Min || value > rangeAttribute.Max)
          {
            Console.WriteLine($"Fild due to Validation {property.Name}, Error message {rangeAttribute.ErrorMessage}");
            return false;
          }

        }
        

      }

      return true;
    }
  }
}
