using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fib_Recursive(11);
        }
        public static void Fib_Recursive(int len_)
        {
            Fib(0, 1, 1, len_);
        }
        private static void Fib(int _a, int _b, int _count, int _len)
        {
            if (_count <= _len)
            {
                Console.Write("{0}", _a);
                Fib(_b,_a+_b,_count + 1,_len);
            }
        
        }
    }
}
