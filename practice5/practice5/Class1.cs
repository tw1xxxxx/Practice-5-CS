using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace practice5
{
    public class Class1
    {
        public struct Card
        {
            public string Key;
            public int Value;

        }
        private static Card[] Products = new Card[]
        {
            new Card() { Key = "Кроссовки NIKE АIR FORCE", Value = 12500},
            new Card() { Key = "Ботинки TIMBERLAND", Value = 28000},
            new Card() { Key = "Футболка HUGO BOSS", Value = 7000},
            new Card() { Key = "Худи CALVIN KLEIN", Value = 18000},
            new Card() { Key = "Худи LACOSTA", Value = 16000},
            new Card() { Key = "Джинсы ARMANI", Value = 12000},
            new Card() { Key = "Шорты GUCCI", Value = 56000},
            new Card() { Key = "Штаны GLORIA JEANS", Value = 4800}
        };

        public void TakeTheItem(int cur, int SizeType)
        {
            switch (SizeType)
            {
                case 0 : WriteLine("Critical Error, return the app"); break;
                case 1 : Kross(cur); break;
                case 2 : Top(cur); break;
                case 3 : Pants(cur); break;
            }
        }

        private void Kross(int cur)
        {
            int SizeIndex = 1;
            List<int> sizes = new List<int>() {35,36,37,38,39,40,41,42};
            while (true)
            {
                Clear();
                WriteLine("Размеры RU\n 35\n 36\n 37\n 38\n 39\n 40\n 41\n 42\n\n Назад");
                SetCursorPosition(0, SizeIndex);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow : if (SizeIndex == 1) SizeIndex = 11; SizeIndex--; break; 
                    case ConsoleKey.DownArrow : if (SizeIndex == 10) SizeIndex = 0; SizeIndex++; break; 
                    case ConsoleKey.Enter: 
                        if(SizeIndex >8) Program.Main();                      
                        else Noting(Products.ElementAt(cur).Key, sizes[SizeIndex-1].ToString(), Products.ElementAt(cur).Value); break;
                       
                        
                }
            }
        }

        private void Top(int cur)
        {
            int SizeIndex = 1;
            List<string> sizes = new List<string>() {"XS", "S", "M", "L", "XL"};
            while (true)
            {
                Clear();
                WriteLine("Размеры в наличии:\n XS\n S\n M\n L\n XL\n Назад");
                SetCursorPosition(0, SizeIndex);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow : if (SizeIndex == 1) SizeIndex = 6; SizeIndex--; break;
                    case ConsoleKey.DownArrow : if (SizeIndex == 6) SizeIndex = 1; SizeIndex++; break;
                    case ConsoleKey.Enter : Noting(Products.ElementAt(cur).Key, sizes[SizeIndex].ToString(), Products.ElementAt(cur).Value); break;
                }
            }
        }
        private void Pants(int cur)
        {
            int SizeIndex = 1;
            List<int> sizes = new List<int>() { 160, 165, 170, 175, 180, 185, 190};
            while (true)
            {
                Clear();
                WriteLine("Размеры в наличии:\n 160\n 165\n 170\n 175\n 180\n 185\n 190");
                SetCursorPosition(0, SizeIndex);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow : if (SizeIndex == 1) SizeIndex = 7; SizeIndex--; break;
                    case ConsoleKey.DownArrow : if (SizeIndex == 7) SizeIndex = 1; SizeIndex++; break;
                    case ConsoleKey.Enter : Noting(Products.ElementAt(cur).Key, sizes[SizeIndex].ToString(), Products.ElementAt(cur).Value); break;
                }
            }
        }
        private void Noting(string Position, string Size, int Price )
        {
            Class2 Instance = new Class2();
            Instance.Position = Position;
            Instance.Size = Size;
            Instance.Price = Price;
            Saving.Corzina.Add(Instance);
            Program.Main();
        }
    }
}
