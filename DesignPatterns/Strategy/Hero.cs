using DesignPatterns.Domain.Strategy;

namespace DesignPatterns.Strategy;

public class Hero
{
    private readonly string _name;
    private IWeapon? _weapon;

    public Hero( string name)
    {
        _name = name;
    }

    public void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon;
    }
    public void Attack()
    {
        Console.WriteLine(">>>");
        if (_weapon is null)
        {
            Console.WriteLine($"{_name} can not attack, Set a weapon");
        }
        else
        {
            Console.WriteLine($"{_name} stands menacingly");
            Console.WriteLine($"{_name}");
            _weapon.Shoot();
            Console.WriteLine($"{_name} ceases to stand menacingly");   
        }
        
    }
}