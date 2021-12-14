using ClassLibrary1;
using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(15, 5);
            calculator.Sub(15, 5);
            calculator.Mul(15, 5);
            calculator.Div(15, 5);
        }
    }
}
