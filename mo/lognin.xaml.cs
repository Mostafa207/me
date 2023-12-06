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
    /// Interaction logic for lognin.xaml
    /// </summary>
    public partial class lognin : Page
    {
        dateEntities db = new dateEntities();
        public lognin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signup signup = new signup();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forget forget = new forget();
            this.NavigationService.Navigate(forget);
        }

               private void Button_Click_3(object sender, RoutedEventArgs e)
               {
                 Adminlogin adminlogin = new Adminlogin();
                this.NavigationService.Navigate(adminlogin);
               }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
          userr date = new userr();
            try
            {
                date = db.userrs.First(x => x.username == txtn.Text && x.password == txtp.Text);
                if (date != null)
                {
                    String name = date.username;
                    profile profile = new profile(name);
                    this.NavigationService.Navigate(profile);
                }
            }
            catch
            {
                MessageBox.Show("not found");
            }
            
        }

       

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Adminlogin adminlogin = new Adminlogin();
            this.NavigationService.Navigate(adminlogin);

        }

        private void txtn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
