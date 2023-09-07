using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola
{
    public class Triangulo : IFigura
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal Hipotenusa { get; set; }
        public Triangulo(decimal ladoA, decimal ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            Hipotenusa = CalcularHipotenusa(ladoA, ladoB);
        }
        private decimal CalcularHipotenusa(decimal ladoA, decimal ladoB)
        {
            return Convert.ToDecimal(Math.Sqrt((double)(LadoA * LadoB + LadoB * LadoB)));
        }
        public decimal Area()
        {
            return LadoA * LadoB / 2;
        }

        public decimal Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}
