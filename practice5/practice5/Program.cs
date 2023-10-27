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
                WriteLine("  Магазин одежды by twixxxxx\n Кроссовки NIKE АIR FORCE\n Ботинки TIMBERLAND\n Футболка HUGO BOSS\n Худи CALVIN KLEIN\n Худи LACOSTA\n Джинсы ARMANI\n Шорты GUCCI\n Штаны GLORIA JEANS\n\n Оформить заказ\n Корзина: " + ssss);
                SetCursorPosition(0, cur);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch(sss.Key){
                    case ConsoleKey.UpArrow:if (cur == 1) cur = 12; cur--; break;
                    case ConsoleKey.DownArrow: if (cur == 11) cur = 0; cur++; break;
                    case ConsoleKey.Enter:
                        if (cur > 0 && cur < 3) clas.TakeTheItem(cur, 1);
                        if (cur > 2 && cur < 6) clas.TakeTheItem(cur, 2);
                        if (cur > 5 && cur < 9) clas.TakeTheItem(cur, 3);
                        if (cur == 10) FinishTheOrder(ssss);
                        if (cur == 11) Package();
                        else Main(); break;
                }
            }
        }
        public static void FinishTheOrder(int ssss)
        {
            Clear();
            DateTime a = DateTime.Now;
            WriteLine("Заказ номер: "+ 121);
            WriteLine(a);
            for (var i = 0; i < Saving.Corzina.Count; i++) {
                File.AppendAllText("C:\\Users/mixar/Desktop/Order_History.txt", "\nПозиция " + i);
                File.AppendAllText("C:\\Users/mixar/Desktop/Order_History.txt", "\nНазвание: " +Saving.Corzina[i].Position);
                File.AppendAllText("C:\\Users/mixar/Desktop/Order_History.txt", "\nРазмер: " + Saving.Corzina[i].Size);
                File.AppendAllText("C:\\Users/mixar/Desktop/Order_History.txt", "\nЦена: " + Saving.Corzina[i].Price);
                
            }
            File.AppendAllText("C:\\Users/mixar/Desktop/Order_History.txt", "\nОбщая цена: " +ssss+ "\n\n\n\n");
            Saving.Corzina.Clear();
            Clear();
            WriteLine("Заказ оформлен");
            ReadKey();
            Main();
        }
        static void Package()
        {
            Clear();
            int cur = 1;
            while (true) { 
                Clear();
                WriteLine("");
                for(var i=0; i<Saving.Corzina.Count; i++)
                    {
                    WriteLine(" 1x  "+Saving.Corzina[i].Position);
                    }
                WriteLine(" Отчистить корзину\n\n  Назад");
                SetCursorPosition(0, cur);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey();
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow : if (cur == 1) cur = Saving.Corzina.Count+4; cur--; break;
                    case ConsoleKey.DownArrow : if (cur == Saving.Corzina.Count+3) cur = 0; cur++; break;
                    case ConsoleKey.Enter: 
                        if (cur< Saving.Corzina.Count + 1) Deleting(cur); 
                        else Saving.Corzina.Clear();    
                        Main();
                        break;
                }
            }
        }
        static void Deleting(int PositionIndex)
        {
            Clear();
            WriteLine("Корзина\n\n Удалить позицию?");
            ConsoleKeyInfo aaa = ReadKey();
            if (aaa.Key == ConsoleKey.Enter)
            {
                Saving.Corzina.RemoveAt(PositionIndex-1);
                Package();
            }
            else Main(); Package();
        }
            
    }
}
