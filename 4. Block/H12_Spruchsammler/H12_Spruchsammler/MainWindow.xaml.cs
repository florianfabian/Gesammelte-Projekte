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

/// <summary>
/// Autor:      Florian Fabian
/// Datum:      08.03. - 09.03.2023
/// Funktion:   Sprüche in einem WPF Programm einspeichern
/// </summary>

namespace H12_Spruchsammler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int speichernfreigeben = 0;
        public MainWindow()
        {
            InitializeComponent();
            if(lbxSpruch.SelectedItem == null)
            {
                bttnlöschen.Visibility = Visibility.Hidden;
            }
            if(tbxAutor.Text == "" & tbxSpruchtext.Text == "")
            {
                bttnSpeichern.Visibility = Visibility.Hidden;
            }

            Closing += MainWindow_Closing;


        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ItemCollection spruchsammlung = lbxSpruch.Items;
            foreach (string spruchtext in spruchsammlung)
            {
                Spruch.Schreiben(spruchtext);
            }
        }

        public void speicherung(string eintrag)
        {
            lbxSpruch.SelectedItems.Add(eintrag);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            speichernfreigeben++;
        }

        private void bttnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            string autor = tbxAutor.Text;
            string spruchtext = tbxSpruchtext.Text;
            tbxAutor.Text = "";
            tbxSpruchtext.Text = "";
            bttnSpeichern.Visibility = Visibility.Hidden;
            lbxSpruch.Items.Add(spruchtext + " (" + autor + ").");
        }

        private void bttnlöschen_Click(object sender, RoutedEventArgs e)
        {           
            lbxSpruch.Items.Remove(lbxSpruch.SelectedItem);
            bttnlöschen.Visibility = Visibility.Hidden;
        }

        public void tbxSpruchtext_TextChanged(object sender, TextChangedEventArgs e)
        {

                speichernfreigeben++;

        }

        private void lbxSpruch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bttnlöschen.Visibility = Visibility.Visible;
        }

        private void tbxAutor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(speichernfreigeben > 0)
            {
                bttnSpeichern.Visibility = Visibility.Visible;
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hilfe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sie müssen die Felder 'Autor' und 'Spruchtext' füllen, bevor Sie speichern können und einen Spruch in der Liste auswählen, um löschen zu können", "ERROR", MessageBoxButton.OK);
        }
    }
}
