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
using MaterialSkin.Controls;

namespace TeachingAssistantApplication
{
    /// <summary>
    /// Interface for the application.
    /// </summary>
    public partial class TAChatBox : MaterialForm
    {

        //Class global assets

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
        QuestionItem _currentQuestion;

        Timer _serverTimer;

        int m = 0;
        int s = 0;

        /// <summary>
        /// Constructor for a new interface
        /// </summary>
        /// <param name="username"></param> Username of this user
        /// <param name="isInstructor"></param> If the user is an instructor
        public TAChatBox(string username, bool isInstructor)
        {
            _serverTimer = new Timer();
            _serverTimer.Enabled = true;
            _serverTimer.Interval = 15000;
            _serverTimer.Tick += new EventHandler(ServerTimer_Tick);

            _username = username;
            _isInstructor = isInstructor;
            queue = new QuestionQueue();
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red300, MaterialSkin.Primary.Red500, MaterialSkin.Primary.Red500, MaterialSkin.Accent.Red100, MaterialSkin.TextShade.WHITE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            uxQuestionCount.Text += queue.Count.ToString();
            uxRecommended.Text = GetTime(out int seconds, out int minutes);
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);
            uxChatBox.Enabled = false;

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

        /// <summary>
        /// Gets the IP of this instance and returns it as a string.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Method that retrieves messages sent over the sockets.
        /// </summary>
        /// <param name="aResult"></param>
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
                        uxChatBox.Text += receivedMessage + "\r\n";
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

        /// <summary>
        /// Click event for the start button. Connects the two IPs on the button click and prepares them
        /// for transfer.
        /// </summary>
        /// <param name="sender"></param> Sender of the event
        /// <param name="e"></param> The event
        private void UxConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(uxLocalIP.Text), Convert.ToInt32(uxLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(uxFriendIP.Text), Convert.ToInt32(uxFriendPort.Text));
                sck.Connect(epRemote);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                uxChatBox.Text += "-- CONNECTED --\r\n";
                uxSend.Enabled = true;
                uxInputBox.Focus();
                uxStart.Enabled = false;
                uxDisconnect.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Question timer ticks every second. Updates the timer label on the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                s = 59;
            }
            else
            {
                s--;
            }
            uxTimer.Text = "Timer " + string.Format("{0:#0}:{1:00}", m, s);
        }

        /// <summary>
        /// Server refresh and check on every 10 seconds. Iterates through the database and adds and then deletes to update
        /// the instructors queue.
        /// </summary>
        /// <param name="sender"></param> Sender of the event
        /// <param name="e"></param> The event
        private async void ServerTimer_Tick(object sender, EventArgs e)
        {
            FirebaseResponse retrieveQuestions = await client.GetAsync("Question Information/" + _username);
            QuestionInformation quesData = retrieveQuestions.ResultAs<QuestionInformation>();
            FirebaseResponse retrieveUser = await client.GetAsync("User Information/" + _username);
            UserInformation userData = retrieveUser.ResultAs<UserInformation>();

            //Call a helper to get all of the student usernames and place each one in a queue
            if (userData != null && quesData != null)
            { 
                Queue<string> questions = GetQuestion(quesData.question);
                Queue<string> passQuestions = new Queue<string>();

                if (_isInstructor)
                {
                    while (questions.Count > 0)
                    {
                        if (questions.Peek() == String.Empty)
                        {
                            questions.Dequeue();
                        }
                        else
                        {
                            queue.AddQuestion(passQuestions.Dequeue(), userData.IP, userData.username);
                        }
                    }
                    uxQuestionCount.Text = "# of Questions: " + queue.Count.ToString();
                    FirebaseResponse delete = await client.DeleteAsync("Question Information/" +  _username);
                }
                else if (!_isInstructor)
                {
                    // queue = queue stored in the cloud
                }
            } //changes
        }

        /// <summary>
        /// Click event for the disconnect button
        /// </summary>
        /// <param name="sender"></param> The sender of the event
        /// <param name="e"></param> The event
        private void UxDisconnect_Click(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            uxChatBox.Text += "-- DISCONNECTED --\r\n";
            uxFriendIP.Text = "";
            uxFriendPort.Text = "";
            uxStart.Enabled = true;
            uxDisconnect.Enabled = false;
        }

        public int _count = 0;
        /// <summary>
        /// Click event for the submit button. Adds a new string to construct a new QuestionItem from the cloud.
        /// </summary>
        /// <param name="sender"></param> Sender of the event
        /// <param name="e"></param> The event
        private async void UxSubmit_Click(object sender, EventArgs e)
        {
            var questionInfo = new QuestionInformation
            {
                username = _username,
                question = uxInputQuestion.Text,
                Count = _count++
            };
            SetResponse queueInfo = await client.SetAsync("Question Information/" + questionInfo.question, questionInfo);
            var userInfo = new UserInformation
            {
                username = _username,
                IP = GetLocalIP(),
                question = uxInputQuestion.Text,
                Count = _count++
            };
            SetResponse usernameInfo = await client.SetAsync("User Information/" + _username, userInfo);
            uxChatBox.Text += ("-- QUESTION ADDED --\r\n");
        }

        /// <summary>
        /// Click event for the send button. Sends the message to the remoteIP and adds it to the chat box
        /// on your instance. It then clears the input box.
        /// </summary>
        /// <param name="sender"></param> Sender of the event
        /// <param name="e"></param> The event
        private void UxSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(GetTag() + _username + ": " + uxInputBox.Text + "\r\n");

                sck.Send(msg);
                if(uxInputBox.Text != "")
                {
                    uxChatBox.Text +=  GetTag() + _username + ": " + uxInputBox.Text + "\r\n";
                }
                else
                {
                    MessageBox.Show("Enter a Message.");
                }
                uxInputBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Click event for the next question button. Adds a line to indicate a new question and then gets the next question
        /// in the queue. Sets the labels for the new questions and gets the IP of the next student.
        /// </summary>
        /// <param name="sender"></param> Sender of the event
        /// <param name="e"></param> The event
        private void UxNextQuestion_Click(object sender, EventArgs e)
        {
            uxQuestionTimer.Enabled = false;
            uxChatBox.Text += "-- NEW QUESTION CONVERSATIONS INITIATED --\r\n";
            _currentQuestion = queue.GetNextQuestion();
            uxQuestionLabel.Text = "Question: " + _currentQuestion.Question;
            uxStudentLabel.Text = "Student: " + _currentQuestion.Username;
            uxQuestionTimer.Enabled = true;
            uxFriendIP.Text = _currentQuestion.IP;
            GetTime(out int seconds, out int minutes);
            m = minutes;
            s = seconds;
        }

        /// <summary>
        /// Gets the tag of the current instance dependent on if it is a instructor
        /// </summary>
        /// <returns></returns>
        private string GetTag()
        {
            if (_isInstructor)
            {
                return "[Teaching Assisant] -- ";
            }
            return "[Student] -- ";
        }

        private Queue<string> GetQuestion(string username)
        {
            FirebaseResponse retrieve = client.Get("Question Information/" + username);
            QuestionInformation quesData = retrieve.ResultAs<QuestionInformation>();
            Queue<string> userinfo = new Queue<string>();
            userinfo.Enqueue(quesData.question);
            return userinfo;
        }

        /// <summary>
        /// Gets the aloted time for a question.
        /// </summary>
        /// <param name="seconds"></param> Seconds of time
        /// <param name="minutes"></param> Minutes of time
        /// <returns></returns>
        private string GetTime(out int seconds, out int minutes)
        {
            int millis = queue.GetTime();
            seconds = millis / 1000;
            minutes = seconds / 60;
            seconds -= (minutes * 60);
            string result = "Time Limit: " + string.Format("{0:#0}:{1:00}", minutes, seconds);
            return result;
        }
    }
}
