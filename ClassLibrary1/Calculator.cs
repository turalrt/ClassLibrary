using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public int n;
        public int m;
        public void Add(int n, int m)
        {
            Console.WriteLine(n + m);
        }
        public void Sub(int n, int m)
        {
            Console.WriteLine(n - m);
        }
        public void Mul(int n, int m)
        {
            Console.WriteLine(n * m);
        }
        public void Div(int n, int m)
        {
            Console.WriteLine(n / m);
        }
    }
}
