using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPF.Helper;
using TestWPF.Navigation;
using TestWPF.Model;

namespace TestWPF.ViewModel
{
    internal class AnimalFeedingViewModel : BaseViewModel
    {
        private AnimalFeedingModel animalFeedingModel = new AnimalFeedingModel();

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
    }
}
