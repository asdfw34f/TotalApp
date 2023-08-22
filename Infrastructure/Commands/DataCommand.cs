using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;
using TotalApp.MVVM.Model;

namespace TotalApp.Infrastructure.Commands
{
    internal class DataCommand
    {
        internal DataCommand()
        {
            GetRootCommand = new LambdaCommand(OnGetRootCommand, CanGetRootCommand);
        }

        public ObservableCollection<RootModel> data { get; set; } = new ObservableCollection<RootModel>();
        private readonly string path = @".\Data\st.json";

        public ICommand GetRootCommand { get; }
        private bool CanGetRootCommand(object p) => true;
        private void OnGetRootCommand(object p)
        {
            string MyStream = File.ReadAllText(path);

            try
            {
                data = JsonConvert.DeserializeObject<ObservableCollection<RootModel>>(MyStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}