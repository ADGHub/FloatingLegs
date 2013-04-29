using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class Home
    {
        partial void Home_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Initialize image properties
            Image_Logo = GetImageByName("logo.png");
            Image_Search = GetImageByName("search.png");
            Image_Student = GetImageByName("student.png");
            Image_Register = GetImageByName("register.png");
            Image_Course = GetImageByName("course.png");

            // Initialize text properties
            Text_Title = "Abilities United Scheduling and Management System";
            Text_Subtitle = "Welcome " + Application.User.FullName + "!";
            Text_Description = "This application is designed for staff members at Abilities United";
            Text_Student = "Adds a new client in the system.";
            Text_Course = "Shows a list of aquatic courses offered by Abilities United.";
            Text_Search = "Searches for an existing client in the system.";
            Text_Register = "Register an existing client into one or more courses.";
        }

        partial void SearchClients_Execute()
        {
            // Write your code here.
            Application.ShowSearchClients();
        }

        partial void AddClient_Execute()
        {
            // Write your code here.
            Application.ShowAddClient();
        }

        partial void RegisterClient_Execute()
        {
            // Write your code here.
            Application.ShowRegisterClient(null, null);
        }

        partial void CourseCatalog_Execute()
        {
            // Write your code here.
            Application.ShowCourseCatalog();
        }

        private byte[] GetImageByName(string filename)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(typeof(Home).Namespace + ".Resources." + filename);
            return GetStreamAsByteArray(stream);
        }

        private byte[] GetStreamAsByteArray(System.IO.Stream stream)
        {
            int streamLength = Convert.ToInt32(stream.Length);
            byte[] fileData = new byte[streamLength];
            stream.Read(fileData, 0, streamLength);
            stream.Close();
            return fileData;
        }

        partial void AddClient_CanExecute(ref bool result)
        {
            // Write your code here.

        }
    }
}
