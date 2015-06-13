using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入任意整數:");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i = i + 2)
                sum += i;
            Console.WriteLine("{0}", sum);
        }
    }
}