using OpgaveRepository;
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

namespace Opgave01
{
    /// <summary>
    /// Interaction logic for BerekenKostprijs.xaml
    /// </summary>
    public partial class BerekenKostprijs : Window
    {
        public BerekenKostprijs()
        {
            InitializeComponent();
        }

        private void buttonBereken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var manager = new TuinManager();
                labelStatus.Content = manager.GemiddeldePrijsVanEenSoort(textSoort.Text);
            }
            catch (Exception ex)
            {
                labelStatus.Content = ex.Message;
            }
        }
    }
}
