using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace DVLDClasses
{
    public class clsUtil
    {
        public static string GenerateGuid()
        {
            Guid NewGuid = Guid.NewGuid();

            return NewGuid.ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                Directory.CreateDirectory(FolderPath);
                return true;

                } catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;

                }
            } 
            return true;
        }

        public static string ReplaceFileNameWithGuid(string sourceFile)
        {
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string ext = fi.Extension;
            return GenerateGuid() + ext;

        }
   
    
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"C:\DVLD-People-Images\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGuid(sourceFile);
            try
            {
                File.Copy(sourceFile,destinationFile,true);

            } catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = destinationFile;
            return true;

        }

    }
}
