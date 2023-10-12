using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activity
                {
                    Title = "Future Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                },
                new Activity
                {
                    Title = "New Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "A brand new activity",
                    Category = "sports",
                    City = "New York",
                    Venue = "Stadium",
                },
                new Activity
                {
                    Title = "New Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Another new activity",
                    Category = "food",
                    City = "Chicago",
                    Venue = "Restaurant",
                },
                new Activity
                {
                    Title = "New Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Exciting event in the future",
                    Category = "music",
                    City = "Los Angeles",
                    Venue = "Concert Hall",
                },
                new Activity
                {
                    Title = "New Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Outdoor adventure",
                    Category = "outdoors",
                    City = "Denver",
                    Venue = "Mountain Trail",
                },
                new Activity
                {
                    Title = "New Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Cultural experience",
                    Category = "culture",
                    City = "Rome",
                    Venue = "Historical Museum",
                },
                new Activity
                {
                    Title = "New Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Food festival",
                    Category = "food",
                    City = "Tokyo",
                    Venue = "Food Street",
                },
                new Activity
                {
                    Title = "New Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Educational seminar",
                    Category = "education",
                    City = "Berlin",
                    Venue = "Conference Center",
                },
                new Activity
                {
                    Title = "New Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Relaxing spa day",
                    Category = "health",
                    City = "Bali",
                    Venue = "Spa Resort",
                },
                new Activity
                {
                    Title = "New Activity 9",
                    Date = DateTime.UtcNow.AddMonths(9),
                    Description = "Art exhibition",
                    Category = "arts",
                    City = "Paris",
                    Venue = "Art Gallery",
                },
                new Activity
                {
                    Title = "New Activity 10",
                    Date = DateTime.UtcNow.AddMonths(10),
                    Description = "Tech conference",
                    Category = "technology",
                    City = "San Francisco",
                    Venue = "Convention Center",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}