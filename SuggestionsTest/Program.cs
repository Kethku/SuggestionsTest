using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestionsTest
{
    class Test
    {
        public void Foobar()
        {
            Console.WriteLine();
        }
    }
    class Program
    {
        static string TestFunc(Func<string> arg) { return arg(); }
        static void Main(string[] args)
        {
            var testObject = new Test();
            testObject.Foobar();
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);
            Console.WriteLine(args[3]);

            int x, y, z;
            bool cond = true;

            if (true)
            {
                x = 0;
                Console.WriteLine("Foo");
                x = 5;
            }
            if (true)
            {
                y = 0;
                Console.WriteLine("Bar");
                y = 5;
            }
            if (true)
            {
                z = 0;
                Console.WriteLine("Baz");
                z = 5;
            }
        }
    }
}
