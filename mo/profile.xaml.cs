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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        dateEntities db = new dateEntities();
        public profile(string name)
        {
            InitializeComponent();
            lable.Content ="welcome" +name;
            date.ItemsSource=db.userrs.Where(x=>x.username==name).ToList();
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lognin lognin = new lognin();
            this.NavigationService.Navigate(lognin);
        }
    }
}
