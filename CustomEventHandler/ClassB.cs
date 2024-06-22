using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    internal class ClassB
    {

        public string msg()
        {
            ClassC classC = new ClassC();
            return classC.msg();
        }
    }
}
