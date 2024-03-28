using DesignPatterns.Builder;
using DesignPatterns.Domain.Factories;
using DesignPatterns.Domain.Proxy;
using DesignPatterns.Factories;
using DesignPatterns.Proxy;
using DesignPatterns.Strategy;

namespace DesignPatterns;

public static class StartUp
{
    public static void StartFactoryExample()
    {
        Console.WriteLine(">>> Welcome to FitnessClub <<< \n");
        Console.WriteLine("> Enter the Membership type you would like to create: ");
        Console.WriteLine("> G -Gym");
        Console.WriteLine("> P - Gym + Pool");
        Console.WriteLine("> T - Personal Training");

        var membershipType = Console.ReadLine();
        if (membershipType == null) return;

        MembershipFactory factory = GetFactory(membershipType);
        IMembership membership = factory.GetMembership();
        Console.WriteLine("\n> Membership you have just created \n");
        Console.WriteLine
        (
            $"\tName:\t\t{membership.Name}\n" +
            $"\tDescription:\t{membership.Description}\n" +
            $"\tPrice:\t\t{membership.GetPrice()}"
        );
    }

    private static MembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(90, "Basic membership"),
            "p" => new GymPlusPoolMembershipFactory(150, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(350, "Best for professionals"),
            _ => throw new ArgumentOutOfRangeException()
        };
    
    public static void StartStrategyExample()
    {
        var hero = new Hero("Name");
        
        hero.SetWeapon( new Broom());
        hero.Attack();
    }
    
    
    public static void StartBuilderExample()
    {
        List<Employee> employees = new()
        {
            new Employee() { Name = "Name1", Salary = 100 },
            new Employee() { Name = "name2", Salary = 82 },
            new Employee(){Name = "name3", Salary = 565}
        };

        var builder = new EmployeeReportBuilder(employees);
        var director = new EmployeeReportDirector(builder);
        director.Build();

        var report = builder.GetReport();
        Console.WriteLine(report);
    }
    
    public static void DontUsingProxyExample()
    {
        Chief chief = new();
        while (true)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Welcome to Cooker!\n");
            Console.WriteLine("================Orders===============\n");
             
            var orders = chief.GetOrders();
            foreach (var order in orders)
            {
                string status = chief.GetStatus().First(s => s.Key == order.StatuesId).Value;
                Console.WriteLine($"{order.Name}\t\t {status}");
            }
        }
    }
    
    public static void ProxyExample()
    {
        IChief chief = new ChiefProxy(new Chief());
        while (true)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Welcome to Cooker!\n");
            Console.WriteLine("================Orders===============\n");
             
            var orders = chief.GetOrders();
            foreach (var order in orders)
            {
                string status = chief.GetStatus().First(s => s.Key == order.StatuesId).Value;
                Console.WriteLine($"{order.Name}\t\t {status}");
            }
        }
    }
}