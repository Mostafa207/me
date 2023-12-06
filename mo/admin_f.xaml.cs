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

namespace me
{
    /// <summary>
    /// Interaction logic for admin_f.xaml
    /// </summary>
    public partial class admin_f : Page
    {
        public admin_f()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            search search = new search();
            this.NavigationService.Navigate(search);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            this.NavigationService.Navigate(page1);
        }
    }
}
