using DesignPatterns.Domain.Proxy;

namespace DesignPatterns.Proxy;

public class ChiefProxy : IChief
{
    private readonly Chief  _chief;
    private IDictionary<int, string>? _statuses;

    public ChiefProxy(Chief chief)
    {
        _chief = chief;
    }
    public IDictionary<int, string> GetStatus()
    {
        Console.WriteLine($"[{DateTime.Now}:dd.MM.yyyy HH:mm:ss] GetOrders()\n");
        return _statuses ??= _chief.GetStatus();
    }

    public IEnumerable<Order> GetOrders()
    {
        return _chief.GetOrders();
    }
}