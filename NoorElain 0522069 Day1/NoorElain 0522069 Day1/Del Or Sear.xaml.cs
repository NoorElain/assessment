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
    /// Interaction logic for Del_Or_Sear.xaml
    /// </summary>
    public partial class Del_Or_Sear : Page
    {
        FasebookEntities1 db = new FasebookEntities1 ();
        public Del_Or_Sear()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

       
        private void delete_butt(object sender, RoutedEventArgs e)
        {
            try
            {
                Data_Table2 Table2 = new Data_Table2();
                if (userphone_t.Text != null)
                {
                    Table2 = db.Data_Table2.First(x => x.Phone == userphone_t.Text);
                    db.Data_Table2.Remove(Table2);
                    db.SaveChanges();
                    data_grid.ItemsSource = db.Data_Table2.Select(x => new { x.Age, x.City, x.Username, x.Gender_var, x.Phone }).ToList();
                    MessageBox.Show("done ^-^!");
                }
                else
                {
                    MessageBox.Show("invalied input !"); 
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void search_butt(object sender, RoutedEventArgs e)
        {
            try
            {
                if (usercity_t.Text != null)
                {
                    data_grid.ItemsSource = db.Data_Table2.Where(x => x.City == usercity_t.Text).Select(x => new { x.Username, x.Age, x.Gender_var, x.Phone, x.City }).ToList();
                }
                else
                {
                    MessageBox.Show("invalied input city !");
                }
            }
            catch { MessageBox.Show("Error"); } 
           
        }
    }
}
