using Mathlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            Console.WriteLine($"Add: {m.Add(5, 7)}");
            Console.WriteLine($"Add: {m.Subtract(8, 7)}");
            Console.WriteLine($"Add: {m.Multiply(5, 7)}");
            Console.WriteLine($"Add: {m.Divide(8, 7)}");
        }
    }
}
