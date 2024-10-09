using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsCountries
  {
    
      public int ID { set; get; }
      public string CountryName { set; get; }

      public clsCountries()
      {
        this.ID = -1;
        this.CountryName = "";
      }

      private clsCountries(int ID, string CountryName)
      {
        this.ID = ID;
        this.CountryName = CountryName;
      }

      public static clsCountries Find(int ID)
      {
        string CountryName = "";
        if (clsCountriesData.GetCountryByID(ID, ref CountryName))
        {
          return new clsCountries(ID, CountryName);
        }
        else
        {

          return null;
        }

      }

      public static clsCountries Find(string CountryName)
      {
        int ID = -1;
        if (clsCountriesData.GetCountryByName(CountryName, ref ID))
        {
          return new clsCountries(ID, CountryName);
        }
        else
        {
          return null;
        }

      }

      public static DataTable GetAllCountries() => clsCountriesData.GetAllCountries();
  
  }
}
