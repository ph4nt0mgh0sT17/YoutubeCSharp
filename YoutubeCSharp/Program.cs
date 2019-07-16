using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Type a second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");

            Console.ReadLine();
        }
    }
}
