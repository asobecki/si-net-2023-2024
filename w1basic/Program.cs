var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (context, next) =>
{
    context.Response.WriteAsync("testy testy");
    await next.Invoke();
});
app.Run();

