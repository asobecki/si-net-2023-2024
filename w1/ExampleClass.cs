namespace w1;

public class ExampleClass : IExampleInterface
{
    public void PrintSomething(string value)
    {
        Console.WriteLine($"Coś wypiszę na ekran {value}");
    }
}