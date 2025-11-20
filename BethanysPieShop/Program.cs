var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// My custom code below (2025-11-16)
app.UseStaticFiles();
//app.mapstasticassetts // New version of use static files. Not used on demo


// Checks the environment variable that if in develop mode, shows the error ouput for debugging
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


// Gives the ability to navigate to our views. It lets MVC handle our incoming requets
app.MapDefaultControllerRoute();



// End custom code
//app.MapGet("/", () => "Hello World!");

app.Run();
