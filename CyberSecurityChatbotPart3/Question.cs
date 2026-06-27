namespace CyberSecurityChatbot
{
    public class Question
    {
        public string QuestionText { get; set; }

        public string[] Options { get; set; }

        public int CorrectAnswer { get; set; }

        public string Explanation { get; set; } 
    }
}
