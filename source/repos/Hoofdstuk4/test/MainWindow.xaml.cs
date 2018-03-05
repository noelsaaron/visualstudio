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

namespace test
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
            double straal = Convert.ToDouble(textbox.Text);
            omtrek.Content = Math.Round(2 * Math.PI * straal, 2);
            oppervlakte.Content = Math.Round(Math.PI * Math.Pow(straal, 2), 2);
            volume.Content = Math.Round((4 * Math.PI / 3) * Math.Pow(straal, 3), 2);
        } 
    }
}
