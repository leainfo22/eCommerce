using eCommerce.API.Middlewares;
using eCommerce.Infrastructure;
using eCommerce.Core;
using System.Text.Json.Serialization;
using eCommerce.Core.Mappers;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Add infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Handle String to Enum conversion in JSON
builder.Services.AddControllers().AddJsonOptions
    (options => {
        options.JsonSerializerOptions.Converters.Add
           (new JsonStringEnumConverter());
    });

//Add AutoMapper
builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

//Add FluentValidation
builder.Services.AddFluentValidationAutoValidation();

//Add API explorer services
builder.Services.AddEndpointsApiExplorer();
//Add Swagger services
builder.Services.AddSwaggerGen();
//Add cors services
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

//Build the web app
var app = builder.Build();
app.UseExceptionHandlingMiddleware();
//Routing
app.UseRouting();
//using swagger
app.UseSwagger();
//add swageger UI
app.UseSwaggerUI();

app.UseAuthentication();    
app.UseAuthorization();

app.MapControllers();
app.Run();
