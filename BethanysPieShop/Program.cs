using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Makes sure our application knows about ASP.NET Core MVC by bringing in framework services that enable MVC
builder.Services.AddControllersWithViews();

// Registered the repositories with the DI container
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

var app = builder.Build();


// Begin bringing in Middleware components and this starts the Middleware Component Pipeline
// My custom code below (2025-11-16)
app.UseStaticFiles(); // Middleware Component
//app.mapstasticassetts // New version of use static files. Not used on demo. Middleware Component


// Diagnostic Middleware Component that checks the environment variable that if in develop mode, shows the error ouput for debugging
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


// Endpoint Middleware Component that gives the ability to navigate to our views. It lets MVC handle our incoming requets
app.MapDefaultControllerRoute();
// End Middleware Components


// Starts the application
app.Run();
