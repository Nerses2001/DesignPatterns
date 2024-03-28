using DesignPatterns.Domain.Factories;

namespace DesignPatterns.Factories;

public class GymPlusPoolMembershipFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public GymPlusPoolMembershipFactory(decimal price, string description)
    {
        _description = description;
        _price = price;
    }


    public override IMembership GetMembership()
    {
        var membership = new GymPlusPoolMembership(_price, _description);
        return membership;
    }
}