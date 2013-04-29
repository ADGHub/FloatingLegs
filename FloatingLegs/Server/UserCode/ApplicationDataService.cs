using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
using System.Linq.Expressions;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Instructors_Updating(Instructor entity)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.UpdatedBy = Application.User.Name;
        }

        partial void Clients_Updating(Client entity)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.UpdatedBy = Application.User.Name;
        }

        partial void AvailableSections_PreprocessQuery(int? ClientId, ref IQueryable<Section> query)
        {
            if (ClientId.HasValue)
            {
                // Return only sections which the client has not registered
                query = from Section s in query
                        where (!(s.Enrollments.Any(f => f.Client.Id == ClientId)))
                        select s;
            }
        }

        partial void SectionsByProgram_PreprocessQuery(int? CategoryId, ref IQueryable<Section> query)
        {
            if (CategoryId.HasValue)
            {
                // Return only sections which fall into the program
                query = from Section s in query
                        where s.Course.CourseProgram.Any(f => f.Program.Id == CategoryId)
                        select s;
            }
        }

        partial void Sections_All_PreprocessQuery(ref IQueryable<Section> query)
        {
            // Specify default sort order for selecting all sections
            query = from Section s in query
                    orderby s.Course.Title, s.SectionID, s.Year, s.Season
                    select s;
        }

        partial void Clients_All_PreprocessQuery(ref IQueryable<Client> query)
        {
            // Specify default sort order for selecting all students
            query = from Client c in query
                    orderby c.LastName, c.FirstName
                    select c;
        }

        partial void Programs_All_PreprocessQuery(ref IQueryable<Program> query)
        {
            // Specify default sort order for selecting all program
            query = from Program c in query
                    orderby c.Name
                    select c;
        }

        partial void Instructors_All_PreprocessQuery(ref IQueryable<Instructor> query)
        {
            // Specify default sort order for selecting all instructors
            query = from Instructor i in query
                    orderby i.LastName, i.FirstName
                    select i;
        }

        partial void Enrollments_Validate(Enrollment entity, EntitySetValidationResultsBuilder results)
        {
            // If the section has reached the max enrollment limit, show an error
            if (entity.Section.SpaceRemaining < 0)
            {
                results.AddEntityError("This section is full.");
            }
        }

        partial void Clients_Validate(Client entity, EntitySetValidationResultsBuilder results)
        {  
            int frequency = 0;

            // Check if sponsor relationship has only 1 primary contact item
            foreach (SponsorRelationship s in entity.SponsorRelationship)
                if (s.IsPrimary == true)
                    frequency++;

            //To-do: Add a resource file with BUSINESS RULE validation dictionary thats hold ALL constant string messages. P2 S1
            if ( frequency == 0 )
               results.AddEntityError("[Business Rule] A Client must have a sponsor list with one sponsor as primary contact. Please add only one sponsor with a primary contact.");
            else if ( frequency >= 2)
               results.AddEntityError("[Business Rule] A Client may have more than one sponsors relationship but must have only one sponsor as primary contact with only.  Please ensure that one sponsor exist with column 'Is Primary' with only one 'true' value.");

        }

        partial void SponsorRelationship_Validate(SponsorRelationship entity, EntitySetValidationResultsBuilder results)
        {
           
        }


        partial void Clients_Updated(Client entity)
        {

        }

        partial void Clients_Filter(ref Expression<Func<Client, bool>> filter)
        {
            // filter = e => e.IntegerProperty == 0;

        }

        partial void Sponsors_Updating(Sponsor entity)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.UpdatedBy = Application.User.Name;
        }

        partial void Sponsors_All_PreprocessQuery(ref IQueryable<Sponsor> query)
        {
            // Specify default sort order for selecting all Sponsors
            query = from Sponsor s in query
                    orderby s.LastName, s.FirstName
                    select s;

        }

        partial void Programs_CanUpdate(ref bool result)
        {

        }

        partial void SaveChanges_Executing()
        {
             //To-do: Add SaveChanges validationg for Client changes on Sponsorship
            if (this.DataWorkspace.ApplicationData.Details.HasChanges)
            {
               // EntityChangeSet changeset = this.DataWorkspace.ApplicationData.Details.GetChanges().OfType<Client>();
              // Cli  changeSet =
               //   this.DataWorkspace.ApplicationData.Details.GetChanges().OfType<Client>();
                //int count = changeSet.Client.SponsorRelationship.Count();
               // EntitySetValidationResultsBuilder results;
               // if (count == 0)
                 //   results.AddEntityError(" You are deleting a business required Sponsor relationship");

            }
        }

        partial void FilterSections_PreprocessQuery(string FilterTerm, ref IQueryable<Section> query)
        {
            query = FilterControl.FilterExtensions.Filter(query, FilterTerm, this.Application);
        }

        partial void SectionsByClient_PreprocessQuery(int? ClientId, ref IQueryable<Section> query)
        {
               
                // Return only sections by registered Client 
            if (ClientId.HasValue)
            {
                query = from Section s in query
                        where s.Enrollments.Any(f => f.Client.Id == ClientId)
                        select s;
            }
        }


      

      
    }
}
