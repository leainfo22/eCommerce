using eCommerce.ProductsService.BusinessLogicLayer;
using eCommerce.ProductsService.DataAccessLayer;
using FluentValidation.AspNetCore;
using ProductMicroService.API;

var builder = WebApplication.CreateBuilder(args);


// Add DAL and BLL to the container.
builder.Services.AddDataAccessLayer(builder.Configuration);
builder.Services.AddBusinessLogicLayer();
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();
app.UseExceptionHandlingMiddleware();  
app.UseRouting();

//Auth
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
