using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class clsSpecialities
  {
    public byte ID { set; get; }
    public string Title{ set; get; }
    public string Description { set; get; }

    public clsSpecialities() 
    {
      this.ID = 0;
      this.Title =  "";
      this.Description = "";
    }

    private clsSpecialities(byte ID,string Title,string Description) 
    {
      this.ID = ID;
      this.Title = Title;
      this.Description = Description;
    }


    public static clsSpecialities Find(byte ID)
    {
      string Title = "", Description = "";

      bool IsFound = clsSpecialitiesData.GetSpecialtyByID(ID, ref Title, ref Description);

      if(IsFound)
        return new clsSpecialities(ID,Title,Description);

      return null;
    }

    public static clsSpecialities Find(string Title)
    {
      byte ID = 0;
      string Description = "";

      bool IsFound = clsSpecialitiesData.GetSpecialtyByTitle(Title, ref ID, ref Description);

      if (IsFound)
        return new clsSpecialities(ID, Title, Description);

      return null;
    }

    // Get all Specialities
    public static DataTable GetAllSpecialities() => clsSpecialitiesData.GetAllSpecialities();
    
  }
}
