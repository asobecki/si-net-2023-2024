var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// builder.Configuration.AddIniFile($"custom.{builder.Environment.EnvironmentName}.ini", optional: true, reloadOnChange: false);
// builder.Configuration.AddJsonFile($"custom.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: false);
// builder.Configuration.AddXmlFile($"custom.{builder.Environment.EnvironmentName}.xml", optional: true, reloadOnChange: false);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
