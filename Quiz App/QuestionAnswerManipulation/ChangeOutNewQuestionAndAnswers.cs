using System;
using System.Windows;

namespace Quiz_App
{
    class ChangeOutNewQuestionAndAnswers
    {
        private readonly ViewModel viewModel;
        private static int listIndex = 0;
     
        public ChangeOutNewQuestionAndAnswers(ViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public void NextQuestionAndAnswers()
        {
            IfArrayReachesBounds();

            var currentQuestion = ViewModel.Questions[++listIndex];
            viewModel.QuestionOnScreen = currentQuestion.question;
            viewModel.Answer1 = currentQuestion.answer1;
            viewModel.Answer2 = currentQuestion.answer2;
            viewModel.Answer3 = currentQuestion.answer3;
            viewModel.Answer4 = currentQuestion.answer4;
        }

        private void IfArrayReachesBounds()
        {
            if (listIndex >= (ViewModel.Questions.Capacity - 1))
            {
                MessageBox.Show("You have finished your test.");
            }
        }
    }
}
