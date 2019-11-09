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
            if (uxUsername.Text == "" && uxPassword.Text == "")
            {
                MessageBox.Show("Username and password are empty");
            }
            else if (uxUsername.Text == "")
            {
                MessageBox.Show("Username is empty.");
            }
            else if (uxPassword.Text == "")
            {
                MessageBox.Show("Password is empty.");
            }
            else if (!(uxInstructorSelection.Checked || uxStudentSelection.Checked))
            {
                MessageBox.Show("Please select either instructor or student");
            }
            else
            {
                if (uxInstructorSelection.Checked)
                {
                    retrieve = await client.GetAsync("Instructor Information/" + uxUsername.Text);
                    _IsInstructor = true;
                }
                else if (uxStudentSelection.Checked)
                {
                    retrieve = await client.GetAsync("Student Information/" + uxUsername.Text);
                }
                else
                {
                    //while loop until checked
                    MessageBox.Show("Please select either instructor or student");
                }
                //FIX: if user types into textbox and doesnt select it sets null
                Data userData = retrieve.ResultAs<Data>();
                var currUser = new Data
                {
                    username = uxUsername.Text.Trim(),
                    password = uxPassword.Text.Trim()
                };
                if (Data.IsEqual(currUser, userData))
                {
                    this.Hide();
                    _username = userData.username;
                    TAChatBox TA = new TAChatBox(_username, _IsInstructor);
                    TA.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password not found.");
                    uxPassword.Clear();
                }
            }
        }

        private async void UxRegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (uxInstructorSelection.Checked || uxStudentSelection.Checked)
            {
                if (uxUsername.Text == "")
                {
                    MessageBox.Show("Please enter a username");
                }
                else if (uxPassword.Text == "")
                {
                    MessageBox.Show("Please enter a password");
                }
                else if (uxUsername.Text == "" && uxPassword.Text == "")
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
                username = uxUsername.Text.Trim(),
                password = uxPassword.Text.Trim()
            };

            if (uxStudentSelection.Checked)
            {
                SetResponse studResponse = await client.SetAsync("Student Information/" + uxUsername.Text, newUser);
            }
            else if (uxInstructorSelection.Checked)
            {
                SetResponse instructResponse = await client.SetAsync("Instructor Information/" + uxUsername.Text, newUser);
            }


        }

        private void UxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
