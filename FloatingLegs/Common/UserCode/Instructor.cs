using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Instructor
    {
        partial void Instructor_Created()
        {
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
            UpdatedBy = Application.User.Name;
        }

        partial void Summary_Compute(ref string result)
        {
            result = LastName + ", " + FirstName;
        }
    }
}
