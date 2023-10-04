namespace w1;

public class ExHostedService : IHostedService
{
    private ILogger<ExHostedService> _logger;

    public ExHostedService(ILogger<ExHostedService> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Start Async from ExHostedService");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Stop Async from ExHostedService");
    }
}