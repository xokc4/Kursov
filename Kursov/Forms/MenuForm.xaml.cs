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
    /// Логика взаимодействия для MenuForm.xaml
    /// </summary>
    public partial class MenuForm : Window
    {
        public MenuForm()
        {
            InitializeComponent();
        }

      
        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btApartment_Click(object sender, RoutedEventArgs e)
        {
            Forms.Apartment apartment = new Apartment();
            apartment.Show();
            this.Close();
        }

        private void btDobKvartir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
