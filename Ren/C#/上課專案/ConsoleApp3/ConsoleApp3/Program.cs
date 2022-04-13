using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 算術運算子
            int x = 9;
            int y = 4;
            int z;
            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y; //整數相除取小數點，非四捨五入
            z = x % y;
            z = -y;
            z = x + y * y;
            z = (x - y) / y;

            int x2 = 5;
            double y2 = 1.1234;
            double y21 = 1.000000000000000001234; //超出精確16位，自動省略為1
            double z2;
            double z21;
            z2 = x2 * y2;
            z21 = x2 * y21;
            z2 = x2 / y2;

            Console.WriteLine("z的值為:" + z);
            Console.WriteLine("z2的值為:" + z2);
            Console.WriteLine("z21的值為:" + z21);
            Console.WriteLine("--------------------------------------");

            // 算術指定運算子
            int c = 250;
            int d = 100;
            //c += 3; // c = c + 3
            //c -= 3;
            //c /= 3;
            //c *= 3;
            //c %= 3;
            c += d;

            Console.WriteLine("c的值為:" + c);
            Console.WriteLine("--------------------------------------");

            // 遞增遞減運算子
            int r = 8;
            r++; // r = r + 1
            r--; // r = r - 1

            Console.WriteLine("r的值為:" + r);
            Console.WriteLine("--------------------------------------");

            // 關係運算子
            double m = 85.23;
            double n = 45.64;
            bool compare;
            compare = m == n;
            compare = m != n;
            compare = m >= n;
            compare = m > n;
            compare = m <= n;
            compare = m < n;

            Console.WriteLine("compare:" + compare);
            Console.WriteLine("--------------------------------------");

            // 複合關係運算式
            float p = 56.78f;
            float w = 92.31f;
            bool logic;

            logic = (p < w) && (p >= 50.0f); // AND 兩邊都True才是True
            logic = (p > 60.0f) && (p != w);
            logic = (w <= 80.0f) || (p <= w); // OR 只要一邊True就是True
            logic = (p > w) || (w < 20.0f);
            logic = (p > 40.0f) && (w < 120.0f) && (p == w);
            logic = (p > 10.0f) || (w > 75.0f) || (p >= w);
            logic = (p > 20.0f) || (w < 50.0f) && (p > w); // 不括號會先算&&
            logic = ((p > 20.0f) || (w < 50.0f)) && (p < w); // 順序自己括清楚
            //logic = !(w < p); // ! 反轉

            Console.WriteLine("logic:" + logic);
            Console.WriteLine("--------------------------------------");



            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
