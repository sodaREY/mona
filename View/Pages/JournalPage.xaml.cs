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

namespace mona.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();
            Flowerlist.ItemsSource = AppData.ModelHelper.molochnikov11Entities.Journal.ToList();

            Flowerlist.ItemsSource = AppData.ModelHelper.molochnikov11Entities.Students.ToList();

            Flowerlist.ItemsSource = AppData.ModelHelper.molochnikov11Entities.Disciplin.ToList();
        }

        private void InsertBB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBB_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
