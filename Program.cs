using System;

namespace CalculoComRaio
{
    class Program
    {
        static Double calculaDiametro(Double r)
        {
            Double retorno = 2 * r;
            return retorno;
        }
        static Double calculaArea(Double r)
        {
           return (3.14 * (r*r));
        }
        static Double calculaCircunferencia(Double r)
        {
            return (2 * 3.14 * r);
        }

        static void exibeResultado(Double a, Double d, Double c) 
        {
            Console.WriteLine("Area: " + a);
            Console.WriteLine("Diâmetro: " + d);
            Console.WriteLine("Circunferência: " + c);
         }
        static void Main(string[] args)
        {
            //Faça um programa que calcule o diâmetro, a área e a circunferêncoa de um círculo
            //sabendo que o único dado disponível é o seu raio.
            //Fórmula: Diâmetro = 2*raio
            //Área = π*raio2
            //Circunferência = 2* π*raio

            Double raio = 0;
            Double area = 0;
            Console.WriteLine("calcula o diâmetro, a área e a circunferência de um círculo");
            Console.Write("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            area = calculaArea(raio);
            exibeResultado(area, calculaDiametro(raio), calculaCircunferencia(raio));
            //Console.WriteLine("Area: " + area);
            //Console.WriteLine("Diâmetro: " + calculaDiametro(raio));
            //Console.WriteLine("Circunferência: " + calculaCircunferencia(raio));
            Console.ReadKey();

        }
    }
}
