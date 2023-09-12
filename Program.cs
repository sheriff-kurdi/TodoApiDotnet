using TodoApi.Middlewares;
using TodoApi.Routes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();

var app = builder.Build();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
app.MapGet("/", () => "Hello World!");
app.UseLoggerEndPoints();
app.Run();


