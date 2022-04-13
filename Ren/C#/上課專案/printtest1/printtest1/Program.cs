using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printtest1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 課程作業加分題: 請輸出 聖誕樹 彩色 有裝飾 (可以任意輸入聖誕樹的高度 H)
            Console.WriteLine("聖誕樹\n");
            Console.Write("請輸入聖誕樹總高度:");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            int z = y/5;
            y += 2*z;
            for (int i = 1; i <= y/4; i += 1)
            {
                for (int k = 1; k <= y/4 - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j += 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
            for (int i = z;i <= y/4; i += 1)
            {
                for (int k = 1; k <= y/4 - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j += 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
            for (int i = z; i <= y/4; i += 1)
            {
                for (int k = 1; k <= y/4 - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j += 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
            for (int i = 1; i <= y/4; i += 1)
            {
                for (int k = 1; k <= y/8; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= y/4; j += 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ResetColor();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
