using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        dateEntities db = new dateEntities();
        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr d = new userr();
             d=db.userrs.First(x=>x.phone==txtphone.Text);
            if (d.phone==txtphone.Text )
            {
                Regex regex = new Regex(@"^(?=.*[A-B])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()]).+$");
                if (regex.IsMatch(txtpass.Text))
                {
                    d.password = txtpass.Text;
                    if (txtpass.Text == txtpass1.Text)
                    {
                        db.userrs.AddOrUpdate(d);
                        db.SaveChanges();
                        MessageBox.Show("pass is change");
                        lognin lognin = new lognin();   
                        this.NavigationService.Navigate(lognin);
                    }
                    else
                    {
                        MessageBox.Show("paasswor invalid ");
                    }
                }
                else
                {
                    MessageBox.Show("the pass is weak");
                }
            }
            
        }

       
    }
}
