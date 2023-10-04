// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using w1;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// builder.Services.AddHostedService<ExBgService>();
// builder.Services.AddHostedService<ExHostedService>();
builder.Services.AddScoped<IExampleInterface, ExampleClass>();
var app = builder.Build();

app.Use(async (context, next) =>
{
    // Do work that can write to the Response.
    Console.WriteLine("Jakiś middleware");
    IExampleInterface SomeClass = context.RequestServices.GetService<IExampleInterface>();
    ExampleSecondClass ESC = new ExampleSecondClass(SomeClass);
    ESC.SomePublicMethod();
    await next.Invoke();
    // Do logging or other work that doesn't write to the Response.
});

app.MapGet("/start", () => "Strona startowa!");
app.MapDefaultControllerRoute();
app.Run();