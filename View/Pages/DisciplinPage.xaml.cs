using mona.AppData;
using mona.Model;
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
    /// Логика взаимодействия для DisciplinPage.xaml
    /// </summary>
    public partial class DisciplinPage : Page
    {
        public DisciplinPage()
        {
            InitializeComponent();
            Flowerlist.ItemsSource = AppData.ModelHelper.molochnikov11Entities.Disciplin.ToList();
        }

        private void InsertBB_Click(object sender, RoutedEventArgs e)
        {
            Disciplin disciplin = new Disciplin();
            //int num = Convert.ToInt32(BarberIdTb.Text);
            //students.id = num;
            disciplin.grade = BarberNameTb.Text;
            disciplin.name = BarberRoleTb.Text;
            ModelHelper.molochnikov11Entities.Disciplin.Add(disciplin);
            ModelHelper.molochnikov11Entities.SaveChanges();
            Flowerlist.ItemsSource = ModelHelper.molochnikov11Entities.Disciplin.ToList();
        }

        private void DeleteBB_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(BarberIdTb.Text);
            //var dRow = Helpers.AuthorizationHelper.barberDb.BarberTb.Where(w => w.IDBarber == num).FirstOrDefault();
            //Helpers.AuthorizationHelper.barberDb.BarberTb.Remove(dRow);
            //Helpers.AuthorizationHelper.barberDb.SaveChanges();
            //BarberList.ItemsSource = Helpers.AuthorizationHelper.barberDb.BarberTb.ToList();
            var dRow = ModelHelper.molochnikov11Entities.Disciplin.Where(w => w.id == num).FirstOrDefault();
            ModelHelper.molochnikov11Entities.Disciplin.Remove(dRow);
            ModelHelper.molochnikov11Entities.SaveChanges();
            Flowerlist.ItemsSource = ModelHelper.molochnikov11Entities.Disciplin.ToList();
        }
    }
}
