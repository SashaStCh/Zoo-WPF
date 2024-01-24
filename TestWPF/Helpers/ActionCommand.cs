using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestWPF.Helper
{
    internal class ActionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action action;

        public ActionCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
