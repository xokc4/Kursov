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
using System.Windows.Shapes;

namespace Kursov.Forms
{
    /// <summary>
    /// Логика взаимодействия для Apartment.xaml
    /// </summary>
    public partial class Apartment : Window
    {
        public Apartment()
        {
            InitializeComponent();
            
            bv.KursovEntities entities = new bv.KursovEntities();
            lbServis.ItemsSource = entities.Apartment.ToList();
        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuFotr = new MainWindow();
            menuFotr.Show();
            this.Close();
        }
    }
}
