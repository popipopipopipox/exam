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

namespace exam
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

        int Cost = 50;
        int Stock = 12;

        private void CalcCost(object sender, RoutedEventArgs e)
        {
            int Kol = Convert.ToInt32(Zakaz.Text);
            int V = Cost * Kol;
            ZakazCost.Text = V.ToString();
        }

        private void Buy(object sender, RoutedEventArgs e)
        {
            int Kol = Convert.ToInt32(Zakaz.Text);
            if (Kol <= Stock)
            {
                MessageBox.Show("Ваш заказ успешно оформлен!");
            }

        else
            {
                MessageBox.Show("К сожалению, товара на складе недостаточно для того чтобы оформить ваш заказ.");
            }

        }

        private void Customer(object sender, RoutedEventArgs e)
        {
            SP1.Visibility = Visibility.Visible;
            SP2.Visibility = Visibility.Visible;
            SP3.Visibility = Visibility.Visible;
            MainSP.Visibility = Visibility.Hidden;

        }

        private void Worker(object sender, RoutedEventArgs e)
        {
            MainSP.Visibility = Visibility.Hidden;
            SP4.Visibility = Visibility.Visible;
            SP5.Visibility = Visibility.Visible;

        }

        private void NewStock(object sender, RoutedEventArgs e)
        {
            int S = Convert.ToInt32(Newkol.Text);
            Stock = S;
            MessageBox.Show("Успешно");
        }

        private void NewCost(object sender, RoutedEventArgs e)
        {
            int C = Convert.ToInt32(Newcost.Text);
            Cost = C;
            MessageBox.Show("Успешно");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            SP1.Visibility = Visibility.Hidden;
            SP2.Visibility = Visibility.Hidden;
            SP3.Visibility = Visibility.Hidden;
            SP4.Visibility = Visibility.Hidden;
            SP5.Visibility = Visibility.Hidden;
            MainSP.Visibility = Visibility.Visible;

        }
    }
}
