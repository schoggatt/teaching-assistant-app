using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingAssistantApplication
{
    public class QuestionQueue
    {
        private Queue<QuestionItem> _questionQueue = new Queue<QuestionItem>();
        QuestionItem _current = null;

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
        private void AddQuestion(string question)
        {
            QuestionItem newQuestion = new QuestionItem(question);
            if(_questionQueue.Count == 0)
            {
                _current = newQuestion;
            }
            _questionQueue.Enqueue(newQuestion);
        }

        /// <summary>
        /// Gets the next question in the queue
        /// </summary>
        /// <returns></returns>
        private QuestionItem GetNextQuestion()
        {
            if(_questionQueue.Count != 0 && _current.Answered == true)
            {
                _current = _questionQueue.Peek();
                return _questionQueue.Dequeue();
            }
            return null;
        }


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
