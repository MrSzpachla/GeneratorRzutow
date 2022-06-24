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

namespace GeneratorRzutow
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
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        private void Generuj_k4_Click(object sender, RoutedEventArgs e)
        {
            k4.Content = GetRandomNumber(1, 5);
        }
        private void Generuj_k6_Click(object sender, RoutedEventArgs e)
        {
            k6.Content = GetRandomNumber(1, 7);
        }

        private void Generuj_k8_Click(object sender, RoutedEventArgs e)
        {
            k8.Content = GetRandomNumber(1, 9);
        }

        private void Generuj_k10_Click(object sender, RoutedEventArgs e)
        {
            k10.Content = GetRandomNumber(1, 11);
        }

        private void Generuj_k12_Click(object sender, RoutedEventArgs e)
        {
            k12.Content = GetRandomNumber(1, 13);
        }

        private void Generuj_k20_Click(object sender, RoutedEventArgs e)
        {
            k20.Content = GetRandomNumber(1, 21);
        }

        private void Generuj_k100_Click(object sender, RoutedEventArgs e)
        {
            k100.Content = GetRandomNumber(1, 101);
        }

        private void Generuj_3k20_Click(object sender, RoutedEventArgs e)
        {
            int temp1,temp2,temp3;
            temp1 = GetRandomNumber(1, 21);
            temp2 = GetRandomNumber(1, 21);
            temp3 = GetRandomNumber(1, 21);
            k21.Content = temp1;
            k22.Content = temp2;
            k23.Content = temp3;
            GenSuma.Content = temp1 + temp2 + temp3;
            GenSrednia.Content = (temp1 + temp2 + temp3)/3;
        }
    }
}
