using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    internal class ClassA
    {

        public string msg()
        {
            ClassB classB = new ClassB();
            return classB.msg();
        }
    }
}
