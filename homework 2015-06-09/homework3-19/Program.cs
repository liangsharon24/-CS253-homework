using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_19
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入任一月份:");
            int month = int.Parse(Console.ReadLine());
            switch (month / 3)
            {
                case 0:
                    Console.WriteLine("現在是冬天");
                    break;

                case 1:
                    Console.WriteLine("現在是春天");
                    break;

                case 2:
                    Console.WriteLine("現在是夏天");
                    break;

                case 3:
                    Console.WriteLine("現在是秋天");
                    break;

                case 4:
                    Console.WriteLine("現在是冬天");
                    break;
            }
        }
    }
}