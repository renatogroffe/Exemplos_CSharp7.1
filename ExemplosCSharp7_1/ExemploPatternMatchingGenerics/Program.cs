using System;

namespace ExemploPatternMatchingGenerics
{
    class Program
    {
        private static DateTime? ConverterData<T>(T valor) where T: IComparable
        {
            switch (valor)
            {
                case string texto:
                    return Convert.ToDateTime(texto);
                case DateTime data:
                    return data;
                default:
                    Console.WriteLine($"{valor} não é uma data válida!");
                    return null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConverterData("27/08/2017"));
            Console.WriteLine(ConverterData(
                new DateTime(2017, 08, 28, 15, 30, 12)));
            Console.WriteLine(ConverterData(30));

            Console.ReadKey();
        }
    }
}