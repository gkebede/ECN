using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Members.Any()) return;
            
            var members = new List<Member>
            {
                new Member
                {
                    FirstName = "Sam",
                    MiddleName= "Tom",

                    LastName = "Keven",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Email = "sam@gmail.com ",
                  
                },
                new Member
                {
                    FirstName = "Max",
                    MiddleName= "Lorry",

                    LastName = "Keven",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-3),
                    Email = "Max@gmail.com ",
                },
                new Member
                {
                   FirstName = "Keven",
                    MiddleName= "King",

                    LastName = "Fidel",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-4),
                    Email = "keven@gmail.com ",
                },
                new Member
                {
                    FirstName = "Eleni",
                    MiddleName= "cherkosie",

                    LastName = "Girma",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-5),
                    Email = "eleni@gmail.com ",
                },
                new Member
                {
                 FirstName = "Elet",
                    MiddleName= "Tsehayu",

                    LastName = "Bogale",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-6),
                    Email = "elet@gmail.com ",
                },
                new Member
                {
                   FirstName = "Becam",
                    MiddleName= "Stochikov",

                    LastName = "Keven",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-7),
                    Email = "becam@gmail.com ",
                },
                new Member
                {
                    FirstName = "Vergilio",
                    MiddleName= "Kumsta",

                    LastName = "Keven",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-8),
                    Email = "vergilio@gmail.com ",
                },
                new Member
                {
                 FirstName = "Bob",
                    MiddleName= "Solomon",

                    LastName = "Sidroff",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-9),
                    Email = "bob@gmail.com ",
                },
                new Member
                {
                 FirstName = "Stiven",
                    MiddleName= "Mukacho",

                    LastName = "Becham",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    
                    Email = "stiven@gmail.com ",
                },

                new Member
                {
                    FirstName = "Dave",
                    MiddleName= "stiven",
                    LastName = "Soloman",
                    PhoneNumber ="12345567",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Email = "dave@gmail.com ",
                }
            };

            await context.Members.AddRangeAsync(members);
            await context.SaveChangesAsync();
        }
    }
}