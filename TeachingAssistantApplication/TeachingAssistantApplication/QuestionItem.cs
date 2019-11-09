using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingAssistantApplication
{
    public class QuestionItem 
    {
        private string _IP;
        private string _username;

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
        /// Constructor for the question item
        /// </summary>
        /// <param name="question"></param> The question
        public QuestionItem(string question, string ip, string username)
        {
            Question = question;
            _IP = ip;
            _username = username;
        }
    }
}
