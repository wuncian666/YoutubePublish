using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube上片通知
{
    public class Channel : ISubject
    {
        public string Name { get; set; }

        public List<IObserver> Users { get { return observers;} }

        List<IObserver> observers = new List<IObserver>();

        public Channel(string name) {
            this.Name = name;
        }

        public void notifyObservers(string pContent)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(observer.Name + pContent);
            }
        }

        public void RegisterObserver(IObserver pObserver)
        {
            observers.Add(pObserver);
        }

        public void RemoveObserver(IObserver pObserver)
        {
            if (observers.IndexOf(pObserver) >= 0)
            {
                observers.Remove(pObserver);
            }
        }

        public void AddUser(IObserver observer)
        {
            RegisterObserver(observer);
        }

        public void RemoveUser(IObserver observer)
        {
            RemoveObserver(observer);
        }

        public static Channel operator + (Channel channel,IObserver observer)
        {
            channel.RegisterObserver(observer);
            return channel;
        }

        public static Channel operator -(Channel channel, IObserver observer)
        {
            channel.RemoveObserver(observer);
            return channel;
        }
    }
}
