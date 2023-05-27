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
using System.Windows.Shapes;
using WpfApp1.Models;
using WpfApp1.Windows;
namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddAndEdit.xaml
    /// </summary>
    public partial class AddAndEdit : Window
    {
        Hotel _hotel;
        TuriDemoEntities _context = new TuriDemoEntities();
        public AddAndEdit(Hotel hotel = null)
        {
            InitializeComponent();
            _hotel = hotel;
            CountryCB.ItemsSource = _context.Country.ToList().Select(x=>x.Name);
            CountryCB.SelectedIndex = 1;
            if (_hotel!=null)
            {
                NameTB.Text = _hotel.Name;
                StarsTB.Text = _hotel.CountOfStars.ToString();
                DesciptionTB.Text = _hotel.Description;
                CountryCB.SelectedValue = _context.Country.Where(x => x.Code==_hotel.CountryCode).Select(x => x.Name).FirstOrDefault();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_hotel.Name))
                errors.AppendLine("Заполните название отеля");
            int CountOfStars = -1;
            int.TryParse(StarsTB.Text, out CountOfStars);
            if (CountOfStars < 1 || CountOfStars > 5)
                errors.AppendLine("Количество звёзд от 1 до 5");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }         
            if (_hotel==null)
            {
                using (TuriDemoEntities AddHotel = new TuriDemoEntities())
                {
                    AddHotel.Hotel.Add(new Hotel()
                    {
                        Name = NameTB.Text,
                        CountOfStars = Convert.ToInt32(StarsTB.Text),
                        Description = DesciptionTB.Text,
                        CountryCode = _context.Country.Where(x => x.Name == CountryCB.SelectedValue.ToString()).Select(x => x.Code).FirstOrDefault()
                    });
                    AddHotel.SaveChanges();
                }
            }
            if(_hotel!=null)
            {
                using (TuriDemoEntities EditHotel = new TuriDemoEntities())
                {
                    Hotel HotelToEdit = EditHotel.Hotel.Where(x => x.Id==_hotel.Id).FirstOrDefault();
                    EditHotel.Hotel.Attach(HotelToEdit);
                    HotelToEdit.Name = NameTB.Text;
                    HotelToEdit.CountOfStars = Convert.ToInt32(StarsTB.Text);
                    HotelToEdit.Description = DesciptionTB.Text;
                    HotelToEdit.CountryCode = _context.Country.Where(x => x.Name == CountryCB.SelectedValue.ToString()).Select(x => x.Code).FirstOrDefault();
                    EditHotel.SaveChanges();
                }
            }
            MessageBox.Show("Данные сохранились");
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }
    }
}
