namespace TeachingAssistantApplication
{
    internal class Data
    {
        public string username { get; set; }
        public string password { get; set; }

        public static string error;

        public static bool IsEqual(Data newUser, Data currUser)
        {
            if(newUser == null || currUser == null)
            {
                return false;
            }

            if(newUser.username != currUser.username)
            {
                error = "Username does not exist.";
                return false;
            }
            else if (newUser.password != currUser.password)
            {
                error = "Username and password do not match.";
                return false;
            }
            else
            {
                error = "Please make sure you picked either Instructor or Student";
                return false;
            }
            return true;
        }
    }
}