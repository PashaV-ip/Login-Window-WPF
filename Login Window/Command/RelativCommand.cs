using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Login_Window.Command
{
    public class RelativCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public RelativCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelativCommand(Action<object> execute) : this(execute, null)
        {

        }

        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null) return _canExecute(parameter);
            else return true;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
