using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    class Quiz
    {
        private Question[] Questions { get; set; }
        public int QuestionIndex { get; set; }

        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;

        }


        public Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }


        public void Guess(string answer)
        {
            var question = this.GetQuestion();
            Console.WriteLine(question.checkAnswer(answer));
            this.QuestionIndex++;

            if (this.Questions.Length==this.QuestionIndex)
            {
                //skor
            }
            else
                this.DisplayQuestion();

        }


        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            Console.WriteLine($"soru {this.QuestionIndex+1}: {question.Text}");

            foreach (var item2 in question.Choices)
            {
                Console.WriteLine($"-> {item2}");
            }

            Console.Write("Answer: ");
            var cvp = Console.ReadLine();
            this.Guess(cvp);

        }
    }
}
