using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube上片通知
{
    public interface IObserver
    {
        String Name { get; set; }
        void Update(string pMessage);
    }
}
