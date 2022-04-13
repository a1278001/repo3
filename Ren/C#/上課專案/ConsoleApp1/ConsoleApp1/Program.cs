using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 單行註解
            /* 多行註解
             1234
             ABCD
             */
            System.Console.WriteLine("Hello World!!"); //命名空間、類別、函式(字串輸出)
            System.Console.WriteLine("Hi, 這是第一個Console程式");
            Console.WriteLine("C# 語言第一個示範");
            Console.WriteLine("C# Demo");
            Console.ForegroundColor = ConsoleColor.Yellow; //更改字體顏色
            Console.BackgroundColor = ConsoleColor.Blue; //更改背景顏色
            Console.WriteLine("1. 主控台應用程式");
            Console.WriteLine("2. Windows Form 應用程式");
            Console.WriteLine("3. Web 應用程式");
            Console.WriteLine(); //換行
            Console.ResetColor(); //重置顏色
            Console.WriteLine("特殊字元符號");
            Console.WriteLine("\"雙引號\""); //反斜線後可輸出符號
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\t縮排"); //按一次Tab的距離(4個字元)
            Console.WriteLine("\t\t\t縮排");
            Console.WriteLine("\n換行");
            Console.WriteLine("\n\n\n換行");
            
            Console.WriteLine("按Enter結束程式");
            System.Console.ReadLine(); //等待使用者輸入
        }
    }
}
