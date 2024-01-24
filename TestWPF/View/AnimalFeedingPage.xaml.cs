using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestWPF.Model;

namespace TestWPF.View
{
    /// <summary>
    /// Логика взаимодействия для AnimalFeedingPage.xaml
    /// </summary>
    public partial class AnimalFeedingPage : Page
    {
        public AnimalFeedingPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var AnimalProcess = DataBase.db.AnimalProcess.ToList();
            var Feeding = DataBase.db.Feeding.ToList();

            var animalFeeding = (from animalProcess in AnimalProcess
                                 join feeding in Feeding on animalProcess.AnimalProcessID equals feeding.ProcessID
                                 select new { animalProcess.AnimalProcessID, animalProcess.EmployeeID, animalProcess.AnimalID, animalProcess.Date, feeding.FoodType }).ToList();
            FeedingGrid.ItemsSource = animalFeeding;
        }
    }
}
