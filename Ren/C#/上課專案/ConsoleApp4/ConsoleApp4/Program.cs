using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // if ... else 條件判斷式
            int x = 40;
            int y = 40;

            if (x > y)
            { // True執行
                Console.WriteLine("x 大於 y");
            }
            else
            { // False執行
                Console.WriteLine("x 小於或等於 y");
            }

            if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else
            {
                if(x == y)
                {
                    Console.WriteLine("x 等於 y");
                }
                else
                {
                    Console.WriteLine("x 小於 y");
                }
            }

            if (x == y)
            {
                Console.WriteLine("x 等於 y");
            }
            else if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else if (x < y)
            {
                Console.WriteLine("x 小於 y");
            }
            else
            {
                Console.WriteLine("不存在");
            }

            // if ... else 簡式
            int w = -3;
            int s = 6;

            if (w < 0)
            {
                s = -1;
            }
            else
            {
                s = w * 2;
            }
            Console.WriteLine("s:" + s);

            s = (w < 0) ? -1 : (w * 2); //指定s值，(條件) ? 成立 : 不成立
            Console.WriteLine("簡式s:" + s);

            // Switch ... case
            Console.WriteLine("=====================================");
            Console.WriteLine("甜點選擇:(代號 a:布丁, b:冰淇淋, c:奶酪, d:紅豆湯)");
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



            Console.WriteLine("-------------------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
