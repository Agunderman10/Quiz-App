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
            viewModel.QuestionOnScreen = currentQuestion.question;
            viewModel.Answer1 = currentQuestion.answer1;
            viewModel.Answer2 = currentQuestion.answer2;
            viewModel.Answer3 = currentQuestion.answer3;
            viewModel.Answer4 = currentQuestion.answer4;
        }
    }
}
