using System;
using System.Windows;

namespace Quiz_App
{
    class ChangeOutNewQuestionAndAnswers
    {
        private readonly ViewModel viewModel;
        private static int arrayIndex = 1;
     
        public ChangeOutNewQuestionAndAnswers(ViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public void NextQuestionAndAnswers()
        {
            //if array reaches bounds, we know the test is done so quit switching to next questions
            if(arrayIndex >= ViewModel.Questions.Length)
            {
                return;
            }

            var currentQuestion = ViewModel.Questions[arrayIndex++];
            viewModel.QuestionOnScreen = currentQuestion.QuestionProperty;
            viewModel.Answer1 = currentQuestion.Answer1;
            viewModel.Answer2 = currentQuestion.Answer2;
            viewModel.Answer3 = currentQuestion.Answer3;
            viewModel.Answer4 = currentQuestion.Answer4;
        }
    }
}
