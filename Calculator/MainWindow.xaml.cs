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

namespace Calculator
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

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

            //list_result.Items.Add(numbers_add1.Text);
            double add1 = Convert.ToDouble(numbers_add1.Text);
            double add2 = Convert.ToDouble(numbers_add2.Text);
            double Result = add1 - add2;

            list_result.Items.Add($"{numbers_add1.Text} - {numbers_add2.Text} = {Result}");
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            double add1 = Convert.ToDouble(numbers_add1.Text);
            double add2 = Convert.ToDouble(numbers_add2.Text);
            double Result = add1 + add2;

            list_result.Items.Add($"{numbers_add1.Text} + {numbers_add2.Text} = {Result}");
        }

        private void Devide_Click(object sender, RoutedEventArgs e)
        {
            double add1 = Convert.ToDouble(numbers_add1.Text);
            double add2 = Convert.ToDouble(numbers_add2.Text);
            double Result = add1 / add2;

            list_result.Items.Add($"{numbers_add1.Text} / {numbers_add2.Text} = {Result}");
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            double add1 = Convert.ToDouble(numbers_add1.Text);
            double add2 = Convert.ToDouble(numbers_add2.Text);
            double Result = add1 * add2;

            list_result.Items.Add($"{numbers_add1.Text} * {numbers_add2.Text} = {Result}");
        }
    }
}
