using Bogus;
using MvcProject.Models;

namespace MvcProject.Data
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Users.Any()) return;

            var faker = new Faker<User>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber());

            var users = faker.Generate(10);

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
