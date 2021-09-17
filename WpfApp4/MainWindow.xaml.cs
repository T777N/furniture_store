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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var item = (sender as ComboBox).SelectedItem as ComboBoxItem;
            var item2 = item.Content as string;
            if (item2 == "Modern")
            {
                
                chairImage.Source = new BitmapImage(new Uri(@"/images/modernChair.jpg", UriKind.Relative));
                tableImage.Source = new BitmapImage(new Uri(@"/images/modernTable.jpg", UriKind.Relative));
                sofaImage.Source = new BitmapImage(new Uri(@"/images/modernSofa.jpg", UriKind.Relative));
            }
            else if(item2 == "Victorian")
            {
                chairImage.Source = new BitmapImage(new Uri(@"/images/victorianChair.jpg", UriKind.Relative));
                tableImage.Source = new BitmapImage(new Uri(@"/images/victorianTable.jpg", UriKind.Relative));
                sofaImage.Source = new BitmapImage(new Uri(@"/images/victorianSofa.jpg", UriKind.Relative));
            }
            else if(item2== "ArtDeco")
            {
                chairImage.Source = new BitmapImage(new Uri(@"/images/artdecoChair.jpg", UriKind.Relative));
                tableImage.Source = new BitmapImage(new Uri(@"/images/artdecoTable.jpg", UriKind.Relative));
                sofaImage.Source = new BitmapImage(new Uri(@"/images/artdecoSofa.jpg", UriKind.Relative));
            }
        }
    }
}
