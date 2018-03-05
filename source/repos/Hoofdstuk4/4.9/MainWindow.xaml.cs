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

namespace _4._9
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
            int ingeworpen = Convert.ToInt32(betaald.Text);
            int kostPrijs = Convert.ToInt32(kostprijs.Text);
            int verschil = ingeworpen - kostPrijs;
            EURO1.Content = verschil / 100;
            verschil = verschil - (Convert.ToInt32(EURO1.Content) * 100);
            CENT50.Content = verschil / 50;
            verschil = verschil - (Convert.ToInt32(CENT50.Content) * 50);
            CENT20.Content = verschil / 20;
            verschil = verschil - (Convert.ToInt32(CENT20.Content) * 20);
            CENT10.Content = verschil / 10;
            verschil = verschil - (Convert.ToInt32(CENT10.Content) * 10);
            CENT5.Content = verschil / 5;
            verschil = verschil - (Convert.ToInt32(CENT5.Content) * 5);
            CENT2.Content = verschil / 2;
            verschil = verschil - (Convert.ToInt32(CENT2.Content) * 2);
            CENT1.Content = verschil / 1;
    

        }

        
    }
}
