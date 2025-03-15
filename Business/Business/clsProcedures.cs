using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  class clsProcedures
  {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = enMode.AddNew;

   
    public int ProceduerID { get; set; }
    public byte Peroxide25 { get; set; }
    public byte Peroxide40 { get; set; }
    public byte CompositeFilling { get; set; }
    public byte PorcelainFilling { get; set; }
    public byte AmalgamFilling { get; set; }
    public byte SingleImplant { get; set; }
    public byte DoubleImplant { get; set; }
    public byte FullMouthImplant { get; set; }
    public byte Cleaning { get; set; }
    public byte Xray { get; set; }
    public byte Diagnosis { get; set; }
    public byte SimpleExtraction { get; set; }
    public byte ComplicatedExtrcation { get; set; }
    public byte ComplexExtraction { get; set; }
    public byte WisdomExtraction { get; set; }


    public clsProcedures() 
    {
      this.ProceduerID = -1;
      this.Peroxide25 = 0;
      this.Peroxide40 = 0;
      this.CompositeFilling = 0;
      this.PorcelainFilling = 0;
      this.AmalgamFilling = 0;
      this.SingleImplant = 0;
      this.DoubleImplant = 0;
      this.FullMouthImplant = 0;
      this.Cleaning = 0;
      this.Xray = 0;
      this.Diagnosis = 0;
      this.SimpleExtraction = 0;
      this.ComplicatedExtrcation = 0;
      this.ComplexExtraction = 0;
      this.WisdomExtraction = 0;

      _Mode = enMode.AddNew;
    }


    public clsProcedures(int procedureID, byte peroxide25, byte peroxide40, byte compositeFilling, byte porcelainFilling,
      byte amalgamFilling,byte singleImplant, byte doubleImplant, byte fullMouthImplant, byte cleaning, byte xray,
      byte Diagnosis, byte simpleExtraction, byte complicatedExtraction, byte complexExtraction, byte wisdomExtraction 
      )
    {
      this.ProceduerID = procedureID;
      this.Peroxide25 = peroxide25;
      this.Peroxide40 = peroxide40;
      this.CompositeFilling = compositeFilling;
      this.PorcelainFilling = porcelainFilling;
      this.AmalgamFilling = amalgamFilling;
      this.SingleImplant = singleImplant;
      this.DoubleImplant = doubleImplant;
      this.FullMouthImplant = fullMouthImplant;
      this.Cleaning = cleaning;
      this.Xray = xray;
      this.Diagnosis = Diagnosis;
      this.SimpleExtraction = simpleExtraction;
      this.ComplicatedExtrcation = complicatedExtraction;
      this.ComplexExtraction = complexExtraction;
      this.WisdomExtraction = wisdomExtraction;

      _Mode = enMode.Update;
    }


    private bool _AddNew()
    {
      return false;
    }

    private bool _Update()
    {
      return false;
    }
  }
}
