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

        public void TakeTheItem(int Position, int SizeType)
        {
            switch (SizeType)
            {
                case 0:
                    WriteLine("Critical Error, return the app");
                    break;
                case 1:
                    Kross(Position);
                    break;
                case 2:
                    Shmot(Position);
                    break;
                case 3:
                    Shmot(Position);
                    break;
            }
        }

        private void Kross(int Position)
        {
            public struct Card
        {
            public string Key;
            public int Value;

        }
        int SizeIndex = 1;
        private static Card[] Cards = new Card[]
        {

            new Card() { Key = "7", Value = 7 },
            new Card() { Key = "8", Value = 8 },
            new Card() { Key = "9", Value = 9 },
            new Card() { Key = "10",Value = 10 },
            new Card() { Key = "J", Value = 1 },
            new Card() { Key = "Q", Value = 1 },
            new Card() { Key = "K", Value = 1 },
            new Card() { Key = "A", Value = 1 }
        };
    
            List<int> sizes = new List<int>() {36,37,38,39,40,41,42,43};
            while (true)
            {
                Clear();
                WriteLine("Размеры");
                WriteLine(" 34");
                WriteLine(" 35");
                WriteLine(" 36");
                WriteLine(" 37");
                WriteLine(" 38");
                WriteLine(" 39");
                WriteLine(" 40");
                WriteLine(" 41");
                WriteLine(" 42");
                SetCursorPosition(0, SizeIndex);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (SizeIndex == 1) SizeIndex = 9;
                        SizeIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (SizeIndex == 8) SizeIndex = 0;
                        SizeIndex++;
                        break;
                    case ConsoleKey.Enter:
                        Noting(NamesPrice.Values.ElementAt(Position).Key,  sizes[SizeIndex], NamesPrice.Values.ElementAt(Position).Value);
                        break;
                }
            }
        }
        private void Shmot(int Pos)
        {
            int raa = 1;
            List<string> Names = new List<string>() { "Pandora", "Fendi", "Dolce Gabbana" };
        
            while (true)
            {
                Clear();
                WriteLine("Размеры");
                WriteLine(" 34");
                WriteLine(" 35");
                WriteLine(" 36");
                WriteLine(" 37");
                WriteLine(" 38");
                WriteLine(" 39");
                WriteLine(" 40");
                WriteLine(" 41");
                WriteLine(" 42");
                SetCursorPosition(0, raa);
                WriteLine(">");
                ConsoleKeyInfo sss = ReadKey(true);
                switch (sss.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (raa == 1) raa = 9;
                        raa--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (raa == 8) raa = 0;
                        raa++;
                        break;
                    case ConsoleKey.Enter:

                        break;
                }
            }
        }
        private void Noting(string Position, string Size, int Price )
        {
            Class2 bbb = new Class2();
            bbb.Position = Position;
            bbb.Size = Size;

            

        }
    }
}
