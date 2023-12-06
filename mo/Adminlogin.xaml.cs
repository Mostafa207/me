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
    /// Interaction logic for Adminlogin.xaml
    /// </summary>
    public partial class Adminlogin : Page
    {
        dateEntities db = new dateEntities();
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                adminn adm = new adminn(); 
               
                
                if (txtn.Text != "" && txtp.Text != "")
                {
                     adm=db.adminns.First(x=> txtn.Text==x.admin_username&&txtp.Text==x.admin_pass);
                    if(adm!=null)
                    {
                      MessageBox.Show("hello");
                        admin_f _F= new admin_f();
                        this.NavigationService.Navigate(_F);
                    }

                }
                else
                {
                    MessageBox.Show("enter date");
                }
     
            }
            catch
            {
                MessageBox.Show("not found");
            }
            


        }
    }
}
