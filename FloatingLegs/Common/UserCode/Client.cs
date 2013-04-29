using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Client
    {
        partial void Client_Created()
        {
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
            UpdatedBy = Application.User.Name;
        }

        partial void Summary_Compute(ref string result)
        {
            result = LastName + ", " + FirstName;
        }

        partial void Age_Compute(ref string result)
        {
            // Set result to the desired field value
            DateTime now = DateTime.Now;
            TimeSpan diff = now - Birthday;

            double age = diff.TotalDays / 365.2425;
            double reminderDays = diff.TotalDays % 365.2425;
            double months = reminderDays / 30;
            age = Math.Floor(age);
            months = Math.Round(months);

            result = "About  - " + age.ToString() + " years " + "and " + months.ToString() + " months old";

// The example displays the following output:
//       6/13/2010 10:47:00 PM - 6/12/2010 6:32:00 PM = 1.04:15:00
           /* DateTime now;
            DateTime then = Birthday;

            int age = now.Year -  then.Year;
            if (now.Month < then.Month || (now.Month == then.Month && now.Day < then.Day)) age--;
            result = age.ToString();*/

        }
    }
}
