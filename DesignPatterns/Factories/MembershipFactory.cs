using DesignPatterns.Domain.Factories;

namespace DesignPatterns.Factories;

public abstract class MembershipFactory
{
    public abstract IMembership GetMembership();
}