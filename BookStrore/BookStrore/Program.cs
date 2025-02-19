var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

//app.MapGet("/", () => "Hello world!");

app.MapDefaultControllerRoute();
app.Run();
