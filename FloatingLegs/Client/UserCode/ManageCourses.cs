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
    public partial class ManageCourses
    {
        partial void AddProgram_Execute()
        {
            if (Courses.SelectedItem != null && AllPrograms.SelectedItem != null)
            {
                // Loop through my category list and see if I already have this category
                foreach (CourseProgram c in CoursePrograms)
                {
                    if (c.Program == AllPrograms.SelectedItem)
                    {
                        return;
                    }
                }
                // Add the new category to my category list
                CourseProgram cc = CoursePrograms.AddNew();
                cc.Course = Courses.SelectedItem;
                cc.Program = AllPrograms.SelectedItem;
            }
        }

        partial void RemoveCategory_Execute()
        {
            if (CoursePrograms.SelectedItem != null)
            {
                CoursePrograms.SelectedItem.Delete();
            }
        }
    }
}
