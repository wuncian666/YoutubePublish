using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube上片通知
{
    public class User : IObserver
    {
        public string Name { get; set; }

        public User(string name) { 
            this.Name = name;
        }

        public void Update(string pMessage)
        {
            EventHandlers.Notify(pMessage);
        }
    }
}
