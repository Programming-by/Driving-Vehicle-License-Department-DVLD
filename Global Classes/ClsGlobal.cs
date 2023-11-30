using DVLDBusinessLayer;
using System;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Text;

namespace DVLDClasses
{
    public class clsGlobal
    {
        public static clsUserData CurrentUser;

       public const string sourceName = "DVLD";
       public const string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

        public static bool RememberUserNameAndPassword(string UserName , string Password)
        {

            if (!EventLog.SourceExists(sourceName))
            {
               EventLog.CreateEventSource(sourceName, "Application");
            }

            try
            {

                Registry.SetValue(keyPath,"UserName",UserName, RegistryValueKind.String);

                Registry.SetValue(keyPath,"Password",Password, RegistryValueKind.String);

                EventLog.WriteEntry(sourceName, "Username and Password has been remembered", EventLogEntryType.Information);

                return true;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                EventLog.WriteEntry(sourceName, ex.Message , EventLogEntryType.Error);

                return false;
            }

        }

        public static bool GetStoredCredential(ref string UserName ,ref string Password)
        {

            if (!EventLog.SourceExists(sourceName))
            {
               EventLog.CreateEventSource(sourceName, "Application");
                
            }

            try
            {
              UserName = Registry.GetValue(keyPath, "UserName",null) as string;
              Password = Registry.GetValue(keyPath, "Password", null) as string;
               
                if (UserName != null || Password != null)
                {
                 EventLog.WriteEntry(sourceName, "the saved Username and Password has been loaded in to the System", EventLogEntryType.Information);
                    return true;
                } else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);

                return false;
            }
        }

        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

    }
}
