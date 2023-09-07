// See https://aka.ms/new-console-template for more information
using AplicacionDeConsola;

Console.WriteLine("Hello, World!");
IFigura cuadrado = new Cuadrado(5);
IFigura triangulo = new Triangulo(6, 10);
Vehiculo auto = new Vehiculo("Peugeot", "208");
auto.MostrarFigura(cuadrado);
auto.MostrarFigura(triangulo);

//Console.WriteLine(cuadrado.Area().ToString());
//Console.WriteLine(cuadrado.Perimetro());
//Console.WriteLine(triangulo.Area().ToString());
//Console.WriteLine(triangulo.Perimetro());
