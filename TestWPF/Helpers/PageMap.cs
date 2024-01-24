using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TestWPF.ViewModel;

namespace TestWPF.Helpers
{
    internal class PageMap
    {
        public Page view;
        public BaseViewModel viewModel;
        public PageMap(Page view, BaseViewModel viewModel)
        {
            this.view = view;
            this.viewModel = viewModel;
        }
    }
}
