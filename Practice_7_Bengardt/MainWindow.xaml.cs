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

namespace Practice_7_Bengardt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Addit_Click(object sender, RoutedEventArgs e)
        {
            Rational firstPair = new Rational(int.Parse(FirstPair1.Text), int.Parse(SecondPair1.Text));
            Rational secondPair = new Rational(int.Parse(FirstPair2.Text), int.Parse(SecondPair2.Text));
            result.Text = Rational.ToString(firstPair + secondPair);
        }

        private void Segmentat_Click(object sender, RoutedEventArgs e)
        {
            Rational firstPair = new Rational(int.Parse(FirstPair1.Text), int.Parse(SecondPair1.Text));
            Rational secondPair = new Rational(int.Parse(FirstPair2.Text), int.Parse(SecondPair2.Text));
            result.Text = Rational.ToString(firstPair / secondPair);
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            Rational firstPair = new Rational(int.Parse(FirstPair1.Text), int.Parse(SecondPair1.Text));
            Rational secondPair = new Rational(int.Parse(FirstPair2.Text), int.Parse(SecondPair2.Text));
            result.Text = Rational.ToString(firstPair - secondPair);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
