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
    /// Логика взаимодействия для Tours.xaml
    /// </summary>
    public partial class Tours : Window
    {
        static TuriDemoEntities _context = new TuriDemoEntities();
        List<Tour> filteredByActual = _context.Tour.ToList();
        List<Tour> filteredBySearch = _context.Tour.ToList();
        List<Tour> filteredByType = _context.Tour.ToList();

        public Tours()
        {
            InitializeComponent();
            var pul = _context.Type.ToList().Select(x => x.Name);
            pul=pul.Prepend("Все типы");
            TypeCBx.ItemsSource = pul;
            TypeCBx.SelectedIndex = 0;
            ToursLV.ItemsSource = _context.Tour.ToList();
        }
        private void RefreshLV()
        {
            ToursLV.ItemsSource = filteredByActual.Intersect(filteredBySearch.Intersect(filteredByType));
        }
        private void ActualCB_Checked(object sender, RoutedEventArgs e)
        {
            filteredByActual=_context.Tour.Where(x => x.IsActual).ToList();
            RefreshLV();
        }

        private void ActualCB_Unchecked(object sender, RoutedEventArgs e)
        {
            filteredByActual = _context.Tour.ToList();
            RefreshLV();
        }

        private void TypeCBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filteredByType.Clear();
            Models.Type type = _context.Type.Where(x => x.Name == TypeCBx.SelectedValue.ToString()).FirstOrDefault();
            foreach (var i in _context.Tour.ToList())
            {
                List<Models.Type> types = new List<Models.Type>();
                if(i.Type.Contains(type))
                {
                    filteredByType.Add(i);
                    continue;
                }
            }
            if (type == null)
                filteredByType = _context.Tour.ToList();
            RefreshLV();
        }

        private void SearchTBx_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SearchTBx.Text=="")
            {
                filteredBySearch = _context.Tour.ToList();
            }
            else
            {
                filteredBySearch = _context.Tour.Where(x => x.Name.ToLower().Contains(SearchTBx.Text.ToLower())).ToList();
            }
            RefreshLV();
        }
    }
}
