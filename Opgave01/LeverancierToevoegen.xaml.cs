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
    /// Interaction logic for LeverancierToevoegen.xaml
    /// </summary>
    public partial class LeverancierToevoegen : Window
    {
        public LeverancierToevoegen()
        {
            InitializeComponent();
        }


        private void Button_Toevoegen(object sender, RoutedEventArgs e)
        {
            try
            {
                var tuin = new TuinManager();
                var leverancier = new Leverancier()
                {
                    Naam = textNaam.Text,
                    Adres = textAdres.Text,
                    PostNr = textPostcode.Text,
                    Woonplaats = textPlaats.Text
                };
                var id = tuin.LeverancierToevoegen(leverancier);
                labelStatus.Content = "nieuwe leverancier toegevoegd met id=" + id.ToString();
            }
            catch (Exception ex)
            {
                labelStatus.Content = ex.Message;                
            }
        }

        private void Button_Korting(object sender, RoutedEventArgs e)
        {
            try
            {
                var manager = new TuinManager();
                labelStatus.Content = manager.EindejaarsKorting().ToString() + " plantenprijzen aangepast";
            }
            catch (Exception ex)
            {
                labelStatus.Content = ex.Message;
            }
        }

        private void Button_Vervang(object sender, RoutedEventArgs e)
        {
            try
            {
                var manager = new TuinManager();
                //labelStatus.Content = manager.EindejaarsKorting().ToString() + " plantenprijzen aangepast";
                manager.VervangLeverancier(2,3);
                labelStatus.Content = "leverancier 2 is verwijderd en vervangen door 3";
                
            }
            catch (Exception ex)
            {
                labelStatus.Content = ex.Message;
            }               
        }
    }
}
