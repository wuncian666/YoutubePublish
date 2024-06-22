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
    public partial class YoutuberForm : Form
    {
        Youtuber youtuber;

        Channel channel;

        public YoutuberForm(Youtuber youtuber)
        {
            InitializeComponent();

            this.youtuber = youtuber;
            this.channel = youtuber.channels[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text + "上片";
            EventHandlers.Notify(message);
            youtuber.Publish(this.channel, message);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is string)
            {
                this.channel = this.youtuber.channels.Find(
                    (x) => x.Name == (string)comboBox1.SelectedValue);
            }
        }

        private void YoutuberForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = youtuber.channels;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }
    }
}
