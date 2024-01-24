using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPF.Helper;
using TestWPF.Model;
using TestWPF.Navigation;


namespace TestWPF.ViewModel
{
    internal class MainMenuViewModel : BaseViewModel
    {
        private MainMenuModel mainmenuModel = new MainMenuModel();

        #region Commands

        private ICommand animalActions;
        public ICommand AnimalActions
        {
            get
            {
                return animalActions ??
                    (animalActions = new ActionCommand(() =>
                    {
                        Navigator.Navigate(Navigator.PageAlias.AnimalMenu);
                    }));
            }
        }

        #endregion
    }
}
