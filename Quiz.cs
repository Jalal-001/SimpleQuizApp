namespace OOP_App
{
    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.questions = questions;
            this.quizIndex = 0;
            this.Score = 0;
        }
        private Question[] questions { get; set; }
        public int quizIndex { get; set; }
        public int Score { get; set; }


        private Question[] getQuestions()
        {
            return this.questions;
        }
        public void diplayQuiz()
        {
            displayProggress();
            var quiz = this.getQuestions();
            System.Console.WriteLine($"{quizIndex + 1}: {quiz[quizIndex].Text}");
            foreach (var c in quiz[quizIndex].Choices)
            {
                System.Console.WriteLine($"-{c}");
            }
            Console.Write("Please choose one option: ");
            string answer = Console.ReadLine();
            Check(answer);
        }
        private void Check(string answ)
        {
            var quiz = this.getQuestions();
            if (quiz[quizIndex].checkAnswer(answ))
            {
                System.Console.WriteLine("---------------------------------");
                Score++;
                System.Console.WriteLine("Your answer is True!");
                System.Console.WriteLine("---------------------------------");
            }
            else
            {
                System.Console.WriteLine("---------------------------------");
                System.Console.WriteLine("Your answer is Wrong!");
                System.Console.WriteLine("---------------------------------");
            }
            quizIndex++;
            if (questions.Length == quizIndex)
                diplayScore();
            else
                this.diplayQuiz();
        }
        private void diplayScore()
        {
            System.Console.WriteLine($"Your score is: {Score}");
        }
        private void displayProggress()
        {
            int totalQuiz = questions.Length;
            int quizNumber = quizIndex + 1;
            System.Console.WriteLine($"Your progress is {quizIndex + 1} of {totalQuiz}");
        }
    }
}