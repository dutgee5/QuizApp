using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question
                (1,
                "How many hours a day do you work?",
                new string[] { "4", "5", "6", "7" },
                "5");

            Question q2 = new Question
             (2,
             "What is your monthly income?",
             new string[] { "10000$", "15000$", "17500$", "20000$" },
             "10000$");


            Question[] questions = { q1, q2 };

            foreach (var item in questions)
            {
                Console.WriteLine(item.QuestionNumber + "-" + item.Text);

                foreach (var item2 in item.Choices)
                {
                    Console.WriteLine($"-> {item2}");
                }

                Console.Write("Answer: ");
                var cvp = Console.ReadLine();
                Console.WriteLine(item.checkAnswer(cvp));
            }

            

            
            
        }
    }
}
