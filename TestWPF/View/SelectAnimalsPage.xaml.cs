using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для SelectAnimalsPage.xaml
    /// </summary>
    public partial class SelectAnimalsPage : Page
    {
        public SelectAnimalsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var Animal = DataBase.db.Animal.ToList();
            var AnimalKind = DataBase.db.AnimalKind.ToList();

            var animalFeeding = (from animal in Animal
                                 join animalKind in AnimalKind on animal.AnimalKindID equals animalKind.AnimalKindID
                                 select new { animal.AnimalID, animal.Name, animalKind.Kind, animal.Gender, animal.AviaryID, animal.BirthDate, animal.DeathDate }).ToList();
            AnimalsGrid.ItemsSource = animalFeeding;
        }

    }
}
