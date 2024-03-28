namespace DesignPatterns.Domain.Factories;

public class GymPlusPoolMembership : IMembership
{
    private readonly decimal _price; 
    public string Name { get; }
    public string Description { get; set; }

    public GymPlusPoolMembership(decimal price, string description)
    {
        Name = "Gym + Pool membership";
        Description = description;
        _price = price;
    }

    public decimal GetPrice() => _price;
}