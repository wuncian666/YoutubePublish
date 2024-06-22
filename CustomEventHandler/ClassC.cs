using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    internal class ClassC
    {
        public string msg()
        {
            //EvenHandles.Notify("notify");

            EvenHandles.CusNotify("cus notify");
            return "msg";
        }
    }
}
