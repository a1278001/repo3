using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("=========   超好吃下午茶    =========");
                Console.WriteLine("=====================================");
                Console.WriteLine("甜點選擇:(代號 a:布丁, b:冰淇淋, c:奶酪, d:紅豆湯)");
                Console.WriteLine("結束選單請輸入exit");
                Console.WriteLine("輸入完成請按Enter");
                string ss = Console.ReadLine();

                switch (ss) // (基本資料型態，除了浮點數)
                {
                    case "a":
                        Console.WriteLine("您選了布丁 60元");
                        break;
                    case "b":
                        Console.WriteLine("您選了冰淇淋 80元");
                        break;
                    case "c":
                        Console.WriteLine("您選了奶酪 100元");
                        break;
                    case "d":
                        Console.WriteLine("您選了紅豆湯 70元");
                        break;
                    default:
                        Console.WriteLine("無此產品");
                        break;
                }

                if (ss == "exit")
                {
                    break;
                }

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("按任意鍵結束");
                Console.ReadKey();
            }
        }
    }
}
