using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppUsingICommand
{
    class MyCommand : ICommand
    {

        Func<object, bool> _canExecute;
        Action<object> _execute;

        public MyCommand(Func<object, bool> canExecute, Action<object> execute)
        {
            _canExecute = canExecute;
            _execute = execute;

        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            
            remove
            {
                CommandManager.RequerySuggested += value;
            }
            
        }
       

        public bool CanExecute(object parameter)
        {
            if(_canExecute!= null)
            {
                return _canExecute(parameter);
            }
            return false;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
