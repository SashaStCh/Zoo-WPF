using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPF.Model;
using TestWPF.Helper;
using TestWPF.Navigation;


namespace TestWPF.ViewModel
{
    internal class AnimalMenuViewModel : BaseViewModel
    {
        private AnimalMenuModel animalMenuModel = new AnimalMenuModel();

        #region Commands

        private ICommand back;
        public ICommand Back
        {
            get
            {
                return back ??
                    (back = new ActionCommand(() =>
                    {
                        Navigator.Navigate(Navigator.PageAlias.MainMenu);
                    }));
            }
        }

        private ICommand selectAnimals;
        public ICommand SelectAnimals
        {
            get
            {
                return selectAnimals ??
                    (selectAnimals = new ActionCommand(() =>
                    {
                        Navigator.Navigate(Navigator.PageAlias.SelectAnimals);
                    }));
            }
        }

        #endregion
    }
}
