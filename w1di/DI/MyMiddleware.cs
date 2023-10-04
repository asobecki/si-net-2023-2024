namespace w1di.DI;

public class MyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<MyMiddleware> _logger;

    private readonly IOperationSingleton _singletonOperation;

    public MyMiddleware(RequestDelegate next, ILogger<MyMiddleware> logger, IOperationSingleton singletonOperation)
    {
        _next = next;
        _logger = logger;
        _singletonOperation = singletonOperation;
    }

    public async Task InvokeAsync(HttpContext context, IOperationTransient operationTransient,
        IOperationScoped operationScoped)
    {
        _logger.LogInformation("DI transient: " + operationTransient.Id);
        _logger.LogInformation("DI scoped: "+ operationScoped.Id);
        _logger.LogInformation("DI singleton: "+ _singletonOperation.Id);

        await _next(context);
    }
}

public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MyMiddleware>();
    }
}