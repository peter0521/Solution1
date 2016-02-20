using SharedProject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t.Id = 1;
            t.Name = "peter";
            Console.WriteLine(t.Id);
            Console.WriteLine(t.Name);

            test2 t2 = new test2();
            t2.work = "design";
            Console.WriteLine(t2.work);
            
        }
    }
}
