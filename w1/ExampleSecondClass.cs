namespace w1;

public class ExampleSecondClass
{
    private IExampleInterface _printer;

    public ExampleSecondClass(IExampleInterface printer)
    {
        _printer = printer;
    }

    public void SomePublicMethod()
    {
        _printer.PrintSomething("Drukuję raport miesięczny");
    }
}