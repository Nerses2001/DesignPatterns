using DesignPatterns.Domain.Factories;

namespace DesignPatterns.Factories;

public class PersonalTrainingMembershipFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public PersonalTrainingMembershipFactory(decimal price, string description)
    {
        _description = description;
        _price = price;
    }


    public override IMembership GetMembership()
    {
        var membership = new PersonalTrainingMembership(_price, _description);
        return membership;
    }
}