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

namespace SelfButtonAndSelfVectorBackground_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ResourceDictionary Theme1 = new ResourceDictionary();
        ResourceDictionary Theme2 = new ResourceDictionary();

        public MainWindow()
        {
          
            Theme1.Source = new Uri("IconStyle2.xaml", UriKind.Relative);
            Theme2.Source = new Uri("IconStyle2.xaml", UriKind.Relative);
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[0] = Theme2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[0] = Theme1;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.btn1.Width = this.slider1.Value;
            this.btn1.Height = this.slider1.Value + 10;
            //this.btn2.Width = this.slider1.Value;
            //this.btn2.Height = this.slider1.Value + 20;

        }
    }
}
