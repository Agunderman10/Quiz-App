using System;
using System.Windows;

namespace Quiz_App
{
    class ChangeOutNewQuestionAndAnswers
    {
        private readonly ViewModel viewModel;
        private static int arrayIndex = 0;

        public ChangeOutNewQuestionAndAnswers(ViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
        public void NextQuestionAndAnswers()
        {
            if(arrayIndex >= (ViewModel.Questions.Length - 1))
            {
                MessageBox.Show("You have finished your test.");
            }
            viewModel.Question = ViewModel.Questions[++arrayIndex];
            viewModel.Answer1 = ViewModel.Button1AnswerChoices[arrayIndex];
            viewModel.Answer2 = ViewModel.Button2AnswerChoices[arrayIndex];
            viewModel.Answer3 = ViewModel.Button3AnswerChoices[arrayIndex];
            viewModel.Answer4 = ViewModel.Button4AnswerChoices[arrayIndex];
        }
    }
}
