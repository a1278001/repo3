using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeOutputConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;Console.Write("using ");
            Console.ResetColor();Console.Write("System;\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("System.Collections.Generic;\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("System.Linq;\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("System.Text;\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("System.Threading.Tasks;\n");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;Console.Write("namespace ");
            Console.ResetColor();Console.Write("ConsoleApp1\n");

            Console.Write("{\n");

            Console.ForegroundColor = ConsoleColor.Blue;Console.Write("\tclass ");
            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Program\n");

            Console.ResetColor();Console.Write("\t{\n");

            Console.ForegroundColor = ConsoleColor.Blue;Console.Write("\t\tstatic void ");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("Main");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Blue;Console.Write("string");
            Console.ResetColor();Console.Write("[] ");
            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("args");
            Console.ResetColor();Console.Write(")\n");

            Console.Write("\t\t{\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\t\t\t// 單行註解\n");
            Console.Write("\t\t\t/* 多行註解\n");
            Console.Write("\t\t\t 1234\n");
            Console.Write("\t\t\t ABCD\n");
            Console.Write("\t\t\t*/\n");

            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("\t\t\tSystem.");
            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Console.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"Hello World!!\"");
            Console.ResetColor();Console.Write(");");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //命名空間、類別、函式\n");

            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("\t\t\tSystem.");
            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Console.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"Hi, 這是第一個Console程式\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"C# 語言第一個示範\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"C# Demo\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ResetColor();Console.Write("ForegroundColor = ");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write(".Yellow;");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //更改字體顏色\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ResetColor();Console.Write("BackgroundColor = ");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write(".blue;");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //更改背景顏色\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"1. 主控台應用程式\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"2. Windows Form 應用程式\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"3. Web 應用程式\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("();");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //換行\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("ResetColor");
            Console.ResetColor();Console.Write("();");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //重置顏色\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"特殊字元符號\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\\"雙引號\"\\\"");
            Console.ResetColor();Console.Write(");");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //反斜線後可輸出符號\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\\\反斜線\\\\\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\\'單引號\\\'\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\t縮排\"");
            Console.ResetColor();Console.Write(");");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //按一次Tab的距離(4個字元)\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\t\\t\\t縮排\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\n換行\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"\\n\\n\\n換行\"");
            Console.ResetColor();Console.Write(");\n");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("\t\t\tConsole.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("WriteLine");
            Console.ResetColor();Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("\"按Enter結束程式\"");
            Console.ResetColor();Console.Write(");\n");

            Console.ForegroundColor = ConsoleColor.Gray;Console.Write("\t\t\tSystem.");
            Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Console.");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("ReadLine");
            Console.ResetColor();Console.Write("();");
            Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write(" //等待使用者輸入\n");

            Console.ResetColor();Console.Write("\t\t}\n");
            Console.Write("\t}\n");
            Console.Write("}\n");

            System.Console.ReadLine(); //等待使用者輸入
        }
    }
}
