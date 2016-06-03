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
using System.Windows.Shapes;
using OpgaveRepository;

namespace Opgave01
{
    /// <summary>
    /// Interaction logic for PlantenOphalenViaSoort.xaml
    /// </summary>
    public partial class PlantenOphalenViaSoort : Window
    {
        public PlantenOphalenViaSoort()
        {
            InitializeComponent();

            //soorten ophalen
        }

        private void comboSoort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //planten ophalen
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var manager = new TuinManager();
                comboSoort.DisplayMemberPath = "SoorNaam";
                comboSoort.SelectedValuePath = "SoortNummer";
                comboSoort.ItemsSource = manager.GetSoorten();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
