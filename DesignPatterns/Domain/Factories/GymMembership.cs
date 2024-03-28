namespace DesignPatterns.Domain.Factories;

public class GymMembership : IMembership
{
    private readonly decimal _price;

    public GymMembership(decimal price, string description)
    {
        _price = price;
        Description = description;
        Name = "Gym membership";
    }
    public string Name { get; }
    public string Description { get; set; }
    public decimal GetPrice() => _price;

}