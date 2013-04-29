using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Section
    {
        partial void SpaceRemaining_Compute(ref int result)
        {
            result = MaxEnrollment - Enrollments.Count();
        }

        partial void Title_Compute(ref string result)
        {
            result = Course.Title + " [" + SectionID + "]";
        }

        partial void Summary_Compute(ref string result)
        {
            result = Title + " - " + MeetingDays + " " + MeetingTime.ToShortTimeString();
        }
    }
}
