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
using Word = Microsoft;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btndosclick(object sender, RoutedEventArgs e)
        {
         
        }
        /// <summary>
        /// btngeri butonuyla maine dönüyoruz.
        /// btngon ile yanıtlar gönderiliyor ve messageboxda yanıtınız gönderildi yazısı gösteriliyor. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btngericlick(object sender, RoutedEventArgs e)
        {
            main2.Content = new MainWindow();
        }
        private void btngonclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yanıtınız gönderilmiştir.");
        }
    }
}
