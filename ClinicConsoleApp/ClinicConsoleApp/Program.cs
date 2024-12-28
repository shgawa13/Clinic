using Business;
using System;
using System.Data;
using System.Reflection;
using Syncfusion.Schedule;
using System.Diagnostics.Eventing.Reader;
using Syncfusion.Windows.Forms.Schedule;
using System.Linq;
using System.Collections.Generic;

namespace ClinicConsoleApp
{

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
      PushToList(ref Testitem);
      PrintPlanList( ref Testitem);
      Console.WriteLine(Testitem.Count.ToString());
      Console.ReadKey();
    }
  }
}
