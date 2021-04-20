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

namespace conversorGrados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numerocentigrados = 0;
        private int numerofahrenheit = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttoncentigrados_Click(object sender, RoutedEventArgs e)
        {
            numerocentigrados = Convert.ToInt32(centigrados.Text);
            fahrenheit.Text = Convert.ToString((numerocentigrados * 9 / 5) + 32);
        }

        private void buttonfahrenheit_Click(object sender, RoutedEventArgs e)
        {
            numerofahrenheit = Convert.ToInt32(fahrenheit.Text);
            centigrados.Text = Convert.ToString((numerofahrenheit - 32) * 5 / 9);
        }
    }
}
