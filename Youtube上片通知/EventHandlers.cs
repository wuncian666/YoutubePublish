using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube上片通知
{
    internal class EventHandlers
    {
        public static event EventHandler<FlowLayoutPanel> messageHandler;

        public static void Notify(string message)
        {
            Label label = new Label
            {
                Width = 400,
                Height = 30,
                Text = message
            };

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Width = 400,
                Height = 30
            };
            flowLayoutPanel.Controls.Add(label);
            messageHandler.Invoke(null,flowLayoutPanel);
        }
    }
}
