var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.MapControllers();    //add this for attribut base routing
app.Run();
