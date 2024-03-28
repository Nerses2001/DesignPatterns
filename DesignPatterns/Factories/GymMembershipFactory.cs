using DesignPatterns.Domain.Factories;

namespace DesignPatterns.Factories;

public class GymMembershipFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public GymMembershipFactory(decimal price, string description)
    {
        _description = description;
        _price = price;
    }
    
    
    public override IMembership GetMembership()
    {
        var membership = new GymMembership(_price, _description);
        return membership;
    }
}