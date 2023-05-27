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
using EasyCaptcha;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для CaptchaTest.xaml
    /// </summary>
    public partial class CaptchaTest : Window
    {
        public CaptchaTest()
        {
            InitializeComponent();
        }

        private void ReloadCpt_Click(object sender, RoutedEventArgs e)
        {
            Captcha.CreateCaptcha(EasyCaptcha.Wpf.Captcha.LetterOption.Alphanumeric, 5);
        }
    }
}
