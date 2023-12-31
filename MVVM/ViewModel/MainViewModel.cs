﻿using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TotalApp.Infrastructure.Commands;
using TotalApp.MVVM.Base;
using TotalApp.MVVM.Model;

namespace TotalApp.MVVM.ViewModel
{
    public class MainViewModel : NotifyProperty
    {
        private ObservableCollection<Paint> _Paints = new();
        public ObservableCollection<Paint> Paints
        {
            get => _Paints;
            set => Set(ref _Paints, value);
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
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "//Data//st.json";

            string buff = File.ReadAllText(path, Encoding.UTF8);

            Paints = JsonConvert.DeserializeObject<ObservableCollection<Paint>>(buff);
        }


        public MainViewModel()
        {

            CloseCommand = new LambdaCommand(OnCloseCommand, CanCloseCommand);
            LoadDataCommand = new LambdaCommand(OnLoadDataCommand, CanLoadDataCommand);
        }
    }
}