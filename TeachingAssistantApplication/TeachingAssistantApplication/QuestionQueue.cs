using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachingAssistantApplication
{
    /// <summary>
    /// Class that manipulates a queue of QuestionItems
    /// </summary>
    public class QuestionQueue
    {
        //Global class assets

        private Queue<QuestionItem> _questionQueue = new Queue<QuestionItem>();
        QuestionItem _current = null;

        /// <summary>
        /// Count of the queue object
        /// </summary>
        public int Count
        {
            get
            {
                return _questionQueue.Count;
            }
        }

        /// <summary>
        /// Adds a new question to the queue
        /// </summary>
        /// <param name="question"></param> String to create new question object
        public void AddQuestion(string question, string ip, string username)
        {
            QuestionItem newQuestion = new QuestionItem(question, ip, username);
            _questionQueue.Enqueue(newQuestion);
        }

        /// <summary>
        /// Gets the next question in the queue
        /// </summary>
        /// <returns></returns>
        public QuestionItem GetNextQuestion()
        {
            if(_questionQueue.Count != 0)
            {
                _current = _questionQueue.Peek();
                return _questionQueue.Dequeue();
            }
            return new QuestionItem("No questions." , "0.00.00.1", "tester");
        }

        /// <summary>
        /// Gets the time aloted for each question.
        /// </summary>
        /// <returns></returns>
        public int GetTime()
        {
            int count = _questionQueue.Count;
            if(count == 0)
            {
                return 0;
            }
            return (60 * 60 * 1000 * 2) / count;
        }

        


    }
}
