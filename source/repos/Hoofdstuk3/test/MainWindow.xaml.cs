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

        private void Lijn_Click(object sender, RoutedEventArgs e)
        {
            Line mijnlijn = new Line();
            mijnlijn.X1 = 10;
            mijnlijn.Y1 = 10;
            mijnlijn.X2 = 120;
            mijnlijn.Y2 = 120;
            mijnlijn.Stroke = new SolidColorBrush(Colors.Aqua);
            mijnlijn.StrokeThickness = 2;
            MYcanvas.Children.Add(mijnlijn);
        }

        private void Rectangle_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Margin = new Thickness(30, 120, 0, 0);
            rectangle.Width = 125;
            rectangle.Height = 90;
            rectangle.Stroke = new SolidColorBrush(Colors.OrangeRed);
            rectangle.Fill = new SolidColorBrush(Colors.Black);
            MYcanvas.Children.Add(rectangle);
        }

        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse circle = new Ellipse();
            circle.Height = Rectangle.Height;
            circle.Width =  Rectangle.Width;
            circle.Margin = Rectangle.Margin;
            circle.Stroke = new SolidColorBrush(Colors.Beige);
            circle.StrokeThickness = 2;
            MYcanvas.Children.Add(circle);
        }

        private void empty_Click(object sender, RoutedEventArgs e)
        {
            MYcanvas.Children.Clear();
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            Line mijnlijn = new Line();
            Line mijnlijn1 = new Line();
            mijnlijn.X1 = 10;
            mijnlijn.Y1 = 10;
            mijnlijn.X2 = 90;
            mijnlijn.Y2 = 10;
            mijnlijn.Stroke = new SolidColorBrush(Colors.Black);
            mijnlijn.StrokeThickness = 4;

            mijnlijn1.X1 = 50;
            mijnlijn1.Y1 = 10;
            mijnlijn1.X2 = 50;
            mijnlijn1.Y2 = 130;
            mijnlijn1.Stroke = new SolidColorBrush(Colors.Black);
            mijnlijn1.StrokeThickness = 4;
            MYcanvas.Children.Add(mijnlijn);
            MYcanvas.Children.Add(mijnlijn1);


        }
    }
}
