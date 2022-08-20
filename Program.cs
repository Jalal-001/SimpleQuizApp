using System;

namespace OOP_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("Which programming language is most popular in backend?", new string[] { "C#", "Java", "Python", "PHP" }, "C#");
            var q2 = new Question("Which programming language make earlier?", new string[] { "Java", "c#", "Python", "PHP" }, "Java");
            var q3 = new Question("Which programming language is Microsoft?", new string[] { "Python", "Java", "C#", "PHP" }, "C#");

            var questions = new Question[] { q1, q2, q3 };
            var quiz = new Quiz(questions);
            quiz.diplayQuiz();
        }
    }
}
