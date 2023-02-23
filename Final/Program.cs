using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "數學：";
            string f = a.Substring(0, a.Length - 1);
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
