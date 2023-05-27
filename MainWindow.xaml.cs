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
using WpfApp1.Models;
using WpfApp1.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TuriDemoEntities _context = new TuriDemoEntities();
        public MainWindow()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = _context.Hotel.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Hotel SelectedHotel = (sender as Button).DataContext as Hotel;
            AddAndEdit AAE = new AddAndEdit(SelectedHotel);
            AAE.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddAndEdit AAE = new AddAndEdit();
            AAE.Show();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var HotelsToRemove = DGridHotels.SelectedItems.Cast<Hotel>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {HotelsToRemove.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    _context.Hotel.RemoveRange(HotelsToRemove);
                    _context.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridHotels.ItemsSource = _context.Hotel.ToList();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void ToToursBtn_Click(object sender, RoutedEventArgs e)
        {
            Tours tours = new Tours();
            tours.Show();
            this.Close();
        }

        private void Captcha_Click(object sender, RoutedEventArgs e)
        {
            CaptchaTest CP = new CaptchaTest();
            CP.Show();
            this.Close();
        }
    }
}
