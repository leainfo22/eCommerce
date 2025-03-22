using eCommerce.API.Middlewares;
using eCommerce.Infrastructure;
using eCommerce.Core;
var builder = WebApplication.CreateBuilder(args);


//Add infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

builder.Services.AddControllers();

//Build the web app
var app = builder.Build();
app.UseExceptionHandlingMiddleware();
//Routing
app.UseRouting();

app.UseAuthentication();    
app.UseAuthorization();

app.MapControllers();
app.Run();
