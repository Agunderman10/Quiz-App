using System;
using System.Windows.Input;

namespace Quiz_App
{
    class ButtonCommands : ICommand
    {
        private readonly ViewModel viewModel;
        public string[] Questions;
        
        public ButtonCommands(ViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            ChangeOutNewQuestionAndAnswers changeOutQA = new ChangeOutNewQuestionAndAnswers(viewModel);
            changeOutQA.NextQuestionAndAnswers();
        }
    }
}
