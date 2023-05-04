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

namespace H01_Body_Mass_Index_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double gewicht = Convert.ToDouble(TxBxGewicht.Text);
            double groesse = Convert.ToDouble(TxBxGroesse.Text);
            double bmi = Math.Round(gewicht / Math.Pow(groesse,2),2);
            TxBckAusgabe.Text = "BMI: " + Convert.ToString(bmi);
            TxBxGewicht.Text = "";
            TxBxGroesse.Text = "";
        }
    }
}
