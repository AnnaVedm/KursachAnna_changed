using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KursachAnna
{
    /// <summary>
    /// Логика взаимодействия для ForHorseTovarsList.xaml
    /// </summary>
    public partial class ForHorseTovarsList : UserControl, INotifyPropertyChanged
    {
        private Visibility _kategoriavisibility = Visibility.Collapsed;
        public Visibility KategoriaVisibility
        {
            get { return _kategoriavisibility; }
            set
            {
                if (_kategoriavisibility != value)
                {
                    _kategoriavisibility = value;
                    OnPropertyChanged(nameof(KategoriaVisibility));
                }
            }
        }
        public ForHorseTovarsList()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void OpenSideMenu()
        {
            // Создание и запуск анимации открытия бокового меню
            DoubleAnimation animation = new DoubleAnimation(200, TimeSpan.FromSeconds(0.2));
            KategoriaMenu.BeginAnimation(Grid.WidthProperty, animation);
            KategoriaVisibility = Visibility.Visible;
        }

        private void CloseSideMenu()
        {
            // Создание и запуск анимации закрытия бокового меню
            DoubleAnimation animation = new DoubleAnimation(40, TimeSpan.FromSeconds(0.2));
            KategoriaMenu.BeginAnimation(Grid.WidthProperty, animation);
            KategoriaVisibility = Visibility.Collapsed;
        }

        private void PereituVmenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = Window.GetWindow(this) as MainWindow;
            mainwindow.OknoToShow.Content = new menu();
        }

        private void ToggleMenu(object sender, RoutedEventArgs e)
        {
            // Переключение состояния бокового меню (открыто/закрыто)
            if (KategoriaMenu.ActualWidth > 40)
                CloseSideMenu();
            else
                OpenSideMenu();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
