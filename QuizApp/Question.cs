using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    class Question
    {
        public int QuestionNumber { get; set; }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }
        

         


        public Question(int questionnmber,string text,string[] choices,string answer)
        {
            this.QuestionNumber = questionnmber;
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }


        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }
}
