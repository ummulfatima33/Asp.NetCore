



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();  //add MVC
var app = builder.Build();


//****set Pattern In MVC by default Route****
app.MapControllerRoute (
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
     );

//****Route Call Static Method****

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/about", () => "About Page");
//app.MapGet("/contact", () => "Contact Page");

app.Run();


