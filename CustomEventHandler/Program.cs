using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EvenHandles.handlers += EvenHandles_handlers;

            EvenHandles.cusHandlers += EvenHandles_handlers;

            ClassA classA = new ClassA();
            classA.msg();

            Console.ReadKey();
        }

        private static void EvenHandles_handlers(string e)
        {
            Console.WriteLine(e);
        }
    }
}
