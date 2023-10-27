using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice5
{
    public class Saving
    {
        public static List<Class2> Corzina = new List<Class2>();
        public void Delete(int Index)
        {
            Corzina.RemoveAt(Index);
        }
        public void DeleteAll()
        {
            Corzina.Clear();
        }
    }
    public class Class2
    {
        public String Position;
        public String Size;
        public int Price;
    }
}
