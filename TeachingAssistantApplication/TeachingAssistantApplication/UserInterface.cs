using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TeachingAssistantApplication
{
    public partial class UserInterface : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        QuestionQueue queue;
        string _username;

        int m = 0;
        int s = 0;
        public UserInterface(string username)
        {
            _username = username;
            queue = new QuestionQueue();
            InitializeComponent();
            uxQuestionCount.Text += queue.Count.ToString();
            uxRecommended.Text += queue.GetTime();
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    uxLocalIP.Text = address.ToString();
                }
            }

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
                    byte[] receivedData = new byte[1500];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    ListBox.CheckForIllegalCrossThreadCalls = false;
                    this.uxChatBox.Invoke(new MethodInvoker(delegate ()
                    {
                        uxChatBox.Items.Add(_username + ": " + receivedMessage);
                    }));
                    
                }

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UxStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(uxLocalIP.Text), Convert.ToInt32(uxLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(uxFriendIP.Text), Convert.ToInt32(uxFriendPort.Text));
                sck.Connect(epRemote);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                uxChatBox.Items.Add("-- CONNECTED --");
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
            if (m <= 0 && s <= 0)
            {
                uxQuestionTimer.Enabled = false;
                MessageBox.Show("Timer is done.");
            }
            if (s == 0)
            {
                m--;
                s = 60;
            }
            else
            {
                s--;
            }
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);
        }

        private void UxDisconnect_Click(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            uxChatBox.Items.Add("-- DISCONNECTED --");
            uxFriendIP.Clear();
            uxFriendPort.Clear();
        }

        //Submit button
        private void UxSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void UxSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(uxInputBox.Text);

                sck.Send(msg);
                uxChatBox.Items.Add(_username + ": " + uxInputBox.Text);
                uxInputBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
