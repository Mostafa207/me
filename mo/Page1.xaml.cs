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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        dateEntities db = new dateEntities();
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr userr = new userr();
            userr = db.userrs.Remove(db.userrs.First(x => x.phone == ___txtphone.Text));
            MessageBox.Show("the user is deleted");
            db.SaveChanges();
            grad.ItemsSource = db.userrs.ToList();
        }
    }
}
