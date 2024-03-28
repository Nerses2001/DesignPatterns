namespace DesignPatterns.Domain.Factories;

public class PersonalTrainingMembership : IMembership
{
    private readonly decimal _price;
    public string Name { get; }
    public string Description { get; set; }

    public PersonalTrainingMembership(decimal price, string description)
    {
        Name = "Personal Training Membership";
        Description = description;
        _price = price;
    }

    public decimal GetPrice() => _price;
}