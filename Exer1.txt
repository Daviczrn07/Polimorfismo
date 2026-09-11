namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria geo = new Geometria();

            double areaQuadrado = geo.CalcularArea(4.0);
            double areaRetangulo = geo.CalcularArea(5.0, 3.0);
            double areaCirculo = geo.CalcularArea(3.0, true);

            Console.WriteLine($"Área do Quadrado: {areaQuadrado:F2}");
            Console.WriteLine($"Área do Retângulo: {areaRetangulo:F2}");
            Console.WriteLine($"Área do Círculo: {areaCirculo:F2}");
        }
    }
}
