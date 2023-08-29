using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using TotalApp.Infrastructure.Commands;
using TotalApp.MVVM.Base;
using TotalApp.MVVM.Model;

namespace TotalApp.MVVM.ViewModel
{
    public class CurrectViewModel : NotifyProperty
    {
        private ObservableCollection<Currect> _Currects = new();
        public ObservableCollection<Currect> Currects
        {
            get => _Currects;
            set => Set(ref _Currects, value);
        }

        public ICommand LoadDataCommand { get; }
        private bool CanLoadDataCommand(object p)
        {
            return true;
        }

        private void OnLoadDataCommand(object p)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "//Data//cr.json";

            string buff = File.ReadAllText(path, Encoding.UTF8);

            Currects = JsonConvert.DeserializeObject<ObservableCollection<Currect>>(buff);
        }

        public CurrectViewModel()
        {
            LoadDataCommand = new LambdaCommand(OnLoadDataCommand, CanLoadDataCommand);
        }
    }
}