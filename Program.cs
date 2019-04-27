using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's tell a story about strings.");
            Console.WriteLine("string anicaug = null;");
            Console.WriteLine("bool t1 = string.IsNullOrEmpty(anicaug);");
            string anicaug = null;
            bool t1 = string.IsNullOrEmpty(anicaug);
            Console.WriteLine("Run command for boolean."); 
            Console.WriteLine(t1);
        }
    }
}
