using System;
using System.Collections.Generic;
using System.IO;
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

namespace H10_NotizzettelPopup_Aufgabe
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
            string[] items = File.ReadAllLines(@"C:\Users\fabflo\Desktop\Gesammelte-Projekte\notizen.txt");
            for (int i = 0; i < items.Length; i++)
            {
                NotizenListe.Items.Add(items[i]);
            }
        }

        private void Window_Closed(object sender, RoutedEventArgs e)
        {
            string[] items = new string[NotizenListe.Items.Count];
            NotizenListe.Items.CopyTo(items, 0);
            File.WriteAllLines(@"C:\Users\fabflo\Desktop\Gesammelte-Projekte\notizen.txt", items);
        }

    private void NotizenListe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void B_Speichern_Click(object sender, RoutedEventArgs e)
        {
            string txt_eingabe = Eingabe.Text;
            if (txt_eingabe == "")
            {
                MessageBox.Show("Bitte einen Notiztext eingeben!");
            }
            else
            {
                NotizenListe.Items.Add(txt_eingabe);
                Eingabe.Text = "";
            }
        }

        private void NotizenListe_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void B_Löschen_Click(object sender, RoutedEventArgs e)
        {
            if(NotizenListe.SelectedItem != null)
            {
                NotizenListe.Items.Remove(NotizenListe.SelectedItem);
            }
            else
            {
                MessageBox.Show("Bitte einen Notiztext zum Löschen auswählen!");
            }
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {

        }
    }
}
