using System;
using ParseString;

namespace ExceptionHandlingModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string line = Console.ReadLine();
            try
            {
                WriteFirstSymbol(line);
            }
            catch (EmptyStringException ex)
            {
            }
            Console.ReadKey();
        }

        public static void WriteFirstSymbol(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                throw new EmptyStringException("String is empty");
            }
            else
            {
                Console.WriteLine(line[0]);
            }
        }
    }
}
