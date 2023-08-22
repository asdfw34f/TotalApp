﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TotalApp.Infrastructure.Commands;
using TotalApp.MVVM.Model;

namespace TotalApp.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для DataViewPage.xaml
    /// </summary>
    public partial class DataViewPage : Page
    {
        DataCommand command;
        public DataViewPage()
        {
            InitializeComponent();
            command = new DataCommand();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            command.GetRootCommand.Execute(null);
            dataGrid.ItemsSource = command.data;
            dataGrid.Columns[0].CanUserReorder = false;
        }
    }
}