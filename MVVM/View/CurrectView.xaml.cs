using System;
using System.Windows;
using System.Windows.Controls;
using TotalApp.MVVM.ViewModel;

namespace TotalApp.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для CurrectView.xaml
    /// </summary>
    public partial class CurrectView : Page
    {
        private CurrectViewModel vm;

        public CurrectView()
        {
            InitializeComponent();
            vm = new CurrectViewModel();
            DataContext = vm;
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            vm.LoadDataCommand.Execute(null);
            TableCurrects.ItemsSource = vm.Currects;
            if (vm.Currects.Count > 0)
            {
                TableCurrects.Columns[0].Header = "Название";
                TableCurrects.Columns[1].Header = "Остаток";
            }
        }
    }
}