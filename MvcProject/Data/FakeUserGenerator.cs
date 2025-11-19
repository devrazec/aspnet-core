using Bogus;
using MvcProject.Models;

public static class FakeUserGenerator
{
    public static List<User> Generate(int count = 20)
    {
        var faker = new Faker<User>()
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.Email, f => f.Internet.Email());

        return faker.Generate(count);
    }
}
