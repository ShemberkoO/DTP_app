using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTP_app.ViewModels
{
    public class Command : ICommand
    {
        #region constructor

        public Command(Action<object> action) {
            ExecuteDelegate = action;
        }

        #endregion

        #region Properties
        
        public Predicate<object> CanExecutePredicate;
        public Action<object> ExecuteDelegate;

        public event EventHandler? CanExecuteChanged;

        #endregion
        public bool CanExecute(object? parameter)
        {
            if (CanExecutePredicate != null)
            {
                return CanExecutePredicate(parameter);
            }
            return true;
        }

        public void Execute(object? parameter)
        {
            if(ExecuteDelegate != null)
            {
                ExecuteDelegate(parameter);
            }
           
        }
    }
}
