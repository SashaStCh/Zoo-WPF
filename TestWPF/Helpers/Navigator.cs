using System;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Collections.Generic;
using TestWPF.Helpers;
using TestWPF.View;
using TestWPF.ViewModel;
using System.Windows.Controls.Primitives;
using static TestWPF.Navigation.Navigator;

namespace TestWPF.Navigation
{
    public sealed class Navigator
    {
        #region Constants
        public enum PageAlias
        {
            SignIn,
            MainMenu,
            AnimalMenu,
            AviaryMenu,
            EmployeeMenu,
            AddAnimal,
            SelectAnimals,
            AddAviary,
            SelectAviary,
            AddEmployee,
            SelectEmployee,
            AnimalFeeding,
            AnimalTraining,
            AnimalCare,
            AnimalAssay,
            AnimalVaccination,
            AviaryCleaning,
            AviaryRepair,
            AddAccount,
            AnimalNameMenu
        }

        private static readonly Dictionary<PageAlias, PageMap> Pages = new Dictionary<PageAlias, PageMap>()
        {
            {PageAlias.SignIn, new PageMap(new SignInPage(), new SignInViewModel())},
            {PageAlias.MainMenu, new PageMap(new MainMenuPage(), new MainMenuViewModel())},
            {PageAlias.AnimalMenu, new PageMap(new AnimalMenuPage(), new AnimalMenuViewModel())},
            {PageAlias.AviaryMenu, new PageMap(new AviaryMenuPage(), new AviaryMenuViewModel())},
            {PageAlias.EmployeeMenu, new PageMap(new EmployeeMenuPage(), new EmployeeMenuViewModel())},
            {PageAlias.AddAnimal, new PageMap(new AddAnimalPage(), new AddAnimalViewModel())},
            {PageAlias.SelectAnimals, new PageMap(new SelectAnimalsPage(), new SelectAnimalsViewModel())},
            {PageAlias.AddAviary, new PageMap(new AddAviaryPage(), new AddAviaryViewModel())},
            {PageAlias.SelectAviary, new PageMap(new SelectAviaryPage(), new SelectAviaryViewModel())},
            {PageAlias.AddEmployee, new PageMap(new AddEmployeePage(), new AddEmployeeViewModel())},
            {PageAlias.SelectEmployee, new PageMap(new SelectEmployeePage(), new SelectEmployeeViewModel())},
            {PageAlias.AnimalFeeding, new PageMap(new AnimalFeedingPage(), new AnimalFeedingViewModel())},
            {PageAlias.AnimalTraining, new PageMap(new AnimalTrainingPage(), new AnimalTrainingViewModel())},
            {PageAlias.AnimalCare, new PageMap(new AnimalCarePage(), new AnimalCareViewModel())},
            {PageAlias.AnimalAssay, new PageMap(new AnimalAssayPage(), new AnimalAssayViewModel())},
            {PageAlias.AnimalVaccination, new PageMap(new AnimalVaccinationPage(), new AnimalVaccinationViewModel())},
            {PageAlias.AviaryCleaning, new PageMap(new AviaryCleaningPage(), new AviaryCleaningViewModel())},
            {PageAlias.AviaryRepair, new PageMap(new AviaryRepairPage(), new AviaryRepairViewModel())},
            {PageAlias.AddAccount, new PageMap(new AddAccountPage(), new AddAccountViewModel())},
            {PageAlias.AnimalNameMenu, new PageMap(new AnimalNameMenuPage(), new AnimalNameMenuViewModel())}
        };

        #endregion

        #region Fields

        private NavigationService _navService;

        #endregion


        #region Properties

        public static NavigationService Service
        {
            get { return Instance._navService; }
            set
            {
                if (Instance._navService != null)
                {
                    Instance._navService.Navigated -= Instance._navService_Navigated;
                }                
                
                Instance._navService = value;
                Instance._navService.Navigated += Instance._navService_Navigated;
            }
        }

        #endregion


        #region Public Methods

        public static void Navigate(PageAlias pageAlias)
        {
            if (Instance._navService == null)
            {
                return;
            }

            Instance._navService.Navigate(Pages[pageAlias].view, Pages[pageAlias].viewModel);
        }

        #endregion


        #region Private Methods

        void _navService_Navigated(object sender, NavigationEventArgs e)
        {
            var page = e.Content as Page;

            if (page == null)
            {
                return;
            }

            page.DataContext = e.ExtraData;
        }

        #endregion


        #region Singleton

        private static volatile Navigator _instance;
        private static readonly object SyncRoot = new Object();

        private static Navigator Instance
        {
            get 
            {
                if (_instance == null) 
                {
                    lock (SyncRoot) 
                    {
                        if (_instance == null)
                            _instance = new Navigator();
                    }
                }

                return _instance;
            }
        }
        #endregion
    }
}
