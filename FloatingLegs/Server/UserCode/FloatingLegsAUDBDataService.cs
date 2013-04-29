using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class FloatingLegsAUDBDataService
    {
        partial void Programs_All_PreprocessQuery(ref IQueryable<FL_Programs> query)
        {
            // Specify default sort order for selecting all program
            query = from  FL_Programs p in query
                    orderby p.Name
                    select p;
        }

        partial void Instructors_All_PreprocessQuery(ref IQueryable<AbilitiesUnitedInstructor> query)
        {

            // Specify default sort order for selecting all instructors
            query = from AbilitiesUnitedInstructor i in query
                    orderby i.LastName, i.FirstName
                    select i;
        }
    }
}
