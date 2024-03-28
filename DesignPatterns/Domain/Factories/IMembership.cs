namespace DesignPatterns.Domain.Factories;

public interface IMembership
{
    public string Name { get; }
    public string Description { get; set; }
    decimal GetPrice();
}