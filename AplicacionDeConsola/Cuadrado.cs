namespace AplicacionDeConsola
{
    public class Cuadrado : IFigura
    {
        public Cuadrado(decimal lado)
        {   
            Lado = lado;
        }
        public decimal Lado { get; set; }

        public decimal Area()
        {
            return Lado*Lado;
        }

        public decimal Suma(decimal valor1)
        {
            return valor1+Lado;
        }
        public decimal Suma(decimal valor1, decimal valor2)
        {
            return valor1 + valor2 + Lado;
        }
        public decimal Suma(int valor1, decimal valor2)
        {
            return valor1 + valor2 + Lado;
        }
        public decimal Suma(decimal valor1, int valor2)
        {
            return valor1 + valor2 + Lado;
        }
        public decimal Perimetro()
        {
            return Lado*4;
        }
    }
}
