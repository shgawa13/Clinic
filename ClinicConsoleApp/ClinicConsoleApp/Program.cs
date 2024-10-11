using Business;
using System;
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

    static void Main(string[] args)
    {

      PrintInfo(AddingNewPerson());
      Console.ReadKey();
    }
  }
}
