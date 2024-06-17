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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OknoToShow.Content = new menu();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Код для выхода
        }

        // Создаем и показываем модальное окно регистрации после загрузки главного окна
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // Создаем окно регистрации
        //    Registrartion registrationWindow = new Registrartion();

        //    // Устанавливаем владельца
        //    registrationWindow.Owner = this;

        //    // Делаем окно модальным и отображаем его
        //    registrationWindow.ShowDialog();
        //}
        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            SignInButton.Visibility = Visibility.Collapsed;
            SignOutButton.Visibility = Visibility.Visible;
        }

        private void SignOutButton_Click(object sender, RoutedEventArgs e)
        {
            SignInButton.Visibility = Visibility.Visible;
            SignOutButton.Visibility = Visibility.Collapsed;
        }
    }
}
