using System.Windows.Forms;

namespace TeachingAssistantApplication
{
    internal class Data
    {
        public string username { get; set; }
        public string password { get; set; }

        public static bool IsEqual(Data newUser, Data currUser)
        {
            if(newUser == null || currUser == null)
            {
                return false;
            }

            if (newUser.username != currUser.username)
            {
                error = "Username does not exist.";
                return false;
            }
            else if (newUser.password != currUser.password)
            {
                error = "Username and password do not match.";
                return false;
            }
            return true;
        }

        public static string error;

    }
}