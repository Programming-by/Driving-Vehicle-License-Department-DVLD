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
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();

                string filePath = currentDirectory + "\\data.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            UserName = result[0];
                            Password = result[1];
                        }
                        return true;

                    }



                }
                else
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
