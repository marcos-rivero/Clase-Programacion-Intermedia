using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola_NetFramework_
{
    public class Vehiculo
    {
        public int VelocidadMaxima { get; set; }
        public int? CantidadDeRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public Vehiculo(){}
        public virtual string MostrarDatos(string tipoDeVehiculo)
        {
            string DatosCambiados = CambiarDatos();
            return $"Vehiculo: {tipoDeVehiculo} Marca: {Marca}, Modelo: {Modelo} Datos {DatosCambiados}";
        }

        private string CambiarDatos(){
            return "Datos cambiados";
        }
    }
}
