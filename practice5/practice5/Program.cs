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
        public static void Main()
        {
            WriteLine("sdsd");
            int cur = 1;
            int SizeType = 0;
            int ssss = 0;
            if (Saving.Corzina.Count>0) for (var i = 0; i < Saving.Corzina.Count; i++) ssss+=Saving.Corzina[i].Price;
            

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
                WriteLine("  Корзина: " + ssss);
                SetCursorPosition(0, cur);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch(sss.Key){
                    case ConsoleKey.UpArrow:
                        if (cur == 1) cur = 10;
                        cur--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cur == 9) cur = 0;
                        cur++;
                        break;
                    case ConsoleKey.Enter:
                        if (cur > 0 && cur < 3) SizeType = 1;
                        if (cur > 2 && cur < 6) SizeType = 2;
                        if (cur > 5 && cur < 9) SizeType = 3;
                        if (cur > 9 && cur != 12) break;


                        clas.TakeTheItem(cur, SizeType);
                        break;
                    
                }
            }
        }
        private void FinishTheOrder()
        {
            Clear();
            DateTime a = DateTime.Now;
            WriteLine("Заказ номер: "+ 121);
            WriteLine(a);
            for (var i = 0; i < Saving.Corzina.Count; i++) {
                WriteLine("Позиция " + i);
                WriteLine(Saving.Corzina[i].Position);
                WriteLine(Saving.Corzina[i].Size);
                WriteLine(Saving.Corzina[i].Price);
            }
            ReadKey();
        }
        public void Package()
        {
            int cur = 1;
            while (true) { 
                for(var i=0; i<Saving.Corzina.Count; i++)
                    {
                    WriteLine("1x  "+Saving.Corzina[i].Position);
                    }
                WriteLine(" Отчистить корзину");
                SetCursorPosition(1, cur);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey();
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (cur == 1) cur = Saving.Corzina.Count+1;
                        cur--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cur == Saving.Corzina.Count+1) cur = 1;
                        cur++;
                        break;
                    case ConsoleKey.Enter: 
                        if (cur!= Saving.Corzina.Count + 1) Deleting(cur); 
                        else Saving.Corzina.Clear(); Main(); break;
                        
                }
            }
        }
        public void Deleting(int PositionIndex)
        {
            WriteLine("Корзина\n\n Удалить позицию?");
            ConsoleKeyInfo aaa = ReadKey();
            if (aaa.Key == ConsoleKey.Enter)
            {
                Saving.Corzina.RemoveAt(PositionIndex);
                //переход в корзину
            }
            else Main();//переход в корзину
                


        }
            
    }
}
