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

        public string _password;

        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connected");
            }
            else if (client == null)
            {
                MessageBox.Show("Empty");
            }
            else
            {
                MessageBox.Show("else");
            }
        }

        private async void UxLoginButton_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                username = uxLogin.Text,
                password = uxPassword.Text
            };

            SetResponse response = await client.SetTaskAsync("Login Information/" + uxLogin.Text, data);
        }
    }
}
