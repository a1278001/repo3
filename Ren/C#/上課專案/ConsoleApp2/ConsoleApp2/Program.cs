using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 變數 Varible 的宣告
            short a; //宣告2^16/2以內的整數，16位元
            a = 32767;
            int amount = 2147483647; //宣告2^32/2以內的整數，32位元
            long count = 9223372036854775807; //宣告2^64/2以內的整數，64位元
            //無正負號
            ushort aa = 65535; //宣告2^16以內的整數，16位元
            uint aamount = 4294967295; //宣告2^32以內的整數，32位元
            ulong ccount = 18446744073709551615; //宣告2^64以內的整數，64位元

            Console.WriteLine("整數的宣告");
            Console.WriteLine(a);
            Console.WriteLine(amount);
            Console.WriteLine(count);
            Console.WriteLine(aa);
            Console.WriteLine(aamount);
            Console.WriteLine(ccount);

            // 浮點數
            float average = 888.23f; // float後面要加f，若沒f會視為double
            double pi = 3.141592;
            Console.WriteLine("平均:" + average);
            Console.WriteLine("圓周率:" + pi);

            // 布林 Boolean
            bool isSuccess = true;
            bool isFinish = false;
            Console.WriteLine("是否成功:" + isSuccess);
            Console.WriteLine("是否完成:" + isFinish);

            // 字串 string
            string name = "王大衛";
            string 電話 = "0912-345-678";
            string email = "test@mmm.com";
            Console.Write("姓名:");
            Console.Write(name);
            Console.Write(", 電話:" + 電話);
            Console.Write(", email:" + email);
            Console.WriteLine();

            // 字元 char
            char myCharOne = 'x';
            char myCharTwo = '微';
            Console.WriteLine("字元輸出:" + myCharOne + myCharTwo);

            // 字串插入，字串插值
            Console.WriteLine("姓名:{0}, 電話:{1}, email:{2}, age:{3}", name, 電話, email, 36);
            // 變數插入
            Console.WriteLine($"姓名:{name}, 電話:{電話}, email:{email}, age:{36}");

            //Console.WriteLine("\n按Enter結束");
            //Console.ReadLine();

            Console.WriteLine("\n按任意鍵結束");
            Console.ReadKey(); //等待使用者輸入任意鍵

        }
    }
}
