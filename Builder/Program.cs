
using Builder;

var builder = new WebApplicationBuilder();

builder.Configuration = "BuilderConfiguration";
builder.Services = new[] { "ProductService", "CategoryService" };

var webApplication= builder.Build();

Console.WriteLine(webApplication._host.Configuration);
