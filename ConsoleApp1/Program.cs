using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "5";
            string data2 = "2";
            int a = int.Parse(data);
            int b = int.Parse(data2);
            int result = a + b;
            Console.WriteLine(result);
        }
        
    }
}
