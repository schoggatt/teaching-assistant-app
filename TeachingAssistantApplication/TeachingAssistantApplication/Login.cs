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

        public bool _IsInstructor;

        public FirebaseResponse retrieve;

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
            
            FirebaseResponse retrieve = await client.GetAsync("Student Information/" + uxLogin.Text);
            if (uxInstructorSelection.Checked)
            {
                retrieve = await client.GetAsync("Instructor Information/" + uxLogin.Text);
                _IsInstructor = true;
            }
            else if (uxStudentSelection.Checked)
            {
                retrieve = await client.GetAsync("Student Information/" + uxLogin.Text);
            }
            Data userData = retrieve.ResultAs<Data>();
            var currUser = new Data
            {
                username = uxLogin.Text.Trim(),
                password = uxPassword.Text.Trim()
            };
            if (!(uxInstructorSelection.Checked || uxStudentSelection.Checked))
            {
                MessageBox.Show("Please select either instructor or student");
            }
            else if (Data.IsEqual(currUser, userData))
            {
                this.Hide();
                _username = userData.username;
                UserInterface TA = new UserInterface(_username, _IsInstructor);
                TA.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password not found.");
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

            //Add a lot more check cases

            var newUser = new Data
            {
                username = uxLogin.Text.Trim(),
                password = uxPassword.Text.Trim()
            };

            if (uxStudentSelection.Checked)
            {
                SetResponse studResponse = await client.SetAsync("Student Information/" + uxLogin.Text, newUser);
            }
            else if(uxInstructorSelection.Checked)
            {
                SetResponse instructResponse = await client.SetAsync("Instructor Information/" + uxLogin.Text, newUser);
            }
            

        }
    }
}
