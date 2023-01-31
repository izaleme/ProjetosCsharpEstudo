using System;
using System.Globalization;

namespace ExercicioStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qntdeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConvertDolarToReal(cotDolar, qntdeDolar);

            Console.WriteLine("Valor a ser pago em reais: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
