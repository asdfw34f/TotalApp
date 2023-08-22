using System;
using System.Windows;

namespace TotalApp.MVVM.View
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _ = Frame12.NavigationService.Navigate(new Uri("./MVVM/View/DataViewPage.xaml", UriKind.Relative));
        }
    }
}