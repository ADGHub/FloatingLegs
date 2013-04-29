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
    public partial class RegisterClient
    {
        partial void RegisterClient_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.EnrollmentProperty = new Enrollment();
            this.Text_Title = "Course Registration";
            this.Year = 2011;

            // StudentId is an optional screen parameter
            if (ClientId.HasValue)
            {
                // If StudentId is set, run a query to get the student record, pre-set the student field on the screen
                this.EnrollmentProperty.Client = DataWorkspace.ApplicationData.Clients_Single(ClientId);
            }

            // SectionId is an optional screen parameter
            if (SectionId.HasValue)
            {
                // If SectionId is set, run a query to get the section record, pre-set the section field on the screen
                this.EnrollmentProperty.Section = DataWorkspace.ApplicationData.Sections_Single(SectionId);
            }
        }

        partial void RegisterClient_Saved()
        {
            // Write your code here.
            this.Close(false);
        }
    }
}