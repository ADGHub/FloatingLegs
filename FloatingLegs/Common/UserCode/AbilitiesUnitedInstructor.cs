using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class AbilitiesUnitedInstructor
    {
        partial void AbilitiesUnitedInstructor_Created()
        {
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
            UpdatedBy = Application.User.Name;
        }

        partial void Summary_Compute(ref string result)
        {
            // Set result to the desired field value
            result = LastName + ", " + FirstName;

        }
    }
}
