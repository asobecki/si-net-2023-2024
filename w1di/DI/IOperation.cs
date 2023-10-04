namespace w1di.DI;

public interface IOperation
{
   string Id { get; }
}

public interface IOperationScoped : IOperation { }
public interface IOperationTransient : IOperation { }
public interface IOperationSingleton : IOperation { }