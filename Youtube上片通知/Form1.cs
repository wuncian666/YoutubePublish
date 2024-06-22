using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube上片通知
{
    public partial class Form1 : Form
    {
        Youtuber youtuber = new Youtuber();

        public Form1()
        {
            InitializeComponent();
            EventHandlers.messageHandler += EventHandlers_messageHandler;
        }

        private void EventHandlers_messageHandler(object sender, FlowLayoutPanel e)
        {
                flowLayoutPanel1.Controls.Add(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoutuberForm youtuberForm = new YoutuberForm(youtuber);
            youtuberForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManageForm userManageForm = new UserManageForm(youtuber.channels);
            userManageForm.Show();
        }
    }
}
