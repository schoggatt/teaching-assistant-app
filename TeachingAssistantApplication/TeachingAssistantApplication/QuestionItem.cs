using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingAssistantApplication
{
    public class QuestionItem 
    {

        /// <summary>
        /// Whether the question has been answered
        /// Default to false
        /// </summary>
        public bool Answered { get; set; } = false;

        /// <summary>
        /// What the current question is
        /// </summary>
        public string Question { get; }

        /// <summary>
        /// What the current IP is
        /// </summary>
        public string IP { get; }

        /// <summary>
        /// What the current username is
        /// </summary>
        public string Username { get; }


        /// <summary>
        /// Contructor for a new QuestionItem.
        /// </summary>
        /// <param name="question"></param> The question
        /// <param name="ip"></param> The IP
        /// <param name="username"></param> The username
        public QuestionItem(string question, string ip, string username)
        {
            Question = question;
            IP = ip;
            Username = username;
        }
    }
}
