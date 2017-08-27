using System;
using System.Linq;
using System.IO;

namespace ExemploInferenciaTuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            // O nome de cada propriedade das tuplas será
            // inferido durante a execução do método Select
            var arquivos = new DirectoryInfo(@"C:\Windows\")
                .GetFiles().Where(a => a.Name.StartsWith("W"))
                .Select(a => (a.Name, a.FullName));
            foreach (var arq in arquivos)
                Console.WriteLine(arq.Name + " -> " + arq.FullName);

            Console.ReadKey();
        }
    }
}