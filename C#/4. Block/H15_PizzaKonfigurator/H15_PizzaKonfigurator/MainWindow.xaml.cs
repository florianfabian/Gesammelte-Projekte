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

namespace H15_PizzaKonfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Items der ComboBox hinzufügen
            List<string> items = new List<string> { "Margherita", "Vesuvio", "Salame", "Napoli", "Tonno", "Hawaii" };
            cmbxTyp.ItemsSource = items;

            // Items der ListBox hinzufügen
            List<string> items2 = new List<string> { "Salami", "Schinken", "Artischocken", "Champignons", "Sardellen", "Oliven", "Paprika" };
            lbxToppings.ItemsSource = items2;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rButtonMittel.IsChecked = false;
            rButtonGroß.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rButtonMittel_Checked(object sender, RoutedEventArgs e)
        {
            rButtonKlein.IsChecked = false;
            rButtonGroß.IsChecked = false;
        }

        private void rButtonGroß_Checked(object sender, RoutedEventArgs e)
        {
            rButtonMittel.IsChecked = false;
            rButtonKlein.IsChecked = false;
        }

        private void lbxToppings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //hier versuch, bei einem klick zu selecten oder nicht. Leider kein Erfolg.
            lbxToppings.SelectedItems.Add(lbxToppings.SelectedItem);
        }

        private void buttonBestellen_Click(object sender, RoutedEventArgs e)
        {
            if(rButtonGroß.IsChecked == true || rButtonMittel.IsChecked == true || rButtonKlein.IsChecked == true & cmbxTyp.SelectedItem != null)
            {
                //Extras in ein String-Array abspeichern
                List<string> extrasv = new List<string>();
                if(cbxKäse.IsChecked == true)
                {
                    extrasv[0] = "Käse";
                }
                if(cbxOlivenöl.IsChecked == true)
                {
                    extrasv[1] = "Olivenöl";
                }
                if(cbxTomaten.IsChecked == true)
                {
                    extrasv[2] = "Tomaten";
                }

                //Toppings in ein String-Array abspeichern
                List<string> toppings = new List<string>();
                toppings = (List<string>)lbxToppings.SelectedItems;

                string typ = (string)cmbxTyp.SelectedItem;

                //Daten an die Klasse Pizza übergeben / Objekt erstellen
                if (rButtonGroß.IsChecked == true)
                {
                    Pizza p1 = new Pizza(typ, "Groß", extrasv, toppings);
                    PizzaDatei p1_write = new PizzaDatei(p1.Typ, p1.Größe, p1.Extras, p1.Toppings, @"pizzaliste.txt");
                }
                else if (rButtonMittel.IsChecked == true)
                {
                    Pizza p1 = new Pizza(typ, "Mittel", extrasv, toppings);
                    PizzaDatei p1_write = new PizzaDatei(p1.Typ, p1.Größe, p1.Extras, p1.Toppings, @"pizzaliste.txt");
                }
                else
                {
                    Pizza p1 = new Pizza(typ, "Klein", extrasv, toppings);
                    PizzaDatei p1_write = new PizzaDatei(p1.Typ, p1.Größe, p1.Extras, p1.Toppings, @"pizzaliste.txt");
                }

                MessageBox.Show("Ihre Pizza ist bestellt und in unserem System eingespeichert. Vielen Dank für Ihre Bestellung!", "SUCCESS", MessageBoxButton.OK);


            }
            else
            {
                MessageBox.Show("Sie müssen die Größe und den Typ angeben, bevor Sie bestellen können!", "ERROR", MessageBoxButton.OK);
            }
        }
    }
}
