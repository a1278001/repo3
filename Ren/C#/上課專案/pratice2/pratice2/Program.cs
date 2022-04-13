using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用條件判斷式，隨意輸入三個數字比大小，按大小排序輸出
            Console.Write("請輸入a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入c:");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("a > b > c");
                }
                else if (c > b)
                {
                    Console.WriteLine("a > c > b");
                }
                else
                {
                    Console.WriteLine("a > b = c");
                }

            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("b > a > c");
                }
                else if (c > a)
                {
                    Console.WriteLine("b > c > a");
                }
                else
                {
                    Console.WriteLine("b > a = c");
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("c > a > b");
                }
                else if (b > a)
                {
                    Console.WriteLine("c > b > a");
                }
                else
                {
                    Console.WriteLine("c > a = b");
                }
            }
            else if (b == c)
            {
                if (b > a)
                {
                    Console.WriteLine("b = c > a");
                }
                else
                {
                    Console.WriteLine("a = b = c");
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("a = c > b");
                }
            }



            Console.WriteLine("-------------------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
