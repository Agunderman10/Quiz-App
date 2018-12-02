using System;

namespace Quiz_App
{
    public struct Question
    {
        public string question;
        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public string correctAnswer;

        public Question(string question, string answer1, string answer2, string answer3, string answer4, string correctAnswer)
        {
            this.question = question ?? throw new ArgumentNullException(nameof(question));
            this.answer1 = answer1 ?? throw new ArgumentNullException(nameof(answer1));
            this.answer2 = answer2 ?? throw new ArgumentNullException(nameof(answer2));
            this.answer3 = answer3 ?? throw new ArgumentNullException(nameof(answer3));
            this.answer4 = answer4 ?? throw new ArgumentNullException(nameof(answer4));
            this.correctAnswer = correctAnswer ?? throw new ArgumentNullException(nameof(correctAnswer));
        }
    }
}
