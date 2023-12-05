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
    /// Interaction logic for Admin_login.xaml
    /// </summary>
    public partial class Admin_login : Page
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Del_Or_Sear del_Or_Sear = new Del_Or_Sear();
            this.NavigationService.Navigate(del_Or_Sear);
        }
    }
}
