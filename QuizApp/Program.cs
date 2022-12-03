using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question
                (1,
                "What is a correct syntax to output 'Hello World' in C#?",
                new string[] { "print ('Hello World');", "Console.WriteLine('Hello World');", "System.out.println('Hello World');", "cout<<'Hello World';" },
                "Console.WriteLine('Hello World');");

            Question q2 = new Question
             (2,
             "How do you create a variable with the numeric value 5?",
             new string[] { "double x=5;", "int x=5;", "x=5", "num x=5" },
             "int x=5;");


            Question[] questions = { q1, q2 };

            Quiz quiz = new Quiz(questions);
            quiz.DisplayQuestion();
            
            
        }
    }
}
