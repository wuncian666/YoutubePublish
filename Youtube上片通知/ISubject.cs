using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube上片通知
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver pObserver);

        void RemoveObserver(IObserver pObserver);
        
        void notifyObservers(string pContent);
    }
}
