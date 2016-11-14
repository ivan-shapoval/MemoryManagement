using System;

namespace Convestudo.Unmanaged
{
    class Program
    {
        private static void Main(string[] args)
        {
            var fileWriter = new FileWriter("Test.txt");
            fileWriter.Write("First test string");

            fileWriter.Dispose();
          

            Console.ReadKey();
        }
    }
}
