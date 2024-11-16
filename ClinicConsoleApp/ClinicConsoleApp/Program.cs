using Business;
using System;
using System.Data;
using System.Reflection;
using Syncfusion.Schedule;
using System.Diagnostics.Eventing.Reader;
namespace ClinicConsoleApp
{
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

    static void Main(string[] args)
    {
      ShowScheduleInfo();

      Console.ReadKey();
    }
  }
}
