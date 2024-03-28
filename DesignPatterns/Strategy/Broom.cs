using DesignPatterns.Domain.Strategy;

namespace DesignPatterns.Strategy;

public class Broom : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("attacks with a broom");
    }
}