namespace DesignPatterns.Singleton;

public sealed class Singleton
{
    private Singleton()
    {
    }
    private static Singleton? _instance = null;
    public static Singleton Instance => _instance ??= new Singleton();
}

public sealed class ThreadSafetSingleton
{
    private ThreadSafetSingleton() { }
   
    private static readonly object Lock = new object();
    private static ThreadSafetSingleton? _instance = null;
    
    public static ThreadSafetSingleton Instance {
        get {
            lock(Lock) {
                if (_instance == null) {
                    _instance = new ThreadSafetSingleton();
                }
                return _instance;
            }
        }
    }
}

public sealed class ThreadSafetSingletonUsingDoubleCheckLocking
{
    private ThreadSafetSingletonUsingDoubleCheckLocking() { }
    
    private static readonly object Lock = new object();
    private static ThreadSafetSingletonUsingDoubleCheckLocking? _instance = null;
    
    public static ThreadSafetSingletonUsingDoubleCheckLocking Instance {
        get {
            if (_instance == null) {
                lock(Lock) {
                    if (_instance == null) {
                        _instance = new ThreadSafetSingletonUsingDoubleCheckLocking();
                    }
                }
            }
            return _instance;
        }
    }
}

public sealed class ThreadSafetSingletonWithoutUsingLocksAndNoLazyInstantiation
{
    private ThreadSafetSingletonWithoutUsingLocksAndNoLazyInstantiation() { }

    static ThreadSafetSingletonWithoutUsingLocksAndNoLazyInstantiation() { }
    
    public static ThreadSafetSingletonWithoutUsingLocksAndNoLazyInstantiation Instance { get; } = new ThreadSafetSingletonWithoutUsingLocksAndNoLazyInstantiation();
}