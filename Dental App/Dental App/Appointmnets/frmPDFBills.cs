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
using System.Windows.Controls;

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
        //// Create PDF graphics for the page.
        //PdfGraphics graphics = page.Graphics;
        ////Set the standard font.
        //PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
        ////Draw the text.
        //graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, new PointF(0, 0));
        ////Save the document.
        //document.Save("Output.pdf");
        ////Close the document.
        //document.Close(true);

        //Create a PdfGrid
        PdfGrid pdfGrid = new PdfGrid();
        //Create a DataTable
        DataTable dataTable = new DataTable();
        //Add columns to the DataTable
        dataTable.Columns.Add("ProductID");
        dataTable.Columns.Add("ProductName");
        dataTable.Columns.Add("Quantity");
        dataTable.Columns.Add("UnitPrice");
        dataTable.Columns.Add("Discount");
        dataTable.Columns.Add("Price");
        //Add rows to the DataTable
        dataTable.Rows.Add(new object[] { "CA-1098", "Queso Cabrales", "12", "14", "1", "167" });
        dataTable.Rows.Add(new object[] { "LJ-0192-M", "Singaporean Hokkien Fried Mee", "10", "20", "3", "197" });
        dataTable.Rows.Add(new object[] { "SO-B909-M", "Mozzarella di Giovanni", "15", "65", "10", "956" });
        //Assign data source
        pdfGrid.DataSource = dataTable;
        //Draw grid to the page of PDF document
        pdfGrid.Draw(page, new PointF(10, 10));
        //Save the document
        document.Save("Output.pdf");
        //Close the document
        document.Close(true);

      }
    }

    private void frmPDFBills_Load(object sender, EventArgs e)
    {
      CreatePDFBills();
    }
  }
}
