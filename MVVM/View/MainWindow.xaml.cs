using System.Windows;
using System.Windows.Controls;
using TotalApp.MVVM.ViewModel;

namespace TotalApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel vm;
        CurrectView Currect;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainViewModel();
            Currect = new CurrectView();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            vm.LoadDataCommand.Execute(null);
            TablePaint.ItemsSource = vm.Paints;
            if (vm.Paints.Count > 0)
            {
                TablePaint.Columns[0].Header = "ID";
                TablePaint.Columns[1].Header = "Марка";
                TablePaint.Columns[2].Header = "Остаток";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.NavigationService.Content = Currect;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myFrame.NavigationService.Content = Paints;
        }
    }
}