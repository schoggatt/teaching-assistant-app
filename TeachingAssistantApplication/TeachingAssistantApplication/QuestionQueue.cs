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

        /// <summary>
        /// Adds a new question to the queue
        /// </summary>
        /// <param name="question"></param> String to create new question object
        private void AddQuestion(string question)
        {
            QuestionItem newQuestion = new QuestionItem(question);
            _questionQueue.Enqueue(newQuestion);
            if(_questionQueue.Count == 0)
            {
                _current = newQuestion;
            }
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

        


    }
}
