using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
namespace ClinicConsoleApp
{
  internal class Program
  {

    public static clsPerson AddingNewPerson()
    {
      clsPerson person = new clsPerson();
      person.NationalID = "1022103033";
      person.FirstName = "Alex";
      person.SecondName = "Hamilton";
      person.LastName = "Doh";
      person.DateOfBirth = new DateTime(1990, 3, 11);
      person.Gendor = 0;
      person.PhoneNumber = "4122188631";
      person.Email = "Alex@gmail.com";
      person.ImagePath = "";
      person.NationalityCountryID = 12;

      if (person.Save())
      {
        Console.WriteLine("New Person has been Added Successfully");
      }
      else
      {
        Console.WriteLine("Error");
      }

      return person;
    }

    public static void FindPerson(int PersonID)
    {
      bool Person = clsPerson.IsExist(PersonID);

      if (Person)
      {
        Console.WriteLine("Find the person");
      }else
        Console.WriteLine("Erorr");

    }

   public static void AddPatient(int PersonID)
    {
      clsPatient patient = new clsPatient();

      patient.PersonID = 1;
      if (patient.Save())
      {
        Console.WriteLine($"new Patient has been added successfully");
        
      }
    }

    public static void FindPatient(int PatientID)
    {
      clsPatient patient = clsPatient.FindPateintByPersonID(PatientID);

      if(patient != null)
      {

        Console.WriteLine($"PatientID         : {patient.PatientID}");
        Console.WriteLine($"PersonID          : {patient.PersonID}");
        Console.WriteLine($"Patient FirstName : {patient.PatientInfo.FirstName}");
        Console.WriteLine($"Patient LastName  : {patient.PatientInfo.LastName}");

      }
    }

    static void Main(string[] args)
    {
      FindPatient(1);

      Console.ReadKey();
    }
  }
}
