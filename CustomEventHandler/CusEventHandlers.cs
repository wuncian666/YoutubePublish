using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandler
{
    class CusEventHandlers<T> : ISubject<T>
    {
        static List<Action<T>> actions = new List<Action<T>>();
        
        public CusEventHandlers() { }

        public static CusEventHandlers<T> operator + (CusEventHandlers<T> handlers, Action<T> action)
        {
            actions.Add(action);
            return handlers;
        }

        public static CusEventHandlers<T> operator - (CusEventHandlers<T> handlers, Action<T> action)
        {
            actions.Remove(action);
            return handlers;
        }

        public void Invoke(T t)
        {
            foreach(Action<T> action in actions)
            {
                action.Invoke(t);
            }
        }




        public void NotifyObservers(T pContent)
        {
        }

        public void RegisterObserver(IObserver pObserver)
        {
        }

        public void RemoveObserver(IObserver pObserver)
        {
        }
    }
}
