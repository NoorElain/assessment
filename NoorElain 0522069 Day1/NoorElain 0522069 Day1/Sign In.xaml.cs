using System;
using System.Collections.Generic;
using System.Data;
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

namespace NoorElain_0522069_Day1
{
    /// <summary>
    /// Interaction logic for Sign_In.xaml
    /// </summary>
    public partial class Sign_In : Page
    {
        FasebookEntities1 db = new FasebookEntities1();
        public Sign_In(string name )
        {
            InitializeComponent();
            User_T.Text = name;
        }
        private void SignIn_Button(object sender, RoutedEventArgs e)
        {
            Data_Table2 data_Table2 = new Data_Table2();
            data_Table2 = db.Data_Table2.First(x => x.Username == User_T.Text &&
            x.User_Password == pass_T.Password);
            Profile profile = new Profile();
            this.NavigationService.Navigate(profile);
        } 
        private void SignUP(object sender, RoutedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            this.NavigationService.Navigate(sign_Up);
        }

        private void Forgetpass(object sender, RoutedEventArgs e)
        {
           Forgetpassword forgetpassword = new Forgetpassword();
            this.NavigationService.Navigate(forgetpassword);
        }

        private void SignInAsAdmin_Button(object sender, RoutedEventArgs e)
        {
            Admin_login admin_Login = new Admin_login();
            this.NavigationService.Navigate(admin_Login);
        }
    }
}
