using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola_NetFramework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto("Bajaj", "Kaizer", 125);
            //moto.CantidadDeRuedas = 2;
            //Moto moto2 = new Moto(150);
            Auto auto = new Auto("Toyota", "Etios", "Trasera");
            Console.WriteLine(moto1.MostrarDatos(nameof(moto1)));
            Console.WriteLine(auto.MostrarDatos(nameof(moto1)));
            //auto.CambiarDatos();
            Console.WriteLine($"Moto Marca: {moto1.Marca}, Modelo: {moto1.Modelo}, Cilindrada: {moto1.Cilindrada}");
            Console.WriteLine($"Auto Marca: {auto.Marca}, Modelo: {auto.Modelo}, Traccion: {auto.Traccion}");
            Console.WriteLine("Hello World .Net Framework");
            
            
            Console.ReadLine();

        }
    }
}
