using System;
using System.Collections.Generic;
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

namespace NoorElain_0522069_Day1
{
    /// <summary>
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Page
    {
        FasebookEntities1 db = new FasebookEntities1();
        public Sign_Up()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Data_Table2 data_Table2 = new Data_Table2();
            
        }

        private void SignUp_Button(object sender, RoutedEventArgs e)
        {
            Data_Table2 data_Table2 = new Data_Table2();
            data_Table2.Username = User_T.Text;
            if(Regex.IsMatch(pass_T.Password,@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$"))
            {

                data_Table2.User_Password = pass_T.Password;
                int age = int.Parse(Age_T.Text);                
                if(age >18 && age<60)
                {
                    data_Table2.Age = age;
                    if(phone_T.Text.Length ==11)
                    {
                        data_Table2.Phone = phone_T.Text;
                        db.Data_Table2.Add(data_Table2);
                        if (combo.Text == "Elmonofia")
                        {
                            data_Table2.City = combo.Text;
                        }
                        else if (combo.Text == "Giza")
                        {
                            data_Table2.City = combo.Text;
                        }
                        else if (combo.Text == "Cairo")
                        {
                            data_Table2.City = combo.Text;
                        }
                        else if (combo.Text == "Elmenia")
                        {
                            data_Table2.City = combo.Text;
                        }
                        else if (combo.Text == "Tokio")
                        {
                            data_Table2.City = combo.Text;
                        }
                        else
                        {
                            MessageBox.Show("Invalied City !");
                        }//gender
                        if(combo_gender.Text == "Female")
                        {
                            data_Table2.Gender_var = combo_gender.Text;
                        }
                        else if (combo_gender.Text == "Male")
                        {
                            data_Table2.Gender_var= combo_gender.Text;
                        }
                        db.SaveChanges();
                        Profile profile = new Profile();
                        this.NavigationService.Navigate(profile);
                        /*if (RadioButton_Checked("Female")//(RadioButton.CheckedItem == readioFem.Contains)
                        {
                            data_Table2.Gender_var = radioFem.Content;
                        }
                        else 
                        {
                            data_Table2.Gender_var = radioFem.Checked;
                        }*/
                    }                    
                }
                else
                {
                    MessageBox.Show(" Age: must be from 18 to 60 !");
                }                
            }
            else
            {
                MessageBox.Show("Password must be contain Upper Case and Digits and Special Characters or Woring Data Format ^_^ ! ");
            }
        }

        private void SignIn_Button(object sender, RoutedEventArgs e)
        {
            Sign_In sign_In = new Sign_In(User_T.Text);
            this.NavigationService.Navigate(sign_In);
        }

        private void RadioFemale_Checked(object sender, RoutedEventArgs e)
        {
           // Data_Table2 data_Table2 = new Data_Table2();
           // if(radioFem.CaptureTouch(data_Table2.Gender_var )
        }

        private void Radiomal_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
