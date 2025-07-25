using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Print
    {
        public static void Array<T>(T[] arr)
        {
            Console.Write("[");
            foreach (var item in arr) Console.Write($" {item} ");
            Console.WriteLine("]");
        } 
    }
}
