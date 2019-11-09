using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace TeachingAssistantApplication
{
    public partial class UserInterface : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        QuestionQueue queue;

        int m = 1;
        int s = 5;
        public UserInterface()
        {
            queue = new QuestionQueue();
            InitializeComponent();
            uxQuestionCount.Text += queue.Count.ToString();
            uxRecommended.Text += queue.GetTime();
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);
            Console.WriteLine("Test");
            uxQuestionTimer.Enabled = true;

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            uxLocalIP.Text = GetLocalIP();
            uxFriendIP.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    uxTextBox.Text += "\nTest: " + receivedMessage;
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Start event handler
        private void UxStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(uxLocalIP.Text), Convert.ToInt32(uxLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(uxFriendIP.Text), Convert.ToInt32(uxFriendPort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                uxStart.Enabled = false;
                uxStart.Text = "Connected";
                uxSend.Enabled = true;
                uxInputBox.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UxQuestionTimer_Tick(object sender, EventArgs e)
        {
            if(s == 0)
            {
                m--;
                s = 60;
            }
            if (m <= 0 && s <= 0)
            {
                uxQuestionCount.Enabled = false;
                MessageBox.Show("Timer is done.");
            }
            else
            {
                s--;
            }
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);
        }

        private void UxSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(uxInputBox.Text);

                sck.Send(msg);
                uxTextBox.Text += "\nYou: " + uxInputBox.Text;
                uxInputBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
