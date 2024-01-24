using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPF.Model;
using TestWPF.Helper;
using TestWPF.Navigation;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace TestWPF.ViewModel
{
    internal class SelectAnimalsViewModel : BaseViewModel
    {
        private SelectAnimalsModel selectAnimalsModel = new SelectAnimalsModel();

        #region Properties

        #endregion

        #region Commands

        private ICommand back;
        public ICommand Back
        {
            get
            {
                return back ??
                    (back = new ActionCommand(() =>
                    {
                        Navigator.Navigate(Navigator.PageAlias.AnimalMenu);
                    }));
            }
        }

        private ICommand next;
        public ICommand Next
        {
            get
            {
                return next ??
                    (next = new ActionCommand(() =>
                    {
                        Navigator.Navigate(Navigator.PageAlias.AnimalNameMenu);
                    }));
            }
        }
        #endregion

    }
}
