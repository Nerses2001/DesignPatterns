using DesignPatterns.Domain.Proxy;

namespace DesignPatterns.Proxy;

public class Chief : IChief
{
    public IDictionary<int, string> GetStatus()
    {
        Dictionary<int, string> statuses = new();
        statuses.Add(1,"ready");
        statuses.Add(2, "not ready");
        statuses.Add(3, "preparing");
        
        Thread.Sleep(2000);
        return statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders = new ()
        {
            new Order() { Name = "Burger", StatuesId = RandomizeStatus() },
            new Order() { Name = "Pasta", StatuesId = RandomizeStatus() },
            new Order(){Name = "Omlate", StatuesId = RandomizeStatus()}
        };
        return orders;
    }

    private static int RandomizeStatus() => new Random().Next(1, 4);

}