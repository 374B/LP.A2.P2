using System;
using System.IO;
using LP.A2.P2.Implementations;

namespace LP.A2.P2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usually you'd set this up with DI
            var fileReverser = new FileReverser(
                new DefaultFileReader(),
                new DefaultFileWriter(),
                new ReversalLogic());

            //There error handling here is poorly designed and there is no validation
            //The focus of this exercise was not the console app

            try
            {

                Console.Write("Input path: ");
                var inPath = Console.ReadLine();

                Console.Write("Output path:");
                var outPath = Console.ReadLine();

                var outFile = fileReverser.Reverse(inPath, outPath);

                Console.WriteLine();

                Console.WriteLine($"File created: {outFile.FullName}");
                Console.WriteLine($"Contents:\n\n");

                foreach (var line in File.ReadLines(outFile.FullName))
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}