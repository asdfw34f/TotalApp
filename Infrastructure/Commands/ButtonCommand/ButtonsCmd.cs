using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TotalApp.Data.Types;
using TotalApp.MVVM.Model;

namespace TotalApp.Infrastructure.Commands.ButtonCommand
{
    public class ButtonsCmd
    {
        public ButtonsCmd()
        {
            CloseCommand = new LambdaCommand(OnCloseCommand, CanCloseCommand);
        }

        public ICommand CloseCommand { get; }
        private bool CanCloseCommand(object p)
        {
            return true;
        }

        private void OnCloseCommand(object p)
        {
            Application.Current.MainWindow.Close();
        }

        public ICommand LoadDataCommand { get; }
        private bool CanLoadDataCommand(object p)
        {
            return true;
        }

        private void OnLoadDataCommand(object p)
        {
            string path = Application.Current.StartupUri.AbsolutePath;
            path += "//Data//st.json";

            string buff = File.ReadAllText(path, Encoding.UTF8);

            MyData.paints = JsonConvert.DeserializeObject<ObservableCollection<RootModel>>(buff);



        }
    }
}
