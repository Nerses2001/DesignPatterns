using DesignPatterns.Proxy;

namespace DesignPatterns.Domain.Proxy;

public interface IChief
{
    public IDictionary<int, string> GetStatus();
    public IEnumerable<Order> GetOrders();
}