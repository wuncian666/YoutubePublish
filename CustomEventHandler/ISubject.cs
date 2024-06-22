using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    interface ISubject<T>
    {
        void RegisterObserver(IObserver pObserver);

        void RemoveObserver(IObserver pObserver);
        
        void NotifyObservers(T pContent);
    }
}
