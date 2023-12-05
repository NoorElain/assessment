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

namespace NoorElain_0522069_Day1
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        FasebookEntities1 db = new FasebookEntities1();   
        public Profile()
        {
          InitializeComponent();
          data_drid.ItemsSource=db.Data_Table2.Select(x => new { x.Username, x.City, x.Age ,x.Gender_var }).ToList();
        }

        private void User_T_TextChanged(object sender, TextChangedEventArgs e)
        {
            Data_Table2 data_Table2 = new Data_Table2();
            User_T.Text.Contains(data_Table2.Username);
            pass_T.Password.Contains(data_Table2.User_Password);
            City_T.Text.Contains(data_Table2.City);
            Gender_T.Text.Contains(data_Table2.Gender_var);
            string age = Convert.ToString(data_Table2.Age);
            Age_T.Text.Contains(age);
            phone_T.Text.Contains(data_Table2.Phone);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_In sign_In = new Sign_In(User_T.Text);
            this.NavigationService.Navigate(sign_In);
        }
        private void data_drid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
