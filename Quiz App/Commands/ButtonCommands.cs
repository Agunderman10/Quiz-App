using System;
using System.Windows.Input;

namespace Quiz_App
{
    class ButtonCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
