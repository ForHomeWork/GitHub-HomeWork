using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Numerics;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int a = 4;
            while (a-->0)
            {
                string input = Console.ReadLine().PadLeft(4, '0');
                list.Add(input);
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
