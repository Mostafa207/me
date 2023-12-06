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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        dateEntities db =new dateEntities();
        public search()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                userr d = new userr();
                date.ItemsSource = db.userrs.Where(x => x.city == txtc.Text).Select(x => new { x.username, x.phone, x.age }).ToList();
                
            }
            catch {
                MessageBox.Show("not found");
            }

        }
    }
}
