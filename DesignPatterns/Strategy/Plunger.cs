using DesignPatterns.Domain.Strategy;

namespace DesignPatterns.Strategy;

public class Plunger : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("Attacks whit a plunger");
    }
}