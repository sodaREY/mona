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
    /// Логика взаимодействия для BasedPage.xaml
    /// </summary>
    public partial class BasedPage : Page
    {
        public BasedPage()
        {
            InitializeComponent();
            Flowerlist.ItemsSource = AppData.ModelHelper.molochnikov11Entities.Students.ToList();
        }

        private void InsertBB_Click(object sender, RoutedEventArgs e)
        {
            //BarberTb barberTb = new BarberTb();
            //int num = Convert.ToInt32(BarberIdTb.Text
            //barberTb.IDBarber = num;
            //barberTb.name = BarberNameTb.Text;
            //barberTb.role = BarberRoleTb.Text;
            //Helpers.AuthorizationHelper.barberDb.BarberTb.Add(barberTb);
            //Helpers.AuthorizationHelper.barberDb.SaveChanges();
            //BarberList.ItemsSource = Helpers.AuthorizationHelper.barberDb.BarberTb.ToList();

            Students students = new Students();
            //int num = Convert.ToInt32(BarberIdTb.Text);
            //students.id = num;
            students.FIO = BarberNameTb.Text;
            students.login = BarberRoleTb.Text;
            students.password = BarberNameTb1.Text;
            ModelHelper.molochnikov11Entities.Students.Add(students);
            ModelHelper.molochnikov11Entities.SaveChanges();
            Flowerlist.ItemsSource = ModelHelper.molochnikov11Entities.Students.ToList();
        }

        private void DeleteBB_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(BarberIdTb.Text);
            //var dRow = Helpers.AuthorizationHelper.barberDb.BarberTb.Where(w => w.IDBarber == num).FirstOrDefault();
            //Helpers.AuthorizationHelper.barberDb.BarberTb.Remove(dRow);
            //Helpers.AuthorizationHelper.barberDb.SaveChanges();
            //BarberList.ItemsSource = Helpers.AuthorizationHelper.barberDb.BarberTb.ToList();
            var dRow = ModelHelper.molochnikov11Entities.Students.Where(w => w.id == num).FirstOrDefault();
            ModelHelper.molochnikov11Entities.Students.Remove(dRow);
            ModelHelper.molochnikov11Entities.SaveChanges();
            Flowerlist.ItemsSource = ModelHelper.molochnikov11Entities.Students.ToList();
        }
    }
}
