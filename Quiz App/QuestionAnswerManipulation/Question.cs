using System;

namespace Quiz_App
{
    public struct Question
    {
        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string correctAnswer;

        public Question(string question, string answer1, string answer2, string answer3, string answer4, string correctAnswer)
        {
            this.question = question ?? throw new ArgumentNullException(nameof(question));
            this.answer1 = answer1 ?? throw new ArgumentNullException(nameof(answer1));
            this.answer2 = answer2 ?? throw new ArgumentNullException(nameof(answer2));
            this.answer3 = answer3 ?? throw new ArgumentNullException(nameof(answer3));
            this.answer4 = answer4 ?? throw new ArgumentNullException(nameof(answer4));
            this.correctAnswer = correctAnswer ?? throw new ArgumentNullException(nameof(correctAnswer));
        }

        public string QuestionProperty
        {
            get => this.question;
            set
            {
                if(this.question != value)
                {
                    this.question = value;
                }
            }
        }

        public string Answer1
        {
            get => this.answer1;
            set
            {
                if (this.answer1 != value)
                {
                    this.answer1 = value;
                }
            }
        }

        public string Answer2
        {
            get => this.answer2;
            set
            {
                if (this.answer2 != value)
                {
                    this.answer2 = value;
                }
            }
        }

        public string Answer3
        {
            get => this.answer3;
            set
            {
                if (this.answer3 != value)
                {
                    this.answer3 = value;
                }
            }
        }

        public string Answer4
        {
            get => this.answer4;
            set
            {
                if (this.answer4 != value)
                {
                    this.answer4 = value;
                }
            }
        }
    }
}
