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

namespace KursachAnna
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }

        //запуск списка товаров для всадника
        private void OpenVsadnikTovarsList(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.OknoToShow.Content = new ForVsadnikTovarsList();
        }

        private void OpenHorseTovarsList(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.OknoToShow.Content = new ForHorseTovarsList();
        }
    }
}
