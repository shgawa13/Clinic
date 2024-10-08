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
      person.NationalID = "1020304050";
      person.FirstName = "Nano";
      person.SecondName = "Tech";
      person.LastName = "kill";
      person.DateOfBirth = new DateTime(1990, 3, 11);
      person.Gendor = 0;
      person.PhoneNumber = "123456790";
      person.Email = "Nano@gmail.com";
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

    static void Main(string[] args)
    {
      FindPerson(1); 

      Console.ReadKey();
    }
  }
}
