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
    public partial class Application
    {
        partial void ManageInstructors_CanRun(ref bool result)
        {
            // only show this screen to admin user
            result = User.HasPermission(Permissions.ViewAdminScreen);
        }

        partial void ManageClients_CanRun(ref bool result)
        {
            // only show this screen to admin user
            result = User.HasPermission(Permissions.ViewAdminScreen);
        }

        partial void ManageCourses_CanRun(ref bool result)
        {
            // only show this screen to admin user
            result = User.HasPermission(Permissions.ViewAdminScreen);
        }

        partial void ManagePrograms_CanRun(ref bool result)
        {
            // only show this screen to admin user
            result = User.HasPermission(Permissions.ViewAdminScreen);
        }

        partial void ManageSponsors_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = User.HasPermission(Permissions.ViewAdminScreen);

        }

    }
}
