using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube上片通知
{
    public class Youtuber
    {
        //public Channel channel = new Channel("Channel A");

        public List<Channel> channels = new List<Channel> 
        { 
            new Channel("Channel A"),
            new Channel("Channel B"),
            new Channel("Channel C")
        };


        public void Publish(Channel channel, string message)
        {
            channel.notifyObservers(channel.Name + ": " + message);
        }
    }
}
