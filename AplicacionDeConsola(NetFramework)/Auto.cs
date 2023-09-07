using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola_NetFramework_
{
    public class Auto : Vehiculo
    {
        public string Traccion { get; set; }
        public Auto(string marca, string modelo, string traccion) : base(marca, modelo)
        {
            Traccion = traccion;
        }
        public override string MostrarDatos(string tipoDeVehiculo)
        {
            
            return base.MostrarDatos(tipoDeVehiculo); 
        }
    }
}
