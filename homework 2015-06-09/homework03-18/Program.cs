using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_18
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game();
        }

        public static int GetUserInput()
        {
            Console.Write("請輸入你要出的拳:1.剪刀,2.石頭,3.布");
            return int.Parse(Console.ReadLine());
        }

        public static int GetNpcInput()
        {
            Random random = new Random();

            return random.Next(1, 4);
        }

        public static void GetResult(int person1, int person2)
        {
            string message = "第一個人出{0}, 第二個人出{1}";
            message = string.Format(message, person1, person2);
            Console.WriteLine(message);
            int result = person1 - person2;
            switch (result)
            {
                case 0:
                    Console.WriteLine("兩個人平手!");
                    break;

                case 1:
                    Console.WriteLine("您贏了!");
                    break;

                case 2:
                    Console.WriteLine("電腦贏了!");
                    break;

                case -1:
                    Console.WriteLine("電腦贏了!");
                    break;

                case -2:
                    Console.WriteLine("您贏了!");
                    break;
            }
        }

        public static void Game()
        {
            int person1 = GetUserInput();
            int person2 = GetNpcInput();
            GetResult(person1, person2);
        }
    }
}