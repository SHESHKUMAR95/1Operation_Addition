using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Operation_Addition
{
    internal class Program
    {
        public void Addition()
        {
            int a = 10, b = 20;
            int c = a + b;
            Console.WriteLine("Addition : " + c);
        }
        static void Main(string[] args)
        {
            Program op = new Program(); 
            op.Addition();
            Console.ReadLine(); 
        }
    }
}
