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
    public partial class ManageInstructors
    {
        partial void ManageInstructors_Created()
        {
            // Make some controls read only
            this.FindControl("CreatedTime1").IsReadOnly = true;
            this.FindControl("UpdatedTime1").IsReadOnly = true;
            this.FindControl("UpdatedBy1").IsReadOnly = true;
        }
    }
}
