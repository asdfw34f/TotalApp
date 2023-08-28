using System.Windows;
using TotalApp.Data.Types;
using TotalApp.Infrastructure.Commands.ButtonCommand;

namespace TotalApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ButtonsCmd cmd;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //_ = Frame12.NavigationService.Navigate(new Uri("./MVVM/View/DataViewPage.xaml", UriKind.Relative));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmd = new ButtonsCmd();
            cmd.LoadDataCommand.Execute(this);
            if (MyData.paints.Count > 0 )
            {
                TablePaint.ItemsSource = MyData.paints;
                TablePaint.Columns[0].Header = "ID";
                TablePaint.Columns[1].Header = "Марка";
                TablePaint.Columns[2].Header = "Остаток";
                /*
                 * <DataGrid.Columns>
                                            <DataGridTextColumn CanUserResize="False" Header="ID" />
                                            <DataGridTextColumn Header="Марка" />
                                            <DataGridTextColumn Header="Остаток" />
                                        </DataGrid.Columns>
                 * 
                 * */
            }
        }
    }
}