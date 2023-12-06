using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace me
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        string Gender;
        dateEntities db = new dateEntities();
        public signup()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr add = new userr();
            Regex regex = new Regex(@"^(?=.*[A-B])(?=.*[a-z])(?=.*\d)(?=.*\W)");

            if (regex.IsMatch(txtpassword.Text))
            {
                int dd = int.Parse(txtage.Text);
                if (txtphone.Text.Length == 11 && dd >= 18 && dd <= 60)
                {
                    add.username = txtname.Text;
                    add.password = txtpassword.Text;
                    add.age = dd;
                    add.phone = txtphone.Text;
                    add.gender = Gender;
                    add.city = comb.Text;
                    db.userrs.Add(add);
                    db.SaveChanges();
                    MessageBox.Show("added succe");
                    string name = txtname.Text;
                    profile profile = new profile(name);
                    this.NavigationService.Navigate(profile);
                    
                }
                else
                {
                    MessageBox.Show("maybe the phone or age is arrer");
                }

            }
            else
            {
                MessageBox.Show("the password is weak");
            }
        }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Gender = "m";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Gender = "f";
        }

        private void txtp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    } 
}
