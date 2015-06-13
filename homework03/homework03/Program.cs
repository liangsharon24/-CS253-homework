using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = GetUserName();
            int gender = GetGuessGender();
            ShowGuessMessage(name, gender);
            GuessUserGender();
        }

        public static string GetUserName()
        {
            Console.WriteLine("請輸入您的姓名:");
            return Console.ReadLine();
        }

        public static int GetGuessGender()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }

        public static void ShowGuessMessage(string name, int gender)
        {
            if (gender == 0)
            {
                Console.WriteLine("我猜{0}您是個男生", name);
            }
            else
            {
                Console.WriteLine("我猜{0}您是個女生", name);
            }
        }

        public static void GuessUserGender()
        {
            Console.WriteLine("請問我猜對了嗎?請輸入Y/N");
            string ans = Console.ReadLine();
            Console.WriteLine(Answer(ans) ? "哈哈，我猜對了" : "阿...猜錯了");
        }

        public static bool Answer(string ans)
        {
            return ans == "Y" || ans == "y" || ans == "YES" || ans == "Yes" || ans == "yes";
        }
    }
}