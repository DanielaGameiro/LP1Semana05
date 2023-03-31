using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sem argumentos passados
            if (args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
            }

            // Com argumentos passados
            else
            {
                // Meter em maiúsculas com ToUpper()
                for (int i = 0; i < args.Length; i++)
                {
                    args[i] = args[i].ToUpper();
                }

                // Ordenar com Sort()
                Array.Sort(args);

                // Unir com StringBuilder()
                StringBuilder finalString = new StringBuilder();
                finalString.Append(String.Join("-", args));

                Console.WriteLine(finalString);
            }
        }
    }
}

