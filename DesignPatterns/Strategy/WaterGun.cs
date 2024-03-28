using DesignPatterns.Domain.Strategy;

namespace DesignPatterns.Strategy;

public class WaterGun : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("Attacks with a water gun");
    }
}