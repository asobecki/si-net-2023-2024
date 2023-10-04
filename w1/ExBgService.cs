namespace w1;

public class ExBgService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine("Zadanie w tle");
            // co się stanie gdy wyłącznie Delay?
            // await Task.Delay(1000);
        } 
    }
}