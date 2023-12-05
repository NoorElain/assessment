using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations;
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

namespace NoorElain_0522069_Day1
{
    /// <summary>
    /// Interaction logic for Forgetpassword.xaml
    /// </summary>
    public partial class Forgetpassword : Page
    {
        FasebookEntities1 db = new FasebookEntities1();
        public Forgetpassword()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data_Table2 data_Table2 = new Data_Table2();
            data_Table2 = db.Data_Table2.First(x => x.Phone == Phone_T.Text);
            if(data_Table2.Phone == Phone_T.Text)
            {
                if(Regex.IsMatch(Passnew_T.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$"))
                {
                    data_Table2.User_Password = Passnew_T.Text;
                    Passnew_T.Text = PassCon_T.Text;
                    db.Data_Table2.AddOrUpdate(data_Table2);
                    db.SaveChanges();
                    //Sign_In sign_In = new Sign_In(User_T.text);
                   // this.NavigationService.Navigate(sign_In);
                }
            }
            
        }
    }
}
