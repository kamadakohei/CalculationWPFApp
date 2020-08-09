﻿using CalculatorApp.ViewModels;
using CalculatorApp.Views;
using System.Windows;

namespace CalculatorApp
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // ウィンドウをインスタンス化します
            var w = new MainView();
            // ウィンドウに対する ViewModel をインスタンス化します
            var vm = new MainViewModel();
            // ウィンドウに対する ViewModel をデータコンテキストに指定します
            w.DataContext = vm;
            // ウィンドウを表示します
            w.Show();
        }
    }
}
