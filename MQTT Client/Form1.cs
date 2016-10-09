using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Client
{
    public partial class Form1 : Form
    {
        MqttClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            //initialize new client
            client = new MqttClient(IPAddress.Parse(IPTextBox.Text));
            //register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            //connect with client id
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
            Console.WriteLine("Connected");
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            client.Subscribe(new string[] { topicTextBox.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            Console.Write(topicTextBox.Text);
            Console.WriteLine(" subscribed");
        }

       void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string msg = Encoding.UTF8.GetString(e.Message);
            if (subTextBox.InvokeRequired)
            {
                subTextBox.Invoke(new MethodInvoker(delegate
                {
                    subTextBox.AppendText(msg);
                    subTextBox.AppendText(Environment.NewLine);
                }));
            }
            Console.WriteLine(msg);
        }

        private void pubButton_Click(object sender, EventArgs e)
        {
            client.Publish(topicTextBox.Text, Encoding.UTF8.GetBytes(pubTextBox.Text));
        }
    }
}
