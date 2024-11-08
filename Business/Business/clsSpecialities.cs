using System;
using System.Collections.Generic;
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


  }
}
