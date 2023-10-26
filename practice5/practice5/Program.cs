using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace practice5
{
    class Program
    {
        static void Main()
        {
            WriteLine("sdsd");
            int cur = 1;
            int SizeType = 0;
            while (true)
            {
                Class1 clas = new Class1();
                Clear();
                WriteLine("  hello");
                WriteLine("  number 1");
                WriteLine("  number 2");
                WriteLine("  number 3");
                WriteLine("  number 4");
                WriteLine("  number 5");
                WriteLine("  number 6");
                WriteLine("  number 7");
                WriteLine("  number 8");
                SetCursorPosition(0, cur);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch(sss.Key){
                    case ConsoleKey.UpArrow:
                        if (cur == 1) cur = 9;
                        cur--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cur == 8) cur = 0;
                        cur++;
                        break;
                    case ConsoleKey.Enter:
                        if (cur > 0 && cur < 3) SizeType = 1;
                        if (cur > 2 && cur < 6) SizeType = 2;
                        if (cur > 5 && cur < 9) SizeType = 3;
                        clas.TakeTheItem(cur, SizeType);
                        break;
                }
                
                

            }
        }
    }
}
