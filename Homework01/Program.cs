using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = GetUserName();
            string gender = GetUserGender();
            ShowMessage(name, gender);
        }

        public static string GetUserName()
        {
            Console.Write("請輸入您的大名:");
            return Console.ReadLine();
        }

        public static string GetUserGender()
        {
            Console.Write("請輸入您的性別:");
            return Console.ReadLine();
        }

        public static void ShowMessage(string name, string gender)
        {
            Console.WriteLine("{0}您好", name);
            Console.WriteLine("我猜{0}您一定是{0}!!", name, gender);
        }
    }
}