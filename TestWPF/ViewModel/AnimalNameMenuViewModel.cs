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
    internal class AnimalNameMenuViewModel : BaseViewModel
    {
        private AnimalNameMenuModel animalNameMenuModel = new AnimalNameMenuModel();

        private ICommand feed;
        public ICommand Feed
        {
            get
            {
                return feed ??
                    (feed = new ActionCommand(() =>
                    {
                        Navigator.Navigate(Navigator.PageAlias.AnimalFeeding);
                    }));
            }
        }
    }
}
