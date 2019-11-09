using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace TeachingAssistantApplication
{
    public partial class Login : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "EoEWF8RsVsBlIsKE4JqcfloXeqEndWKJVKxlBM7p",
            BasePath = "https://hack2019-ad4f4.firebaseio.com/"
        };


        IFirebaseClient client;

        public string _username;

        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Connection Problem");
            }

        }

        private async void UxLoginButton_Click(object sender, EventArgs e)
        {

            FirebaseResponse retrieve = await client.GetAsync("Login Information/" + uxLogin.Text);
            Data obj = retrieve.ResultAs<Data>();
            var currUser = new Data
            {
                username = uxLogin.Text,
                password = uxPassword.Text
            };

            if(Data.IsEqual(currUser, obj))
            { 
                _username = obj.username;
                UserInterface TA = new UserInterface(_username);
                TA.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Error: " + Data.error);
            }
            
        }

        private async void UxRegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(uxInstructorSelection.Checked || uxStudentSelection.Checked )
            {
                if (uxLogin.Text == "")
                {
                    MessageBox.Show("Please enter a username");
                }
                else if (uxPassword.Text == "")
                {
                    MessageBox.Show("Please enter a password");
                }
                else if (uxLogin.Text == "" && uxPassword.Text == "")
                {
                    MessageBox.Show("Please enter a username and a password");
                }
            }
            else
            {
                MessageBox.Show("Please pick Instructor or Student");
            }

            //Add a lot more cases to check

            var newUser = new Data
            {
                username = uxLogin.Text,
                password = uxPassword.Text
            };

            SetResponse response = await client.SetAsync("Login Information/" + uxLogin.Text, newUser);

        }
    }
}
