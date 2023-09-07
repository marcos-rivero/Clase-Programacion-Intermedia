// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using PrincipiosSolid;

Console.WriteLine("Hello, World!");
var serviceProvider = new ServiceCollection()    
    .AddScoped<ILogging, Logging>()
    .AddScoped<Articulo>()
    .AddScoped<Cache>().BuildServiceProvider();

var articulo = serviceProvider.GetService<Articulo>();
articulo.ConsultarArticulo("test");
