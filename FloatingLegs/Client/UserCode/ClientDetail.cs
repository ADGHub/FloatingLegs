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
    public partial class ClientDetail
    {
        partial void Client_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Client);
        }

        partial void Client_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Client);
        }

        partial void ClientDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Client);
        }

        partial void RegisterClient_Execute()
        {
            // Write your code here.
            Application.ShowRegisterClient(Client.Id, null);
        }

        partial void UnregisterClient_CanExecute(ref bool result)
        {
            result = Enrollments.SelectedItem != null;
        }

        partial void UnregisterClient_Execute()
        {
            // Show a confirmation dialog before the course is dropped
            if (this.ShowMessageBox("Are you sure you want to un-register Client from this Course?", "Unregister Client", MessageBoxOption.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                Enrollments.SelectedItem.Delete();
            }
        }

        partial void RegisterClient_CanExecute(ref bool result)
        {
            // Write your code here.
            result = Client != null;
        }
    }
}