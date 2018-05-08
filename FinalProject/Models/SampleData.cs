using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalProject.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<FinalProjectDbContext>
    {
        protected override void Seed(FinalProjectDbContext context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType {Name = "Movie"},
                new EventType {Name = "Dance"},
                new EventType {Name = "Food"},
                new EventType {Name = "Skydiving"},
                new EventType {Name = "Marathon"},
                new EventType {Name = "Shopathon"},
                new EventType {Name = "Town Hall"},
                new EventType {Name = "Golf"},
                new EventType {Name = "Baseball"},
                new EventType {Name = "Basketball"},
            };

            var users = new List<User>
            {
                new User {FullName = "Daniel Satnic", AspNetUserId = new Guid()},
                new User {FullName = "Bobby Jackson", AspNetUserId = new Guid()},
            };

            new List<Event>
            {
                new Event { Title = "Jaws", EventType = eventTypes.Single(g => g.Name == "Movie"), Description = "Water and fish movie", Organizer = users.Single(g => g.FullName == "Daniel Satnic"), StartDate = new DateTime(2018,05,05), StartTime = new DateTime(2018,05,05,21,0,0), EndDate = new DateTime(2018,05,05), EndTime = new DateTime(2018,05,05,23,0,0), Location = "Movie Theater 1"},
                new Event { Title = "Jaws 2", EventType = eventTypes.Single(g => g.Name == "Movie"), Description = "More water more fish", Organizer = users.Single(g => g.FullName == "Daniel Satnic"), StartDate = new DateTime(2018,05,07), StartTime = new DateTime(2018,05,07,10,0,0), EndDate = new DateTime(2018,05,07), EndTime = new DateTime(2018,05,07,12,0,0), Location = "Movie Theater 2"},
                new Event { Title = "Taco Bell Fiesta", EventType = eventTypes.Single(g => g.Name == "Food"), Description = "All you can eat bean burritos", Organizer = users.Single(g => g.FullName == "Bobby Jackson"), StartDate = new DateTime(2018,05,06), StartTime = new DateTime(2018,05,06,15,0,0), EndDate = new DateTime(2018,05,06), EndTime = new DateTime(2018,05,06,17,0,0), Location = "Taco Bell"}
            }.ForEach(a => context.Events.Add(a));
        }
    }
}