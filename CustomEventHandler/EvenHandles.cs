using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    internal class EvenHandles
    {

        public static event EventHandler<string> handlers;

        public static CusEventHandlers<string> cusHandlers =new CusEventHandlers<string>();

        public static void Notify(string msg)
        {
            handlers.Invoke(null,msg);
        }

        public static void CusNotify(string msg)
        {
            cusHandlers.Invoke(msg);
        }
    }
}
