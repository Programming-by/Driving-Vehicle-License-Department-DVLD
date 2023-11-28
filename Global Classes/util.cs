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
using System.Diagnostics;

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

            if (!EventLog.SourceExists(clsGlobal.sourceName))
            {
                EventLog.CreateEventSource(clsGlobal.sourceName, "Application");

            }

            if (!Directory.Exists(FolderPath))
            {
                try
                {
                Directory.CreateDirectory(FolderPath);
                EventLog.WriteEntry(clsGlobal.sourceName, "DVLD Images Folder Created", EventLogEntryType.Information);

                    return true;

                } catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    EventLog.WriteEntry(clsGlobal.sourceName, ex.Message, EventLogEntryType.Error);

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


            if (!EventLog.SourceExists(clsGlobal.sourceName))
            {
                EventLog.CreateEventSource(clsGlobal.sourceName, "Application");
            }


            try
            {
                File.Copy(sourceFile,destinationFile,true);
                EventLog.WriteEntry(clsGlobal.sourceName, "Image Copied To Project Images Folder", EventLogEntryType.Information);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               EventLog.WriteEntry(clsGlobal.sourceName, iox.Message, EventLogEntryType.Error);
                return false;
            }
            sourceFile = destinationFile;
            return true;

        }

    }
}
