using DVLDBusinessLayer;
using System;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLDClasses
{
    public class clsGlobal
    {
        public static clsUserData CurrentUser;

        public static bool RememberUserNameAndPassword(string UserName , string Password)
        {

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            string valueNameOfUserName = "UserName";
            string valueDataOfUserName = UserName;

            string valueNameOfPassword = "Password";
            string valueDataOfPassword = Password;

            try
            {

                Registry.SetValue(keyPath,valueNameOfUserName,valueDataOfUserName, RegistryValueKind.String);

                Registry.SetValue(keyPath,valueNameOfPassword,valueDataOfPassword, RegistryValueKind.String);
           
                return true;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string UserName ,ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string valueNameOfUserName = "UserName";
            string valueNameOfPassword = "Password";

            try
            {
              UserName = Registry.GetValue(keyPath, valueNameOfUserName,null) as string;
              Password = Registry.GetValue(keyPath, valueNameOfPassword, null) as string;
               
                if (UserName != null || Password != null)
                {
                    return true;
                } else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }


    }
}
