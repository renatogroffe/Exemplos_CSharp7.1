using System;

namespace ExemploDefaultExpressions
{
    class Program
    {
        private const double VALOR_TESTE = default;

        private static int MetodoExemplo1()
        {
            return default;
        }

        private static void MetodoExemplo2(decimal parametro = default)
        {
            Console.WriteLine(
                $"{nameof(MetodoExemplo2)} - Valor recebido como parâmetro = {parametro}");
        }

        private static void ConverterData(string valor)
        {
            DateTime resultado =
                DateTime.TryParse(valor, out resultado) ? resultado : default;

            Console.WriteLine(
                $"{nameof(ConverterData)} - " +
                $"Parâmetro de entrada: {valor} " +
                $"Resultado: {resultado}");
        }

        private static void ImprimirArray()
        {
            int[] exemploArray = { default, 2, 4, 8, 10 };

            Console.Write($"{nameof(ImprimirArray)} = [  ");
            foreach (int valor in exemploArray)
                Console.Write($"{valor}  ");
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{nameof(VALOR_TESTE)} = {VALOR_TESTE}");
            Console.WriteLine($"{nameof(MetodoExemplo1)} = {MetodoExemplo1()}");

            float variavelTeste = default;
            Console.WriteLine($"{nameof(variavelTeste)} = {variavelTeste}");

            MetodoExemplo2();

            ConverterData("ERRO");
            ConverterData("27/08/2017");

            ImprimirArray();

            Console.ReadKey();
        }
    }
}

/*
 
        class Program
    {
        private const double VALOR_TESTE = default(double);

        private static int MetodoExemplo1()
        {
            return default(int);
        }

        private static void MetodoExemplo2(decimal parametro = default(decimal))
        {
            Console.WriteLine(
                $"{nameof(MetodoExemplo2)} - Valor recebido como parâmetro = {parametro}");
        }

        private static void ConverterData(string valor)
        {
            DateTime resultado =
                DateTime.TryParse(valor, out resultado) ? resultado : default(DateTime);

            Console.WriteLine(
                $"{nameof(ConverterData)} - " +
                $"Parâmetro de entrada: {valor} " +
                $"Resultado: {resultado}");
        }

        private static void ImprimirArray()
        {
            int[] exemploArray = { default(int), 2, 4, 8, 10 };

            Console.Write($"{nameof(ImprimirArray)} = [  ");
            foreach (int valor in exemploArray)
                Console.Write($"{valor}  ");
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{nameof(VALOR_TESTE)} = {VALOR_TESTE}");
            Console.WriteLine($"{nameof(MetodoExemplo1)} = {MetodoExemplo1()}");

            float variavelTeste = default(float);
            Console.WriteLine($"{nameof(variavelTeste)} = {variavelTeste}");

            MetodoExemplo2();

            ConverterData("ERRO");
            ConverterData("27/08/2017");

            ImprimirArray();

            Console.ReadKey();
        }
    }
     
     */
