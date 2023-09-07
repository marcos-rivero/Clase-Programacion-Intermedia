using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola_NetFramework_
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }
        public Moto(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
        public override string MostrarDatos(string nombreObjeto)
        {
            return base.MostrarDatos(nombreObjeto) + $" Cilindrada: {Cilindrada}";
        }
    }
}
