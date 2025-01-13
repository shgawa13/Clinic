using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace Dental_App.Appointmnets
{
  public partial class frmPDFBills : Form
  {
    public frmPDFBills()
    {
      InitializeComponent();
    }

    private void CreatePDFBills()
    {
      // create new pdf document
      using(PdfDocument document = new PdfDocument())
      {
        // Adding new page
        PdfPage page = document.Pages.Add();
        // Create PDF graphics for the page.
        PdfGraphics graphics = page.Graphics;
        //Set the standard font.
        PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
        //Draw the text.
        graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, new PointF(0, 0));
        //Save the document.
        document.Save("Output.pdf");
        //Close the document.
        document.Close(true);
      }
    }
  }
}
