namespace w1di.DI;

public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
{
    public Operation()
    {
        Id = Guid.NewGuid().ToString()[^4..];
    }

    public string Id { get; }
}