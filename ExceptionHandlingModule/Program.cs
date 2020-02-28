using System;
using ParseString;

namespace ExceptionHandlingModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            var line = Console.ReadLine(); //use explicit type for variable 'string' instead of 'var'
            try
            {
                WriteFirstStringSymbol(line);
            }
            catch (EmptyStringException ex)
            {
                //  Console.WriteLine(ex.Message);
            }
        }

        public static void WriteFirstStringSymbol(string line)// let's simplify the name as WriteFirstSymbol
        {
            if (line == string.Empty) // use string.IsNullOrEmpty() to check 'line'
            {
                throw new EmptyStringException(); // pass exception message
            }
            else
            {
                Console.WriteLine(line[0]);
            }
        }
    }
}
