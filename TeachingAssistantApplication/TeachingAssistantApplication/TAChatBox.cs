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

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace TeachingAssistantApplication
{
    public partial class TAChatBox : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "EoEWF8RsVsBlIsKE4JqcfloXeqEndWKJVKxlBM7p",
            BasePath = "https://hack2019-ad4f4.firebaseio.com/"
        };


        IFirebaseClient client;


        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        QuestionQueue queue;
        string _username;
        bool _isInstructor;

        Timer _serverTimer;

        int m = 0;
        int s = 0;
        public TAChatBox(string username, bool isInstructor)
        {
            _serverTimer = new Timer();
            _serverTimer.Enabled = true;
            _serverTimer.Interval = 10000;
            _serverTimer.Tick += new EventHandler(ServerTimer_Tick);


            _username = username;
            _isInstructor = isInstructor;
            queue = new QuestionQueue();
            InitializeComponent();
            uxQuestionCount.Text += queue.Count.ToString();
            uxRecommended.Text += queue.GetTime();
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Connection Problem");
            }


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
                        uxChatBox.Items.Add(receivedMessage);
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

        private async void ServerTimer_Tick(object sender, EventArgs e)
        {

            //Iterate through the questions database from top to bottom
            //For each question branch make a new question
            //Add it to the teacher queue
            //Delete the branch

            FirebaseResponse retrieve = await client.GetAsync("Question Information/" + _username);
            QuestionInformation userData = retrieve.ResultAs<QuestionInformation>();


            //Once empty upload that queue to the cloud

            if (_isInstructor && userData.Count > 0)
            {
                while(userData.Count > 0)
                {
                    queue.AddQuestion(userData.question, userData.IP, userData.username);
                    uxQuestionCount.Text = queue.Count.ToString();
                    FirebaseResponse delete = await client.DeleteAsync("Question Information/" + _username);
                    userData.Count--;
                }
            }
            else if(!_isInstructor)
            {
                // queue = queue stored in the cloud
                MessageBox.Show("Not Instructor");
            }
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
        private async void UxSubmit_Click(object sender, EventArgs e)
        {
            int count = 0;
            var questionInfo = new QuestionInformation
            {
                username = _username,
                IP = GetLocalIP(),
                question = uxInputQuestion.Text,
                Count = count + 1
            };


            SetResponse queueInfo = await client.SetAsync("Question Information/" + _username, questionInfo);

            uxChatBox.Items.Add("-- QUESTION ADDED --");
        }

        private void UxSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(GetTag() + _username + ": " + uxInputBox.Text);

                sck.Send(msg);
                if(uxInputBox.Text != "")
                {
                    uxChatBox.Items.Add(GetTag() + _username + ": " + uxInputBox.Text);
                }
                else
                {
                    MessageBox.Show("Enter a Message.");
                }
                uxInputBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetTag()
        {
            if (_isInstructor)
            {
                return "[Teaching Assisant] -- ";
            }
            return "[Student] -- ";
        }
    }
}
