using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Data;

namespace Dental_App.Global_Classes
{
  internal class clsUtilities
  {
    // Create new Guid
    public static string GenrateGUID()
    {
      Guid GUID = Guid.NewGuid();
      return GUID.ToString();
    }

    // Create Folder if not exits
    public static bool CreateFolderIfNotExist(string FolderPath)
    {
      // if the folder is not Exist 
      if (!Directory.Exists(FolderPath))
      {
        // we try to create it
        try
        {
          Directory.CreateDirectory(FolderPath);
          return true;
        }
        catch(IOException ex)
        {
          MessageBox.Show($"Can't create folder due to {ex.Message}");
          return false;
        }
      }

      return true; 
    }

    // Replace image with Guid
    public static string ReplaceImageNameWithGUID(string sourceFile)
    {
      string FileName = sourceFile;
      FileInfo info = new FileInfo(FileName);
      string extn = info.Extension; // .png  .jpg

      return GenrateGUID() + extn;
    }


    // this function will copy image and store it in Project Image
    // Also will  call all Functions abover like Create Folder and replace image name with Guid

    public static bool CopyImageToProjectImages(ref string sourceFile)
    {
      // Image will be stored in this folder
      string DestinationFolder = @"C:\Clinic_Images\";

      // we call Create Folder
      if (!CreateFolderIfNotExist(DestinationFolder))
      {
        return false;
      }

      // the new destinationFile will be the DestinationFolder + the image after replacing the name
      // we store both DestinationFolder + ImageWithGuidName;
      string destinationFolder = DestinationFolder + ReplaceImageNameWithGUID(sourceFile);

      //now we try to copy image for orignal folder to project Folder
      try
      {
        File.Copy(sourceFile, destinationFolder, true);
      }
      catch (IOException iox)
      {
        MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      // now we change the path to the new path
      sourceFile = destinationFolder;
      return true;

    }
    
    // This function will handle Empty DataTable from database
    public static bool HandleEmptyTable(ref DataTable dt) => dt.Rows.Count > 0;
    

  }
}
