using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop 迴圈示範
            for (int i = 1; i <= 20; i += 1) // 初始宣告;邊界條件;step步進
            {
                Console.WriteLine("i:" + i);
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 2; i <= 100; i += 2) // 偶數 2...100
            {
                Console.WriteLine("i:" + i);
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 100; i += 1) // 偶數 2...100
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("i:" + i);
                }
            }

            Console.WriteLine("-------------------------------------");
            
            for (int i = 10; i > 0 ; i -= 1) // 輸出 10...1
            {
                Console.WriteLine("i:" + i);
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 20; i += 1)
            {
                if (i > 9) 
                { 
                    break; // 中斷迴圈
                }
                Console.WriteLine("i:" + i);
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 20; i += 1)
            {
                if (i == 8)
                {
                    continue; // 跳過此次迴圈
                }
                Console.WriteLine("i:" + i);
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= 10; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= i; j += 1) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------");

            for (int i = 1; i <= 9; i += 1) 
            {
                for (int j = 1; j <= 9; j += 1)
                {
                    //Console.Write(i);
                    //Console.Write("x");
                    //Console.Write(j);
                    //Console.Write("=");
                    //Console.Write(i*j+", ");
                    Console.Write("{0}x{1}={2}, ",i,j,i*j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------");
            // 練習: 請用*輸出 等腰三角形, 菱形
            Console.WriteLine("等腰三角形");

            for (int i = 1; i <= 5; i += 1)
            {
                for (int k = 1; k <= 5-i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2*i-1; j += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("請輸入等腰三角形高度:");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);

            for (int i = 1; i <= b; i += 1)
            {
                for (int k = 1; k <= b - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("正三角形");
            for (int i = 1; i <= 7; i += 1)
            {
                for (int k = 1; k <= 7 - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("▲");
                }

                Console.WriteLine();
            }

            Console.Write("請輸入正三角形高度:");
            string c = Console.ReadLine();
            int d = Convert.ToInt32(c);
            for (int i = 1; i <= d; i += 1)
            {
                for (int k = 1; k <= d - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("▲");
                }

                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("菱形");
            for (int i = 1; i <= 5; i += 1)
            {
                for (int k = 1; k <= 5 - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = 1; i <= 6; i += 1)
            {
                for (int k = 1; k <= i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 9 - 2 * i; j += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("請輸入菱形對角長度:");
            string e = Console.ReadLine();
            int f = Convert.ToInt32(e);

            for (int i = 1; i <= f/2; i += 1)
            {
                for (int k = 1; k <= f/2 - i; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            if (f % 2 == 0)
            {
                for (int i = 1; i <= f / 2; i += 1)
                {
                    for (int k = 1; k <= i; k += 1)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= f - 1 - 2 * i; j += 1)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= f / 2; i += 1)
                {
                    for (int k = 1; k <= i; k += 1)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= f - 2 - 2 * i; j += 1)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }





            Console.WriteLine("-------------------------------------");
            // 課程作業加分題: 請輸出 聖誕樹 彩色 有裝飾 (可以任意輸入聖誕樹的高度 H)
            Console.WriteLine("聖誕樹\n");
            Console.Write("請輸入聖誕樹總高度:");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            int z = y / 5;
            y += 2 * z;
            for (int i = 1; i <= y / 4; i += 1)
            {
                for (int k = 1; k <= y / 4 - i; k += 1)
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
            for (int i = z; i <= y / 4; i += 1)
            {
                for (int k = 1; k <= y / 4 - i; k += 1)
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
            for (int i = z; i <= y / 4; i += 1)
            {
                for (int k = 1; k <= y / 4 - i; k += 1)
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
            for (int i = 1; i <= y / 4; i += 1)
            {
                for (int k = 1; k <= y / 8; k += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= y / 4; j += 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ResetColor();

            Console.WriteLine("-------------------------------------");



            //Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
