using eCommerce.API.Middlewares;
using eCommerce.Infrastructure;
using eCommerce.Core;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);


//Add infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();


//Habdle String to Enum conversion in JSON
builder.Services.AddControllers().AddJsonOptions
    (options => {
        options.JsonSerializerOptions.Converters.Add
           (new JsonStringEnumConverter());
    });

//Build the web app
var app = builder.Build();
app.UseExceptionHandlingMiddleware();
//Routing
app.UseRouting();

app.UseAuthentication();    
app.UseAuthorization();

app.MapControllers();
app.Run();
