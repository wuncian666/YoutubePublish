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
    public partial class UserManageForm : Form
    {
        List<Channel> channels;

        Channel channel;

        public UserManageForm(List<Channel> channels)
        {
            InitializeComponent();
            this.channels = channels; 
            this.channel = channels[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Channel channel = this.channels.Find((x) => x.Name == comboBox1.Text);

            User user = new User(textBox1.Text);

            //this.channel.AddUser(user);

            this.channel += user;

            EventHandlers.Notify(textBox1.Text + "訂閱" + channel.Name);
            // 把訂閱者加進 panel 裡
            flowLayoutPanel1.Controls.Add(this.SubPanel(user));

        }

        private void CreatePanel(Channel channel)
        {
            flowLayoutPanel1.Controls.Clear();  
            foreach (IObserver user in channel.Users) {
                flowLayoutPanel1.Controls.Add(this.SubPanel(user));
            }
        }

        private FlowLayoutPanel SubPanel(IObserver user)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Height = 30;
            Label label = new Label();
            label.Text = user.Name;
            
            Button button = new Button();
            button.Text = "取消訂閱";
            button.Tag = user;
            button.Click += UnSubscribeChannel;

            flowLayoutPanel.Controls.Add(label);
            flowLayoutPanel.Controls.Add(button);

            return flowLayoutPanel;
        }

        private void UnSubscribeChannel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            User user = (User)button.Tag;
            //channel.RemoveUser(user);
            this.channel -= user;
            FlowLayoutPanel pannel = (FlowLayoutPanel)button.Parent;
            flowLayoutPanel1.Controls.Remove(pannel);

            EventHandlers.Notify(user.Name + "取消訂閱" + this.channel.Name);
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is string)
            {
                this.channel = this.channels.Find(
                    (x) => x.Name == (string)comboBox1.SelectedValue);

                this.CreatePanel(this.channel);
            }
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = this.channels;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }
    }
}
