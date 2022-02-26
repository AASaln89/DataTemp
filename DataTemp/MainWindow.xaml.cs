using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataTemp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                pName = "Apple",
                pView = "Image/apple.jpg",
                pInfo = "Red",
                pPrice = 60,
                pCategory = pCategories.Food
            });
            products.Add(new Product()
            {
                pName = "Lemon",
                pView = "Image/lemon.jpg",
                pInfo = "yellow",
                pPrice = 100,
                pCategory = pCategories.Food
            });
            products.Add(new Product()
            {
                pName = "tPhone",
                pView = "Image/phone.jpg",
                pInfo = "iPhone",
                pPrice = 100000,
                pCategory = pCategories.Mehanical
            });
            listBox.ItemsSource = products;
        }
    }
}
