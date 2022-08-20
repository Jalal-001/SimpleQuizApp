namespace OOP_App
{
    public class Question
    {
        public Question(string text, string[] choice, string answer)
        {
            this.Text = text;
            this.Choices = choice;
            this.Answer = answer;
        }

        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public bool checkAnswer(string answer)
        {
            return this.Answer == answer;
        }
    }
}