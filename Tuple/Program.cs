using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTuple<int, string> obj = new ValueTuple<int, string>(1, "Bibekananda");
            Console.WriteLine(obj.Item1+"  "+obj.Item2);
            Console.Read();
        }

        
    }
}
