using System.Collections.ObjectModel;
using TotalApp.MVVM.Model;

namespace TotalApp.Data.Types
{
    public static class MyData
    {
        public static ObservableCollection<RootModel> paints { get; set; } = new ObservableCollection<RootModel>();

    }
}