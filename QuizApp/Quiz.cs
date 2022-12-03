using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    class Quiz
    {
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;

        }


        private Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }


        private void Guess(string answer)
        {
            var question = this.GetQuestion();
            if (question.checkAnswer(answer))
                this.Score++;
            this.QuestionIndex++;

            if (this.Questions.Length==this.QuestionIndex)
            {
                this.DisplayScore();
            }
            else
            {
                this.DisplayQuestion();
            }
                

        }


        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            Console.WriteLine($"soru {this.QuestionIndex+1}: {question.Text}");

            foreach (var item2 in question.Choices)
            {
                Console.WriteLine($"-> {item2}");
            }

            Console.Write("Answer: ");
            var cvp = Console.ReadLine();
            this.Guess(cvp);

        }

        private void DisplayScore()
        {
            Console.WriteLine($"Score: {this.Score}");
        }

        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex + 1;

            if (totalQuestion >= questionNumber)
            {
                Console.WriteLine($"Question {questionNumber}/{totalQuestion}");
            }

        }
    }
}
