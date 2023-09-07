namespace AplicacionDeConsola
{
    public class Vehiculo
    {
        public int VelocidadMaxima { get; set; }
        public int CantidadDeRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public string MostrarDatos()
        {
            return $"Auto Marca: {Marca}, Modelo: {Modelo}";
        }
        public void MostrarFigura(IFigura nuevaFigura){
            Console.WriteLine(nuevaFigura.Area());
            Console.WriteLine(nuevaFigura.Perimetro());
        }
    }
}
